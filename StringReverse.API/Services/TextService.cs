using StringReverse.API.Abstractions;
using System.Text;

namespace StringReverse.API.Services
{
    public class TextService:ITextService
    {
        public string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}