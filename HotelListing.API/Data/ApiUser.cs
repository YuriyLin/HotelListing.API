﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace HotelListing.API.Data
{
    public class ApiUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
