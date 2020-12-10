using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace EnglishTestBuilder.UI
{
    public partial class MainForm : KryptonForm
    {
        //private static Autofac.IContainer Container { get; set; }
        public MainForm()
        {
            //Container = IoCBuilder.Container;
            InitializeComponent();
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = IoCBuilder.Container.Resolve<ImportWordFormFromFile>();
            form.Show();
        }

        private void fromFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportWordFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = IoCBuilder.Container.Resolve<ExportWordFormBuilder>();
            form.Show();
        }
    }
}
