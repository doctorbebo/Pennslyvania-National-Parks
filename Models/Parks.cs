using System;
using Microsoft.AspNetCore.Http;

namespace Pennslyvania_National_Parks.Models
{
    public class Parks
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

}
