using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.Core.Implementations
{
    public class AppSettingsFile : IAppSettings
    {
        private readonly ApplicationSettingsBase _settings;
        public AppSettingsFile(ApplicationSettingsBase appSettings)
        {
            _settings = appSettings;
        }

        public Dictionary<string, object> AllSettings => _settings.PropertyValues.Cast<SettingsPropertyValue>().ToDictionary(x => x.Name, x => x.PropertyValue);

        public T Get<T>(string key, T defaultValue = default(T))
        {
            try
            {
                return (T)Convert.ChangeType(_settings[key], typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }

        public void Set<T>(string key, T value)
        {
            try
            {
                _settings[key] = value;
            }
            catch { /* Just ignore invalid settings */}
        }
    }
}
