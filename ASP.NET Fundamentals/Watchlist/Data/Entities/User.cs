﻿using Microsoft.AspNetCore.Identity;
using System.Security.Policy;

namespace Watchlist.Data.Entities
{
    public class User : IdentityUser
    {
        public List<UserMovie> UsersMovies { get; set; } = new List<UserMovie>();
    }


}
