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
            var wirkerTypeID1 = 1;

            var workTypes = new List<WorkerType>()
            {
                new WorkerType { WorkerTypeId = wirkerTypeID1, Name = "Дизайнер" },
                new WorkerType { WorkerTypeId = 2, Name = "Чертежник" },
                new WorkerType { WorkerTypeId = 2, Name = "Архитектор" }
            };

            
            modelBuilder.Entity<WorkerType>().HasData(workTypes);

            var workerGuid1 = Guid.NewGuid();
            var workers = new List<Worker>
            {
                new Worker
                {
                    WorkerId = workerGuid1,
                    ContactInfo = "Ломоносова 46/1",
                    Name = "Veranda Design Studio",
                    WorkerTypeId = wirkerTypeID1,
                },
            };
            modelBuilder.Entity<Worker>().HasData(workers);

            //var worker1 = Guid.NewGuid();

            //var portfolioProjectId = Guid.NewGuid();

            //modelBuilder.Entity<Worker>().HasData(
            //    new Worker
            //    {
            //        WorkerId = worker1,
            //        ContactInfo = "Lomonosova",
            //        Name = "Veranda"
            //    });

            //modelBuilder.Entity<PortfolioProject>().HasData(
            //    new PortfolioProject
            //    {
            //        PortfolioProjectId = portfolioProjectId,
            //        Name = "Project 1",
            //        WorkerId = Guid.NewGuid()
            //    });






            //var image1 = new Image
            //{
            //    ImageId = Guid.NewGuid(),
            //    Name = "Спальня",
            //    Description = "Светлая спальня",
            //};

            //var portfolio = new PortfolioProject
            //{
            //    Name = "Project X",
            //    Description = "Test Project 1",
            //    Images = new List<Image>()
            //                {
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Спальня",
            //                        Description = "Светлая спальня",
            //                    },
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Кухня",
            //                        Description = "Кухня спальня",
            //                    }
            //                }
            //};

            //modelBuilder.Entity<Image>().HasData(image1);
            //modelBuilder.Entity<PortfolioProject>().HasData(image1);


            //modelBuilder.Entity<Worker>().HasData(
            //    new Worker
            //    {
            //        Name = "Veranda Design Studio",
            //        ContactInfo = "{phone:\"03123123123\"}",
            //        PortfolioProjects = new List<PortfolioProject>()
            //        {
            //            new PortfolioProject
            //            {
            //                Name = "Project X",
            //                Description = "Test Project 1",
            //                Images = new List<Image>()
            //                {
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Спальня",
            //                        Description = "Светлая спальня",
            //                    },
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Кухня",
            //                        Description = "Кухня спальня",
            //                    }
            //                }
            //            },
            //            new PortfolioProject
            //            {
            //                Name = "Project Yura",
            //                Description = "Test Project 2",
            //                Images = new List<Image>()
            //                {
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Спальня - Юра",
            //                        Description = "Светлая спальня Юра",
            //                    },
            //                    new Image
            //                    {
            //                        ImageId = Guid.NewGuid(),
            //                        Name = "Кухня Юра",
            //                        Description = "Кухня спальня Юра",
            //                    }
            //                }
            //            }
            //        },
                    
            //    }
            //);
        }
    }
}
