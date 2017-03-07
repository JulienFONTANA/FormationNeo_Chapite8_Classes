using Ressources_Partagés;
using System;

namespace FormationNeo_Chapite8_Classes_Solution
{
    class Villain : Personne
    {
        public string NomDeVillain { get; set; }

        public Villain(int age, string nom, string addr, string nomVillain)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
            NomDeVillain = nomVillain;
        }

        public override void Presentation()
        {
            Console.WriteLine("HAHAHAHAHA! Je suis " + NomDeVillain + " et je suis un villain!!!");
        }

        public void RireDiabolique()
        {
            Console.WriteLine("HAHAHAHAHAHAHAHAHAHAH !!!!!!!!");
        }
    }
}
