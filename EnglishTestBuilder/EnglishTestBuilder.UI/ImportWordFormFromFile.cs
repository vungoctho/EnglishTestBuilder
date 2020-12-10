using ComponentFactory.Krypton.Toolkit;
using EnglishTestBuilder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTestBuilder.UI
{
    public partial class ImportWordFormFromFile : KryptonForm
    {
        private readonly IWordFormImportService _wordFormImportService;
        public ImportWordFormFromFile(IWordFormImportService wordFormImportService)
        {
            _wordFormImportService = wordFormImportService;
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            openFileDialog1.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                var filePath = openFileDialog1.FileName;
                txtFilePath.Text = filePath;
                txtFileContent.Text = System.IO.File.ReadAllText(filePath);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                var content = txtFileContent.Text;
                var grade = int.Parse((string)cbxGrade.SelectedItem);
                _wordFormImportService.ImportWordFormFromFile(grade, content);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
