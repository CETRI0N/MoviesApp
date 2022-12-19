using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.ViewModels {
	public class InputActor {
		[Required]
		public string Name {get; set;}

		[Required]
		public string LastName {get; set;}

		[Required]
		public DateTime Birthday {get; set;}
	}
}
