using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class PoslovnoPodrucje
    {
        public PoslovnoPodrucje()
        {
            PodrucjeProjekt = new HashSet<PodrucjeProjekt>();
        }

        public int IdPodrucja { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<PodrucjeProjekt> PodrucjeProjekt { get; set; }
    }
}
