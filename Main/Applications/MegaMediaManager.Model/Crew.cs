﻿using System;
using System.Collections.Generic;
using Infrastructure;
using Newtonsoft.Json;

namespace MegaMediaManager.Model
{
    public class Crew : DomainEntity<int>
    {
        [JsonProperty("credit_id")]
        public string CreditId;

        [JsonProperty("department")]
        public Department Department;

        [JsonProperty("job")]
        public Job Job;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("profile_path")]
        public string ProfilePath;
    }
}