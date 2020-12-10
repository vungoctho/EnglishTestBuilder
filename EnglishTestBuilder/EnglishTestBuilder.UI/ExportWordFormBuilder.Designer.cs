namespace EnglishTestBuilder.UI
{
    partial class ExportWordFormBuilder
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
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wordFormCheckedListBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.btnSelectAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUnselectAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGrade = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(96, 333);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 25);
            this.btnExport.TabIndex = 20;
            this.btnExport.Values.Text = "Export to Word";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // wordFormCheckedListBox
            // 
            this.wordFormCheckedListBox.Location = new System.Drawing.Point(96, 72);
            this.wordFormCheckedListBox.Name = "wordFormCheckedListBox";
            this.wordFormCheckedListBox.Size = new System.Drawing.Size(356, 239);
            this.wordFormCheckedListBox.TabIndex = 21;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(470, 72);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(90, 25);
            this.btnSelectAll.TabIndex = 22;
            this.btnSelectAll.Values.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(470, 103);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(90, 25);
            this.btnUnselectAll.TabIndex = 23;
            this.btnUnselectAll.Values.Text = "Unselect All";
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Grade";
            // 
            // cbxGrade
            // 
            this.cbxGrade.DropDownWidth = 121;
            this.cbxGrade.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.cbxGrade.Location = new System.Drawing.Point(96, 45);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(121, 21);
            this.cbxGrade.TabIndex = 24;
            this.cbxGrade.SelectedIndexChanged += new System.EventHandler(this.cbxGrade_SelectedIndexChanged);
            // 
            // ExportWordFormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGrade);
            this.Controls.Add(this.btnUnselectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.wordFormCheckedListBox);
            this.Controls.Add(this.btnExport);
            this.Name = "ExportWordFormBuilder";
            this.Text = "WordFormBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox wordFormCheckedListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSelectAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUnselectAll;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxGrade;
    }
}