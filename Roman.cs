using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPPLivres
{
    internal class Roman : Livres
    {
        public string genre { get; set; }

        public Roman(string Titre, string Auteur, int NombresPages, string Genre) : base(Titre, Auteur, NombresPages)
        {
            genre = Genre;

        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($" Titre {titre}, Auteur {auteur},NombresPage {nombresPages}, Genre {genre}");
        }


    }
}
