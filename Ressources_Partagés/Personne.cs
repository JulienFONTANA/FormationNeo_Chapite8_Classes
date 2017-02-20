using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ressources_Partagés
{
    public class Personne
    {
        // Attributs
        public int Age { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }

        // Constructeur
        public Personne(int age, string nom, string addr)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
        }

        public Personne(int age, string nom)
        {
            Age = age;
            Nom = nom;
            Adresse = "nulle part";
        }

        // Methodes
        public virtual void Presentation()
        {
            Console.WriteLine("Bonjour, je m'appelle " + Nom + ", et j'habite " + Adresse + '.');
        }

        public void DireAge()
        {
            if (Age < 50)
                Console.WriteLine("J'ai " + Age + " ans.");
            else
                Console.WriteLine("Je ne suis plus tout jeune !");
        }
    }
}
