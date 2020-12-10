using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Core
{
    public interface IAppSettings : IKeyValue
    {
        Dictionary<string, object> AllSettings { get; }
    }
}
