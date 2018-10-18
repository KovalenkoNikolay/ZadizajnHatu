using System.Collections.Generic;

namespace Contracts
{
    public class ContactInfo
    {
        public List<string> PhoneNumbers { get; set; }
        public List<string> Emails { get; set; }
        public string Site { get; set; }
    }
}
