﻿using BusinessLogic.Managers;
using Microsoft.AspNetCore.Mvc;
using PublicApi.Models.DesignStudio;
using System.Threading.Tasks;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignStudioController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDesignStudios()
        {
            

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateDesignStudio designStudio)
        {
            ImageManager.SaveImage(designStudio.Cover);

            return Ok();
        }
    }
}
