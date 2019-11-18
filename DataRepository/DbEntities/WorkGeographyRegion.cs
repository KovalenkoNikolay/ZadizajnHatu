using System;

namespace DataRepository.DbEntities
{
    public class WorkGeographyRegion
    {
        public Guid WorkGeographyId { get; set; }

        public WorkGeography WorkGeography { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }
    }
}
