using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Music_Database
{
    [Table("AllTracks")]class Track
    {
        [Key]public string TrackID { get; set; }
        public string TrackName { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string GenreName { get; set; }
    }
}
