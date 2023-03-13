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
