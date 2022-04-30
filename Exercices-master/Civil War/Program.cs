using System;

namespace Civil_War
{
    class Program
    {
        private static void Main(string[] args)
        {
            Faction factionCaptainAmerica = new Faction("Captain America");
            factionCaptainAmerica.AjouterMembre(new CaptainAmerica());
            factionCaptainAmerica.AjouterMembre(new BlackWidow());
            factionCaptainAmerica.AjouterMembre(new AntMan());
            factionCaptainAmerica.AjouterMembre(new SoldatHiver());

            Console.WriteLine(factionCaptainAmerica.GetInfoMembres());

            Faction factionIronMan = new Faction("Iron Man");
            factionIronMan.AjouterMembre(new IronMan());
            factionIronMan.AjouterMembre(new SpiderMan());
            factionIronMan.AjouterMembre(new WarMachine());
            factionIronMan.AjouterMembre(new PanthereNoire());

            Console.WriteLine(factionIronMan.GetInfoMembres());

            factionCaptainAmerica.SupprimerMembre("Black Widow");
            factionCaptainAmerica.SupprimerMembre("Ant Man");
            factionIronMan.SupprimerMembre("War Machine");

            Console.WriteLine(factionCaptainAmerica.GetInfoMembres());
            Console.WriteLine(factionIronMan.GetInfoMembres());


        }
    }
}
