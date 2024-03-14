using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkAsyncTask
{
    public partial class FileMove : Form
    {
        public FileMove()
        {
            InitializeComponent();
        }

        private void MoveBtn_Click(object sender, EventArgs e)
        {
            string source = SourceTB.Text;
            string dest = DestTB.Text;
            Directory.SetCurrentDirectory(source);
            List<string> files = Directory.GetFiles(source).ToList();
            bool IsFile = true;
            for(int i = 0; i < files.Count; i++)
            {
                for(int j = 1 + 1;  j < files.Count; j++)
                {
                    if (files[i] == files[j])
                    {
                        IsFile = false;
                    }
                    if (IsFile && File.Exists(files[i]))
                    {
                        File.Move(files[i], dest, true);
                    }
                }
            }
        }
    }
}
