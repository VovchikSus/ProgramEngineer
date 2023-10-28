using System.Collections.Generic;

namespace LabJob3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rojer = new Hero<EquipmentHeroBase>();

            rojer.EquipmentList.Add(new Weapon("Меч кладинец"));
            rojer.EquipmentList.Add(new Weapon("Щит короля"));
            rojer.EquipmentList.Add(new Armor("Алмазный нагрудник"));
            rojer.EquipmentList.Add(new Armor("Сапоги путешественника"));


            rojer.EquipmentPrint();
        }
    }
}