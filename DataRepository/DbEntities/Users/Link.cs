namespace DataRepository.DbEntities.Users
{
    public class Link
    {
        public int LinkTypeId { get; set; }
        public string LinkAddresse { get; set; }

        public LinkType LinkType { get; set; }
    }
}
