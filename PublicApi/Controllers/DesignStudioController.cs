using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Add()
        {


            return Ok();
        }
    }
}
