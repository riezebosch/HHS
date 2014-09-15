using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HHS.EF
{
    public class Speler
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public List<Team> Teams { get; set; }
    }
}
