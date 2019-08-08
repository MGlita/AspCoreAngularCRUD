using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAngular.Models
{
    public class ModelContext: DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options):base(options)
        {

        }

        public DbSet<UserAddress> UserAddress { get; set; }
    }
}
