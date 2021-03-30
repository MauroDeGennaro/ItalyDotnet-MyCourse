using Microsoft.AspNetCore.Mvc;

namespace ItalyDotnet_MyCourse.controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            return Content("sono il contenuto dell'home");
        }
    }
}