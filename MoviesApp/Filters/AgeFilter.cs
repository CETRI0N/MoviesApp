using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace MoviesApp.Filters {
	public class AgeFilter : Attribute, IActionFilter {
		public void OnActionExecuting(ActionExecutingContext context) {

			DateTime filt = DateTime.Parse(context.HttpContext.Request.Form["Birthday"]);
			if((DateTime.Now-filt).Year < 7 || (DateTime.Now-filt).Year > 99) {
				context.Result = new BadRequestResult();
			}
		}
		public void OnActionExecuted(ActionExecutedContext context) {

		}
	}

}
