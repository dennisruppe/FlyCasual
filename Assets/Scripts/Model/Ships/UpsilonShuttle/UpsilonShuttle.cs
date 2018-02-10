﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Movement;
using ActionsList;

namespace Ship
{
    namespace UpsilonShuttle
    {
        public class UpsilonShuttle : GenericShip
        {

            public UpsilonShuttle() : base()
            {
                Type = "Upsilon-class Shuttle";
                IconicPilots.Add(Faction.Imperial, typeof(StarkillerBasePilot));
                ShipBaseSize = BaseSize.Large;

                ManeuversImageUrl = "https://vignette.wikia.nocookie.net/xwing-miniatures/images/7/74/MI_UPSILON.PNG";

                Firepower = 4;
                Agility = 1;
                MaxHull = 6;
                MaxShields = 6;

                SubFaction = SubFaction.FirstOrder;

                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.System);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Crew);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Crew);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Tech);
                PrintedUpgradeIcons.Add(Upgrade.UpgradeType.Tech);

                PrintedActions.Add(new TargetLockAction());
                PrintedActions.Add(new CoordinateAction());

                AssignTemporaryManeuvers();
                HotacManeuverTable = new AI.UpsilonShuttleTable();

                factions.Add(Faction.Imperial);
                faction = Faction.Imperial;

                SkinName = "Upsilon-class Shuttle";

                SoundShotsPath = "Slave1-Fire";
                ShotsCount = 3;

                for (int i = 1; i < 3; i++)
                {
                    SoundFlyPaths.Add("Slave1-Fly" + i);
                }
            }

            private void AssignTemporaryManeuvers()
            {
                Maneuvers.Add("0.S.S", ManeuverColor.Red);
                Maneuvers.Add("1.L.T", ManeuverColor.Red);
                Maneuvers.Add("1.L.B", ManeuverColor.White);
                Maneuvers.Add("1.F.S", ManeuverColor.Green);
                Maneuvers.Add("1.R.B", ManeuverColor.White);
                Maneuvers.Add("1.R.T", ManeuverColor.Red);
                Maneuvers.Add("2.L.T", ManeuverColor.White);
                Maneuvers.Add("2.L.B", ManeuverColor.Green);
                Maneuvers.Add("2.F.S", ManeuverColor.Green);
                Maneuvers.Add("2.R.B", ManeuverColor.Green);
                Maneuvers.Add("2.R.T", ManeuverColor.White);
                Maneuvers.Add("3.L.T", ManeuverColor.Red);
                Maneuvers.Add("3.L.B", ManeuverColor.White);
                Maneuvers.Add("3.F.S", ManeuverColor.White);
                Maneuvers.Add("3.R.B", ManeuverColor.White);
                Maneuvers.Add("3.R.T", ManeuverColor.Red);
            }

        }
    }
}
