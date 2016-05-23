using SinemaOdev.DTO.Bilet;
using SinemaOdev.ORM;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class Biletservice
    {
        BiletRepository repository = new BiletRepository();
        public IList<BiletListeleDTO> ListeleFilm()
        {
            return repository.Listele().Select(x => new BiletListeleDTO
            {
                BiletID=x.BiletID,
                BiletKoltukNumara=x.BiletKoltukNumara,
                BiletTarih=x.BiletTarih,
                FilmID=x.FilmID,
                SatisID=x.SatisID,
            
     
            }).ToList();
        }
        public void EkleYap(BiletEkleDTO entity)
        {
            Bilet flmt = new Bilet
            {
           
                BiletKoltukNumara=entity.ChairNumber,
                FilmID=entity.FilmNumber,
                SatisID=entity.SatisNumber,
            };
            repository.Ekle(flmt);
        }
    }
}
