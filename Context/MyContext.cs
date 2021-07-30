
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EXAMPLE.Model.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=DatabaseContext")//App.config içerisindeki DatabaseContext isimli connectionString yolunu gösterir.
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<People> Peoples { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }

    }
}
