using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chattruta.Repositories.Interfaces;
using Chattruta.Models;
using Chattruta.ViewModels;

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
			var vmChattmeddelande = new VMChattmeddelande();
			vmChattmeddelande.Chattmeddelanden = _context.Get();
            return View(vmChattmeddelande);
        }

		[HttpPost]
		public IActionResult Index(Chattmeddelande chattmeddelande)
		{
			chattmeddelande.Datum = DateTime.Now;
			if (ModelState.IsValid)
			{
				_context.Create(chattmeddelande);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				var vmChattmeddelande = new VMChattmeddelande();
				vmChattmeddelande.Chattmeddelanden = _context.Get();
				vmChattmeddelande.Chattmeddelande = chattmeddelande;
				return View(vmChattmeddelande);
			}
			
		}

		public IActionResult Error()
        {
            return View();
        }
    }
}
