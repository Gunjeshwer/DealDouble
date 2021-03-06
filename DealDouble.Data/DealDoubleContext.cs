using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealDouble.Entities;

namespace DealDouble.Data
{
    class DealDoubleContext : DbContext
    {
        public DealDoubleContext() : base("name=DealDoubleConnectionString")
        {
        }
        public DbSet<Auction> Auctions { get; set; }
    }
}
