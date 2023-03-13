using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CoreDotnetClassLibrary
{
    public class Class1
    {
        public string GetImageFromFilePath(string filePath)
        {
            string username = "admin";
            string password = "Admin123"; // Sensitive
            string usernamePassword  = "user=admin&password=Admin123"; // Sensitive
            string url = "scheme://user:Admin123@domain.com"; // Sensitive

            var urlHttp = "http://example.com";                 // Noncompliant
            var urlFtp = "ftp://anonymous@example.com";         // Noncompliant
            var urlTelnet = "telnet://anonymous@example.com";   // Noncompliant

            
            byte[] image = null;
            if (!string.IsNullOrEmpty(filePath))
            {
                image = System.IO.File.ReadAllBytes(filePath);
            }
            if (image == null)
                return null;
            return "image/jpeg";
        }
    }
}
