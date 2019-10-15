using Microsoft.AspNetCore.Http;
using System;

namespace PublicApi.Models.DesignStudio
{
    public class CreateDesignStudio
    {
        public string Name { get; set; }

        public string Comments { get; set; }

        public Guid UserId { get; set; }

        public IFormFile Cover { get; set; }
    }
}
