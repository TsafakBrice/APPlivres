using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPPLivres
{
    internal class Revue : Livres
    {
     
        public int Numero {  get; set; } 
        public int Annee { get; set; } 

        public Revue(string Titre, string Auteur, int NombresPages, int annee, int numero) : base(Titre,Auteur,NombresPages)
        {
            Numero = numero;
            Annee = annee;

        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"numero de la page {Numero}, annee {Annee}");     
           
        }
    }
}
