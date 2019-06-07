using AutoMapper;
using BusinessLogic.Managers;
using DataRepository;
using DataRepository.DbEntities.DesignStudio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PublicApi.Models.DesignStudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignStudio = PublicApi.Models.DesignStudio.DesignStudio;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignStudioController : Controller
    {
        readonly Lazy<ImageManager> _imageManager;
        readonly Lazy<AppDbContext> _appDbContext;

        ImageManager ImageManager => _imageManager.Value;
        AppDbContext DbContext => _appDbContext.Value;

        public DesignStudioController(AppDbContext dbContext)
        {
            _imageManager = new Lazy<ImageManager>();
            _appDbContext = new Lazy<AppDbContext>(() => dbContext);
        }

        [HttpGet]
        public async Task<List<DesignStudioPreview>> GetDesignStudios()
        {
            var designStudios = DbContext.DesignStudios.Include(ds => ds.Prices).Take(5).ToList();

            var targetDesignStudios = Mapper.Map<List<DesignStudioPreview>>(designStudios);
            
            return targetDesignStudios;
        }

        [HttpGet]
        [Route("{studioId}")]
        public async Task<DesignStudio> GetDesignStudioById(Guid studioId)
        {
            var designStudio = DbContext.DesignStudios
                .Include(ds => ds.Prices)
                .Include(ds => ds.Portfolios)
                    .ThenInclude(p => p.Images)
                .FirstOrDefault(ds=>ds.Id == studioId);

            var targetDesignStudio = Mapper.Map<DesignStudio>(designStudio);

            return targetDesignStudio;
        }

        //[HttpGet]
        //public Models.DesignStudio.DesignStudio GetDesignStudios()
        //{
        //    var ds = DbContext.DesignStudios.Take(5).ToList();

        //    //return Mapper.Map<List<Models.DesignStudio.DesignStudio>>(ds)[0];

        //    //return Ok(Mapper.Map<List<Models.DesignStudio.DesignStudio>>(ds)[0]);
        //    return new Models.DesignStudio.DesignStudio() {
        //        Name = "Hwllo!",
        //        Id = Guid.NewGuid(),
        //        AppUserId = "HelloAppUser",
        //        CoverPath = "HelloCOverPath"
        //    };
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(CreateDesignStudio designStudio)
        //{
        //    // TODO: Save image
        //    var coverName = ImageManager.SaveImageToStorage(designStudio.Cover);

        //    var designStudioToAdd = Mapper.Map<DataRepository.DbEntities.DesignStudio.DesignStudio>(designStudio);

        //    // TODO: Get CurrentUserId
        //    designStudioToAdd.CoverName = coverName;
        //    designStudioToAdd.AppUserId = null;

        //    DbContext.Add(designStudioToAdd);
        //    DbContext.SaveChanges();

        //    return Ok();
        //}
    }
}