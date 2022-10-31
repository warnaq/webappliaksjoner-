using GruppeOppgaveFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GruppeOppgaveFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Observasjoner> model = new List<Observasjoner>();
            using (var db = new UfoContext())
            {
                model = db.observasjoner.ToList();
            }
            TempData["model"] = model;
            return View();


        }

        public IActionResult OmOss()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult LeggBrukere()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LeggBrukere(Observasjoner model)
        {
            using (var db = new UfoContext())
            {
                db.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");

            }

        }
        [HttpPost]
        public IActionResult UpdateObservasjon(Observasjoner observasjon)
        {
            using (var db = new UfoContext())
            {
                var observasjonTemp = db.observasjoner.Where(u => u.id == observasjon.id).FirstOrDefault();
                TempData["observasjonTemp"] = observasjonTemp;
            }
            return View();

        }
        [HttpPost]
        public IActionResult UpdateBrukereFinal(Observasjoner observasjon)
        {
            using (var db = new UfoContext())
            {
                var UpdateObservasjon = db.observasjoner.Where(u => u.id == observasjon.id).FirstOrDefault();

                UpdateObservasjon.fullnavn = observasjon.fullnavn;
                UpdateObservasjon.email = observasjon.email;
                UpdateObservasjon.adress = observasjon.adress;
                UpdateObservasjon.land = observasjon.land;
                UpdateObservasjon.dato = observasjon.dato;
                UpdateObservasjon.Beskrivelse = observasjon.Beskrivelse;

                db.SaveChanges();

            }
            return View(Index);
        }
        public IActionResult Delet(Observasjoner model)
        {

            using (var db = new UfoContext())
            {
                var observasjonerDelet = db.observasjoner.Where(u => u.id == model.id).FirstOrDefault();
                db.observasjoner.Remove(model);
                db.SaveChanges();

                return View();


            }
        }
    }
}