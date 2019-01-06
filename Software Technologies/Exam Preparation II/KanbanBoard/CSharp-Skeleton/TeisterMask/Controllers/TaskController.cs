  namespace TeisterMask.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class TaskController : Controller
    {
        private readonly TeisterMaskDbContext dbContext;

        public TaskController(TeisterMaskDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //TODO

            var tasks = dbContext.Tasks.ToList();

            var open = dbContext.Tasks.Where(t => t.Status == "Open").ToList();
            var inProgress = dbContext.Tasks.Where(t => t.Status == "In Progress").ToList();
            var finished = dbContext.Tasks.Where(t => t.Status == "Finished").ToList();

            return View(tasks);
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Task task)
        {
            //TODO

            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {

            //TODO

            Task task = dbContext.Tasks.Where(p => p.Id == id).FirstOrDefault();
            return View(task);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirm(Task taskModel)
        {
            //TODO

            dbContext.Tasks.Update(taskModel);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
