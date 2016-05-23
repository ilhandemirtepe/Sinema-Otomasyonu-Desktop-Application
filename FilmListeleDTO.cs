using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.DTO.Film
{
    public class FilmListeleDTO
    {
        public int FilmID { get; set; }
        public string FilmAd { get; set; }
        public Nullable<bool> FilmUcBoyutlumu { get; set; }
        public Nullable<int> FilmTurID { get; set; }
        public Nullable<int> FilmSure { get; set; }
        public Nullable<bool> FilmYerlimi { get; set; }
    }
}
