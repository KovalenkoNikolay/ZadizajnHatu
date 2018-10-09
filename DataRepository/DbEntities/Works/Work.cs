using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.DbEntities.Works
{
    public class Work
    {
        public int WorkTypeId { get; set; }
        public Cost MinCost { get; set; }
        public Cost MaxCost { get; set; }

        public WorkType WorkType { get; set; }
    }
}