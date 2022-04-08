using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6bis
{
    class Voiture
    {
        private string nom;
        private string categorie;
        private Client loueur;

        public Voiture(string nom, string categorie)
        {
            this.nom = nom;
            this.categorie = categorie;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        internal Client Loueur { get => loueur; set => loueur = value; }

        public string Decrire()
        {
            string description;

            description = this.Nom + " (" + this.Categorie + "). ";

            if (this.Loueur == null)
            {
                description += "Disponible.";
            }
            else
            {
                description += "Actuellement louée par " + this.Loueur.Prenom + " " + this.Loueur.Nom;
            }

            return description;
        }
    }
}
