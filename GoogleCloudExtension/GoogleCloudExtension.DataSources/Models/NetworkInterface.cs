﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleCloudExtension.DataSources.Models
{
    public class NetworkInterface
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accessConfigs")]
        public IList<NetworkAccessConfig> AccessConfigs { get; set; }

        [JsonProperty("networkIP")]
        public string NetworkIp { get; set; }
    }
}