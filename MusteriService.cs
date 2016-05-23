using SinemaOdev.DTO.Musteri;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class MusteriService
    {

        MusteriRepository repository = new MusteriRepository();
        public IList<MusteriListeleDTO> ListeleMusterileri()
        {
            return repository.Listele().Select(x => new MusteriListeleDTO
            {
                 MusteriID=x.MusteriID,
                 MusteriAdı=x.MusteriAdı,
                 MusteriSoyad=x.MusteriSoyad
            }).ToList();
        }
    }
}
