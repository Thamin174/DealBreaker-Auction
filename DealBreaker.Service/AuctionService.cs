using DealBreaker.Entities;
using DealDouble.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealBreaker.Service
{
    public class AuctionService
    {
        public Auction GetAuctionById(int Id)
        {
            DealBreakerContext context = new DealBreakerContext();

            return context.Auctions.Where(a => a.Id == Id).First();
        }
        public List<Auction> GetAllAuction()
        {
            DealBreakerContext context = new DealBreakerContext();

            return context.Auctions.ToList();
        }
        public void SaveAuctions(Auction auction)

        {
            DealBreakerContext context = new DealBreakerContext();

            context.Auctions.Add(auction);
            context.SaveChanges();
        }

        public void UpdateAuctions(Auction auction)

        {
            DealBreakerContext context = new DealBreakerContext();

            context.Entry(auction).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteAuctions(Auction auction)

        {
            DealBreakerContext context = new DealBreakerContext();

            context.Entry(auction).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
