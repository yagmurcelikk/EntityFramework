using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOrnek1804
{
    public class OgrenciDal
    {
        public List<Ogrenci> GetAll()
        {
            using (EOgrenciContex context = new EOgrenciContex())
            {
                return context.ogrenciler.ToList();
            }
        }

        public void Add(Ogrenci ogrenci)
        {
            using (EOgrenciContex context = new EOgrenciContex())
            {
                var entity = context.Entry(ogrenci);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Ogrenci ogrenci)
        {
            using (EOgrenciContex context = new EOgrenciContex())
            {
                var entity = context.Entry(ogrenci);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Ogrenci ogrenci)
        {
            using (EOgrenciContex context = new EOgrenciContex())
            {
                var entity = context.Entry(ogrenci);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
