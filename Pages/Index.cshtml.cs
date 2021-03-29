using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using fizzbuzzwebowo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace fizzbuzzwebowo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        [BindProperty]
        public Adress Address { get; set; }
        public string Kolor;
        public string Ocena;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
                Name = "User";
        }
        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                Address.Data = DateTime.Now;
                if (Address.Number % 15 == 0)
                {
                    Ocena = "FizzBuzz";
                    Kolor = "pink";

                }
                else if (Address.Number % 3 == 0)
                {
                    Ocena = "Fizz";

                    Kolor = "green";
                }
                else if (Address.Number % 5 == 0)
                {
                    Ocena = "Buzz";

                    Kolor = "blue";

                }
                else
                {
                    Ocena = "Liczba " + Address.Number + " nie spełnia warunków zadania Fizz/Buzz! ";

                    Kolor = "red";
                }
                Address.Ocena = Ocena;
                HttpContext.Session.SetString("SessionAddress", JsonConvert.SerializeObject(Address));
                //return RedirectToPage("./Index");
            }
            return Page();
        }

    }
}
