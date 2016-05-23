using SinemaOdev.DTO.Film;
using SinemaOdev.DTO.Seans;
using SinemaOdev.ORM;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class SeansService
    {
      
        SeansRepository repository = new  SeansRepository();
        public IList<SeansListeleDTO> ListeleSeans()
        {
            return repository.Listele().Select(x => new SeansListeleDTO
            {
                SeansID = x.SeansID,
                FilmID=x.FilmID,
                SeansSaat=x.SeansSaat,
            }).ToList();
        }
        public void EkleYap(SeansEkleDTO entity)
        {
            Seans flmt = new Seans
            {
                SeansSaat=entity.KacinciSaat,
                FilmID=entity.FilmID
            };
            repository.Ekle(flmt);
        }
    }
}
