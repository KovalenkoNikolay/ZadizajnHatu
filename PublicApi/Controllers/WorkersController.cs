using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataRepository;
using DataRepository.DbEntities;
using Microsoft.AspNetCore.Mvc;
using PublicApi.Managers;

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        readonly Lazy<AppDbContext> _appDbContext;

        AppDbContext DbContext => _appDbContext.Value;

        public WorkersController(AppDbContext dbContext)
        {
            _appDbContext = new Lazy<AppDbContext>(() => dbContext);
        }

        [HttpGet("")]
        public async Task<List<Models.Worker.WorkerPreview>> GetWorkers()
        {
            var workers = DbContext.Workers.ToList();

            var workerPreviews = Mapper.Map<List<Models.Worker.WorkerPreview>>(workers);

            
            foreach (var workerPreview in workerPreviews)
            {
                var workerReviews = DbContext.WorkerReviews.Where(wr => wr.WorkerId == workerPreview.WorkerId);

                workerPreview.Rating = RatingManager.CalculateWorkerRating(workerReviews);
                workerPreview.RatingCount = workerReviews.Count();
                workerPreview.CommentCount = workerReviews.Where(wr => wr.Comment != null).Count();
            }

            return workerPreviews;
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

        [HttpPost]
        [Route("{id}/reviews")]
        public async void AddReviewForWorker(Guid wokerId, string comment, int rating)
        {
            var review = new WorkerReview() {
                Comment = comment,
                WorkerId = wokerId,
                Rating = rating
            };

            DbContext.WorkerReviews.Add(review);
            DbContext.SaveChanges();
        }

        [HttpGet]
        [Route("{id}/reviews")]
        public async Task<List<Models.Worker.WorkerReview>> GetWorkerReviews(Guid id)
        {
            var workerReviews = DbContext.WorkerReviews.Where(wr => wr.WorkerId == id);

            return Mapper.Map<List<Models.Worker.WorkerReview>>(workerReviews);
        }
    }
}