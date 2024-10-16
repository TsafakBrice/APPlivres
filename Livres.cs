using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPPLivres
{
    internal class Livres
    {

        public string titre { get; set; }
        public string auteur { get; set; }
        public int nombresPages { get; set; }

        public Livres(string Titre, string Auteur, int NombresPages)

        {
            titre = Titre;
            auteur = Auteur;
            nombresPages = NombresPages;

        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre {titre}, Auteur {auteur}, NombresPages {nombresPages}");
            

        }




    }
    








}
