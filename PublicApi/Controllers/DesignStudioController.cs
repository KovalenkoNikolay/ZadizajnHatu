using AutoMapper;
using BusinessLogic.Managers;
using DataRepository;
using DataRepository.DbEntities.DesignStudio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PublicApi.Models.DesignStudio;
using System;
using System.Threading.Tasks;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignStudioController : ControllerBase
    {
        readonly Lazy<ImageManager> _imageManager;
        readonly Lazy<AppDbContext> _appDbContext;

        ImageManager ImageManager => _imageManager.Value;
        AppDbContext DbContext => _appDbContext.Value;

        public DesignStudioController(IConfiguration configuration)
        {
            _imageManager = new Lazy<ImageManager>();
            _appDbContext = new Lazy<AppDbContext>(() => new AppDbContext(configuration));
        }

        [HttpGet]
        public async Task<IActionResult> GetDesignStudios()
        {
            

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateDesignStudio designStudio)
        {
            // TODO: Save image
            //var coverName = ImageManager.SaveImageToStorage(designStudio.Cover);
            var coverName = Guid.NewGuid().ToString();

            var designStudioToAdd = Mapper.Map<DesignStudio>(designStudio);

            // TODO: Get CurrentUserId
            designStudioToAdd.Cover = coverName;
            designStudioToAdd.AppUserId = null;
            
            DbContext.Add(designStudioToAdd);
            DbContext.SaveChanges();
            
            return Ok();
        }
    }
}