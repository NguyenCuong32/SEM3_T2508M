using eSmartVehicle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSmartVehicle.Controllers
{
    public class ColorController : Controller
    {
        private readonly eSmartVehicleDBContext vehicleDBContext;

        public ColorController(eSmartVehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }
        // GET: ColorController
        public ActionResult Index()
        {
            //var colors = new List<Color>()
            //{
            //    new Color(1,"red","12fff"),
            //    new Color(2,"blue","12f4f"),
            //    new Color(3,"yellow","15fff"),
            //    new Color(3,"yellow","15fff"),
            //    new Color(3,"yellow","15fff"),
            //    new Color(3,"yellow","15fff"),
            //};
            var colors = this.vehicleDBContext.Color;
            return View(colors);
        }

        // GET: ColorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ColorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ColorId,ColorName,ColorHex")] eSmartVehicle.Models.Color color)
        {
            try
            {
                var cl = new eSmartVehicle.Models.Color(
                    color.ColorName,
                    color.ColorHex
                    );
                vehicleDBContext.Add(cl);
                vehicleDBContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ColorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ColorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ColorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ColorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
