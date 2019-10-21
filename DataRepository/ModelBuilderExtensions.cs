using DataRepository.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(
                new Worker
                {
                    Name = "Veranda Design Studio"
                }
            );
        }
    }
}
