using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Database
{
    class Album
    {
        public int AlbumID { get; set; }

        public int ArtistID { get; set; }

        public string AlbumName { get; set; }

        public int TrackCount { get; set; }
    }
}
