using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		List<Customer> customers = new List<Customer>
		{
			new Customer {Name = "John Smith", Id = 1},
			new Customer {Name = "Mary Williams", Id = 2}
		};

		// GET: Customers
		public ActionResult Index()
		{
			

			var viewModel = new CustomerViewModel
			{
				Customers = customers
			};

			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
			return View(customers.Find(x => x.Id == id));
		}
	}
}