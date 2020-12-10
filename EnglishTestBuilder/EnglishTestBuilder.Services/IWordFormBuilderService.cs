using EnglishTestBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Services
{
    public interface IWordFormBuilderService
    {
        WordFormDataSource LoadWordFormDataSourceFromFile(string filePath);
        string ExportToFile(List<WordForm> words);    
    }
}
