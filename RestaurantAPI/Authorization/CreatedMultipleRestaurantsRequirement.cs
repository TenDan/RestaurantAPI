﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace RestaurantAPI.Authorization
{
    public class CreatedMultipleRestaurantsRequirement : IAuthorizationRequirement
    {
        public int MinimumRestaurants { get; }

        public CreatedMultipleRestaurantsRequirement(int minimumRestaurants)
        {
            MinimumRestaurants = minimumRestaurants;
        }
    }
}
