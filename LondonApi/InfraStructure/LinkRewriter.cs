using LondonApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.InfraStructure
{
    public class LinkRewriter
    {
        private readonly IUrlHelper _urlHelper;

        public LinkRewriter(IUrlHelper urlHelper)
        {
            _urlHelper = urlHelper;
        }

        public Link Rewrite(Link Original)
        {
            if (Original == null) return null;
            return new Link()
            {
                Href = _urlHelper.Link(Original.RouteName, Original.RouteValue),
                Method = Original.Method,
                Relations = Original.Relations
            };
        }
    }
}
