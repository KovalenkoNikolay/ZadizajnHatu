using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicApi.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
