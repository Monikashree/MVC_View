using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainTicketBookingMVC.DAL;
using TrainTicketBookingMVC.Entity;

namespace TrainTicketBookingMVC.Controllers
{
    public class TrainController : Controller
    {
        // GET: Train
        public ActionResult Index()
        {
            IEnumerable<Train> details = TrainRepository.GetTrainDetails();
            ViewBag.details = details;
            ViewData["Details"] = details;
            TempData["Details"] = details;
            return View();
        }
    }
}