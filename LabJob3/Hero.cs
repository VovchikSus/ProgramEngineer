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
            var builder = new StringBuilder();
            builder.Append($"У выбранного героя: ");
            foreach (var el in this.EquipmentList)
            {
                builder.Append($"{el.Name}, ");
            }

            Console.WriteLine(builder);
        }
    }
}