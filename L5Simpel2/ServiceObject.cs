using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5Simpel2
{
    public class Medewerker
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Werkzaamheid
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Uren { get; set; }
        public int Medewerkerid { get; set; }
        public string Datum { get; set; }
    }

    public class ProjectMedewerker
    {
        public int Id { get; set; }
        public int Medewerkerid { get; set; }
        public int Projectid { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Werkzaamheidid { get; set; }
        public int Medewerkerid { get; set; }

    }
}
