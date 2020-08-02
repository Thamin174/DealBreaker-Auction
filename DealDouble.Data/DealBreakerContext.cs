using DealBreaker.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Data
{
    public class DealBreakerContext : DbContext
    {
        public DealBreakerContext() : base("DBConnection")
        {

        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
