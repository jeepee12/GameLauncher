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

            nomDesJeux[(int)listeJeux.commandAndConquer] = "Command & Conquer Generals Zero Hour";
            nomDesJeux[(int)listeJeux.coh2] = "Company of Heroes 2";
            nomDesJeux[(int)listeJeux.coh] = "Company of Heroes Tales of Valor";
            nomDesJeux[(int)listeJeux.Scrolls] = "Scrolls";
            nomDesJeux[(int)listeJeux.LoL] = "League of Legends";
            nomDesJeux[(int)listeJeux.Magicka] = "Magicka";
            nomDesJeux[(int)listeJeux.Minecraft] = "Minecraft";
            nomDesJeux[(int)listeJeux.Terraria] = "Terraria";
            nomDesJeux[(int)listeJeux.SaintsRow3] = "Saints Row The Third";
            nomDesJeux[(int)listeJeux.Sanctum] = "Sanctum";
            nomDesJeux[(int)listeJeux.Skyrim] = "Skyrim";
            nomDesJeux[(int)listeJeux.Smite] = "Smite (game du penta:37028695)";
            nomDesJeux[(int)listeJeux.SC2] = "StarCraft II";
            nomDesJeux[(int)listeJeux.Age2] = "Age of Empire II, The Conquerors";
            nomDesJeux[(int)listeJeux.Bfme2] = "The Lord of the Rings, The Rise of the Witch-king";
            nomDesJeux[(int)listeJeux.UnrealTournament] = "UnrealTournament";
            nomDesJeux[(int)listeJeux.VirtualPlaytable] = "VirtualPlaytable";
            nomDesJeux[(int)listeJeux.Worms] = "Worms Revolution";
            nomDesJeux[(int)listeJeux.Bf3] = "Battlefield 3";
            nomDesJeux[(int)listeJeux.Burnout] = "Burnout";
            nomDesJeux[(int)listeJeux.C2] = "Crysis 2";
            nomDesJeux[(int)listeJeux.DS3] = "Dead Space 3";
            nomDesJeux[(int)listeJeux.MoH] = "Medal of honor";
            nomDesJeux[(int)listeJeux.ME] = "Mirror's Edge";
            nomDesJeux[(int)listeJeux.SaintsRow4] = "Saint Row 4";
            nomDesJeux[(int)listeJeux.HearthStone] = "HearthStone";
            nomDesJeux[(int)listeJeux.antichamber] = "Antichamber";
            nomDesJeux[(int)listeJeux.trine] = "Trine 1";
            nomDesJeux[(int)listeJeux.trine2] = "Trine 2";
            nomDesJeux[(int)listeJeux.portal2] = "Portal 2";

            for (int i = 0; i < nombreJeux; i++)
            {
                tabLogiciel[i] = new Logiciel(nomDesJeux[i]);
            }
            tabLogiciel[(int)listeJeux.commandAndConquer].UrlRacourcis = @".\\tritor\\Command & Conquer Generals Zero Hour";
            tabLogiciel[(int)listeJeux.coh2].UrlRacourcis = @"steam://rungameid/231430";
            tabLogiciel[(int)listeJeux.coh].UrlRacourcis = @"steam://rungameid/20540";
            tabLogiciel[(int)listeJeux.Scrolls].UrlRacourcis = @".\\tritor\\Scrolls";
            tabLogiciel[(int)listeJeux.LoL].UrlRacourcis = @".\\tritor\\lol.launcher.admin.exe - Raccourci";
            tabLogiciel[(int)listeJeux.Magicka].UrlRacourcis = @"steam://rungameid/42910";
            tabLogiciel[(int)listeJeux.Minecraft].UrlRacourcis = @".\\tritor\\Minecraft.exe";
            tabLogiciel[(int)listeJeux.Terraria].UrlRacourcis = @"steam://rungameid/105600";
            tabLogiciel[(int)listeJeux.SaintsRow3].UrlRacourcis = @"steam://rungameid/55230";
            tabLogiciel[(int)listeJeux.Sanctum].UrlRacourcis = @"steam://rungameid/91600";
            tabLogiciel[(int)listeJeux.Skyrim].UrlRacourcis = @".\\tritor\\SkyrimLauncher.exe - Raccourci";
            tabLogiciel[(int)listeJeux.Smite].UrlRacourcis = @".\\tritor\\Smite";
            tabLogiciel[(int)listeJeux.SC2].UrlRacourcis = @"C:\Program Files (x86)\Battle.net\Battle.net Launcher.exe";
            tabLogiciel[(int)listeJeux.Age2].UrlRacourcis = @".\\tritor\\The Conquerors";
            tabLogiciel[(int)listeJeux.Bfme2].UrlRacourcis = @".\\tritor\\The Lord of the Rings, The Rise of the Witch-king";
            tabLogiciel[(int)listeJeux.UnrealTournament].UrlRacourcis = @".\\tritor\\UnrealTournament.exe - Raccourci";
            tabLogiciel[(int)listeJeux.VirtualPlaytable].UrlRacourcis = @".\\tritor\\Virtual Playtable";
            tabLogiciel[(int)listeJeux.Worms].UrlRacourcis = @"steam://rungameid/200170";
            tabLogiciel[(int)listeJeux.Bf3].UrlRacourcis = @".\\tritor\\Battlefield 3";
            tabLogiciel[(int)listeJeux.Burnout].UrlRacourcis = @".\\tritor\\Burnout Paradise The Ultimate Box";
            tabLogiciel[(int)listeJeux.C2].UrlRacourcis = @"";
            tabLogiciel[(int)listeJeux.DS3].UrlRacourcis = @".\\tritor\\Dead Space 3";
            tabLogiciel[(int)listeJeux.MoH].UrlRacourcis = @"steam://rungameid/47790";
            tabLogiciel[(int)listeJeux.ME].UrlRacourcis = @"steam://rungameid/17410";
            tabLogiciel[(int)listeJeux.SaintsRow4].UrlRacourcis = @"steam://rungameid/206420";
            tabLogiciel[(int)listeJeux.HearthStone].UrlRacourcis = @".\\tritor\\Hearthstone";
            tabLogiciel[(int)listeJeux.antichamber].UrlRacourcis = @"steam://rungameid/219890";
            tabLogiciel[(int)listeJeux.trine].UrlRacourcis = @"steam://rungameid/35700";
            tabLogiciel[(int)listeJeux.trine2].UrlRacourcis = @"steam://rungameid/35720";
            tabLogiciel[(int)listeJeux.portal2].UrlRacourcis = @"steam://rungameid/620";

            tabLogiciel[(int)listeJeux.antichamber].NbMinutes = 14;

            tabLogiciel[(int)listeJeux.Scrolls].NbJours = 2;
            tabLogiciel[(int)listeJeux.Scrolls].NbHeures = 21;
            tabLogiciel[(int)listeJeux.Scrolls].NbMinutes = 49;

            tabLogiciel[(int)listeJeux.LoL].NbJours = 1;
            tabLogiciel[(int)listeJeux.LoL].NbHeures = 21;
            tabLogiciel[(int)listeJeux.LoL].NbMinutes = 16;

            tabLogiciel[(int)listeJeux.Minecraft].NbJours = 2;
            tabLogiciel[(int)listeJeux.Minecraft].NbHeures = 4;
            tabLogiciel[(int)listeJeux.Minecraft].NbMinutes = 28;

            tabLogiciel[(int)listeJeux.Terraria].NbHeures = 11;
            tabLogiciel[(int)listeJeux.Terraria].NbMinutes = 22;

            tabLogiciel[(int)listeJeux.SaintsRow3].NbHeures = 15;
            tabLogiciel[(int)listeJeux.SaintsRow3].NbMinutes = 39;

            tabLogiciel[(int)listeJeux.Skyrim].NbHeures = 6;
            tabLogiciel[(int)listeJeux.Skyrim].NbMinutes = 52;

            tabLogiciel[(int)listeJeux.Smite].NbJours = 4;
            tabLogiciel[(int)listeJeux.Smite].NbHeures = 14;
            tabLogiciel[(int)listeJeux.Smite].NbMinutes = 49;

            tabLogiciel[(int)listeJeux.SC2].NbJours = 3;
            tabLogiciel[(int)listeJeux.SC2].NbHeures = 5;
            tabLogiciel[(int)listeJeux.SC2].NbMinutes = 2;

            tabLogiciel[(int)listeJeux.UnrealTournament].NbMinutes = 43;

            tabLogiciel[(int)listeJeux.VirtualPlaytable].NbHeures = 2;
            tabLogiciel[(int)listeJeux.VirtualPlaytable].NbMinutes = 30;

            tabLogiciel[(int)listeJeux.Worms].NbHeures = 4;
            tabLogiciel[(int)listeJeux.Worms].NbMinutes = 55;

            tabLogiciel[(int)listeJeux.Burnout].NbHeures = 1;
            tabLogiciel[(int)listeJeux.Burnout].NbMinutes = 19;

            tabLogiciel[(int)listeJeux.trine2].NbHeures = 3;
            tabLogiciel[(int)listeJeux.trine2].NbMinutes = 10;

            tabLogiciel[(int)listeJeux.DS3].NbMinutes = 43;

            tabLogiciel[(int)listeJeux.ME].NbHeures = 4;
            tabLogiciel[(int)listeJeux.ME].NbMinutes = 21;

            tabLogiciel[(int)listeJeux.SaintsRow4].NbHeures = 4;
            tabLogiciel[(int)listeJeux.SaintsRow4].NbMinutes = 9;

            tabLogiciel[(int)listeJeux.HearthStone].NbJours = 1;
            tabLogiciel[(int)listeJeux.HearthStone].NbMinutes = 52;

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
