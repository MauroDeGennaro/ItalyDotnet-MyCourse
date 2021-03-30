using Microsoft.AspNetCore.Mvc;
namespace MyCourse.controllers
{
    public class CoursesController: Controller
    {
        public IActionResult Index(){
            return Content("sono index");
        }
        public IActionResult detail(string id){
            return Content($"sono detail, ho ricevuto l'id,{id}");
        }
    }
}