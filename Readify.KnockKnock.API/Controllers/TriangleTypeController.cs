using System.Web.Http;

namespace Readify.KnockKnock.API.Controllers
{
    /// <summary>
    /// The controller to identify the triangle type.
    /// </summary>
    public class TriangleTypeController : ApiController
    {
        /// <summary>
        /// Get a triangle type.
        /// </summary>
        /// <param name="a">Length a.</param>
        /// <param name="b">Length b.</param>
        /// <param name="c">Length c.</param>
        /// <returns>The triangle type.</returns>
        public string Get(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a >= b + c || b >= c + a || c >= a + b)
            {
                return "Error";
            }

            if (a == b && b == c)
            {
                return "Equilateral";
            }

            if (a == c || b == c || a == b)
            {
                return "Isosceles";
            }

            return "Scalene";
        }
    }
}