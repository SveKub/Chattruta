using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chattruta.Models;
using Chattruta.Repositories.Interfaces;

namespace Chattruta.Repositories
{
	public class ChattmeddelandeRepository : IChattmeddelandeRepository
	{
		private readonly ChattrutaContext _context;
		public ChattmeddelandeRepository(ChattrutaContext chattrutaContext)
		{
			_context = chattrutaContext;
		}

		public IEnumerable<Chattmeddelande> Get()
		{
			return _context.Chattmeddelande;
		}
	}
}
