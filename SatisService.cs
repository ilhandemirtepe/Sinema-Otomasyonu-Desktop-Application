using SinemaOdev.DTO.Satis;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class SatisService
    {

        SatisRepositiry repository = new SatisRepositiry();
        public IList<SatisListeleDTO> ListeleSatislari()
        {
            return repository.Listele().Select(x => new SatisListeleDTO
            {
                CalisanID=x.CalisanID,
                MusteriID=x.MusteriID,
                SatisFiyat=x.SatisFiyat,
                SatisID=x.SatisID,
                SatisTarih=x.SatisTarih
              
            }).ToList();
        }
    }
}
