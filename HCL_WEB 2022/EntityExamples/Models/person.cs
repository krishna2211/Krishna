using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityExamples.Models
{
    public class person
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string dept { get; set; }
    }
    public class personcontext : DbContext
    {
        public personcontext() : base("MySqlConnection")
        {
        }
        public DbSet<person> people { get; set; }
        
    }
}