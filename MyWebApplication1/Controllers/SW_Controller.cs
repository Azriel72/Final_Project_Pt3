using Microsoft.AspNetCore.Mvc;
using SearchWords_ClassLibrary;

namespace MyWebApplication1.Controllers
{
    [ApiController]
    [Route("SixLetterWords")]
    public class Search_Word : ControllerBase
    {
        [HttpGet (Name = "List")]
        public IEnumerable<string> GetWords(string input)
        {
            var goodInput = new InputString(input);
            var result = new ResultStringService();
            var output = result.SeperatedByComas(goodInput);

            IWordsRepository repository = new WordsRepository(output);
            var search_service = new DDD_Six_Letter_Words(repository);
            var six_letter_words = search_service.Search_SixLetter_Words();

            return six_letter_words;

        }
    }
}
