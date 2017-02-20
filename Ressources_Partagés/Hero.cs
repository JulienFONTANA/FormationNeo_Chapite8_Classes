using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Classe "Hero"
 * 
 * Cette classe est ce qui sert de base aux super-héros
*/

namespace Ressources_Partagés
{
    // La classe "Hero" hérite de la classe "Personne"
    // On dit que "Hero" est la classe fille et que "Personne" est la classe mère
    // Notez la synthaxe avec le ':'
    //      -> classe fille : classe mère
    //
    // En C#, une classe ne peut hériter que d'une seule et unique autre classe
    public class Hero : Personne
    {
        // Attributs
        public string Pouvoir { get; set; }
        public string NomDeHero { get; set; }

        // Constructeur
        // Ce constructeur est complexe.
        // Il reprends tout les élémentsz de la classe mère (age, nom, addr) et ajoute les siens (nomHero, pouvoir).
        // On a donc un constructeur avec 5 paramètres!
        public Hero(int age, string nom, string addr, string nomHero, string pouvoir)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
            Pouvoir = pouvoir;
            NomDeHero = nomHero;
        }

        // Encore un constructeur vide
        // Il est surtout là pour faciliter vos exercices!
        public Hero() {}

        // Methodes
        // Cette méthode "surcharge" la méthode "Présentation()" grâce au mot-clé "override"
        // Cette surcharge est possible grâce au mot clé "virtual" présent dans la classe "Personne"
        // Le comportement de cette méthode est donc radicalement différent de celle de la classe mère!
        public override void Presentation()
        {
            Console.WriteLine("Bonjour, je m'appelle " + NomDeHero + ", et mon adresse doit rester secrete!");
        }

        // Méthode propre a la classe "Hero"
        public void UtiliseSonPouvoir()
        {
            Console.WriteLine("Craint moi bandit! car je possède ma " + Pouvoir + " !!!");
        }

        // Juste un exemple simple qui montre qu'une méthode est une fonction comme les autres
        // Celle-ci prends un paramètre...
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

        // ... et celle-ci à un retour
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

        // Il est possible d'avoir un objet en parapètres, comme un variable
        public virtual void Alliance(Hero autreHero)
        {
            Console.WriteLine("Que je suis content de te voir " + autreHero.NomDeHero + " ! Ensemble nous sommes plus fort!");
        }

        // Il est possible d'utiliser seulement une partie des attributs d'une classe
        public void OuEsTaBaseSecrete(string addr)
        {
            Console.WriteLine("Alors ta base secrète est au " + addr + " !");
        }
    }
}
