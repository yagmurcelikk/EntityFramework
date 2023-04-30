using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityOrnek1804
{
    public class EOgrenciContex:DbContext
    {
        public DbSet<Ogrenci> ogrenciler { get; set; }
    }
}
