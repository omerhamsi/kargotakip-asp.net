using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace google_cloud_api.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Locations> Locations { get; set; }

    }
}
