using SinemaOdev.DTO.FilmTur;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOdev.ORM;
namespace SinemaOdev.Service
{
    public class FilmTurService
    {


 
     
        FilmTurRepository repository = new FilmTurRepository();
        public IList<FilmTurListeleDTO> ListeleFilmTurleri()
        {
            return repository.Listele().Select(x => new FilmTurListeleDTO
                {
                FilmTurId = x.FilmTurID,
                    FilmTurAd = x.FilmTurAd
                }).ToList();
        }
        public void EkleYap(FilmTurEkleDTO entity)
        {
            FilmTur flmt = new FilmTur
            {
                FilmTurAd = entity.FilmTurAdi
            };
            repository.Ekle(flmt);
        }

        public void SilmeYap(FilmTurSilDTO entity)
        {
            FilmTur flmt = new FilmTur
            {
                FilmTurID=entity.FilmTurID,
                FilmTurAd = entity.FilmTurAdi
            };
            repository.Sil(flmt);
           
        }
    }
}
