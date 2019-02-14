using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Music_Database
{
    public class DataAccess
    {
        public string connStr = "Server=.;Database = MusicDatabase;Integrated Security = SSPI;";
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader sRdr;
        private SqlDataAdapter sAdptr;
        private DataSet dSet;

        public DataTable UpdatedTrack()
        {
            DataTable dTable = new DataTable();
            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = ("insertTrack2");
            cmd.Connection = conn;
            sRdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dTable.Load(sRdr);
            return dTable;
        }
        public DataTable GetAllTracks()
        {
            DataTable dTable = new DataTable();
            conn = new SqlConnection(connStr);
            cmd = new SqlCommand();
            cmd.CommandText = "spShowAll";
            cmd.Connection = conn;
            conn.Open();
            sRdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dTable.Load(sRdr);
            return dTable;
        }

        public DataTable GetAllAlbum(string album)
        {
            DataTable dTable = new DataTable();
            conn = new SqlConnection(connStr);
            cmd.CommandText = "select a.ArtistName as Artist, al.AlbumName as Album,t.TrackName as Track, t.Time, g.GenreName as Genre " +
                              "from Track t " +
                              "inner join Artist a on a.ArtistID = t.ArtistID " +
                              "inner join Album al on al.AlbumID = t.AlbumID " +
                              "inner join Genre g on g.GenreID = t.GenreID " +
                              $"where al.AlbumName = '{album}'"; ;
            cmd = new SqlCommand(cmd.CommandText, conn);
            conn.Open();
            sRdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dTable.Load(sRdr);
            return dTable;
        }

        public DataTable GetAllGenre(string genre)
        {
            DataTable dTable = new DataTable();
            conn = new SqlConnection(connStr);
            cmd.CommandText = "select a.ArtistName as Artist, al.AlbumName as Album,t.TrackName as Track, t.Time, g.GenreName as Genre " +
                              "from Track t " +
                              "inner join Artist a on a.ArtistID = t.ArtistID " +
                              "inner join Album al on al.AlbumID = t.AlbumID " +
                              "inner join Genre g on g.GenreID = t.GenreID " +
                              $"where g.GenreName = '{genre}'";
            cmd = new SqlCommand(cmd.CommandText, conn);
            conn.Open();
            sRdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dTable.Load(sRdr);
            return dTable;
        }

        public DataTable GetAllArtist(string artist)
        {
            DataTable dTable = new DataTable();
            conn = new SqlConnection(connStr);
            cmd.CommandText = "select a.ArtistName as Artist, al.AlbumName as Album,t.TrackName as Track, t.Time, g.GenreName as Genre " +
                              "from Track t " +
                              "inner join Artist a on a.ArtistID = t.ArtistID " +
                              "inner join Album al on al.AlbumID = t.AlbumID " +
                              "inner join Genre g on g.GenreID = t.GenreID " +
                              $"where a.ArtistName = '{artist}'";
            cmd = new SqlCommand(cmd.CommandText, conn);
            conn.Open();
            sRdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dTable.Load(sRdr);
            return dTable;
        }

        public bool Get<T>(string query, out List<T> items)
        {
            try
            {
                conn = new SqlConnection(connStr);
                {
                    conn.Open();
                    items = conn.Query<T>(query).ToList();
                    return items != null;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
