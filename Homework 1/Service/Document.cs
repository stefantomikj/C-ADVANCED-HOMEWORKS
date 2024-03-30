using System.Linq;
using System.Reflection.Metadata;

namespace Service
{
    public class Document : ISearchable
    {
        public string Text { get; set; }

        public Document(string text)
        {
            Text = text;
        }
        public string Search(string word)
        {
            if (Text.Contains(word)) 
            {
                return $"The document contains the word : {word}";
            }
            else
            {
                return $"The document doesn't contain the word!";
            }
        }
    }
}
