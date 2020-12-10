namespace EnglishTestBuilder.UI
{
    partial class ImportWordFormFromFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxGrade = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnChooseFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtFileContent = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.btnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGrade
            // 
            this.cbxGrade.DropDownWidth = 121;
            this.cbxGrade.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.cbxGrade.Location = new System.Drawing.Point(92, 20);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(121, 21);
            this.cbxGrade.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Import";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(92, 55);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(356, 23);
            this.txtFilePath.TabIndex = 13;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(466, 55);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(90, 25);
            this.btnChooseFile.TabIndex = 14;
            this.btnChooseFile.Values.Text = "Choose file";
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(92, 104);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(356, 243);
            this.txtFileContent.TabIndex = 15;
            this.txtFileContent.Text = "";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(92, 372);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 25);
            this.btnImport.TabIndex = 16;
            this.btnImport.Values.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportWordFormFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGrade);
            this.Name = "ImportWordFormFromFile";
            this.Text = "Import Word Form";
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChooseFile;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtFileContent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}