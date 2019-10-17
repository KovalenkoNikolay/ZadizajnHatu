using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.DbEntities
{
    public class WorkGeography
    {
        public City City { get; set; }

        public Region Region { get; set; }

        public Country Country { get; set; }

        public Worker Worker { get; set; }
    }
}
