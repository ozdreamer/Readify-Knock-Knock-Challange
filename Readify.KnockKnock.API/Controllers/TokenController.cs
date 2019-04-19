using System;
using System.Web.Http;

namespace Readify.KnockKnock.API.Controllers
{
    /// <summary>
    /// The controller to provide token.
    /// </summary>
    public class TokenController : ApiController
    {
        /// <summary>
        /// Basic get function to invoke the startup page.
        /// </summary>
        /// <returns>An empty guid.</returns>
        public string Get() => "47d64986-f2bb-442f-b7a9-974f33a9b500";
    }
}