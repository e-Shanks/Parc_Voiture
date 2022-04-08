using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6bis
{
    class exo6bis
    {
        static void Main(string[] args)
        {
            Agence agenceLyon = InitialiserAgence();
            Console.Write(agenceLyon.Decrire());

            Console.Write("\n\nEntrez la catégorie souhaitée : ");
            string categorie = Console.ReadLine();
            Console.WriteLine("\nVoici la liste des voitures correspondant à cette catégorie :");
            //Console.WriteLine("\t" + agenceLyon.TrouverVoitures(categorie));
            List<Voiture> CategorieVoitures = agenceLyon.TrouverVoitures(categorie);
            foreach(Voiture UneVoiture in CategorieVoitures)
            {
                Console.WriteLine("\t" + UneVoiture.Decrire());
            }

            Console.Write("\n\nEntrez le nom de la voiture que vous souhaitez louer : ");
            string nomVoiture = Console.ReadLine();
            Voiture voitureLouee = agenceLyon.TrouverVoiture(nomVoiture);
            Console.Write("Entrez votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Entrez votre prenom : ");
            string prenom = Console.ReadLine();
            Client loueur = new Client(nom, prenom);
            voitureLouee.Loueur = loueur;
            agenceLyon.AjouterVoiture(voitureLouee);

            Console.Write(agenceLyon.Decrire());

            Console.ReadKey();
        }

        static Agence InitialiserAgence()
        {
            Agence agence = new Agence("Lyon");

            agence.AjouterVoiture(new Voiture("500", "Economique"));
            agence.AjouterVoiture(new Voiture("207", "Economique"));

            Voiture voiture = new Voiture("Classe A", "Compacte");
            Client client = new Client("Zette", "Annie");
            voiture.Loueur = client;
            agence.AjouterVoiture(voiture);

            agence.AjouterVoiture(new Voiture("Megane", "Compacte"));
            agence.AjouterVoiture(new Voiture("Golf", "Compacte"));
            agence.AjouterVoiture(new Voiture("Scenic", "Monospace"));
            agence.AjouterVoiture(new Voiture("Touran", "Monospace"));
            agence.AjouterVoiture(new Voiture("Picasso", "Monospace"));
            agence.AjouterVoiture(new Voiture("Laguna", "Routière"));

            voiture = new Voiture("407", "Routière");
            client = new Client("Roïd", "Paula");
            voiture.Loueur = client;
            agence.AjouterVoiture(voiture);

            agence.AjouterVoiture(new Voiture("Boxster", "Sport"));
            agence.AjouterVoiture(new Voiture("R8", "Sport"));

            voiture = new Voiture("California", "Sport");
            client = new Client("Kilo", "Sandy");
            voiture.Loueur = client;
            agence.AjouterVoiture(voiture);

            return agence;
        }
    }
}
