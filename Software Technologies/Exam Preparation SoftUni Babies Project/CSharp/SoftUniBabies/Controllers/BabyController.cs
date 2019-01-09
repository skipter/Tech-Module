namespace SoftUniBabies.Controllers
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class BabyController : Controller
    {
        private readonly BabyDbContext dbContext;

        public BabyController(BabyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //TODO

            var babies = dbContext.Babies.ToList();
            return View(babies);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            //TODO
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Baby baby)
        {
            //TODO

            dbContext.Add(baby);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            //TODO

            Baby baby = dbContext.Babies.Where(b => b.Id == id).FirstOrDefault();
            return View(baby);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Baby baby)
        {
            //TODO

            dbContext.Babies.Update(baby);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
            
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            //TODO

            Baby baby = dbContext
                            .Babies
                            .Where(b => b.Id == id)
                            .FirstOrDefault();

            return View(baby);
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Baby baby)
        {
            //TODO

            dbContext.Babies.Remove(baby);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
