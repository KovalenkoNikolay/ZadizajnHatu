using Microsoft.AspNetCore.Http;

namespace Contracts.DesignStudio
{
    public class CreateDesignStudio
    {
        public string Name { get; set; }

        public IFormFile Cover { get; set; }
    }
}
