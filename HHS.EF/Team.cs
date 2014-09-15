using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HHS.EF
{
    public class Team
    {
        public int Id { get; set; }

       
        public string Naam { get; set; }

        public List<Speler> Spelers { get; set; }
    }
}
