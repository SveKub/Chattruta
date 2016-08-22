using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Chattruta.Models
{
    public class ChattrutaContext : DbContext
    {
        public ChattrutaContext (DbContextOptions<ChattrutaContext> options)
            : base(options)
        {
        }

        public DbSet<Chattmeddelande> Chattmeddelande { get; set; }
    }
}
