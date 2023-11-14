using System;
using System.Dynamic;

namespace Labratory4
{
    public class Unit
    {
        public double HpBar { get; set; }
        public double BoomDistance { get; set; }

        public Unit(double hpBar, double boomDistance)
        {
            if (!(hpBar < 0))
            {
                HpBar = hpBar;
            }
            else
            {
                throw new ArgumentException(null, nameof(hpBar));
            }

            if (!(boomDistance < 0))
            {
                BoomDistance = boomDistance;
            }
            else
            {
                throw new ArgumentException(null, nameof(boomDistance));
            }
        }
    }
}