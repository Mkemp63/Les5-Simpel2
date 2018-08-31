using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace L5Simpel2
{
    class DBConnect
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "urenregistratie";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode = none;";
            connection = new MySqlConnection(connectionString);
        }

      

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Geen verbinding met de server gevonden =)" + ex.Message);
                        break;

                    case 1045:
                        Console.WriteLine("Verkeerde username pass combo =(");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string Login(string query)
        {
            List<Medewerker> medewerkers = new List<Medewerker>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                return cmd.ExecuteScalar().ToString();

               
               
            
            }
            else
            {
                return "fout";
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteScalar();

                //close connection
                this.CloseConnection();


            }
        }

        //Delete statement
        public void Delete(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteScalar();
                //close connection
                this.CloseConnection();


            }
        }

        //Update statement
        public void Update(string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteScalar();
                //close connection
                this.CloseConnection();
            }
        }
        public List<Project> SelectProject(string query)
        {
            List<Project> projecten = new List<Project>();

            if (OpenConnection() == true)
            {
                //create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //data reader en query uitvoeren
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //lezen en opslaan
                while (dataReader.Read())
                {

                    Project p = new Project()
                    {

                        Id = int.Parse(dataReader["id"] + ""),
                        Naam = (dataReader["name"] + ""),
                        //Werkzaamheidid = int.Parse(dataReader["werkzaamheididFK"] + ""),
                        //Medewerkerid = int.Parse(dataReader["medewerkeridFK"] + "")

                        
                    };
                    projecten.Add(p);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            return projecten;
        }


        // misschien onnodig?
        public List<Werkzaamheid> RegistreerWerkzaamheid(string query)
        {
            List<Werkzaamheid> werkzaamheden = new List<Werkzaamheid>();

            if (OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //data reader en de query uitvoeren
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //lezen en opslaan
                while (dataReader.Read())
                {
                    Werkzaamheid w = new Werkzaamheid()
                    {
                        Id = int.Parse(dataReader["id"] + ""),
                        Naam = (dataReader["name"] + ""),
                        Uren = int.Parse(dataReader["uren"] + ""),
                        //Medewerkerid = int.Parse(dataReader["medewerkeridFK"] + ""),
                        Datum = (dataReader["datum"] + "")
                    };
                    werkzaamheden.Add(w);
                }

                dataReader.Close();
                this.CloseConnection();
            }
            return werkzaamheden;

        }

        public List<Medewerker> SelectMedewerker(string query)
        {
            List<Medewerker> medewerkers = new List<Medewerker>();

            if (OpenConnection() == true)
            {
                
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //data reader en de query uitvoeren
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //lezen en opslaan
                while (dataReader.Read())
                {
                    Medewerker m = new Medewerker()
                    {

                        Id = int.Parse(dataReader["id"] + ""),
                        Username = (dataReader["username"] + ""),
                        Password = (dataReader["password"] + "")
                    };
                    medewerkers.Add(m);
                }

                dataReader.Close();
                this.CloseConnection();
            }
             
            return medewerkers;
        }



    }
}
