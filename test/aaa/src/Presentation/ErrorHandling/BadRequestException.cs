using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Test22.Presentation.ErrorHandling
{
    public class BadRequestException : Exception
    {
        public BadRequestException(ActionExecutingContext context)
        : base() { ActionExecutingContext = context; }
        
        public ActionExecutingContext ActionExecutingContext { get; set; }
    }
}