using System.Net;

namespace CSharpStarter.Shared.Exceptions
{
    public class NotFoundException : HttpException
    {
        public NotFoundException(HttpStatusCode status = HttpStatusCode.NotFound, string msg = "Entity not Found") : base(status, msg)
        {}
    }
}
