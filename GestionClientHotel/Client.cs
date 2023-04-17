using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientHotel
{
    internal class Client
    {
        private string nomClient, prenomClient, courriel, carteCredit;
        private int numeroChambre;

        public string NomClient { get; set; }
        public string PrenomClient { get; set; }

        public string Courriel { get; set; }
        public string CarteCredit { get; set;}
        public int NumeroChambre { get; set; }


        public Client(string nom,string prenom,string courriel,string carteCredit,int numchambre)
        {
            this.NomClient= nom;
            this.PrenomClient= prenom;
            this.Courriel= courriel;
            this.CarteCredit= carteCredit;
            this.NumeroChambre= numchambre;
        }
    }
}
