using Microsoft.AspNetCore.Mvc;
namespace PTPMQL2324.Controller;


{
    public class PersonControllers : Controller
    {
        [httpGet]
        //khai báo các action
        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FName)
        {
            viewBang.thongbao ="xinchao" +Name ;
            return View();
        }
    }
}