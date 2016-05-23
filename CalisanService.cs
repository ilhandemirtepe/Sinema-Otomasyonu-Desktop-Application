using SinemaOdev.DTO.Calisan;
using SinemaOdev.ORM;
using SinemaOdev.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOdev.Service
{
    public class CalisanService
    {
        CalisanRepository repository = new CalisanRepository();
        public IList<CalisanListeleDTO> ListeleCalisanlari()
        {
            return repository.Listele().Select(x => new CalisanListeleDTO
            {
                CalisanAd=x.CalisanAd,
                CalisanID=x.CalisanID,
                CalisanKullaniciAd=x.CalisanKullaniciAd,
                CalisanParola=x.CalisanParola,
                CalisanSoyad=x.CalisanSoyad,
                CalisanTcNo=x.CalisanTcNo
            }).ToList();
        }
        public void EkleYap(CalisanEkleDTO entity)
        {
            Calisan flmt = new Calisan
            {
                CalisanAd=entity.CalisanName,
                CalisanSoyad=entity.CalisanSurname,
                CalisanTcNo=entity.CalisanTcNumara,
                CalisanParola=entity.CalisanPassword,
                CalisanKullaniciAd=entity.CalisanUsername,

            };
            repository.Ekle(flmt);
        }
    }
}
