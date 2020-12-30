using System;
using MyClassLib.WorldOfTanks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] PantherDivision = { new Tank("Panther"), new Tank("Panther"), new Tank("Panther"), new Tank("Panther"), new Tank("Panther") };
            Tank[] T34Division = { new Tank("T-34"), new Tank("T-34"), new Tank("T-34"), new Tank("T-34"), new Tank("T-34") };
            int countOfFights = PantherDivision.Length;
            for (int i = 0; i < countOfFights; i++)
            {
                Console.WriteLine("Fight number " + (i + 1) + "\n");
                if (PantherDivision[i] ^ T34Division[i])
                {
                    Console.WriteLine($"Tank Panther with:\n" +
                        $"Ammunition Level: {PantherDivision[i].GetAmmunitionLevelString()}\n" +
                        $"Level of armor: {PantherDivision[i].GetArmorLevelString()}\n" +
                        $"Maneuverability Level: {PantherDivision[i].GetManeuverabilityLevelString()}\n" +
                        $"Won in this fight!\n");
                    Console.WriteLine($"Tank T-34 with:\n" +
                        $"Ammunition Level: {T34Division[i].GetAmmunitionLevelString()}\n" +
                        $"Level of armor: {T34Division[i].GetArmorLevelString()}\n" +
                        $"Maneuverability Level: {T34Division[i].GetManeuverabilityLevelString()}\n" +
                        $"Lost in this fight!");
                }
                else
                {
                    Console.WriteLine($"Tank T-34 with:\n" +
                        $"Ammunition Level: {T34Division[i].GetAmmunitionLevelString()}\n" +
                        $"Level of armor: {T34Division[i].GetArmorLevelString()}\n" +
                        $"Maneuverability Level: {T34Division[i].GetManeuverabilityLevelString()}\n" +
                        $"Won in this fight!\n");
                    Console.WriteLine($"Tank Panther with:\n" +
                        $"Ammunition Level: {PantherDivision[i].GetAmmunitionLevelString()}\n" +
                        $"Level of armor: {PantherDivision[i].GetArmorLevelString()}\n" +
                        $"Maneuverability Level: {PantherDivision[i].GetManeuverabilityLevelString()}\n" +
                        $"Lost in this fight!");
                };
                Console.WriteLine();
            }
        }
    }
}