using System;
using DataRepository;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Managers
{
    public class ImageManager
    {
        public string AddImageToPortfolio(IFormFile file)
        {
            string imageName = Guid.NewGuid().ToString();

            // TODO: Save image to S3

            // Save name to DB
            
            return imageName;
        }

        public string SaveImageToStorage(IFormFile file)
        {
            string imageName = Guid.NewGuid().ToString();

            return imageName;
        }

        public static string GetImgFullPath(string imgName)
        {
            // TODO: Return link to S3
            return "assets\\" + $"{imgName}.jpg";
        }
    }
}
