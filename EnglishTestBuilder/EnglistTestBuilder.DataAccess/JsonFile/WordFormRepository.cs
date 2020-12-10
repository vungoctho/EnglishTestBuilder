using EnglishTestBuilder.Core;
using EnglishTestBuilder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglistTestBuilder.DataAccess.JsonFile
{
    public class WordFormRepository : BaseRepository, IWordFormRepository
    {
        public WordFormRepository(IAppSettings appSettings)
            :base(appSettings)
        {

        }

        public bool Save(WordFormDataSource datasource)
        {
            var json = JsonConvert.SerializeObject(datasource);
            var path = _appSettings.Get<string>("WordFormDataRootFolder");
            var filename = _appSettings.Get<string>("WordFormDataFileName");
            var jsonFile = Path.Combine(path, filename);
            if (!File.Exists(jsonFile))
            {
                File.WriteAllText(jsonFile, json);
            }
            else
            {
                // update
            }
            return true;
        }

        public WordFormDataSource Load(string filePath)
        {
            var wordFormJsonSource = System.IO.File.ReadAllText(filePath);
            var ds = JsonConvert.DeserializeObject<WordFormDataSource>(wordFormJsonSource);
            return ds;
        }
    }
}
