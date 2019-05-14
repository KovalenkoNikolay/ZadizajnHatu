using Microsoft.AspNetCore.Http;

namespace PublicApi.Models.DesignStudio
{
    public class CreateDesignStudio
    {
        public string Name { get; set; }

        public IFormFile Cover { get; set; }
    }
}
