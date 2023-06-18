using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Windows.Forms;
using System.Media;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TagLib;

namespace ki_fi
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        IDictionary<string, string> tracks_list = new Dictionary<string, string>();
        string[] selected_track = new string[2];
        string current_state = "none";

        private string retrieve_tracklist_file()
        {

            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\song_track_list.txt";

            if (System.IO.File.Exists(path))
            {
                return path;
            }
            else
            {
                MessageBox.Show("Failed to retrieve configuration file with songs, a new configuration file will now be created :)");
                return path;
            }
                
        }




        private void btnImportTrack_Click(object sender, EventArgs e)
        {
            //import tracks as filepath names into a text editor

            importTrackDialog.Filter = "tracks|*.mp3; *.m4a";
            importTrackDialog.FilterIndex = 1;
            importTrackDialog.Multiselect = true;

            if (importTrackDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = importTrackDialog.FileName;
                string[] arrAllFiles = importTrackDialog.FileNames; 


                // create song tracklist file
                string path = retrieve_tracklist_file();

                // write filepaths to text editor
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    for (int i = 0; i < arrAllFiles.Length; i++)
                    {
                        sw.WriteLine(arrAllFiles[i]);
                    }
                }

            }

            load_all_tracks();


        }


        private void load_all_tracks()
        {

            // retrieve all tracks from the songs list
            // TODO: allow songs with the same name to be added


            songListBox.Items.Clear();

            foreach (string song_path in System.IO.File.ReadLines(retrieve_tracklist_file()))
            {
                string song_name = Path.GetFileNameWithoutExtension(song_path);

                // check if it already exists

                if (tracks_list.ContainsKey(song_name))
                {
                    MessageBox.Show(song_name + " already exists in the library, please name it something else");
                }
                else
                {
                    songListBox.Items.Add(" > " + song_name);
                    tracks_list.Add(song_name, song_path);
                }
                
                
            }
        }


        private void songPictureBox_Click(object sender, EventArgs e)
        {

        }


 
        private void songListBox_MouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.BackColor = Color.Black;
        }

        public void set_selected_song()
        {
            // play music when new song selected
            // get the selected songlist item's key
            string song_title = songListBox.SelectedItems[0].Text;
            // remove the first character (">")
            string song_path = tracks_list[song_title.Replace(" > ", "")];

            selected_track[0] = song_title;
            selected_track[1] = song_path;
         
            play_selected_song();

        }
        public void play_selected_song()
        {
            // start the windows media player
            wplayer.URL = selected_track[1];
            wplayer.controls.play();

            // populate the media details
            songNameLabel.Text = wplayer.currentMedia.getItemInfo("Title");
            //songArtistName.Text = wplayer.currentMedia.getItemInfo("Artist");

            // populate the cover photo
            TagLib.File file = TagLib.File.Create(selected_track[1]);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                songPictureBox.Image = bm;
                songPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // set "no cover" image
            }


            

            // set the controls to play
            btnPlayTrack.Text = " || ";
            btnPlayTrack.ForeColor = Color.Green;
            current_state = "playing";

            song_track.Start();


        }

        public void pause_selected_song()
        {
            // start the windows media player
            wplayer.controls.pause();

            // set the controls to play
            btnPlayTrack.Text = " ▶ ";
            btnPlayTrack.ForeColor = Color.Red;
            current_state = "paused";
        }

        public void resume_playing_song()
        {
            // start the windows media player
            wplayer.controls.play();

            // set the controls to play
            btnPlayTrack.Text = " || ";
            btnPlayTrack.ForeColor = Color.Red;
            current_state = "playing";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            load_all_tracks();
            wplayer.settings.volume = trackBar1.Value;

        }

        private void importTrackDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnPlayTrack_Click(object sender, EventArgs e)
        {
            // check if paused
            if (current_state == "paused")
            {
                resume_playing_song();
            }
            else if (current_state == "playing")
            {
                pause_selected_song();
               
            }
            else
            {
                // check if any songs in tracklist
                if (selected_track[0] == "")
                {
                    set_selected_song();
                    play_selected_song();
                }
                else
                {
                    play_selected_song();
                }
            }
        }
        private void songListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (songListBox.SelectedItems.Count == 0)
            {
                return;

            }

            set_selected_song();

            

        }

        private void songProgress_Scroll(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition = songProgress.Value / 1000;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            wplayer.settings.volume = trackBar1.Value;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double duration = wplayer.currentMedia.duration;
        }

        private void song_track_Tick(object sender, EventArgs e)
        {
            double duration = wplayer.currentMedia.duration;
            songProgress.Maximum = (int)(duration*1000);
            songProgress.Value = (int)(wplayer.controls.currentPosition * 1000);
        }
    }
}