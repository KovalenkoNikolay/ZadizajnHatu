﻿using System.ComponentModel.DataAnnotations;

namespace DataRepository.DbEntities
{
    public class WorkerTypeId
    {
        [Key]
        protected int Id { get; set; }

        public string Name { get; set; }
    }
}
