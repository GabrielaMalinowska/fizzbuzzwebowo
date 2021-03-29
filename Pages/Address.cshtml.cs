using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using fizzbuzzwebowo.Models;
using Newtonsoft.Json;

namespace fizzbuzzwebowo.Pages.Shared
{
    public class AdressModel : PageModel
    {

        private string sessionAddress;

        public Adress Address { get; private set; }

        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
                Address = JsonConvert.DeserializeObject<Adress>(SessionAddress);
        }

    }

}
