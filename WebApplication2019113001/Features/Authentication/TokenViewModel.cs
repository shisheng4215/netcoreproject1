﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Features.Authentication
{
    public class TokenViewModel
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("access_token_expiration")]
        public DateTime AccessTokenExpiration { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public IEnumerable<string> Roles { get; set; }


    }
}
