using System.Web.Http;

namespace Readify.KnockKnock.API.Controllers
{
    /// <summary>
    /// Controller to reverse a sentence.
    /// </summary>
    public class ReverseWordsController : ApiController
    {
        /// <summary>
        /// Function to return the reverse of a given sentence.
        /// </summary>
        /// <param name="sentence">A string to reverse.</param>
        /// <returns>The reverse string.</returns>
        public string Get(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            var words = sentence.Split(' ');
            for (int w = 0; w < words.Length; w++)
            {
                var word = words[w];
                var len = word.Length;
                var letters = new char[len];
                var count = len % 2 == 0 ? len / 2 : len / 2 + 1;
                for (int i = 0; i < count; i++)
                {
                    letters[i] = word[len - 1 - i];
                    letters[len - 1 - i] = word[i];
                }

                words[w] = new string(letters);
            }

            return string.Join(" ", words);
        }
    }
}