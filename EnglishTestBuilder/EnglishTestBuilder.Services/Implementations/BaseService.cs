using EnglishTestBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Services.Implementations
{
    public abstract class BaseService
    {
        protected IAppSettings _appSettings;
        public BaseService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
    }
}
