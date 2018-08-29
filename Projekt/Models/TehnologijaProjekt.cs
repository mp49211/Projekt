using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class TehnologijaProjekt
    {
        public int Id { get; set; }
        public int IdProjekta { get; set; }
        public int IdTehnologije { get; set; }

        public Projekt IdProjektaNavigation { get; set; }
        public Tehnologija IdTehnologijeNavigation { get; set; }
    }
}
