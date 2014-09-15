using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHS
{
    public class ProductBacklogHelper
    {
        public static List<string> Combine(List<List<string>> items)
        {
            return items
                .SelectMany(
                    x => x.Select((m, i) => new { Index = i, Item = m }))
                .GroupBy(m => m.Item, m => m.Index)
                .Select(m => new { m.Key, Prioriteit = m.Sum() })
                .OrderBy(m => m.Prioriteit)
                .Select(m => m.Key).ToList();
        }
    }
}
