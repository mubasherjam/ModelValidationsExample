using Microsoft.AspNetCore.Mvc;
using ModelValidationsExample.Models;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.Controllers
{
    public class HomeController : Controller
    {

        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                string errors = string.Join("\n",
                    ModelState.Values.SelectMany(v => v.Errors)
                    .Select(err => err.ErrorMessage));

                return BadRequest (errors);
            }
            return Content($"{person}");
        }
    }
}
