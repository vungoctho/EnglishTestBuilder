using EnglishTestBuilder.Common;
using EnglishTestBuilder.Models;
using EnglistTestBuilder.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Word;
using EnglishTestBuilder.Core;

namespace EnglishTestBuilder.Services.Implementations
{
    public class WordFormBuilderService : BaseService, IWordFormBuilderService
    {
        private readonly IWordFormRepository _wordFormRepository;
        public WordFormBuilderService(IAppSettings appSettings, IWordFormRepository wordFormRepository)
            :base(appSettings)
        {
            _wordFormRepository = wordFormRepository;
        }
        
        public WordFormDataSource LoadWordFormDataSourceFromFile(string filePath)
        {
            return _wordFormRepository.Load(filePath);
        }

        public string ExportToFile(List<WordForm> words)
        {
            // use factory to get WordWriter instance
            // Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //Microsoft.Office.Interop.Word.Document doc = app.Documents.(@"Output.docx");
            //object missing = System.Reflection.Missing.Value;
            //doc.Content.Text += "TESING";
            //app.Visible = true;    //Optional
            //doc.Save();

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            _Application oWord;
            _Document oDoc;
            oWord = new Microsoft.Office.Interop.Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            //Paragraph oPara1;
            //oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //oPara1.Range.Text = "Heading 1";
            ////oPara1.Range.Font.Bold = 1;
            //oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            //oPara1.Range.InsertParagraphAfter();
            foreach (var wordForm in words)
            {
                var arrayWords = wordForm.OverviewWordForm.Split(',').Select(s => s.Trim()).ToArray();
                int randomSelectedIndex = (new Random()).Next(0, arrayWords.Count());
                Paragraph oPara1;
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara1 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara1.Range.Text = arrayWords[randomSelectedIndex];
                oPara1.Format.SpaceAfter = 6;
                oPara1.Range.InsertParagraphAfter();
                for (var i = 0; i < arrayWords.Count(); i++)
                {
                    if (i == randomSelectedIndex) continue;
                    Paragraph oPara2;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara2.Range.Text = "------------------------";
                    oPara2.Format.SpaceAfter = 6;
                    oPara2.Range.InsertParagraphAfter();
                }

            }
            var timestamp = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            var path = _appSettings.Get<string>("WordFormOutputRootFolder");
            var filename = $"workform_{timestamp}.docx";
            var fileOutput = Path.Combine(path, filename);
            oDoc.SaveAs2(fileOutput);
            oDoc.Save();
            oDoc.Close();
            return fileOutput;
        }
    }
}
