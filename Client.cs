using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6bis
{
    class Client
    {
        private string nom;
        private string prenom;

        public Client(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public string Decrire()
        {
            string description;

            description = this.Nom + " " + this.Prenom;

            return description;
        }
    }
}
