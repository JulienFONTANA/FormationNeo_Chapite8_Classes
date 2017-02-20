using Ressources_Partagés;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite8_Classes_Solution
{
    class SuperHero : Hero
    {
        public string SuperSymbol { get; set; }
        public Villain EnnemiJure { get; set; }

        public SuperHero(int age, string nom, string addr, string nomHero, string pouvoir, string symbol, Villain ennemi)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
            Pouvoir = pouvoir;
            NomDeHero = nomHero;
            SuperSymbol = symbol;
            EnnemiJure = ennemi;
        }

        public override void Presentation()
        {
            Console.WriteLine("Je suis " + NomDeHero +", et le symbol "+ SuperSymbol +" sur ma cape est synonyme d'espoir! Mon ennemi juré est " + EnnemiJure.NomDeVillain +"!");
        }

        public void VaincreLeMal()
        {
            Console.WriteLine("Je te battrai toujours " + EnnemiJure.NomDeVillain + " !");
        }

        public void VaincreLeMal(Villain autreVillain)
        {
            Console.WriteLine("Tu es vaincu " + autreVillain.NomDeVillain + " !");
        }
    }
}
