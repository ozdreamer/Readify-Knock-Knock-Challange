using System.Web.Http;

namespace Readify.KnockKnock.API.Controllers
{
    /// <summary>
    /// The controller to generate fibonacci.
    /// </summary>
    public class FibonacciController : ApiController
    {
        /// <summary>
        /// Function to return the reverse of a given sentence.
        /// </summary>
        /// <param name="sentence">A string to reverse.</param>
        /// <returns>The reverse string.</returns>
        public long Get(int n)
        {
            long a = 0;
            long b = 1;
            long c;
            for (int i = 31; i >= 0; i--)
            {
                long d = a * (b * 2 - a);
                long e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
            }

            return a;
        }
    }
}