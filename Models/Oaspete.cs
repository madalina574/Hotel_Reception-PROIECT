using System.ComponentModel;

namespace Hotel_Reception_PROIECT.Models
{
    public class Oaspete
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public int Telefon { get; set; }
        [DisplayName("Check-In")]
        public DateTime CheckIn { get; set; }
        [DisplayName("Check-Out")]
        public DateTime CheckOut { get; set; }
        [DisplayName("Tip Cameră Ocupată")]
        public string TipCameraOcupata { get; set; }
        public int? CazareID { get; set; }
        public Cazare? Cazare { get; set; }


    }
}
