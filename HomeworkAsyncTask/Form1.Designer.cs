namespace HomeworkAsyncTask
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
            TextRTB = new RichTextBox();
            SentensesCB = new CheckBox();
            SymbolsCB = new CheckBox();
            WordsCB = new CheckBox();
            InterrogativeCB = new CheckBox();
            ExclamatoryCB = new CheckBox();
            FindBtn = new Button();
            SuspendLayout();
            // 
            // TextRTB
            // 
            TextRTB.Location = new Point(12, 12);
            TextRTB.Name = "TextRTB";
            TextRTB.Size = new Size(225, 228);
            TextRTB.TabIndex = 0;
            TextRTB.Text = "";
            // 
            // SentensesCB
            // 
            SentensesCB.AutoSize = true;
            SentensesCB.Location = new Point(249, 20);
            SentensesCB.Name = "SentensesCB";
            SentensesCB.Size = new Size(89, 24);
            SentensesCB.TabIndex = 1;
            SentensesCB.Text = "Речення";
            SentensesCB.UseVisualStyleBackColor = true;
            // 
            // SymbolsCB
            // 
            SymbolsCB.AutoSize = true;
            SymbolsCB.Location = new Point(249, 50);
            SymbolsCB.Name = "SymbolsCB";
            SymbolsCB.Size = new Size(94, 24);
            SymbolsCB.TabIndex = 2;
            SymbolsCB.Text = "Символи";
            SymbolsCB.UseVisualStyleBackColor = true;
            // 
            // WordsCB
            // 
            WordsCB.AutoSize = true;
            WordsCB.Location = new Point(249, 80);
            WordsCB.Name = "WordsCB";
            WordsCB.Size = new Size(73, 24);
            WordsCB.TabIndex = 3;
            WordsCB.Text = "Слова";
            WordsCB.UseVisualStyleBackColor = true;
            // 
            // InterrogativeCB
            // 
            InterrogativeCB.AutoSize = true;
            InterrogativeCB.Location = new Point(249, 110);
            InterrogativeCB.Name = "InterrogativeCB";
            InterrogativeCB.Size = new Size(157, 24);
            InterrogativeCB.TabIndex = 4;
            InterrogativeCB.Text = "Питальні речення";
            InterrogativeCB.UseVisualStyleBackColor = true;
            // 
            // ExclamatoryCB
            // 
            ExclamatoryCB.AutoSize = true;
            ExclamatoryCB.Location = new Point(249, 140);
            ExclamatoryCB.Name = "ExclamatoryCB";
            ExclamatoryCB.Size = new Size(150, 24);
            ExclamatoryCB.TabIndex = 5;
            ExclamatoryCB.Text = "Окличні речення";
            ExclamatoryCB.UseVisualStyleBackColor = true;
            // 
            // FindBtn
            // 
            FindBtn.Location = new Point(249, 170);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(94, 29);
            FindBtn.TabIndex = 6;
            FindBtn.Text = "Знайти";
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.Click += FindBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FindBtn);
            Controls.Add(ExclamatoryCB);
            Controls.Add(InterrogativeCB);
            Controls.Add(WordsCB);
            Controls.Add(SymbolsCB);
            Controls.Add(SentensesCB);
            Controls.Add(TextRTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextRTB;
        private CheckBox SentensesCB;
        private CheckBox SymbolsCB;
        private CheckBox WordsCB;
        private CheckBox InterrogativeCB;
        private CheckBox ExclamatoryCB;
        private Button FindBtn;
    }
}