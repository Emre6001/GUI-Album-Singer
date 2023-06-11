namespace M11Lab_EmreKarakaş
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabpage_singers = new System.Windows.Forms.TabPage();
            this.btn_createSinger = new System.Windows.Forms.Button();
            this.txt_singerActiveSince = new System.Windows.Forms.TextBox();
            this.txt_singerSurname = new System.Windows.Forms.TextBox();
            this.txt_singerName = new System.Windows.Forms.TextBox();
            this.lbl_infoSinger = new System.Windows.Forms.Label();
            this.lbl_activeSince = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tabpage_albums = new System.Windows.Forms.TabPage();
            this.cmb_singer = new System.Windows.Forms.ComboBox();
            this.lbl_singer = new System.Windows.Forms.Label();
            this.dtp_releaseYear = new System.Windows.Forms.DateTimePicker();
            this.lbl_infoAlbums = new System.Windows.Forms.Label();
            this.lbl_releaseDate = new System.Windows.Forms.Label();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.lbl_albumName = new System.Windows.Forms.Label();
            this.btn_createAlbum = new System.Windows.Forms.Button();
            this.tabpage_songs = new System.Windows.Forms.TabPage();
            this.lbl_infoSongs = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.cmb_albums = new System.Windows.Forms.ComboBox();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.lbl_length = new System.Windows.Forms.Label();
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_createSongs = new System.Windows.Forms.Button();
            this.tabpage_SingersAlbumsSongs = new System.Windows.Forms.TabPage();
            this.btn_showAlbums = new System.Windows.Forms.Button();
            this.lst_singers = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_showSongs = new System.Windows.Forms.Button();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.lst_albums = new System.Windows.Forms.ListBox();
            this.tabControl2.SuspendLayout();
            this.tabpage_singers.SuspendLayout();
            this.tabpage_albums.SuspendLayout();
            this.tabpage_songs.SuspendLayout();
            this.tabpage_SingersAlbumsSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabpage_singers);
            this.tabControl2.Controls.Add(this.tabpage_albums);
            this.tabControl2.Controls.Add(this.tabpage_songs);
            this.tabControl2.Controls.Add(this.tabpage_SingersAlbumsSongs);
            this.tabControl2.Location = new System.Drawing.Point(49, 77);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(649, 413);
            this.tabControl2.TabIndex = 4;
            // 
            // tabpage_singers
            // 
            this.tabpage_singers.Controls.Add(this.btn_createSinger);
            this.tabpage_singers.Controls.Add(this.txt_singerActiveSince);
            this.tabpage_singers.Controls.Add(this.txt_singerSurname);
            this.tabpage_singers.Controls.Add(this.txt_singerName);
            this.tabpage_singers.Controls.Add(this.lbl_infoSinger);
            this.tabpage_singers.Controls.Add(this.lbl_activeSince);
            this.tabpage_singers.Controls.Add(this.lbl_surname);
            this.tabpage_singers.Controls.Add(this.lbl_name);
            this.tabpage_singers.Location = new System.Drawing.Point(4, 34);
            this.tabpage_singers.Name = "tabpage_singers";
            this.tabpage_singers.Size = new System.Drawing.Size(641, 375);
            this.tabpage_singers.TabIndex = 3;
            this.tabpage_singers.Text = "Manage Singers";
            this.tabpage_singers.UseVisualStyleBackColor = true;
            // 
            // btn_createSinger
            // 
            this.btn_createSinger.Location = new System.Drawing.Point(243, 237);
            this.btn_createSinger.Name = "btn_createSinger";
            this.btn_createSinger.Size = new System.Drawing.Size(90, 34);
            this.btn_createSinger.TabIndex = 7;
            this.btn_createSinger.Text = "Create";
            this.btn_createSinger.UseVisualStyleBackColor = true;
            this.btn_createSinger.Click += new System.EventHandler(this.btn_createSinger_Click);
            // 
            // txt_singerActiveSince
            // 
            this.txt_singerActiveSince.Location = new System.Drawing.Point(183, 180);
            this.txt_singerActiveSince.Name = "txt_singerActiveSince";
            this.txt_singerActiveSince.Size = new System.Drawing.Size(150, 31);
            this.txt_singerActiveSince.TabIndex = 6;
            // 
            // txt_singerSurname
            // 
            this.txt_singerSurname.Location = new System.Drawing.Point(183, 125);
            this.txt_singerSurname.Name = "txt_singerSurname";
            this.txt_singerSurname.Size = new System.Drawing.Size(150, 31);
            this.txt_singerSurname.TabIndex = 5;
            // 
            // txt_singerName
            // 
            this.txt_singerName.Location = new System.Drawing.Point(183, 71);
            this.txt_singerName.Name = "txt_singerName";
            this.txt_singerName.Size = new System.Drawing.Size(150, 31);
            this.txt_singerName.TabIndex = 4;
            // 
            // lbl_infoSinger
            // 
            this.lbl_infoSinger.AutoSize = true;
            this.lbl_infoSinger.Location = new System.Drawing.Point(51, 299);
            this.lbl_infoSinger.Name = "lbl_infoSinger";
            this.lbl_infoSinger.Size = new System.Drawing.Size(252, 25);
            this.lbl_infoSinger.TabIndex = 3;
            this.lbl_infoSinger.Text = "Fill the form to create a singer.";
            // 
            // lbl_activeSince
            // 
            this.lbl_activeSince.AutoSize = true;
            this.lbl_activeSince.Location = new System.Drawing.Point(51, 186);
            this.lbl_activeSince.Name = "lbl_activeSince";
            this.lbl_activeSince.Size = new System.Drawing.Size(115, 25);
            this.lbl_activeSince.TabIndex = 2;
            this.lbl_activeSince.Text = "Active Since :";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(51, 131);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(91, 25);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(51, 77);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // tabpage_albums
            // 
            this.tabpage_albums.Controls.Add(this.cmb_singer);
            this.tabpage_albums.Controls.Add(this.lbl_singer);
            this.tabpage_albums.Controls.Add(this.dtp_releaseYear);
            this.tabpage_albums.Controls.Add(this.lbl_infoAlbums);
            this.tabpage_albums.Controls.Add(this.lbl_releaseDate);
            this.tabpage_albums.Controls.Add(this.txt_albumName);
            this.tabpage_albums.Controls.Add(this.lbl_albumName);
            this.tabpage_albums.Controls.Add(this.btn_createAlbum);
            this.tabpage_albums.Location = new System.Drawing.Point(4, 34);
            this.tabpage_albums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabpage_albums.Name = "tabpage_albums";
            this.tabpage_albums.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabpage_albums.Size = new System.Drawing.Size(1203, 375);
            this.tabpage_albums.TabIndex = 0;
            this.tabpage_albums.Text = "Manage Albums";
            this.tabpage_albums.UseVisualStyleBackColor = true;
            // 
            // cmb_singer
            // 
            this.cmb_singer.FormattingEnabled = true;
            this.cmb_singer.Location = new System.Drawing.Point(206, 204);
            this.cmb_singer.Name = "cmb_singer";
            this.cmb_singer.Size = new System.Drawing.Size(197, 33);
            this.cmb_singer.TabIndex = 8;
            // 
            // lbl_singer
            // 
            this.lbl_singer.AutoSize = true;
            this.lbl_singer.Location = new System.Drawing.Point(53, 212);
            this.lbl_singer.Name = "lbl_singer";
            this.lbl_singer.Size = new System.Drawing.Size(71, 25);
            this.lbl_singer.TabIndex = 7;
            this.lbl_singer.Text = "Singer :";
            // 
            // dtp_releaseYear
            // 
            this.dtp_releaseYear.Location = new System.Drawing.Point(206, 146);
            this.dtp_releaseYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_releaseYear.Name = "dtp_releaseYear";
            this.dtp_releaseYear.Size = new System.Drawing.Size(197, 31);
            this.dtp_releaseYear.TabIndex = 6;
            // 
            // lbl_infoAlbums
            // 
            this.lbl_infoAlbums.AutoSize = true;
            this.lbl_infoAlbums.Location = new System.Drawing.Point(53, 320);
            this.lbl_infoAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_infoAlbums.Name = "lbl_infoAlbums";
            this.lbl_infoAlbums.Size = new System.Drawing.Size(264, 25);
            this.lbl_infoAlbums.TabIndex = 5;
            this.lbl_infoAlbums.Text = "Fill the form to create an album.";
            // 
            // lbl_releaseDate
            // 
            this.lbl_releaseDate.AutoSize = true;
            this.lbl_releaseDate.Location = new System.Drawing.Point(53, 152);
            this.lbl_releaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_releaseDate.Name = "lbl_releaseDate";
            this.lbl_releaseDate.Size = new System.Drawing.Size(121, 25);
            this.lbl_releaseDate.TabIndex = 3;
            this.lbl_releaseDate.Text = "Release Date :";
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(206, 74);
            this.txt_albumName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(197, 31);
            this.txt_albumName.TabIndex = 2;
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(53, 77);
            this.lbl_albumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(131, 25);
            this.lbl_albumName.TabIndex = 1;
            this.lbl_albumName.Text = "Album Name : ";
            // 
            // btn_createAlbum
            // 
            this.btn_createAlbum.Location = new System.Drawing.Point(294, 256);
            this.btn_createAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_createAlbum.Name = "btn_createAlbum";
            this.btn_createAlbum.Size = new System.Drawing.Size(109, 38);
            this.btn_createAlbum.TabIndex = 0;
            this.btn_createAlbum.Text = "Create";
            this.btn_createAlbum.UseVisualStyleBackColor = true;
            this.btn_createAlbum.Click += new System.EventHandler(this.btn_createAlbum_Click);
            // 
            // tabpage_songs
            // 
            this.tabpage_songs.Controls.Add(this.lbl_infoSongs);
            this.tabpage_songs.Controls.Add(this.lbl_album);
            this.tabpage_songs.Controls.Add(this.cmb_albums);
            this.tabpage_songs.Controls.Add(this.txt_length);
            this.tabpage_songs.Controls.Add(this.lbl_length);
            this.tabpage_songs.Controls.Add(this.txt_songTitle);
            this.tabpage_songs.Controls.Add(this.label12);
            this.tabpage_songs.Controls.Add(this.btn_createSongs);
            this.tabpage_songs.Location = new System.Drawing.Point(4, 34);
            this.tabpage_songs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabpage_songs.Name = "tabpage_songs";
            this.tabpage_songs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabpage_songs.Size = new System.Drawing.Size(1203, 375);
            this.tabpage_songs.TabIndex = 1;
            this.tabpage_songs.Text = "Manage Songs";
            this.tabpage_songs.UseVisualStyleBackColor = true;
            // 
            // lbl_infoSongs
            // 
            this.lbl_infoSongs.AutoSize = true;
            this.lbl_infoSongs.Location = new System.Drawing.Point(52, 297);
            this.lbl_infoSongs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_infoSongs.Name = "lbl_infoSongs";
            this.lbl_infoSongs.Size = new System.Drawing.Size(244, 25);
            this.lbl_infoSongs.TabIndex = 12;
            this.lbl_infoSongs.Text = "Fill the form to create a song.";
            // 
            // lbl_album
            // 
            this.lbl_album.AutoSize = true;
            this.lbl_album.Location = new System.Drawing.Point(57, 188);
            this.lbl_album.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(79, 25);
            this.lbl_album.TabIndex = 11;
            this.lbl_album.Text = "Album : ";
            // 
            // cmb_albums
            // 
            this.cmb_albums.FormattingEnabled = true;
            this.cmb_albums.Location = new System.Drawing.Point(209, 180);
            this.cmb_albums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_albums.Name = "cmb_albums";
            this.cmb_albums.Size = new System.Drawing.Size(197, 33);
            this.cmb_albums.TabIndex = 10;
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(209, 128);
            this.txt_length.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(197, 31);
            this.txt_length.TabIndex = 9;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(57, 128);
            this.lbl_length.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(134, 25);
            this.lbl_length.TabIndex = 8;
            this.lbl_length.Text = "Length in Secs :";
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(209, 59);
            this.txt_songTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(197, 31);
            this.txt_songTitle.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Song Title : ";
            // 
            // btn_createSongs
            // 
            this.btn_createSongs.Location = new System.Drawing.Point(271, 244);
            this.btn_createSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_createSongs.Name = "btn_createSongs";
            this.btn_createSongs.Size = new System.Drawing.Size(107, 38);
            this.btn_createSongs.TabIndex = 5;
            this.btn_createSongs.Text = "Create";
            this.btn_createSongs.UseVisualStyleBackColor = true;
            this.btn_createSongs.Click += new System.EventHandler(this.btn_createSongs_Click);
            // 
            // tabpage_SingersAlbumsSongs
            // 
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.btn_showAlbums);
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.lst_singers);
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.btn_delete);
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.btn_showSongs);
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.lst_songs);
            this.tabpage_SingersAlbumsSongs.Controls.Add(this.lst_albums);
            this.tabpage_SingersAlbumsSongs.Location = new System.Drawing.Point(4, 34);
            this.tabpage_SingersAlbumsSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabpage_SingersAlbumsSongs.Name = "tabpage_SingersAlbumsSongs";
            this.tabpage_SingersAlbumsSongs.Size = new System.Drawing.Size(641, 375);
            this.tabpage_SingersAlbumsSongs.TabIndex = 2;
            this.tabpage_SingersAlbumsSongs.Text = "Singers, Albums and Songs";
            this.tabpage_SingersAlbumsSongs.UseVisualStyleBackColor = true;
            // 
            // btn_showAlbums
            // 
            this.btn_showAlbums.Location = new System.Drawing.Point(15, 186);
            this.btn_showAlbums.Name = "btn_showAlbums";
            this.btn_showAlbums.Size = new System.Drawing.Size(180, 38);
            this.btn_showAlbums.TabIndex = 8;
            this.btn_showAlbums.Text = "Show Albums";
            this.btn_showAlbums.UseVisualStyleBackColor = true;
            this.btn_showAlbums.Click += new System.EventHandler(this.btn_showAlbums_Click);
            // 
            // lst_singers
            // 
            this.lst_singers.FormattingEnabled = true;
            this.lst_singers.ItemHeight = 25;
            this.lst_singers.Location = new System.Drawing.Point(15, 45);
            this.lst_singers.Name = "lst_singers";
            this.lst_singers.Size = new System.Drawing.Size(180, 129);
            this.lst_singers.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(432, 284);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(193, 38);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_showSongs
            // 
            this.btn_showSongs.Location = new System.Drawing.Point(214, 234);
            this.btn_showSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_showSongs.Name = "btn_showSongs";
            this.btn_showSongs.Size = new System.Drawing.Size(199, 38);
            this.btn_showSongs.TabIndex = 4;
            this.btn_showSongs.Text = "Show Songs >";
            this.btn_showSongs.UseVisualStyleBackColor = true;
            this.btn_showSongs.Click += new System.EventHandler(this.btn_showSongs_Click);
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 25;
            this.lst_songs.Location = new System.Drawing.Point(434, 45);
            this.lst_songs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(191, 229);
            this.lst_songs.TabIndex = 1;
            // 
            // lst_albums
            // 
            this.lst_albums.FormattingEnabled = true;
            this.lst_albums.ItemHeight = 25;
            this.lst_albums.Location = new System.Drawing.Point(214, 45);
            this.lst_albums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_albums.Name = "lst_albums";
            this.lst_albums.Size = new System.Drawing.Size(197, 179);
            this.lst_albums.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 566);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabpage_singers.ResumeLayout(false);
            this.tabpage_singers.PerformLayout();
            this.tabpage_albums.ResumeLayout(false);
            this.tabpage_albums.PerformLayout();
            this.tabpage_songs.ResumeLayout(false);
            this.tabpage_songs.PerformLayout();
            this.tabpage_SingersAlbumsSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabpage_singers;
        private System.Windows.Forms.Button btn_createSinger;
        private System.Windows.Forms.TextBox txt_singerActiveSince;
        private System.Windows.Forms.TextBox txt_singerSurname;
        private System.Windows.Forms.TextBox txt_singerName;
        private System.Windows.Forms.Label lbl_infoSinger;
        private System.Windows.Forms.Label lbl_activeSince;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TabPage tabpage_albums;
        private System.Windows.Forms.ComboBox cmb_singer;
        private System.Windows.Forms.Label lbl_singer;
        private System.Windows.Forms.DateTimePicker dtp_releaseYear;
        private System.Windows.Forms.Label lbl_infoAlbums;
        private System.Windows.Forms.Label lbl_releaseDate;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.Label lbl_albumName;
        private System.Windows.Forms.Button btn_createAlbum;
        private System.Windows.Forms.TabPage tabpage_songs;
        private System.Windows.Forms.Label lbl_infoSongs;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.ComboBox cmb_albums;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_createSongs;
        private System.Windows.Forms.TabPage tabpage_SingersAlbumsSongs;
        private System.Windows.Forms.Button btn_showAlbums;
        private System.Windows.Forms.ListBox lst_singers;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_showSongs;
        private System.Windows.Forms.ListBox lst_songs;
        private System.Windows.Forms.ListBox lst_albums;
    }
}
