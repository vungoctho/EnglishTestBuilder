using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Common
{
    public static class ErrorMemoryStorage
    {
        private static List<string> _errors = new List<string>();
        public static void AddError(string message)
        {
            _errors.Add(message);
        }
        public static string Get()
        {
            return string.Join("\r\n", _errors);
        }
        public static void Reset()
        {
            _errors = new List<string>();
        }
    }
}
