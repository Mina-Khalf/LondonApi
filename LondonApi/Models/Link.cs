using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Models
{
    public class Link
    {
        public static Link To(string RouteName, Object RouteValue=null)
            => new()
            {
                RouteName = RouteName,
                RouteValue = RouteValue,
                Method = GetMethod,
                Relations=null
            };

        public const string GetMethod= "GET";
        [JsonProperty(Order =-4)]
        public string Href { get; set; }
        [JsonProperty(Order =-3 , PropertyName ="rel" ,NullValueHandling =NullValueHandling.Ignore)]
        public string[] Relations { get; set; }
        [JsonProperty(Order = -2 , NullValueHandling = NullValueHandling.Ignore ,DefaultValueHandling =DefaultValueHandling.Ignore)]
        [DefaultValue(GetMethod)]
        public string Method { get; set; }



        //the two properties sotres the route before being rewritten by LinkRewritingFilter
        [JsonIgnore]
        public string RouteName { get; set; }
        [JsonIgnore]
        public Object RouteValue { get; set; }
    }
}
