using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.DTO.Salon
{
    public class SalonListeleDTO
    {
        public int SalonID { get; set; }
        public string SalonAd { get; set; }
        public Nullable<int> SeansID { get; set; }
        public Nullable<int> SalonKapasite { get; set; }
        public Nullable<int> SalonSiraSayisi { get; set; }
    
    }
}
