using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value=''>--Please select a language--</option>" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='arabic'>Arabic</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='german'>German</option>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}

        // GET: /<controller>/welcome?name=value?language=value or GET: /<controller>/welcome/name/language
        // POST: /<controller>/index
        [HttpGet("index")]
        [HttpPost]
        public IActionResult CreateMessage(string name = "World", string language = "english")
        {
            string greeting = "";
            if (language == "english")
            {
                greeting = "Hello, ";
            }
            if (language == "french")
            {
                greeting = "Bonjour, ";
            }
            if (language == "arabic")
            {
                greeting = "Ahelen Was Ahelen, ";
            }
            if (language == "spanish")
            {
                greeting = "Hola, ";
            }
            if (language == "german")
            {
                greeting = "Guttentag, ";
            }
            return Content($"<h1>{greeting}{name}!</h1>", "text/html");
        }
    }
}
