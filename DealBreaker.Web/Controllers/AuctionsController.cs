using DealBreaker.Entities;
using DealBreaker.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealBreaker.Web.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionService auctionService = new AuctionService();
        // GET: Auctions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            var auction = auctionService.GetAllAuction();
            return View(auction);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            auctionService.SaveAuctions(auction);
            return RedirectToAction("Listing");
        }

        public ActionResult Edit(int Id)
        {
            var auction = auctionService.GetAuctionById(Id);
            return View(auction);
        }
        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            auctionService.UpdateAuctions(auction);
            return RedirectToAction("Listing");
        }

        public ActionResult Delete(int Id)
        {
            var auction = auctionService.GetAuctionById(Id);
            return View(auction);
        }
        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            auctionService.DeleteAuctions(auction);
            return RedirectToAction("Listing");
        }
    }
}