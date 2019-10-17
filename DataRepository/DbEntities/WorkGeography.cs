using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.DbEntities
{
    public class WorkGeography
    {
        public Guid WorkerId { get; set; }

        public Guid? CityId { get; set; }

        public Guid? RegionId { get; set; }

        public Guid? CountryId { get; set; }
    }
}
