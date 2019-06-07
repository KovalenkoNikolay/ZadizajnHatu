using System;
using System.Collections.Generic;

namespace PublicApi.Models.DesignStudio
{
    public class DesignStudioPreview
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CoverPath { get; set; }

        public List<Price> Prices { get; set; }

        public string AppUserId { get; set; }
    }
}
