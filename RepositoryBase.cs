using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaOdev.ORM;
namespace SinemaOdev.Repository
{
    public class RepositoryBase<T> where T : class
    {

        private static SinemaOtomasyonuEntities context;
        //Sinleton pattern oluşturduk
        public SinemaOtomasyonuEntities Context
        {
            get
            {
                if (context==null)
                {
                    context = new SinemaOtomasyonuEntities();
                }
                return context;
            }
            set { context = value; }
        }
        public IList<T> Listele()
        {
            return Context.Set<T>().ToList();
        }
        public void Ekle(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            Context = new SinemaOtomasyonuEntities(); //ekleme yaparsan guncellenmesi için yaptık
      
        }
        public void Sil(T entity)
        {
           
       
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            Context = new SinemaOtomasyonuEntities();
        }
        public void Guncelle()
        {
            Context.SaveChanges();
        }
    }
}
