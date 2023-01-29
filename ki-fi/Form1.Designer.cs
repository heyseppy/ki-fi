namespace ki_fi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label songArtistName;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnLoveTrack = new System.Windows.Forms.Button();
            this.btnPrevTrack = new System.Windows.Forms.Button();
            this.btnPlayTrack = new System.Windows.Forms.Button();
            this.btnNextTrack = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songListBox = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportTrack = new System.Windows.Forms.Button();
            this.btnNewTrack = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.importTrackDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            songArtistName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // songArtistName
            // 
            songArtistName.AutoSize = true;
            songArtistName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            songArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            songArtistName.Location = new System.Drawing.Point(1081, 352);
            songArtistName.Name = "songArtistName";
            songArtistName.Size = new System.Drawing.Size(161, 20);
            songArtistName.TabIndex = 12;
            songArtistName.Text = "ripsquad [rs og tracks]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label1.Location = new System.Drawing.Point(1221, 521);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 15);
            label1.TabIndex = 18;
            label1.Text = "playlists:";
            // 
            // songPictureBox
            // 
            this.songPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songPictureBox.BackgroundImage")));
            this.songPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.songPictureBox.Location = new System.Drawing.Point(1081, 12);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(348, 305);
            this.songPictureBox.TabIndex = 1;
            this.songPictureBox.TabStop = false;
            this.songPictureBox.Click += new System.EventHandler(this.songPictureBox_Click);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlaylist.Location = new System.Drawing.Point(1365, 386);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(64, 50);
            this.btnAddPlaylist.TabIndex = 5;
            this.btnAddPlaylist.Text = "+";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnLoveTrack
            // 
            this.btnLoveTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoveTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoveTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoveTrack.Location = new System.Drawing.Point(1081, 386);
            this.btnLoveTrack.Name = "btnLoveTrack";
            this.btnLoveTrack.Size = new System.Drawing.Size(64, 50);
            this.btnLoveTrack.TabIndex = 7;
            this.btnLoveTrack.Text = "❤";
            this.btnLoveTrack.UseVisualStyleBackColor = true;
            // 
            // btnPrevTrack
            // 
            this.btnPrevTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrevTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevTrack.Location = new System.Drawing.Point(1155, 386);
            this.btnPrevTrack.Name = "btnPrevTrack";
            this.btnPrevTrack.Size = new System.Drawing.Size(64, 50);
            this.btnPrevTrack.TabIndex = 8;
            this.btnPrevTrack.Text = "<<";
            this.btnPrevTrack.UseVisualStyleBackColor = true;
            // 
            // btnPlayTrack
            // 
            this.btnPlayTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayTrack.Location = new System.Drawing.Point(1225, 386);
            this.btnPlayTrack.Name = "btnPlayTrack";
            this.btnPlayTrack.Size = new System.Drawing.Size(64, 50);
            this.btnPlayTrack.TabIndex = 9;
            this.btnPlayTrack.Text = "▶";
            this.btnPlayTrack.UseVisualStyleBackColor = true;
            this.btnPlayTrack.Click += new System.EventHandler(this.btnPlayTrack_Click);
            // 
            // btnNextTrack
            // 
            this.btnNextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTrack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextTrack.Location = new System.Drawing.Point(1295, 386);
            this.btnNextTrack.Name = "btnNextTrack";
            this.btnNextTrack.Size = new System.Drawing.Size(64, 50);
            this.btnNextTrack.TabIndex = 10;
            this.btnNextTrack.Text = ">>";
            this.btnNextTrack.UseVisualStyleBackColor = true;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.songNameLabel.ForeColor = System.Drawing.Color.White;
            this.songNameLabel.Location = new System.Drawing.Point(1081, 332);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(218, 20);
            this.songNameLabel.TabIndex = 11;
            this.songNameLabel.Text = "rare rila instrumental i dance 2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.songListBox);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 699);
            this.panel1.TabIndex = 13;
            // 
            // songListBox
            // 
            this.songListBox.AllowColumnReorder = true;
            this.songListBox.AutoArrange = false;
            this.songListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.songListBox.CheckBoxes = true;
            this.songListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.songListBox.ForeColor = System.Drawing.Color.White;
            this.songListBox.Location = new System.Drawing.Point(10, -1);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(1008, 691);
            this.songListBox.TabIndex = 1;
            this.songListBox.UseCompatibleStateImageBehavior = false;
            this.songListBox.View = System.Windows.Forms.View.List;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ki_fi.Properties.Resources.bar_gif_1bf8155eb958d7505bed18887340801f;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1081, 595);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 103);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1365, 678);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "@ki-fi";
            // 
            // btnImportTrack
            // 
            this.btnImportTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImportTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImportTrack.Location = new System.Drawing.Point(1081, 539);
            this.btnImportTrack.Name = "btnImportTrack";
            this.btnImportTrack.Size = new System.Drawing.Size(64, 50);
            this.btnImportTrack.TabIndex = 16;
            this.btnImportTrack.Text = "import";
            this.btnImportTrack.UseVisualStyleBackColor = true;
            this.btnImportTrack.Click += new System.EventHandler(this.btnImportTrack_Click);
            // 
            // btnNewTrack
            // 
            this.btnNewTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNewTrack.Location = new System.Drawing.Point(1151, 539);
            this.btnNewTrack.Name = "btnNewTrack";
            this.btnNewTrack.Size = new System.Drawing.Size(64, 50);
            this.btnNewTrack.TabIndex = 17;
            this.btnNewTrack.Text = "new +";
            this.btnNewTrack.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "summer tracks",
            "my favs",
            "2022 replay"});
            this.listBox2.Location = new System.Drawing.Point(1221, 539);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 45);
            this.listBox2.TabIndex = 2;
            // 
            // importTrackDialog
            // 
            this.importTrackDialog.DefaultExt = "mp3";
            this.importTrackDialog.Multiselect = true;
            this.importTrackDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.importTrackDialog_FileOk);
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(1081, 474);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(348, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1441, 718);
            this.ControlBox = false;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnNewTrack);
            this.Controls.Add(this.btnImportTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(songArtistName);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.btnNextTrack);
            this.Controls.Add(this.btnPlayTrack);
            this.Controls.Add(this.btnPrevTrack);
            this.Controls.Add(this.btnLoveTrack);
            this.Controls.Add(this.songPictureBox);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ki-fi - lusi + ripsquad (feat. skys)";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox songPictureBox;
        private Button btnAddPlaylist;
        private PageSetupDialog pageSetupDialog1;
        private Button btnLoveTrack;
        private Button btnPrevTrack;
        private Button btnPlayTrack;
        private Button btnNextTrack;
        private Label songNameLabel;
        private Label songArtistName;
        private Panel panel1;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Button btnImportTrack;
        private Button btnNewTrack;
        private ListBox listBox2;
        private OpenFileDialog importTrackDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TrackBar trackBar1;
        private ListView songListBox;
    }
}