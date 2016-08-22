using Chattruta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chattruta.ViewModels
{
    public class VMChattmeddelande
    {
		public IEnumerable<Chattmeddelande> Chattmeddelanden { get; set; }
		public Chattmeddelande Chattmeddelande { get; set; }

		public VMChattmeddelande()
		{
			Chattmeddelande = new Chattmeddelande();
		}
	}
}
