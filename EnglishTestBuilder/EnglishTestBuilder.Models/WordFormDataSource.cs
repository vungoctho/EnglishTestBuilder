using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Models
{
    public class WordFormDataSource
    {
        public List<WordForm> WordForms { get; set; }
        public int LastWordFormId { get; set; }
    }
}
