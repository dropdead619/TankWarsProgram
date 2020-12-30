using System;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string name;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;
        public Tank(string name)
        {
            this.name = name;
            Random rnd = new Random();
            ammunitionLevel = rnd.Next(0, 100);
            armorLevel = rnd.Next(0, 100);
            maneuverabilityLevel = rnd.Next(0, 100);
        }
        public static bool operator ^(Tank firstTank, Tank secondTank)
        {
            if ((firstTank.ammunitionLevel == secondTank.ammunitionLevel) &&
                     (firstTank.armorLevel == secondTank.armorLevel) &&
                     (firstTank.maneuverabilityLevel == secondTank.maneuverabilityLevel))
            {
                return new Random().Next() > (Int32.MaxValue / 2);
            }
            else if ((firstTank.ammunitionLevel == secondTank.ammunitionLevel) &&
                     (firstTank.armorLevel == secondTank.armorLevel) &&
                     (firstTank.maneuverabilityLevel > secondTank.maneuverabilityLevel) ||
                     (firstTank.ammunitionLevel == secondTank.ammunitionLevel) &&
                     (firstTank.armorLevel > secondTank.armorLevel) &&
                     (firstTank.maneuverabilityLevel == secondTank.maneuverabilityLevel) ||
                     (firstTank.ammunitionLevel > secondTank.ammunitionLevel) &&
                     (firstTank.armorLevel == secondTank.armorLevel) &&
                     (firstTank.maneuverabilityLevel == secondTank.maneuverabilityLevel)
                    )
            {
                return true;
            }
            else if ((firstTank.ammunitionLevel > secondTank.ammunitionLevel &&
              firstTank.armorLevel > secondTank.armorLevel) ||
              (firstTank.armorLevel > secondTank.armorLevel &&
               firstTank.maneuverabilityLevel > secondTank.maneuverabilityLevel) ||
              (firstTank.maneuverabilityLevel > secondTank.maneuverabilityLevel &&
              firstTank.ammunitionLevel > secondTank.ammunitionLevel)
              )
            {
                return true;
            }
            return false;
        }
        public string GetAmmunitionLevelString()
        {
            return ammunitionLevel.ToString();
        }
        public string GetArmorLevelString()
        {
            return armorLevel.ToString();
        }
        public string GetManeuverabilityLevelString()
        {
            return maneuverabilityLevel.ToString();
        }
    }
}