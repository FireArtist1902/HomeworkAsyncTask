using System.Reflection.Metadata.Ecma335;

namespace HomeworkAsyncTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountSentenses(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i] == '?' || str[i] == '!' && str[i + 1] != '.' || str[i + 1] != '?' || str[i + 1] != '!')
                {
                    count++;
                }
            }
            return count;
        }

        private int CountSymbols(string str)
        {
            return str.Length;
        }

        private int CountWords(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == ' ' || str[i] == '.' || str[i] == ',')
                {
                    count++;
                }
            }
            return count;
        }

        private int CountInterrogative(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '?')
                {
                    count++;
                }
            }
            return count;
        }

        private int CountExclamatory(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '!')
                {
                    count++;
                }
            }
            return count;
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string str = "";

            if (SentensesCB.Checked)
            {
                str += $"Кількість речень: {CountSentenses(TextRTB.Text)}\n";
            }
            if (SymbolsCB.Checked)
            {
                str += $"Кількість речень: {CountSymbols(TextRTB.Text)}\n";
            }
            if (WordsCB.Checked)
            {
                str += $"Кількість речень: {CountWords(TextRTB.Text)}\n";
            }
            if (InterrogativeCB.Checked)
            {
                str += $"Кількість речень: {CountInterrogative(TextRTB.Text)}\n";
            }
            if (ExclamatoryCB.Checked)
            {
                str += $"Кількість речень: {CountExclamatory(TextRTB.Text)}\n";
            }

            MessageBox.Show(str, "Result", MessageBoxButtons.OK);
        }
    }
}