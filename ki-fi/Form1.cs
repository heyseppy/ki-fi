using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Windows.Forms;

namespace ki_fi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private string retrieve_tracklist_file()
        {

            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\song_track_list.txt";

            if (File.Exists(path))
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

            importTrackDialog.Filter = "tracks|*.mp3";
            importTrackDialog.FilterIndex = 1;
            importTrackDialog.Multiselect = true;

            if (importTrackDialog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = importTrackDialog.FileName;
                string[] arrAllFiles = importTrackDialog.FileNames; //used when Multiselect = true           
                MessageBox.Show(arrAllFiles.ToString());

                // create song tracklist file
                string path = retrieve_tracklist_file();

                // write filepaths to text editor
                using (StreamWriter sw = File.CreateText(path))
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
                if (!songListBox.Items.Cast<string>().Any(x => x == song_name))
                {
                    songListBox.Items.Add(song_name);
                }
            }
        }


        private void songPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_all_tracks();
        }

        private void importTrackDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}