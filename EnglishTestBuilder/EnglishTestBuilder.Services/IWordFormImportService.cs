using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Services
{
    public interface IWordFormImportService
    {
        void ImportWordFormFromFile(int grade, string contentFile);
    }
}
