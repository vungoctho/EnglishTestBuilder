using EnglishTestBuilder.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Models
{
    public class WordForm
    {
        public long Id { get; set; }
        public int Grade { get; set; }
        public List<string> NounWords { get; set; }
        public List<string> VerbWords { get; set; }
        public List<string> AdjectiveWords { get; set; }
        public List<string> AdverbWords { get; set; }
        public string VnMeaning { get; set; }
        public string OverviewWordForm
        {
            get
            {
                string JoinString(List<string> words)
                {
                    if (words != null && words.Any())
                    {
                        return string.Join(", ", words);
                    }
                    return string.Empty;
                }
                var array = new string[] { JoinString(VerbWords), JoinString(NounWords), JoinString(AdjectiveWords), JoinString(AdverbWords) };
                array = array.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                var result = string.Join(", ", array);
                return result;
            }
        }
        public WordForm()
        {
            NounWords = new List<string>();
            VerbWords = new List<string>();
            AdjectiveWords = new List<string>();
            AdverbWords = new List<string>();
        }

        public void AddWord(List<WordType> types, string word)
        {
            foreach (var type in types)
            {
                switch (type)
                {
                    case Models.Enums.WordType.Verb:
                        this.VerbWords.Add(word);
                        break;
                    case Models.Enums.WordType.Noun:
                        this.NounWords.Add(word);
                        break;
                    case Models.Enums.WordType.Adjective:
                        this.AdjectiveWords.Add(word);
                        break;
                    case Models.Enums.WordType.Adverb:
                        this.AdverbWords.Add(word);
                        break;
                }
            }
        }
    }
}
