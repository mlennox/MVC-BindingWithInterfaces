using System.Web.Mvc;
using PartialBindingExample.Models;

namespace PartialBindingExample.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var yourModel = new YourModel
			{
				AlterOnlyInCreate = "only bound in create",
				AlterOnlyInUpdate = "only bound in update",
				PublicValue = "always bound!"
			};

			return View(yourModel);
		}


		//[HttpPost]
		public ActionResult Create()
		{
			var ymodel = new YourModel();
			UpdateModel<IYourModelCreate>(ymodel);

			return View("Index", ymodel);
		}

		//[HttpPost]
		public ActionResult Update()
		{
			var ymodel = new YourModel();
			UpdateModel<IYourModelUpdate>(ymodel);

			return View("Index", ymodel);
		}

	}
}
