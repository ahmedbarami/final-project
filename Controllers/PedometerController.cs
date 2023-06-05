using health_and_fitness_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace health_and_fitness_app.Controllers
{
    public class PedometerController : Controller
    {
        private readonly stepsdbcontext context;

        public PedometerController(stepsdbcontext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }


        [HttpPost]
        public IActionResult StepsToCalories(stepsmodelcs x)
        {

            double TotalCaloriesBurned = x.Numbersteps * 0.04;
            x.time = DateTime.Now;
            context.steps.Add(x);
            context.SaveChanges();
            ViewBag.total = TotalCaloriesBurned;
            return View();
        }
    }
}
