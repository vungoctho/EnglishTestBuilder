using Autofac;
using EnglishTestBuilder.Core;
using EnglishTestBuilder.Core.Implementations;
using EnglishTestBuilder.Services;
using EnglishTestBuilder.Services.Implementations;
using EnglistTestBuilder.DataAccess;
using EnglistTestBuilder.DataAccess.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestBuilder.UI
{
    public static class IoCBuilder
    {
        private static IContainer _container = BuildContainer();

        public static IContainer Container
        {
            get {
                return _container; 
            }
        }
        private static IContainer BuildContainer()
        {
            //var logger = new LoggerConfiguration()
            //        .MinimumLevel.Verbose()
            //        .WriteTo.Console(outputTemplate: outputTemplate)
            //            .WriteTo.File("logs/log-.log",
            //                          outputTemplate: outputTemplate,
            //                          rollingInterval: RollingInterval.Day)
            //            .CreateLogger();

            // Container
            var builder = new ContainerBuilder();
            //builder.RegisterInstance(logger).As<ILogger>().SingleInstance();

            builder.RegisterType<WordFormImportService>().As<IWordFormImportService>();
            builder.RegisterType<WordFormRepository>().As<IWordFormRepository>();
            builder.RegisterType<WordFormBuilderService>().As<IWordFormBuilderService>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<ImportWordFormFromFile>();
            builder.RegisterType<ExportWordFormBuilder>();
            
            // Settings from the App.settings UI
            var settings = new AppSettingsFile(App.Default);
            builder.RegisterInstance<IAppSettings>(settings).SingleInstance();

            //Container = builder.Build();
            return builder.Build();
        }
    }
}
