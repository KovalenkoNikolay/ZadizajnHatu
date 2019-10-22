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
                    Name = "Veranda Design Studio",
                    ContactInfo = "{phone:\"03123123123\"}",
                    PortfolioProjects = new List<PortfolioProject>()
                    {
                        new PortfolioProject
                        {
                            Name = "Project X",
                            Description = "Test Project 1",
                            Images = new List<Image>()
                            {
                                new Image
                                {
                                    ImageId = Guid.NewGuid(),
                                    Name = "Спальня",
                                    Description = "Светлая спальня",
                                },
                                new Image
                                {
                                    ImageId = Guid.NewGuid(),
                                    Name = "Кухня",
                                    Description = "Кухня спальня",
                                }
                            }
                        }
                    },

                }
            ); ;
        }
    }
}
