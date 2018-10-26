﻿using System;
using Newtonsoft.Json;

namespace AppPortal.ApiHost.ViewModels
{
    public class UserLogined
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public DateTime? ExpiresIn { get; set; }
        [JsonProperty("isLoggedIn")]
        public bool? IsLoggedIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
