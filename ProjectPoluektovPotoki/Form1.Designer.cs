namespace ProjectPoluektovPotoki
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
            SelectFolder = new Button();
            directory = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ShowFiles = new Button();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            LookFile = new Button();
            label1 = new Label();
            words = new TextBox();
            ShowWithWords = new Button();
            SuspendLayout();
            // 
            // SelectFolder
            // 
            SelectFolder.Location = new Point(12, 12);
            SelectFolder.Name = "SelectFolder";
            SelectFolder.Size = new Size(114, 23);
            SelectFolder.TabIndex = 0;
            SelectFolder.Text = "Выбор папки:";
            SelectFolder.UseVisualStyleBackColor = true;
            SelectFolder.Click += SelectFolder_Click;
            // 
            // directory
            // 
            directory.Location = new Point(145, 12);
            directory.Name = "directory";
            directory.Size = new Size(340, 23);
            directory.TabIndex = 1;
            // 
            // ShowFiles
            // 
            ShowFiles.Location = new Point(505, 11);
            ShowFiles.Name = "ShowFiles";
            ShowFiles.Size = new Size(118, 23);
            ShowFiles.TabIndex = 2;
            ShowFiles.Text = "Показать файлы";
            ShowFiles.UseVisualStyleBackColor = true;
            ShowFiles.Click += ShowFiles_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 169);
            listBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 329);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 166);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // LookFile
            // 
            LookFile.Location = new Point(14, 283);
            LookFile.Name = "LookFile";
            LookFile.Size = new Size(132, 23);
            LookFile.TabIndex = 5;
            LookFile.Text = "Показать файл";
            LookFile.UseVisualStyleBackColor = true;
            LookFile.Click += LookFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 47);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Введите слово:";
            // 
            // words
            // 
            words.Location = new Point(144, 46);
            words.Name = "words";
            words.Size = new Size(341, 23);
            words.TabIndex = 7;
            // 
            // ShowWithWords
            // 
            ShowWithWords.Location = new Point(504, 46);
            ShowWithWords.Name = "ShowWithWords";
            ShowWithWords.Size = new Size(191, 23);
            ShowWithWords.TabIndex = 8;
            ShowWithWords.Text = "Показать файлы со словом";
            ShowWithWords.UseVisualStyleBackColor = true;
            ShowWithWords.Click += ShowWithWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(ShowWithWords);
            Controls.Add(words);
            Controls.Add(label1);
            Controls.Add(LookFile);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(ShowFiles);
            Controls.Add(directory);
            Controls.Add(SelectFolder);
            Name = "Form1";
            Text = "Полуэктов. Потоки.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolder;
        private TextBox directory;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button ShowFiles;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Button LookFile;
        private Label label1;
        private TextBox words;
        private Button ShowWithWords;
    }
}