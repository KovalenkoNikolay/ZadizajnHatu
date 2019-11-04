namespace PublicApi.Models.Worker
{
    public class ContactInfo
    {
        public string Address { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        public string[] Phones { get; set; }

        public SocialMedia SocialMedia { get; set; }
    }

    public class SocialMedia
    {
        public string Instagram { get; set; }

        public string Facebook { get; set; }

        public string Behance { get; set; }
    }
}
