using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDemo
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
    public class Car
    {
     [Key]
        public int modelNo { get; set; }
        public string CarModel { get; set; }
        public string color { get; set; }

    }
}
