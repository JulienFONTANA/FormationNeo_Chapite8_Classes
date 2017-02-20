using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ressources_Partagés
{
    public class Hero : Personne
    {
        // Attributs
        public string Pouvoir { get; set; }
        public string NomDeHero { get; set; }

        // Constructeur
        public Hero(int age, string nom, string addr, string nomHero, string pouvoir) : base(age, nom, addr)
        {
            //Age = age;
            //Nom = nom;
            //Adresse = addr;
            Pouvoir = pouvoir;
            NomDeHero = nomHero;
        }

        // Methodes
        public override void Presentation()
        {
            Console.WriteLine("Bonjour, je m'appelle " + NomDeHero + ", et mon adresse doit rester secrette!");
        }

        public void UtiliseSonPouvoir()
        {
            Console.WriteLine("Craint moi bandit! car je possède ma " + Pouvoir + " !!!");
        }

        public void FrappeLeRobotGeant(int resistanceDuRobot)
        {
            while (resistanceDuRobot > 0)
            {
                Console.WriteLine("Pif! Paf! Pouf! Prends ça robot géant!");
                resistanceDuRobot /= 2;
                resistanceDuRobot -= 3;
            }
            Console.WriteLine("Ce n'est plus qu'un tas de boulon!");
        }

        public bool AUnEnnemiJure()
        {
            if (Age > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Alliance(Hero autreHero)
        {
            Console.WriteLine("Que je suis content de te voir " + autreHero.NomDeHero + " ! Ensemble nous sommes plus fort!");
        }

        public void OuEsTaBaseSecrete(string addr)
        {
            Console.WriteLine("Alors ta base secrète est au " + addr + " !");
        }
    }
}
