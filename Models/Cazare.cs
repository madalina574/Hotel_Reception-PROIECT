using System.ComponentModel;

namespace Hotel_Reception_PROIECT.Models
{
    public class Cazare
    {
        public int ID { get; set; }
        [DisplayName("Numar Camera")]
        public int NumarCamera { get; set; }
        public int Etaj { get; set; }
        [DisplayName("Tip Camera")]
        public string TipCamera { get; set; }
        public string Disponibilitate { get; set; }
        public ICollection<Oaspete>? Oaspeti { get; set; } //navigation property
    }
}
