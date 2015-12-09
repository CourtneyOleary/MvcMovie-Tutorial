using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        public string BoBindex()
        {
            return "This is the BoBindex :) ";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int ID = 6)
        {
            return HtmlEncoder.Default.HtmlEncode(
                "Hello " + name + ", ID: " + ID);
        }
    }
}
