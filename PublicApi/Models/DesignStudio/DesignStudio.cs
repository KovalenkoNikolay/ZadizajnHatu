﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicApi.Models.DesignStudio
{
    public class DesignStudio
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CoverPath { get; set; }

        public List<Price> Prices { get; set; }

        public List<DesignStudioPortfolio> Portfolios{ get; set; }

        public string AppUserId { get; set; }
    }
}
