using Microsoft.AspNetCore.Mvc;
using StringReverse.API.Abstractions;
using StringReverse.API.Services;

namespace StringReverse.API.Controllers
{
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;
        public TextController(ITextService textService)
        {
            _textService = textService;
        }
        [HttpGet("GetReversedText")]
        public ActionResult<string> GetReversedText(string text)
        {
            var reversedText = _textService.ReverseText(text);

            return reversedText;
        }
    }
}
