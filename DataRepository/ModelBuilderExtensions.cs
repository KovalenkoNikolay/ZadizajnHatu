using DataRepository.DbEntities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // WorkerType
            var workTypes = new List<WorkerType>()
            {
                new WorkerType { WorkerTypeId = 1, Name = "Дизайнер" },
                new WorkerType { WorkerTypeId = 2, Name = "Чертежник" },
                new WorkerType { WorkerTypeId = 3, Name = "Архитектор" }
            };
            modelBuilder.Entity<WorkerType>().HasData(workTypes);

            var countries = new List<Country>() { new Country { CountryId = 1, Name = "Украина" } };
            modelBuilder.Entity<Country>().HasData(countries);

            var regions = new List<Region>() { 
                new Region { RegionId = 1, Name = "Киевская", CountryId = 1 },
                new Region { RegionId = 2, Name = "Винницкая", CountryId = 1 },
                new Region { RegionId = 3, Name = "Волынская", CountryId = 1 },
                new Region { RegionId = 4, Name = "Днепропетровская", CountryId = 1 },
                new Region { RegionId = 5, Name = "Донецкая", CountryId = 1 },
                new Region { RegionId = 6, Name = "Житомирская", CountryId = 1 },
                new Region { RegionId = 7, Name = "Закарпатская", CountryId = 1 },
                new Region { RegionId = 8, Name = "Ивано-Франковская", CountryId = 1 },
                new Region { RegionId = 9, Name = "Кировоградская", CountryId = 1 },
                new Region { RegionId = 10, Name = "Луганская", CountryId = 1 },
                new Region { RegionId = 11, Name = "Львовская", CountryId = 1 },
                new Region { RegionId = 12, Name = "Николаевская", CountryId = 1 },
                new Region { RegionId = 13, Name = "Одесская", CountryId = 1 },
                new Region { RegionId = 14, Name = "Полтавская", CountryId = 1 },
                new Region { RegionId = 15, Name = "Ровненская", CountryId = 1 },
                new Region { RegionId = 16, Name = "Сумская", CountryId = 1 },
                new Region { RegionId = 17, Name = "Тернопольская", CountryId = 1 },
                new Region { RegionId = 18, Name = "Харьковская", CountryId = 1 },
                new Region { RegionId = 19, Name = "Херсонская", CountryId = 1 },
                new Region { RegionId = 20, Name = "Хмельницкая", CountryId = 1 },
                new Region { RegionId = 21, Name = "Черкасская", CountryId = 1 },
                new Region { RegionId = 22, Name = "Черниговская", CountryId = 1 },
                new Region { RegionId = 23, Name = "Черновицкая", CountryId = 1 },
            };
            modelBuilder.Entity<Region>().HasData(regions);

            var cities = new List<City> { 
                new City { CityId = 1, Name = "Киев", RegionId = 1 },
                new City { CityId = 2, Name = "Белая Церковь", RegionId = 1 },
                new City { CityId = 3, Name = "Бровары", RegionId = 1 },
                new City { CityId = 4, Name = "Борисполь", RegionId = 1 },
                new City { CityId = 5, Name = "Фастов", RegionId = 1 },
                new City { CityId = 6, Name = "Ирпень", RegionId = 1 },
                new City { CityId = 7, Name = "Вишнёвое", RegionId = 1 },
                new City { CityId = 8, Name = "Васильков", RegionId = 1 },
                new City { CityId = 9, Name = "Боярка", RegionId = 1 },
                new City { CityId = 10, Name = "Обухов", RegionId = 1 },
                new City { CityId = 11, Name = "Буча", RegionId = 1 },
                new City { CityId = 12, Name = "Переяслав", RegionId = 1 },
                new City { CityId = 13, Name = "Вышгород", RegionId = 1 },
                new City { CityId = 14, Name = "Славутич", RegionId = 1 },
                new City { CityId = 15, Name = "Яготин", RegionId = 1 },

                new City { CityId = 16, Name = "Винница", RegionId = 2 },
                new City { CityId = 17, Name = "Жмеринка", RegionId = 2 },
                new City { CityId = 18, Name = "Могилёв-Подольский", RegionId = 2 },
                new City { CityId = 19, Name = "Хмельник", RegionId = 2 },
                new City { CityId = 20, Name = "Гайсин", RegionId = 2 },
                new City { CityId = 21, Name = "Козятин", RegionId = 2 },
                new City { CityId = 22, Name = "Ладижин", RegionId = 2 },
                new City { CityId = 23, Name = "Калиновка", RegionId = 2 },
            };

            modelBuilder.Entity<City>().HasData(cities);

            // ============TEST DATA============
            var workerId1 = Guid.NewGuid();
            var workers = new List<Worker>
            {
                new Worker
                {
                    WorkerId = Guid.NewGuid(),
                    ContactInfo = JsonConvert.SerializeObject(new
                    {
                        address = "Ломоносова 50",
                        email = "verandadesignstuio@gmail.com",
                        phones = new string[] { "+1111111111", "222222222222" },
                        site = "verandadesignstuion.com",
                        socialMedia = new { 
                            instagram = "instagramVeranda",
                            facebook = "facebookVeranda",
                            pinterest = "pinterestVeranda"
                        }
                    }),
                    Name = "Veranda Design Studio",
                    WorkerTypeId = workTypes[0].WorkerTypeId,
                },
            };
            modelBuilder.Entity<Worker>().HasData(workers);

            var workerPrices = new List<WorkerPrice> 
            {
                new WorkerPrice
                {
                    Amount = 10,
                    WorkerPriceId = Guid.NewGuid(),
                    WorkerId = workers[0].WorkerId
                }
            };
            modelBuilder.Entity<WorkerPrice>().HasData(workerPrices);

            var workerCities = new List<WorkerCity>() {
                new WorkerCity { CityId = 1, WorkerId = workerId1, WorkerCityId = Guid.NewGuid() },
            };
            modelBuilder.Entity<WorkerCity>().HasData(workerCities);

            var workerGeo = new List<WorkGeography>() {
                new WorkGeography {  },
            };
            modelBuilder.Entity<WorkerCity>().HasData(workerCities);

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
