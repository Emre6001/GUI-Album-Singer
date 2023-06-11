using M11Lab_EmreKarakaş.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11Lab_EmreKarakaş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindSingers();
        }
        SingerDbContext _db = new SingerDbContext();

        public void BindSingers()
        {
            lst_singers.ValueMember = "Id";
            lst_singers.DisplayMember = "DisplayText";
            lst_singers.DataSource = _db.Singers.ToList();
        }
        public void BindSongs()
        {
            int selectTheAlbumId = (int)lst_albums.SelectedValue;
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "SongTitle";
            lst_songs.DataSource = _db.Songs.ToList();
        }
        public void BindAlbums()
        {
            int selectTheSingerId = (int)lst_singers.SelectedValue;
            lst_albums.ValueMember = "Id";
            lst_albums.DisplayMember = "DisplayText";
            lst_albums.DataSource = _db.Albums.ToList();
        }
        public void BindTheCmbAlbums()
        {
            cmb_albums.ValueMember = "Id";
            cmb_albums.DisplayMember = "AlbumName";
            cmb_albums.DataSource = _db.Albums.ToList();
        }
        public void BindTheCmbSingers()
        {
            cmb_singer.ValueMember = "Id";
            cmb_singer.DisplayMember = "SingerName";
            cmb_singer.DataSource = _db.Singers.ToList();
        }
        private void btn_createSinger_Click(object sender, EventArgs e)
        {
            try
            {

                Singer s1 = new Singer()
                {
                    SingerName = txt_singerName.Text,
                    SingerSurname = txt_singerSurname.Text,
                    ActiveSince = int.Parse(txt_singerActiveSince.Text),

                };

                //Add the album instance to the database
                _db.Singers.Add(s1);
                _db.SaveChanges();
                BindSingers();
                BindTheCmbSingers();
                //Show message and reset the fields
                MessageBox.Show("Album created!");

            }
            catch (Exception ex)
            {
                lbl_infoSinger.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_createAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Album class
                int selectTheSingerId = (int)cmb_singer.SelectedValue;
                Album a1 = new Album()
                {
                    AlbumName = txt_albumName.Text,
                    ReleaseDate = dtp_releaseYear.Value.Date.ToString(),      //
                    SingerId = selectTheSingerId,
                };

                //Add the album instance to the database
                _db.Albums.Add(a1);
                _db.SaveChanges();
                BindAlbums();
                BindTheCmbAlbums();
                //Show message and reset the fields
                MessageBox.Show("Album created!");

            }
            catch (Exception ex)
            {
                lbl_infoAlbums.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_createSongs_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Song class
                int selectTheAlbumId = (int)cmb_albums.SelectedValue;

                Song s1 = new Song()
                {
                    SongTitle = txt_songTitle.Text,
                    SongLength = int.Parse(txt_length.Text),
                    AlbumId = selectTheAlbumId,

                };
                //Add the song instance to the database
                _db.Songs.Add(s1);
                _db.SaveChanges();
                BindSongs();
                //Show message and reset the fields
                MessageBox.Show("Song created!");
            }
            catch (Exception ex)
            {
                lbl_infoSongs.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_showAlbums_Click(object sender, EventArgs e)
        {
            BindAlbums();
        }

        private void btn_showSongs_Click(object sender, EventArgs e)
        {
            BindSongs();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String selectedSongTitle = lst_songs.GetItemText(lst_songs.SelectedItem);
            var songToDelete = _db.Songs.FirstOrDefault(c => c.SongTitle == selectedSongTitle);
            _db.Songs.Remove(songToDelete);
            _db.SaveChanges();
            BindSongs();
        }
    }
}
