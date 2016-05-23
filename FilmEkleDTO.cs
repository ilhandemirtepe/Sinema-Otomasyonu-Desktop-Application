using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.DTO.Film
{
    public class FilmEkleDTO
    {
        public string FilmAdi { get; set; }
        public int FilmTurID { get; set; }
        public int  FilmSure { get; set; }
        public bool YerliDurumu { get; set; }
        public bool UcboyutluDurumu { get; set; }


    }
}
