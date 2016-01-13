using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSM
{
    class Context:DbContext
    {
        public DbSet<Item> Items {get; set;}
        public DbSet<Buyer> Buyers {get;set;}


    }
}
