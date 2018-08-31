using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace L5Simpel2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDateService" in both code and config file together.
    [ServiceContract]
    public interface IServices
    {
        // Alle services die de WPF ondersteunt 
        [OperationContract]
        bool Login(string name, string password);
        [OperationContract]
        string Register(string naam);
        [OperationContract]
        string GetProjecten();
        [OperationContract]
        string GetProjectInfo();
        [OperationContract]
        string GetMedewerker(int id);
        [OperationContract]
        string GetWerkzaamheden(int id);
        [OperationContract]
        string RegistreerWerkzaamheid(int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        [OperationContract]
        string EditWerkzaamheid(int id, int uren, int medewerkerid, string werkzaamheid, string date, string naam);
        [OperationContract]
        string DeleteWerkzaamheid(int id);
    }
}
