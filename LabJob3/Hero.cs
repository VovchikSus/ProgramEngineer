using System;
using System.Collections.Generic;
using System.Text;

namespace LabJob3
{
    public class Hero<T> where T : EquipmentHeroBase
    {
        public List<T> EquipmentList = new List<T>();


        public void EquipmentPrint()
        {
            var PrintText = new StringBuilder();
            PrintText.Append($"У выбранного героя: ");
            foreach (var el in this.EquipmentList)
            {
                PrintText.Append($"{el.Name}, ");
            }

            Console.WriteLine(PrintText);
        }
    }
}