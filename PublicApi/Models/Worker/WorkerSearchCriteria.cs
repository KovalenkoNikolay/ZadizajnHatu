namespace PublicApi.Models.Worker
{
    public class WorkerSearchCriteria
    {
        public int? AmountFrom { get; set; }

        public int? AmountTo { get; set; }

        public string City { get; set; }

        public bool RemoteWork { get; set; }

        public int[] Services { get; set; }
    }
}