using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurtiKamizOnline.Domain.Entities;
using System.Data.Entity;

namespace KurtiKamizOnline.Domain.Concrete
{
    public class EFDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
