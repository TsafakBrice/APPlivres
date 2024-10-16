using ConsoleAPPLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
     
        List<Livres> livres = new List<Livres>();

        Revue revue100 = new Revue ("nouvelle romance", "henri lopez", 101, 10, 208);
        Revue revue200 = new Revue ("le barbier de seville", "gerald depardieu", 201, 20, 209);
        Revue revue300 = new Revue ("la belle et la bete", "brice tsafak", 301, 30, 2010);

        Roman roman100 = new Roman("le roi lion", "romain" , 150, "roman");
        Roman roman200 = new Roman("commando", "arnold" , 250, "action");
        Roman roman300 = new Roman("rambo", "stalone" , 350, "guerre");


        livres.Add(revue100);
        livres.Add(revue200);
        livres.Add(revue300);
        livres.Add(roman100);
        livres.Add(roman200);
        livres.Add(roman300);

        foreach (Livres livre in livres)

        {
            livre.AfficherDetails();

        }
    }
}

