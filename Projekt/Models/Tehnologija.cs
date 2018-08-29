using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class Tehnologija
    {
        public Tehnologija()
        {
            TehnologijaProjekt = new HashSet<TehnologijaProjekt>();
        }

        public int IdTehnologije { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<TehnologijaProjekt> TehnologijaProjekt { get; set; }
    }
}
