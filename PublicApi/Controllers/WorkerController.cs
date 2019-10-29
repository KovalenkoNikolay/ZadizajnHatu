using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataRepository;
using DataRepository.DbEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        readonly Lazy<AppDbContext> _appDbContext;

        AppDbContext DbContext => _appDbContext.Value;

        public WorkerController(AppDbContext dbContext)
        {


            //_appDbContext = new Lazy<AppDbContext>(() => new AppDbContext(configuration));
            _appDbContext = new Lazy<AppDbContext>(() => dbContext);
        }

        [HttpGet]
        public async Task<List<Worker>> GetWorkers()
        {
            var workers = new List<Worker>();

            workers = DbContext.Workers.ToList();

            return workers;
        }
    }
}