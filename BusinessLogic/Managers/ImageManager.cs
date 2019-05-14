using System;
using DataRepository;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Managers
{
    public class ImageManager
    {
        public static string SaveImage(IFormFile file)
        {
            string imageName = Guid.NewGuid().ToString();

            // TODO: Save image to S3

            // Save name to DB
            using (AppDbContext _dbContext = new AppDbContext()) {
                //_dbContext.Add<>
            }

            return imageName;
        }
    }
}
