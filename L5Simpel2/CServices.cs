using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L5Simpel2.DBConnect;
using System.Web.Script.Serialization;

namespace L5Simpel2
{
    public class Service : IServices
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        DBConnect dbconnect = new DBConnect();

        public string Register(string name)
        {
            try
            {
                string wachtwoord = new string(name.ToCharArray().Reverse().ToArray());
                dbconnect.Insert("insert into urenregistratie.medewerker(username, password) values('" + name + "', '" + wachtwoord+")");
                return "gelukt";
            }
            catch (Exception e)
            {
                return serializer.Serialize(e);
            }
           

        }

        public bool Login(string username, string password)
        {
            dbconnect.Login("SELECT * from urenregistratie.medewerker where username=" + username + " and password=" +
                                             password);
            return true;

            
        }
        
        public string GetProjecten()
        {
            try
            {
                return serializer.Serialize(dbconnect.SelectProject("SELECT * FROM urenregistratie.project;"));
            }
            catch (Exception e)
            {

                return serializer.Serialize(e);
            }
        }
        
        public string GetProjectInfo()
        {
            return "GET PROJECTINFO UIT CSERVICE";
        }
        public string GetMedewerker(int id)
        {
            try
            {
                return serializer.Serialize(dbconnect.SelectMedewerker("SELECT * FROM urenregistratie.medewerker WHERE id=" + id));
            }
            catch (Exception e)
            {

                return serializer.Serialize(e);
            }
        }
        
        public string RegistreerWerkzaamheid(int uren, int medewerkerid, string werkzaamheid, string date, string naam)
        {
            try
            {
                dbconnect.Insert("INSERT INTO urenregistratie.werkzaamheid(id, name, uren, medewerkeridFK, datum) values(null, '" + naam + "','" + uren + "','" + medewerkerid + "','" + date + "')'");
                return "werkzaamheid geregistreerd";
            }
            catch (Exception e)
            {

                return serializer.Serialize(e);
            }
        }

        public string GetWerkzaamheden(int id)
        {
            try
            {
                return serializer.Serialize(
                    dbconnect.RegistreerWerkzaamheid(
                        "Select * from urenregistratie.werkzaamheid where medewerkeridFK=" + id));

            }
            catch (Exception e)
            {
                return serializer.Serialize(e);
            }
        }

        public string EditWerkzaamheid(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam)
        {
            try
            {
                dbconnect.Update("UPDATE urenregistratie.werkzaamheid SET uren=" + uren + ", name=" + naam + ", datum=" + date + ", medewerkeridFK=" + medewerkerid + " WHERE id=" + id);
                return "edit gelukt";
            }
            catch (Exception e)
            {

                return serializer.Serialize(e);
            }
        }

        public string DeleteWerkzaamheid(int id)
        {
            try
            {
                dbconnect.Update("DELETE urenregistratie.werkzaamheid WHERE id=" + id);
                return "delete gelukt";
            }
            catch (Exception e)
            {

                return serializer.Serialize(e);
            }
        }



    }
}
