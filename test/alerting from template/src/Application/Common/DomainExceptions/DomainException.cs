﻿using System;

namespace Alerting.Application.Common.DomainExceptions
{
    public class DomainException : Exception
    {
        public DomainException(ErrorStatusCode statusCode, ErrorMessage errorMessage)
        : base(null) { ErrorStatusCode = statusCode; ErrorMessage = errorMessage; }

        public ErrorStatusCode ErrorStatusCode { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
    }
}