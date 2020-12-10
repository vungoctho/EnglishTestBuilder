using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Core
{
    public interface IKeyValue
    {
        T Get<T>(string key, T defaultValue = default(T));
        void Set<T>(string key, T value);
    }
}
