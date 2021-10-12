using System;
using System.Net;

namespace CSharpStarter.Shared.Exceptions
{
    public class HttpException : Exception
    {

        public HttpStatusCode Status { get; set; }

        public HttpException(HttpStatusCode status, string msg) : base(msg)
        {
            Status = status;
        }

       
    }
}
