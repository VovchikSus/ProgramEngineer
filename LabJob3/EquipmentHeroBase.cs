using System;

namespace LabJob3
{
    public class EquipmentHeroBase
    {
        protected EquipmentHeroBase(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                throw new ArgumentException(null, nameof(name));
            }
        }

        public string Name { get; set; }
    }
}