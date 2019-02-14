using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Music_Database
{
    public partial class AddAlbumNtrack : Form
    {
        DataAccess dtAs = new DataAccess();
        public AddAlbumNtrack()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxAlbumName.Text != null)
            {
                List<Album> album = new List<Album>();
                List<Track> track = new List<Track>();
                List<Artist> artists = new List<Artist>();

                string addAlbum = "";
                int addAlbumID = 0;
                int addArtistID = 0;
                string addArtist = "";
                string addTrack = "";

                addAlbum = txtBoxAlbumName.Text;
                SqlConnection conn = new SqlConnection(dtAs.connStr);
                conn.Execute("InsertAlbum", new { @AlbumName = addAlbum }, commandType:
                    CommandType.StoredProcedure);

                album = conn.Query<Album>("select AlbumID from Album where AlbumName = @AlbumName",
                    new { @AlbumName = addAlbum }).ToList();
                addAlbumID = album.First().AlbumID;

                addArtist = textBox2.Text;
                conn.Execute("InsertArtist", new { @ArtistName = addArtist },
                    commandType: CommandType.StoredProcedure);

                artists = conn.Query<Artist>("select ArtistID from Artist where ArtistName = @ArtistName",
                    new { @ArtistName = addArtist }).ToList();
                addArtistID = artists.First().ArtistID;

                for (int j = 0; j < newAlbumNtrackView.Rows.Count - 1; j++)
                {
                    addTrack = newAlbumNtrackView.Rows[j].Cells[0].Value.ToString();
                    conn.Execute("InsertTrack", new { @AlbumID = addAlbumID, @ArtistID = addArtistID, @TrackName = addTrack },
                        commandType: CommandType.StoredProcedure);
                }

                MessageBox.Show(" Successfully saved! ");
            }
            else
            {
                MessageBox.Show(" Insert an Album Name ");
            }
        }

        private void buttonCheckoutBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusicPlayer fmMP = new frmMusicPlayer();
            fmMP.Show();
        }
    }
}
