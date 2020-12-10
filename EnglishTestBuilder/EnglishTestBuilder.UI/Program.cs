using Autofac;
using EnglishTestBuilder.Services;
using EnglishTestBuilder.Services.Implementations;
using EnglistTestBuilder.DataAccess;
using EnglistTestBuilder.DataAccess.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTestBuilder.UI
{
    static class Program
    {
        private static IContainer Container { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Bootstrap();
            Container = IoCBuilder.Container;
            Application.Run(Container.Resolve<MainForm>());
        }

        //static void Bootstrap()
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<WordFormImportService>().As<IWordFormImportService>();
        //    builder.RegisterType<WordFormRepository>().As<IWordFormRepository>();
        //    builder.RegisterType<MainForm>();
        //    builder.RegisterType<ImportWordFormFromFile>();
        //    Container = builder.Build();

        //}
    }
}
