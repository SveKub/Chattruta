using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chattruta.Models;
namespace Chattruta.Repositories.Interfaces
{
    public interface IChattmeddelandeRepository
    {
		IEnumerable<Chattmeddelande> Get();
    }
}
