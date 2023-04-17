using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientHotel
{
    internal class Hotel
    {
        public ArrayList  clients;

        public Hotel() 
        {
            clients = new ArrayList();
        }

        public void AjoutClient(Client client)
        {
            clients.Add(client);
        }

        public void ImprimerChiffrede1a5()
        {
            for(int i=0; i < 5; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
