using ClientServer.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientServer.Web.Controllers
{
    public class AjaxEmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Employee> GetEmpList()
        {
            var empList = new List<Employee>()
            {
                new Employee { ID=1, Name="Manas"},
                new Employee { ID=2, Name="Tester"}
            };

            return empList;
        }
        //List<Employee> empList
        [HttpPost]
        public bool SaveEmpList([FromBody] List<Employee> empList)
        {
            var parEntrada = false;
            try
            {
                if (empList.Count() > 0)
                    parEntrada = true;
                // Implement your logic to save EmpList in Database  
                var a = empList;
            }
            catch (Exception ex)
            {
                // Log Error  
                return false;
            }

            return parEntrada;
        }

        [HttpPost]
        public bool SaveEmpList2([FromBody] Employee empList)
        {
            var parEntrada = false;
            try
            {
                
                    parEntrada = true;
                // Implement your logic to save EmpList in Database  
                var a = empList;
            }
            catch (Exception ex)
            {
                // Log Error  
                return false;
            }

            return parEntrada;
        }

        //[HttpPost]
        public bool SaveEmpList1([FromBody] string? empList)
        {
            var parEntrada = true;
            if (empList == null)
                parEntrada = false;
            try
            {
                // Implement your logic to save EmpList in Database  
                var a = "";
            }
            catch (Exception ex)
            {
                // Log Error  
                return false;
            }

            return parEntrada;
        }
    }
}
