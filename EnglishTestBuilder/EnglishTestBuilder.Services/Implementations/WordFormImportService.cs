using EnglishTestBuilder.Common;
using EnglishTestBuilder.Core;
using EnglishTestBuilder.Models;
using EnglistTestBuilder.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EnglishTestBuilder.Services.Implementations
{
    public class WordFormImportService : BaseService, IWordFormImportService
    {
        private readonly IWordFormRepository _wordFormRepository;
        public WordFormImportService(IAppSettings appSettings, IWordFormRepository wordFormRepository)
            :base(appSettings)
        {
            _wordFormRepository = wordFormRepository;
        }
        public void ImportWordFormFromFile(int grade, string contentFile)
        {
            try
            {
                List<WordForm> wordForms = new List<WordForm>();
                var id = 1;
                using (var sr = new StringReader(contentFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var wordForm = new WordForm()
                        {
                            Id = id,
                            Grade = grade,

                        };
                        //1.happy (adj)     # unhappy (a)     happily (adv)     happiness (n) :hạnh phúc.
                        var arrayWord = line.Split(new[] { ")" }, StringSplitOptions.RemoveEmptyEntries);
                        for (var idx = 0; idx < arrayWord.Length; idx++)
                        {
                            var word = arrayWord[idx];
                            if (idx == arrayWord.Length - 1) // VNese meaning
                            {
                                var wordTrim = word.RemoveSpecialStringForVN();
                                wordForm.VnMeaning = wordTrim;
                            }
                            else
                            {
                                var wordTrim = word.RemoveSpecialString();
                                var ingredents = wordTrim.Split('(', ')');
                                var wordTypes = ingredents[1].ConvertToWordType();
                                var wordString = ingredents[0];
                                if (wordTypes.Any())
                                    wordForm.AddWord(wordTypes, wordString);
                            }

                        }

                        wordForms.Add(wordForm);
                        id++;
                    }
                }

                var result = new WordFormDataSource()
                {
                    WordForms = wordForms,
                    LastWordFormId = id
                };
                _wordFormRepository.Save(result);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
