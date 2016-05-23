using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.DTO.Satis
{
    public class SatisListeleDTO
    {
        public int SatisID { get; set; }
        public Nullable<int> CalisanID { get; set; }
        public Nullable<System.DateTime> SatisTarih { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
    }
}
