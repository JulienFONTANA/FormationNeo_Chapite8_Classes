using Ressources_Partagés;
using System;

namespace FormationNeo_Chapite8_Classes_Solution
{
    class SolutionCh8
    {
        static void Main(string[] args)
        {
            /* Exercies sur les classes!
             * Attention : les classes "Personne" et "Hero" ne doivent pas être modifiées!!!
            */

            // Créer une "Personne" en utilisant le constructeur complet
            // Faites en sorte que cette personne se présente
            Personne Henri = new Personne(55, "Henri", "23 rue de l'église");
            Henri.Presentation();

            // Créer un héros, puis afficher son vrai nom à l'écran, sans modifier la classe!
            // Indice: Ne passez pas par une méthode!
            Hero MegaMan = new Hero(33, "Thomas Light", "13 rue du Dr. Wily", "MegaMan", "Canon laser");
            Console.WriteLine(MegaMan.Nom);

            /* Créer un nouveau fichier dans le projet "FormationNeo_Chapite8_Classes_Exercices"
             * Pour ce faire, faites un clic droit > Ajouter > Nouvel Element > Classe (C#)
             * Renommer cette classe "Villain"
             * Dans "Villain.cs", modifier la classe ainsi créée pour la faire hériter de la classe "Personne"
             * N'oubliez pas "using Ressources_Partagés;" en haut du fichier
             * 
             * Tout villain qui se respecte à un "Nom de villain" (attribut)
             * 
             * Quand ils se présentent, les villains commencent toujours par rire de manière diabolique:
             * Exemple: "HAHAHAHAHA! Je suis System Error et je suis un villain!!!"
             * (ici System Error est un exemple de nom de villain)
             *
             * Ils peuvent aussi rire sur commande grace à la méthode RireDiabolique();
             * 
             * Appelez aussi une méthode pour afficher l'age de votre villain!
             * Indice: il ne faut pas l'écrire!!!
            */
            Villain SystemError = new Villain(33, "Paul Eugène VaillantCouturier", "1 chemin de la base secrète dans le Volcan", "System Error");
            Villain Pabopagentil = new Villain(48, "Brad Morfer", "14 base lunaire 51", "Pabopagentil");
            SystemError.Presentation();
            SystemError.RireDiabolique();
            SystemError.DireAge();


            /* Créer un nouveau fichier dans le projet "FormationNeo_Chapite8_Classes_Exercices"
             * Pour ce faire, faites un clic droit > Ajouter > Nouvel Element > Classe (C#)
             * Renommer cette classe "SuperHero"
             * Dans "SuperHero.cs", modifier la classe ainsi créée pour la faire hériter de la classe "Hero"
             * N'oubliez pas "using Ressources_Partagés;" en haut du fichier
             * 
             * Un superhéro à sa propre cape, avec un "Super Symbol", et un "Ennemi Juré" (un "Villain" en attribut!)
             * 
             * Quand ils se présentent, les superhéros ont une aura spéciale et se présentent ainsi:
             * "Je suis CodeMan, et le symbol 'en C#' sur ma cape est synonyme d'espoir! Mon ennemi juré est System Error!"
             * (CodeMan est ici le nom du superhéro, "en C#" est son super symbol et System Error est un villain)
             * 
             * Enfin un SuperHéro doit vaincre sont son ennemi juré sans qu'il ai besoin de réfléchir!
             * Pour cela, il utilise la méthode "VaincreLeMal()"!
             * 
             * Faites se battre votre héro et un robot géant en utilisant la méthode FrappeLeRobotGeant()
             * 
             * Bonus : Surcharger la méthode "VaincreLeMal()" pour qu'elle puisse prendre un autre Villain en paramètre
             * car un vrai superhéro peux vaincre plusieur ennemis!
             * 
             * Bonus2: Un super héro doit pouvoir s'allier à un autre héro ou un autre superhéro!
             * Essayer de faire s'allier un deux super héros puis un héro et un super-héro.
             * Il n'y à pas d'erreur! Comment expliquer cela?
            */
            SuperHero CodeMan = new SuperHero(25, "John Hatan", "92 avenue du Général Leclerc", "CodeMan", "Super Force", "de chat", SystemError);
            SuperHero TacoLibre = new SuperHero(40, "José Manuel Ravier", "4 avenue du Mexique", "TacoLibre", "Super Taille", "de tacos", SystemError);
            Hero Pierrus = new Hero(29, "Pierre Mur", "3 chemin du gravier", "Pierrus", "Super Resistance");

            CodeMan.Presentation();
            CodeMan.FrappeLeRobotGeant(99);
            CodeMan.VaincreLeMal();

            // Bonus 1: Surcharger la méthode "VaincreLeMal()"
            CodeMan.VaincreLeMal(Pabopagentil);

            // Bonus 2: Comment expliquer l'alliance de héros et de super-héros?
            CodeMan.Alliance(Pierrus);
            CodeMan.Alliance(TacoLibre);
            /* La classe "Hero" possède cette méthode:
             * 
             * public virtual void Alliance(Hero autreHero)
             *      {
             *          Console.WriteLine("Que je suis content de te voir " + autreHero.NomDeHero + " ! Ensemble nous sommes plus fort!");
             *      }
             * 
             * Elle prends en paramètre un "Hero" et utilise cet autre héro pour déterminer son NomDeHero.
             * Il est normal que cette methode marche entre deux héros
             * 
             * Pourtant:
             * Un héro peut s'allier à un super-héro
             * Un super-héro peut s'allier à un héro
             * Deux super-héros peuvent s'allier entre eux!
             * 
             * L'explication est simple : les super-héros sont des "Hero", et ils héritent de toutes les propriétés d'un héro
             * Ainsi, un superhero est un héro particulier. Il peut être utilisé comme un héro, et possèdant bien un
             * attribut "NomDeHero", la méthode "Alliance" fonctionne tout le temps!
             * 
             * C'est la puissance de la programmation objet!
             * 
            */
        }
    }
}
