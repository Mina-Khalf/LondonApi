using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Models
{
    public abstract class Resource:Link
    {
        [JsonIgnore]
        public Link Self { get; set; }
    }
}
