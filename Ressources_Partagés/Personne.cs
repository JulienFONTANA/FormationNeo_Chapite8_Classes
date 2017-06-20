using System;

/* Classe "Personne"
 * 
 * Cette classe est ce qui sert de base aux héros et super-héros
*/

namespace Ressources_Partagés
{
    // Notez que la classe Personne, ses attributs et ses méthodes sont précédés du
    // mot-clé "public". Ce mot est un "accesseur" et permet de donner accès au code
    // de cette classe dans tout le reste du programme
    public class Personne
    {
        // Attributs
        // Ce sont des variables propres à une classe
        public int Age { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        // A noter: la synthaxe { get; set; } permet d'accéder, de lire et de modifier
        // les attributs d'une classe. Ce sont les GETTER et SETTER d'un attribut

        // Constructeur
        // Le constructeur indique quel est le "plan de montage" de la classe
        // Il indique quel sont les paramètres attendu, leur type, leur nombre,
        // leur ordre, puis rempli et créer la classe pour qu'elle soit utilisable.

        // Constructeur complet (N°1)
        public Personne(int age, string nom, string addr)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
        }

        // Constructeur simplifié (N°2)
        // Ici on ne demande pas l"adresse lors de la création de la Personne
        // On suppose que si l'adresse n'est pas remplie, alors une valeur par 
        // défaut suffira
        public Personne(int age, string nom)
        {
            Age = age;
            Nom = nom;
            Adresse = "nulle part";
        }

        // Ce constructeur est vide! (N°3)
        // Il permet de créer un objet "Personne" ne contenant rien, car il suppose que ces
        // attributs seront rempli plus tard.
        // Ce constructeur permet aussi de simplifier l'héritage 
        public Personne() {}

        // Methodes
        // Ce sont les fonctions propres à la classe. Ces fonctions ne peuvent pas être
        // appelés en dehors de la classe (essayer d'appelez cette fonction dans le main,
        // sans rien devant...)

        // Une méthode simple qui présente une personne.
        // Notez le mot-clé "virtual", nous y reviendrons très très bientôt. 
        // Il permet à la fonction d'être surchargée.
        public virtual void Presentation()
        {
            Console.WriteLine("Bonjour, je m'appelle " + Nom + ", et j'habite " + Adresse + '.');
        }

        // Une autre méthode simple qui affiche un age si celui-ci est inférieur à 50.
        public void DireAge()
        {
            if (Age < 50)
                Console.WriteLine("J'ai " + Age + " ans.");
            else
                Console.WriteLine("Je ne suis plus tout jeune !");
        }
    }
}
