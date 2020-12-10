using ComponentFactory.Krypton.Toolkit;
using EnglishTestBuilder.Core;
using EnglishTestBuilder.Models;
using EnglishTestBuilder.Services;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace EnglishTestBuilder.UI
{
    public partial class ExportWordFormBuilder : KryptonForm
    {
        private readonly IWordFormBuilderService _wordFormBuilderService;
        private WordFormDataSource _wordFormDataSource;
        private IAppSettings _appSettings;
        public ExportWordFormBuilder(IAppSettings appSettings, IWordFormBuilderService wordFormBuilderService)
        {
            _wordFormBuilderService = wordFormBuilderService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var selectedWords = from string word in wordFormCheckedListBox.CheckedItems select word;
            var selectedWordForms = _wordFormDataSource.WordForms.Where(s => selectedWords.Contains(s.OverviewWordForm)).ToList();
            _wordFormBuilderService.ExportToFile(selectedWordForms);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            UpdateAllState(true);
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            UpdateAllState(false);
        }

        private void UpdateAllState(bool isCheck)
        {
            for (int i = 0; i < wordFormCheckedListBox.Items.Count; i++)
            {
                wordFormCheckedListBox.SetItemChecked(i, isCheck);
            }
        }

        private void cbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_wordFormDataSource == null)
            {
                var path = _appSettings.Get<string>("WordFormDataRootFolder");
                var filename = _appSettings.Get<string>("WordFormDataFileName");
                var jsonFile = Path.Combine(path, filename);
                if (File.Exists(jsonFile))
                {
                    _wordFormDataSource = _wordFormBuilderService.LoadWordFormDataSourceFromFile(jsonFile);                                       
                }
                else
                {
                    // error
                    return;
                }
            }
            
            var grade = int.Parse((string)cbxGrade.SelectedItem);
            wordFormCheckedListBox.Items.Clear();
            var list = _wordFormDataSource.WordForms
                .Where(s=> s.Grade == grade)
                .Select(s => s.OverviewWordForm).OrderBy(s => s).ToArray();
            wordFormCheckedListBox.Items.AddRange(list);
        }
    }
}
