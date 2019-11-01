using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataRepository;
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
            _appDbContext = new Lazy<AppDbContext>(() => dbContext);
        }

        [HttpGet("")]
        public async Task<List<Models.Worker.Worker>> GetWorkers()
        {
            var workers = DbContext.Workers.ToList();

            return Mapper.Map<List<Models.Worker.Worker>>(workers);
        }

        [HttpGet("{id}")]
        public async Task<Models.Worker.WorkerDetails> GetWorkerDetailsById(Guid id)
        {
            var worker = DbContext.Workers.FirstOrDefault(w => w.WorkerId == id);

            var woker = Mapper.Map<Models.Worker.WorkerDetails>(worker);

            return Mapper.Map<Models.Worker.WorkerDetails>(worker);
        }

        [HttpGet]
        [Route("{id}/projects")]
        public async Task<Models.Worker.PortfolioProject> GetWorkerPortfolioProjects(Guid id)
        {
            var workerProjects = DbContext.PortfolioProjects.Where(pp => pp.WorkerId == id);

            return Mapper.Map<Models.Worker.PortfolioProject>(workerProjects);
        }
    }
}