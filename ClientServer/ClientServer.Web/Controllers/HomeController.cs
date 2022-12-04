using ClientServer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientServer.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Original
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

        #region Example1

        [HttpPost]
        public JsonResult ToDouble(int amountValue)
        {
            var amountDouble = amountValue * 2;

            var result = new Result()
            {
                AmountDouble = amountDouble,
                AmountValue = amountValue
            };

            return Json(result);
        }

        [HttpPost]
        public JsonResult ToDoubleAjax([FromBody] int amountValue)
        {
            var amountDouble = amountValue * 2;

            var result = new Result()
            {
                AmountDouble = amountDouble,
                AmountValue = amountValue
            };

            return Json(result);
        }

        #endregion

        #region Example2

        [HttpPost]
        public JsonResult CreatePersonJ(Person people)
        {
            //Utilamos una clase base para todas nuestras comunicaciones para establecer un estandard
            var result = new BaseResult();

            try
            {
                if (people.Age < 18)
                {
                    throw new ApplicationException("The person cannot be less than 18 years old");
                }

                //código para crear persona...
                result.Mensaje = "person created successfully";
                result.Ok = true;
            }
            catch (Exception ex)
            {
                result.Ok = false;
                result.Mensaje = ex.Message;
            }
            return Json(result);
        }

        [HttpPost]
        public JsonResult CreatePersonAjax([FromBody] Person people)
        {
            //FromBody: learn.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api
            //Utilamos una clase base para todas nuestras comunicaciones para establecer un estandard
            var result = new BaseResult();

            try
            {
                if (people.Age < 18)
                {
                    throw new ApplicationException("The person cannot be less than 18 years old");
                }

                //código para crear persona...
                result.Mensaje = "person created successfully";
                result.Ok = true;
            }
            catch (Exception ex)
            {
                result.Ok = false;
                result.Mensaje = ex.Message;
            }
            return Json(result);
        }

        #endregion

        #region Example3

        [HttpGet]
        public PartialViewResult AddPeopleListJ(string data, int valnum)
        {
            var valorPasado = data;
            var person = new List<Person>()
            {
                new Person(){Name = "a", Age=2},
                new Person(){Name = "a1", Age=19},
                new Person(){Name = "a2", Age=53},
            };

            return PartialView("_PeopleList", person);
        }

        #endregion
    }
}