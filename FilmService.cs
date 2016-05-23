using SinemaOdev.DTO.Film;
using SinemaOdev.ORM;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class FilmService
    {
      
        FilmRepository repository = new FilmRepository();
        public IList<FilmListeleDTO> ListeleFilm()
        {
            return repository.Listele().Select(x => new FilmListeleDTO
            {
                FilmID = x.FilmID,
                FilmAd = x.FilmAd,
                FilmSure=x.FilmSure,
                FilmUcBoyutlumu=x.FilmUcBoyutlumu,
                FilmYerlimi=x.FilmYerlimi,
                FilmTurID=x.FilmTurID
            }).ToList();
        }
        public void EkleYap(FilmEkleDTO entity)
        {
            Film flmt = new Film
            {
                FilmAd = entity.FilmAdi,
                FilmTurID=entity.FilmTurID,
                FilmUcBoyutlumu=entity.UcboyutluDurumu,
                FilmYerlimi=entity.YerliDurumu,
                FilmSure=entity.FilmSure,
                
                
            };
            repository.Ekle(flmt);
        }

    
    }
}
