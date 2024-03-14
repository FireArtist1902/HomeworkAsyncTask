namespace HomeworkAsyncTask
{
    partial class FileMove
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
            SourceTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DestTB = new TextBox();
            MoveBtn = new Button();
            SuspendLayout();
            // 
            // SourceTB
            // 
            SourceTB.Location = new Point(12, 67);
            SourceTB.Name = "SourceTB";
            SourceTB.Size = new Size(164, 27);
            SourceTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Початкова директорія";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 33);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 3;
            label2.Text = "Кінцева директорія";
            // 
            // DestTB
            // 
            DestTB.Location = new Point(224, 67);
            DestTB.Name = "DestTB";
            DestTB.Size = new Size(164, 27);
            DestTB.TabIndex = 2;
            // 
            // MoveBtn
            // 
            MoveBtn.AutoSize = true;
            MoveBtn.Location = new Point(12, 110);
            MoveBtn.Name = "MoveBtn";
            MoveBtn.Size = new Size(107, 30);
            MoveBtn.TabIndex = 4;
            MoveBtn.Text = "Перемістити";
            MoveBtn.UseVisualStyleBackColor = true;
            MoveBtn.Click += MoveBtn_Click;
            // 
            // FileMove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 193);
            Controls.Add(MoveBtn);
            Controls.Add(label2);
            Controls.Add(DestTB);
            Controls.Add(label1);
            Controls.Add(SourceTB);
            Name = "FileMove";
            Text = "FileMove";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceTB;
        private Label label1;
        private Label label2;
        private TextBox DestTB;
        private Button MoveBtn;
    }
}