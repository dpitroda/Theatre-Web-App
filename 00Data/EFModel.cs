using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAdminWebApp.Movie
{
    public class Movie
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Releasedate { get; set; }

        public string Director { get; set; }

        public string EmailAddress { get; set;}

        public CharEnumerator Language { get; set; }

        public string Category { get; set; }




    }
}
