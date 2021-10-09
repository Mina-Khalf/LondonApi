using LondonApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;
        public JsonExceptionFilter(IWebHostEnvironment env)
        {
            _env = env;
        }
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            var error = new ApiError();
            if (_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Details = context.Exception.StackTrace;
            }else
            {
                error.Message = "server error";
                error.Details = context.Exception.Message;
            }
            context.Result = new ObjectResult(error)
            {
                StatusCode = 0
            };
        }
    }
}
