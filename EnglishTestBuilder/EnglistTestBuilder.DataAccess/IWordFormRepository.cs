using EnglishTestBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglistTestBuilder.DataAccess
{
    public interface IWordFormRepository
    {
        bool Save(WordFormDataSource datasource);
        WordFormDataSource Load(string filePath);
    }
}
