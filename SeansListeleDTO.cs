using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.DTO.Seans
{
   public  class SeansListeleDTO
    {
        public int SeansID { get; set; }
        public Nullable<int> FilmID { get; set; }
        public Nullable<int> SeansSaat { get; set; }

    }
}
