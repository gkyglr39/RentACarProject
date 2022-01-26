using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Business
{
    public class FileHelper
    {
        public static string  Upload(IFormFile file)
        {
            var fileFullPath = "";
            string currentDir = Environment.CurrentDirectory + "\\wwwroot\\";
            if (file.Length > 0 && CheckFileType(file))
            {
                string fileDir = Path.Combine(currentDir,"images");
                if (!Directory.Exists(fileDir))
                {
                    Directory.CreateDirectory(fileDir);
                }
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName);
                fileFullPath = Path.Combine(fileDir, fileName + extension);

                using (FileStream fs =File.Create(fileFullPath))
                {
                    file.CopyTo(fs);
                    fs.Dispose();
                    return fileFullPath;
                }
            }
            return fileFullPath;
        }

        private static bool CheckFileType(IFormFile file)
        {

            if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png")
                return true;
            return false;
        }




    }
}
