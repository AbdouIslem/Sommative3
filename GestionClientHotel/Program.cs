namespace GestionClientHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Hotel hotel= new Hotel();
            Client client = new Client("nom", "prenom", "courriel", "3323", 2);

            hotel.AjoutClient(client);
            hotel.ImprimerChiffrede1a5();

        }
    }
}