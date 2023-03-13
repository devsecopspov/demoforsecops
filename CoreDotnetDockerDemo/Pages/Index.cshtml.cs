using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace CoreDotnetDockerDemo.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            this.Message = "This is my First ASP.Net Core Razor Page";
            string name = Request.QueryString["name"];
            Response.Write("Hello " + name); // Noncompliant
        }
        
        
        [HttpGet]
        public ActionResult Download(string fileName)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine("C", fileName));
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public FileContentResult GetImageFromFilePath(string filePath)
        {
            byte[] image = null;
            if (!string.IsNullOrEmpty(filePath))
            {
                image = System.IO.File.ReadAllBytes(filePath);
            }
            if (image == null)
                return null;
            return File(image, "image/jpeg");
        }
    }
}
