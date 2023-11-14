using System.Collections.Generic;
using System.Linq;

namespace Labratory4
{
    public class UnitList : List<Unit>
    {
        public IEnumerable<Unit> SortByHp()
        {
            return this.Where(e => e.BoomDistance <= 10).OrderBy(e => e.HpBar);
        }
    }
}