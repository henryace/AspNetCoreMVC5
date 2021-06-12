using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AspNetCoreMVC5.Controllers
{
    public class HelloworldController : Controller
    {
        // index & welcome
        // get action


        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // https://localhost:44336/Helloworld/WelcomeMan?name=test&numTimes=99
        // 用 HtmlEncoder.Default.Encode 來保護應用程式免于惡意輸入，例如透過 JavaScript。
        public string WelcomeMan(string name, int numTimes = 1)
        {
            // return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public string WelcomeID(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Welcome2(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
