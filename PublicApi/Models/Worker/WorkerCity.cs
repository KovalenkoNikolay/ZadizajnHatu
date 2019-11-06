using DataRepository.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicApi.Models.Worker
{
    public class WorkerCity
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
    }
}
