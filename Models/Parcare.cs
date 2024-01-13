using System.ComponentModel;

namespace Hotel_Reception_PROIECT.Models
{
    public class Parcare
    {
        public int ID { get; set; }
        public string Client { get; set; }
        [DisplayName("Număr Cameră")]
        public int NumarCamera { get; set; }
        [DisplayName("Loc Parcare Ocupat")]
        public int LocParcareOcupat { get; set; }
        [DisplayName("Data Ocupării")]
        public DateTime DataOcuparii { get; set; }
        [DisplayName("Data Eliberării")]
        public DateTime DataEliberarii { get; set; }
    }
}