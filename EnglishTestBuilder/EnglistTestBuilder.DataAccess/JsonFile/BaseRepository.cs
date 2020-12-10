using EnglishTestBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglistTestBuilder.DataAccess.JsonFile
{
    public abstract class BaseRepository
    {
        protected IAppSettings _appSettings;
        public BaseRepository(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
    }
}
