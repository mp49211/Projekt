using System;
using System.Collections.Generic;

namespace Projekt.Models
{
    public partial class Dokument
    {
        public Dokument()
        {
            DokumentProjekt = new HashSet<DokumentProjekt>();
        }

        public int IdDokumenta { get; set; }
        public string Naziv { get; set; }
        public string Poveznica { get; set; }
        public byte[] Document { get; set; }
        public string Opis { get; set; }

        public ICollection<DokumentProjekt> DokumentProjekt { get; set; }
    }
}
