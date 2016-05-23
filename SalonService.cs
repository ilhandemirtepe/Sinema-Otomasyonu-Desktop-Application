using SinemaOdev.DTO.Salon;
using SinemaOdev.ORM;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class SalonService
    {
        SalonRepository repository = new SalonRepository();
        public IList<SalonListeleDTO> ListeleSalon()
        {
            return repository.Listele().Select(x => new SalonListeleDTO
            {
                
                SalonID=x.SalonID,
                SalonAd=x.SalonAd,
                SalonKapasite=x.SalonKapasite,
                SeansID=x.SeansID,
                SalonSiraSayisi=x.SalonSiraSayisi,
              
            }).ToList();
        }
        public void EkleYap(SalonEkleDTO entity)
        {
            Salon flmt = new Salon
            {
                SalonAd=entity.SalonaName,
                SalonKapasite=entity.SalonCapasity,
                SeansID=entity.SeansID,
                SalonSiraSayisi=entity.SalonRowSayisi
            };
            repository.Ekle(flmt);
        }
    }
}
