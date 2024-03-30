using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Service
{
    public class WebPage : ISearchable
    {
        public string WebText { get; set; }

        public WebPage(string webText) {

            WebText = webText;


        }
        public string Search(string word)
        {
            if (WebText.Contains(word))
            {
                return $"The Web Page contains the word : {word}";
            }
            else
            {
                return $"The Web Page doesn't contain the word!";
            }

        }
    }
}
