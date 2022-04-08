using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6bis
{
    class Agence
    {
        private string ville;
        private List<Voiture> parcVoitures;

        public Agence(string ville)
        {
            this.ville = ville;
            this.parcVoitures = new List<Voiture>();
        }

        public string Ville { get => ville; set => ville = value; }
        public List<Voiture> ParcVoitures { get => parcVoitures; set => parcVoitures = value; }

        public void AjouterVoiture(Voiture UneVoiture)
        {
            this.ParcVoitures.Add(UneVoiture);
        }

        public List<Voiture> TrouverVoitures(string categorie)
        {
            List<Voiture> CategorieVoitures = new List<Voiture>();

            foreach (Voiture uneVoiture in ParcVoitures)
            {
                if (uneVoiture.Categorie == categorie)
                {
                    CategorieVoitures.Add(uneVoiture);
                }
            }
            return CategorieVoitures;
        }

        public Voiture TrouverVoiture(string nom)
        {
            Voiture voiture = null;

            foreach (Voiture UneVoiture in parcVoitures)
            {
                if (UneVoiture.Nom == nom)
                {
                    voiture = UneVoiture;
                }
            }
            return voiture;
        }

        public string Decrire()
        {
            string description;

            description = "Voici la liste des voitures de l'agence de " + this.Ville;

            foreach (Voiture UneVoiture in this.ParcVoitures)
            {
                description += "\n" + UneVoiture.Decrire();
            }

            return description;
        }
    }
}
