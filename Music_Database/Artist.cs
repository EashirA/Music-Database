using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Database
{
    class Artist
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }
    }
}
