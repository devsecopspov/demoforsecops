using System;
using System.IO;

namespace CoreDotnetClassLibrary
{
    public class Class1
    {
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
