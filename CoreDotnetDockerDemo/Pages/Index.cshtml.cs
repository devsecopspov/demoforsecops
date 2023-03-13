using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Web.UI;

namespace CoreDotnetDockerDemo.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            this.Message = "This is my First ASP.Net Core Razor Page";
        }
        public object MyDeserialize(byte[] bytes)
        {
            LosFormatter formatter = new LosFormatter();
            return formatter.Deserialize(new MemoryStream(bytes));
        }
    }
}
