using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chattruta.Repositories.Interfaces;

namespace Chattruta.Controllers
{
    public class HomeController : Controller
    {
		private readonly IChattmeddelandeRepository _context;
		public HomeController(IChattmeddelandeRepository context)
		{
			_context = context;
		}
        public IActionResult Index()
        {
            return View(_context.Get());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
