using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class DokumentProjekt
    {
        public int Id { get; set; }
        public int IdProjekta { get; set; }
        public int IdDokumenta { get; set; }

        public Dokument IdDokumentaNavigation { get; set; }
        public Projekt IdProjektaNavigation { get; set; }
    }
}
