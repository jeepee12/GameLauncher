using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    [Serializable]
    enum listeJeux { commandAndConquer, trine2, trine, Scrolls, LoL, Magicka, Minecraft, Terraria, SaintsRow3, Sanctum, Skyrim, Smite, SC2, Age2, Bfme2, UnrealTournament, VirtualPlaytable, Worms, Bf3, Burnout, C2, DS3, MoH, ME, SaintsRow4, HearthStone, coh2, coh, antichamber, portal2 };
    [Serializable]
    class EnsembleDesDonnees
    {
        private Logiciel[] tabLogiciel;
        private string[] nomDesJeux;
        public EnsembleDesDonnees(int nombreJeux)
        {
            nomDesJeux = new string[nombreJeux];
            tabLogiciel = new Logiciel[nombreJeux];

            nomDesJeux[(int)listeJeux.commandAndConquer] = "Libre";//removed
            nomDesJeux[(int)listeJeux.coh2] = "Watch dog";//changed
            nomDesJeux[(int)listeJeux.coh] = "Libre";//removed
            nomDesJeux[(int)listeJeux.Scrolls] = "Scrolls";
            nomDesJeux[(int)listeJeux.LoL] = "League of Legends";
            nomDesJeux[(int)listeJeux.Magicka] = "libre";//removed
            nomDesJeux[(int)listeJeux.Minecraft] = "Minecraft";
            nomDesJeux[(int)listeJeux.Terraria] = "Terraria";
            nomDesJeux[(int)listeJeux.SaintsRow3] = "Saints Row The Third";
            nomDesJeux[(int)listeJeux.Sanctum] = "Heroes of the storm";//changed
            nomDesJeux[(int)listeJeux.Skyrim] = "Skyrim";
            nomDesJeux[(int)listeJeux.Smite] = "Smite (game du penta:37028695)";
            nomDesJeux[(int)listeJeux.SC2] = "StarCraft II";
            nomDesJeux[(int)listeJeux.Age2] = "Overwatch";//changed
            nomDesJeux[(int)listeJeux.Bfme2] = "The Lord of the Rings, The Rise of the Witch-king";
            nomDesJeux[(int)listeJeux.UnrealTournament] = "UnrealTournament";
            nomDesJeux[(int)listeJeux.VirtualPlaytable] = "VirtualPlaytable";
            nomDesJeux[(int)listeJeux.Worms] = "Worms Revolution";
            nomDesJeux[(int)listeJeux.Bf3] = "The Crew";//removed and changed
            nomDesJeux[(int)listeJeux.Burnout] = "Factorio";//changed
            nomDesJeux[(int)listeJeux.C2] = "libre";//removed
            nomDesJeux[(int)listeJeux.DS3] = "libre";//removed
            nomDesJeux[(int)listeJeux.MoH] = "Strife";//changed
            nomDesJeux[(int)listeJeux.ME] = "libre";//removed
            nomDesJeux[(int)listeJeux.SaintsRow4] = "libre";//removed
            nomDesJeux[(int)listeJeux.HearthStone] = "HearthStone";
            nomDesJeux[(int)listeJeux.antichamber] = "libre";//removed
            nomDesJeux[(int)listeJeux.trine] = "libre";//removed
            nomDesJeux[(int)listeJeux.trine2] = "libre";//removed
            nomDesJeux[(int)listeJeux.portal2] = "libre";//removed

            for (int i = 0; i < nombreJeux; i++)
            {
                tabLogiciel[i] = new Logiciel(nomDesJeux[i]);
            }
            tabLogiciel[(int)listeJeux.commandAndConquer].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.coh2].UrlRacourcis = @"uplay://launch/274/0";
            tabLogiciel[(int)listeJeux.coh].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.Scrolls].UrlRacourcis = @".\\racourcis\\Scrolls";
            tabLogiciel[(int)listeJeux.LoL].UrlRacourcis = @".\\racourcis\\lol.launcher.admin.exe - Raccourci";
            tabLogiciel[(int)listeJeux.Magicka].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.Minecraft].UrlRacourcis = @".\\racourcis\\Minecraft.exe";
            tabLogiciel[(int)listeJeux.Terraria].UrlRacourcis = @"steam://rungameid/105600";
            tabLogiciel[(int)listeJeux.SaintsRow3].UrlRacourcis = @"steam://rungameid/55230";
            tabLogiciel[(int)listeJeux.Sanctum].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.Skyrim].UrlRacourcis = @".\\racourcis\\SkyrimLauncher.exe - Raccourci";
            tabLogiciel[(int)listeJeux.Smite].UrlRacourcis = @".\\racourcis\\Smite";
            tabLogiciel[(int)listeJeux.SC2].UrlRacourcis = @".\\racourcis\\StarCraft II";
            tabLogiciel[(int)listeJeux.Age2].UrlRacourcis = @".\\racourcis\\Overwatch";
            tabLogiciel[(int)listeJeux.Bfme2].UrlRacourcis = @".\\racourcis\\The Lord of the Rings, The Rise of the Witch-king";
            tabLogiciel[(int)listeJeux.UnrealTournament].UrlRacourcis = @".\\racourcis\\UnrealTournament.exe - Raccourci";
            tabLogiciel[(int)listeJeux.VirtualPlaytable].UrlRacourcis = @".\\racourcis\\Virtual Playtable";
            tabLogiciel[(int)listeJeux.Worms].UrlRacourcis = @"steam://rungameid/200170";
            tabLogiciel[(int)listeJeux.Bf3].UrlRacourcis = @"uplay://launch/413/0";
            tabLogiciel[(int)listeJeux.Burnout].UrlRacourcis = @".\\racourcis\\Factorio";
            tabLogiciel[(int)listeJeux.C2].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.DS3].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.MoH].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.ME].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.SaintsRow4].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.HearthStone].UrlRacourcis = @".\\racourcis\\LancerHearthstone.bat";
            tabLogiciel[(int)listeJeux.antichamber].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.trine].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.trine2].UrlRacourcis = @".\\racourcis\\libre";
            tabLogiciel[(int)listeJeux.portal2].UrlRacourcis = @".\\racourcis\\libre";

            tabLogiciel[(int)listeJeux.coh2].NbMinutes = 42;

            tabLogiciel[(int)listeJeux.Scrolls].NbJours = 3;
            tabLogiciel[(int)listeJeux.Scrolls].NbHeures = 1;
            tabLogiciel[(int)listeJeux.Scrolls].NbMinutes = 7;

            tabLogiciel[(int)listeJeux.LoL].NbJours = 4;
            tabLogiciel[(int)listeJeux.LoL].NbHeures = 6;
            tabLogiciel[(int)listeJeux.LoL].NbMinutes = 12;

            tabLogiciel[(int)listeJeux.Minecraft].NbJours = 2;
            tabLogiciel[(int)listeJeux.Minecraft].NbHeures = 12;
            tabLogiciel[(int)listeJeux.Minecraft].NbMinutes = 3;

            tabLogiciel[(int)listeJeux.Terraria].NbHeures = 11;
            tabLogiciel[(int)listeJeux.Terraria].NbMinutes = 22;

            tabLogiciel[(int)listeJeux.SaintsRow3].NbHeures = 15;
            tabLogiciel[(int)listeJeux.SaintsRow3].NbMinutes = 39;

            tabLogiciel[(int)listeJeux.Sanctum].NbJours = 2;
            tabLogiciel[(int)listeJeux.Sanctum].NbHeures = 10;
            tabLogiciel[(int)listeJeux.Sanctum].NbMinutes = 29;

            tabLogiciel[(int)listeJeux.Skyrim].NbHeures = 6;
            tabLogiciel[(int)listeJeux.Skyrim].NbMinutes = 56;

            tabLogiciel[(int)listeJeux.Smite].NbJours = 18;
            tabLogiciel[(int)listeJeux.Smite].NbHeures = 14;
            tabLogiciel[(int)listeJeux.Smite].NbMinutes = 27;

            tabLogiciel[(int)listeJeux.SC2].NbJours = 19;
            tabLogiciel[(int)listeJeux.SC2].NbHeures = 14;
            tabLogiciel[(int)listeJeux.SC2].NbMinutes = 31;

            tabLogiciel[(int)listeJeux.Age2].NbJours = 2;
            tabLogiciel[(int)listeJeux.Age2].NbHeures = 0;
            tabLogiciel[(int)listeJeux.Age2].NbMinutes = 47;

            tabLogiciel[(int)listeJeux.UnrealTournament].NbMinutes = 58;

            tabLogiciel[(int)listeJeux.VirtualPlaytable].NbHeures = 2;
            tabLogiciel[(int)listeJeux.VirtualPlaytable].NbMinutes = 30;

            tabLogiciel[(int)listeJeux.Worms].NbHeures = 4;
            tabLogiciel[(int)listeJeux.Worms].NbMinutes = 55;

            tabLogiciel[(int)listeJeux.Burnout].NbHeures = 8;
            tabLogiciel[(int)listeJeux.Burnout].NbMinutes = 8;

            tabLogiciel[(int)listeJeux.HearthStone].NbJours = 30;
            tabLogiciel[(int)listeJeux.HearthStone].NbHeures = 0;
            tabLogiciel[(int)listeJeux.HearthStone].NbMinutes = 14;

            tabLogiciel[(int)listeJeux.MoH].NbHeures = 12;
            tabLogiciel[(int)listeJeux.MoH].NbMinutes = 31;

        }


        public Logiciel[] TabLogiciel
        {
            get { return tabLogiciel; }
            set { tabLogiciel = value; }
        }

        public string[] NomDesJeux
        {
            get { return nomDesJeux; }
        }
    }
}
