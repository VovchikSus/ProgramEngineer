using System;

namespace Labratory4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var unit1 = new Unit(100, 20);
            var unit2 = new Unit(40, 6);
            var unit3 = new Unit(24, 4);
            var unit4 = new Unit(51, 0);
            var listOfUnits = new UnitList { unit1, unit2, unit3, unit4 };

            foreach (var unit in listOfUnits.SortByHp())
            {
                Console.WriteLine(unit.HpBar);
            }
        }
    }
}