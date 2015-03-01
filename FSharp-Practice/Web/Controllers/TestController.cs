using Microsoft.AspNet.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class TestController : Controller
    {

		private ApplicationDbContext context;

		public TestController(ApplicationDbContext context)
		{
			this.context = context;
		}

		// GET: /<controller>/
        public async Task<IActionResult> Index()
        {
			var rand = new Random();

			Enumerable.Range(0, 10).Select(i => new TestModel { Id = rand.Next(1000) }).ToList().ForEach((t) =>
			{
				context.TestModels.Add(t);
			});

			await context.SaveChangesAsync();

			return View(context.TestModels.ToList());
        }
    }
}
