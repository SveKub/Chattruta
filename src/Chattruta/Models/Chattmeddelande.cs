using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Chattruta.Models
{
    public class Chattmeddelande
    {
		[Key]
		public int Id { get; set; }
		public DateTime Datum { get; set; }
		[MaxLength(80)]
		public string Namn { get; set; }
		[MaxLength(240)]
		public string Meddelande { get; set; }
	}
}
