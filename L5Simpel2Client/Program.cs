using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace L5Simpel2Client
{
    class Program
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //L5Simpel2 Reference
            using (ServiceReference1.ServicesClient client =
                    new ServiceReference1.ServicesClient())
            {
       
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Console.WriteLine(client.GetMedewerker(1).ToString());
                var k = serializer.Deserialize<List<Medewerker>>(client.GetMedewerker(1));
                //var p = serializer.Deserialize<List<Project>>(client.GetProjecten()).ToString();
                //Console.WriteLine(p.ToString() + p.Count());
                //Console.WriteLine(client.GetProjecten());
                //Console.WriteLine(k.Count());
                

            }
            Console.ReadKey();
            
        }

        // Pojos
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
            public string Uren { get; set; }
            public double Medewerkerid { get; set; }
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
}
