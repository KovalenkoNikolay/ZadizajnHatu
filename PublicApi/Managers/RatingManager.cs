using DataRepository.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace PublicApi.Managers
{
    public class RatingManager
    {
        public static decimal CalculateWorkerRating(IEnumerable<WorkerReview> reviews)
        {
            if (reviews.Count() == 0)
            {
                return 0;
            }

            decimal totalRating = reviews.Sum(wr => wr.Rating) / reviews.Count();

            if (totalRating < 0.75m)
            {
                return 0.5m;
            }

            return totalRating;
        }
    }
}
