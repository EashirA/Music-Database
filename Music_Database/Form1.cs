using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Music_Database
{
    public partial class frmMusicPlayer : Form
    {
        DataAccess dtAs = new DataAccess();

        public frmMusicPlayer()
        {

            InitializeComponent();

            txtSearch.KeyDown += txtSearch_KeyDown;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    break;
            }
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAlbumNtrack add = new AddAlbumNtrack();
            add.Show();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            FillLists();
            musicDataView.DataSource = dtAs.UpdatedTrack();
        }

        // Put all data together into new table ALLTRACKS
        private void txtSearchTrack_TextChanged(object sender, EventArgs e)
        {
            switch (comSearchBox.Text)
            {
                case "Track":
                    {
                        dtAs.Get("SELECT a.ArtistName, g.GenreName, t.TrackName From Track t " +
                                 "inner join Genre g on t.GenreID = g.GenreID " +
                                 "inner join Artist a on t.ArtistID = a.ArtistID where t.TrackName like  '" + txtSearch.Text + "%'", out List<Track> list);
                        musicDataView.DataSource = list;
                        txtSearch.KeyDown += txtSearch_KeyDown;
                        break;
                    }

                case "Albums":
                    {
                        dtAs.Get("SELECT * FROM AllTracks WHERE AlbumName like '" + txtSearch.Text + "%'", out List<Track> list);
                        musicDataView.DataSource = list;
                        txtSearch.KeyDown += txtSearch_KeyDown;
                        break;
                    }

                case "Genre":
                    {
                        dtAs.Get("SELECT * FROM AllTracks WHERE GenreName like '" + txtSearch.Text + "%'", out List<Track> list);
                        musicDataView.DataSource = list;
                        txtSearch.KeyDown += txtSearch_KeyDown;
                        break;
                    }

                case "Artists":
                    {
                        dtAs.Get("SELECT * FROM AllTracks WHERE ArtistName like '" + txtSearch.Text + "%'", out List<Track> list);
                        musicDataView.DataSource = list;
                        txtSearch.KeyDown += txtSearch_KeyDown;
                        break;
                    }
            }
        }

        private void btnShowAllTracks_Click(object sender, EventArgs e)
        {
            musicDataView.Columns.Clear();
            musicDataView.DataSource = dtAs.GetAllTracks();
        }

        private void musicDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (musicDataView.ColumnCount > 2)
            {
                if (musicDataView.Rows[e.RowIndex].Cells[0].Selected)
                {
                    if (musicDataView.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        var artist = musicDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        musicDataView.DataSource = dtAs.GetAllArtist(artist);
                    }
                }
                else if (musicDataView.Rows[e.RowIndex].Cells[1].Selected)
                {
                    if (musicDataView.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        var album = musicDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        musicDataView.DataSource = dtAs.GetAllAlbum(album);
                    }
                }
                else if (musicDataView.Rows[e.RowIndex].Cells[4].Selected)
                {
                    if (musicDataView.Rows[e.RowIndex].Cells[4].Value != null)
                    {
                        var genre = musicDataView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        musicDataView.DataSource = dtAs.GetAllGenre(genre);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();

        }

        public void FillLists()
        {

            using (IDbConnection connection = new SqlConnection(dtAs.connStr))
            {
                MyLists.tracks = connection.Query<Track>("select * from Track").ToList();
                MyLists.albums = connection.Query<Album>("select * from Album").ToList();
                MyLists.artists = connection.Query<Artist>("select * from Artist").ToList();
                //MyLists.genres = connection.Query<Genres>("select * from Genre").ToList();
            }
        }

        private void frmMusicPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
