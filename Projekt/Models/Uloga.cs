using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class Uloga
    {
        public Uloga()
        {
            OsobaProjekt = new HashSet<OsobaProjekt>();
        }

        public int IdUloge { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<OsobaProjekt> OsobaProjekt { get; set; }
    }
}
