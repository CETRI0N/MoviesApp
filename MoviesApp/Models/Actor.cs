﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models {
	public class Actor {
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
	}
}
