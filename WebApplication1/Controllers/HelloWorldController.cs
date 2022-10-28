using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs= new List<DogViewModel>();
        public IActionResult Index()
        {

            return View(dogs);
        }
        public string Hello()
        {
            return "Who's htere?";
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();

            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
