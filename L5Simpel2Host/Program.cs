using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using L5Simpel2;

namespace L5Simpel2Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host =
               new ServiceHost(typeof(L5Simpel2.Service)))
            {
                host.Open();
                foreach (var a in host.BaseAddresses)
                {
                    // toont aanroep adres op het scherm
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("Date service running...");
                Console.WriteLine("Press enter to terminate Host.");
                Console.ReadKey();
            }

        }
    }
}
