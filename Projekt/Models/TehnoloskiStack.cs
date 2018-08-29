using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class TehnoloskiStack
    {
        public TehnoloskiStack()
        {
            Projekt = new HashSet<Projekt>();
        }

        public int IdStacka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<Projekt> Projekt { get; set; }
    }
}
