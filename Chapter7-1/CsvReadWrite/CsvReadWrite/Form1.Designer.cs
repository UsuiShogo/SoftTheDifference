namespace CsvReadWrite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInputCSVFileName = new TextBox();
            buttonCsvRead = new Button();
            dateGridViewCsv = new DataGridView();
            textBoxOutputCSVFileName = new TextBox();
            buttonCsvWrite = new Button();
            openFileDialogcsv = new OpenFileDialog();
            saveFileDialogCsv = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dateGridViewCsv).BeginInit();
            SuspendLayout();
            // 
            // textBoxInputCSVFileName
            // 
            textBoxInputCSVFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInputCSVFileName.Location = new Point(20, 11);
            textBoxInputCSVFileName.Name = "textBoxInputCSVFileName";
            textBoxInputCSVFileName.Size = new Size(572, 23);
            textBoxInputCSVFileName.TabIndex = 0;
            // 
            // buttonCsvRead
            // 
            buttonCsvRead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCsvRead.Location = new Point(622, 13);
            buttonCsvRead.Name = "buttonCsvRead";
            buttonCsvRead.Size = new Size(144, 21);
            buttonCsvRead.TabIndex = 1;
            buttonCsvRead.Text = "CSV取得";
            buttonCsvRead.UseVisualStyleBackColor = true;
            buttonCsvRead.Click += buttonCsvRead_Click;
            // 
            // dateGridViewCsv
            // 
            dateGridViewCsv.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewCsv.Location = new Point(24, 50);
            dateGridViewCsv.Name = "dateGridViewCsv";
            dateGridViewCsv.Size = new Size(742, 347);
            dateGridViewCsv.TabIndex = 2;
            // 
            // textBoxOutputCSVFileName
            // 
            textBoxOutputCSVFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutputCSVFileName.Location = new Point(24, 415);
            textBoxOutputCSVFileName.Name = "textBoxOutputCSVFileName";
            textBoxOutputCSVFileName.Size = new Size(568, 23);
            textBoxOutputCSVFileName.TabIndex = 3;
            // 
            // buttonCsvWrite
            // 
            buttonCsvWrite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCsvWrite.Location = new Point(622, 415);
            buttonCsvWrite.Name = "buttonCsvWrite";
            buttonCsvWrite.Size = new Size(142, 25);
            buttonCsvWrite.TabIndex = 4;
            buttonCsvWrite.Text = "CSV出力";
            buttonCsvWrite.UseVisualStyleBackColor = true;
            buttonCsvWrite.Click += buttonCsvWrite_Click;
            // 
            // openFileDialogcsv
            // 
            openFileDialogcsv.FileName = "*.csv";
            openFileDialogcsv.InitialDirectory = ".\\";
            // 
            // saveFileDialogCsv
            // 
            saveFileDialogCsv.InitialDirectory = ".\\";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCsvWrite);
            Controls.Add(textBoxOutputCSVFileName);
            Controls.Add(dateGridViewCsv);
            Controls.Add(buttonCsvRead);
            Controls.Add(textBoxInputCSVFileName);
            Name = "Form1";
            Text = "CSVの読み書き";
            ((System.ComponentModel.ISupportInitialize)dateGridViewCsv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputCSVFileName;
        private Button buttonCsvRead;
        private DataGridView dateGridViewCsv;
        private TextBox textBoxOutputCSVFileName;
        private Button buttonCsvWrite;
        private OpenFileDialog openFileDialogcsv;
        private SaveFileDialog saveFileDialogCsv;
    }
}
