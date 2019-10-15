using System;

namespace PublicApi.Models.DesignStudio
{
    public class Image
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FullPath { get; set; }
    }
}