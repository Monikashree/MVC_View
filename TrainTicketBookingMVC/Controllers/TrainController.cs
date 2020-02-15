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
        TrainRepository trainRepository;
        public TrainController()
        {
            trainRepository = new TrainRepository();
        }
            

        public ActionResult Index()
        {
            IEnumerable<Train> details = trainRepository.GetTrainDetails();
            ViewBag.details = details;
            ViewData["Details"] = details;
            TempData["Details"] = details;
            return View();
        }

        //public ActionResult DataPassing()
        //{
        //    IEnumerable<Train> trains = trainRepository.GetTrainDetails();
        //    ViewBag.trains = trains;
        //    ViewData["trains"] = trains;
        //    return View();
        //}
        //public ActionResult TempDataCheck()
        //{
        //    IEnumerable<Train> trains = trainRepository.GetTrainDetails();
        //    TempData["trains"] = trains;
        //    return RedirectToAction("TempDataChecking");
        //}
        //public ActionResult TempDataChecking()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Train train)
        {
            // if(ModelState.IsValid)
            //{
            trainRepository.AddDetails(train);
            TempData["Details"] = "Details added";
            return RedirectToAction("Index");
            //}
            //return View(packageDetails);
        }
        public ActionResult Edit(int id)
        {
            Train trains = trainRepository.GetDetailsById(id);
            return View(trains);
        }
        public ActionResult Delete(int id)
        {
            trainRepository.DeleteDetails(id);
            TempData["Details"] = "Details deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(Train train)
        {
            // if (ModelState.IsValid)
            //{
            trainRepository.UpdateDetails(train);
            TempData["Details"] = "Details updated";
            return RedirectToAction("Index");
            //}
            //return View("Edit",packageDetails);
        }
    }
}