
/* Bienvenue dans le quatrième tutoriel de la formation Néo!
 * Les variables n'ont plus aucun secret pour vous?
 * Les structures de controles sont devenu une seconde nature?
 * Les fonctions ne vont font plus peur? Parfait!
 * 
 * Il est temps de créer vos propres classes.
 * Une classe est un objet. C'est une représentation du monde réel,
 * un concept, une idée abstraite... et c'est un outils très puissant!
 * 
 * Il est temps de créer mos Héros, et nos SuperHéros!
 * Nous allons voir ici des notions comme la déclaration et la construction
 * de classes, l'appel de méthodes et l'héritage.
 * 
 * Il est temps de voir les classes!!!
 * 
*/

using System;

// Nous utilisons ici des classes présentes dans un autre "namespace"
// C'est le projet "ressources partagés" présent en bas de votre
// explorateur de solutions. Comme son nom l'indique, ce projet
// contient des ressources partagés entre le cours et les différents
// exercices. Vous verrez que c'est même la que va se passer 90% du cours!
using Ressources_Partagés;

namespace FormationNeo_Chapite8_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Classe simple : Personne
             * 
             * Nous allons commencer par une classe simple, c'est à dire une "personne" quelconque
             * Ce sera la base de nos héros. Il est crucial de comprendre comment chaque paramètres
             * et chaque méthode s'imbrique pour comprendre la suite.
             * Soyez sur d'avoir le fichier "Personne.cs" ouvert dans un onglet, et de le lire
             * en même temps que le code ci-dessous
            */
            Console.WriteLine("- - - Personne - - -");

            // Déclaration avec le constructeur complet (N°1)
            // Contrairement aux variables, il faut allouer de la mémoire pour une classe, et
            // la synthaxe pour ce faire est "Classe Nom = new Classe(paramètres)"
            Personne Paul = new Personne(23, "Paul", "43 rue de la République");
            // Déclaration avec le constructeur simplifié (N°2)
            Personne Jean = new Personne(62, "Jean"); // Ici pas d'adresse!
            // Declaration avec le constructeur vide (N°3)
            Personne Alex = new Personne();

            // Notez Que ces deux lignes ont le même résultat, la présentation d'une personne
            Paul.Presentation(); // Présentation complette de Paul
            Jean.Presentation(); // Présentation de Jean, notez qu'une "adresse" est fournie

            // Ici et contrairement aux lignes précédentes, le même appel de fonction
            // à un résultat différent! Ce comportement est lié à une variable interne à la
            // classe! Voir Personne.cs pour plus d'info.
            Paul.DireAge(); // Paul donne son age car il a moins de 50 ans
            Jean.DireAge(); // Jean ne donne pas son age, car il a plus de 50 ans

            // Il est possible de modifier les variables dans une classe de la même
            // manière qu'on modifiais les variables précédement!
            Alex.Age = 40;
            Alex.DireAge();

            // A noter : Alex n'as pas tout ces attributs déclarés.
            // Le résultat de certaines méthodes est alors parfois étrange... 
            Alex.Presentation();


            /* 
             * Classe héritée : Héro
             * 
             * La classe "Hero" HERITE de la classe "Personne". En effet, un héro est une personne.
             * Un héro possède donc tout les attributs d'un personne, mais possède ces propres attributs.
             * Un héro peut aussi faire tout ce que fait une personne, mais pas forcément de la même manière.
             * 
             * Les notions abordés ici sont PRIMORDIALES. A la fin de ce cours, vous devez savoir:
             *      - Ce qu'est l'hériatge
             *      - Ce qu'est la surcharge
             *      - Et surtout POURQUOI ON UTILISE DES CLASSES
             *      
             * Les objets sont au coeur de la Programmation Orientée Objet (POO), les classes étant
             * le pillier de tout programme écrit en C#. J'en profite pour attirer votre attention sur
             * le fait que chacun de ces programmes (et ce depuis le premier exercice) EST UNE CLASSE!
            */
            Console.WriteLine('\n' + "- - - Hero - - -");

            // Deux déclarations identiques pour créer deux héros
            Hero SuperBaleze = new Hero(35, "Jean-Marie", "14 rue des gens gentils", "SuperBaleze", "Super Force");
            Hero LeBinoclard = new Hero(21, "Jean-Guy", "122 impasse de chez Mamie", "LeBinoclard", "Mega Vision");

            // La classe Héro ne possède pas de fonction "DireAge()" ni même d'attribut "Age" (Allez voir!)
            // Il est possible d'appeler cette fonction sans erreur car SuperBaleze est un héro, et
            // qu'un héro est une personne. La classe "Hero" hérite de "Personne", et donc ces attributs et méthodes
            // sont elles aussi hérités.
            SuperBaleze.DireAge();

            // Cette méthode est propre aux héros, elle n'existe que dans la classe "Hero"
            // "Jean" ou "Paul" n'y ont pas accès...
            SuperBaleze.UtiliseSonPouvoir();
            LeBinoclard.UtiliseSonPouvoir();
            // Erreur à la ligne suivante
            //Jean.UtiliseSonPouvoir();

            // Première complication. Lors de sa présentation, "LeBinoclard" ne donne ni son nom ni son adresse!
            // Pourtant cette fonction est la même que celle appelée par "Paul" ou "Jean"!
            // Ce phénomène est possible car la fonction "Présentation()" à été surchargé
            // Pour plus de détails, allez voir "Personne.cs"
            LeBinoclard.Presentation();

            // Comme pour une fonction traditionelle, les méthodes peuvent prendre des paramètres...
            SuperBaleze.FrappeLeRobotGeant(100);

            // ...et de la même manière, ces méthodes peuvent avoir un retour!
            if (SuperBaleze.AUnEnnemiJure())
                Console.WriteLine("C'est surement l'oeuvre de mon ennemi juré!");
            else
                Console.WriteLine("D'où sort ce robot géant?");

            if (LeBinoclard.AUnEnnemiJure())
                Console.WriteLine("C'est surement l'oeuvre de mon ennemi juré!");
            else
                Console.WriteLine("D'où sort ce robot géant?");

            // Une classe peut être manipulée comme une variable, et être passée en paramètre
            // (une classe peut même être un type de retour!!!)
            SuperBaleze.Alliance(LeBinoclard);

            // Enfin, une partie de classe peut être passé en paramètre
            LeBinoclard.OuEsTaBaseSecrete(SuperBaleze.Adresse);
        }
    }
}
