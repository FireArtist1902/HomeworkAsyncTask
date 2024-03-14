using System.Reflection.Metadata.Ecma335;

namespace HomeworkAsyncTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<int> CountSentenses(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    count++;
                }
            }
            return count;
        }

        private async Task<int> CountSymbols(string str)
        {
            return str.Length;
        }

        private async Task<int> CountWords(string str)
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

        private async Task<int> CountInterrogative(string str)
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

        private async Task<int> CountExclamatory(string str)
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

        private async void FindBtn_Click(object sender, EventArgs e)
        {
            List<string> str = new List<string>();


            if (SentensesCB.Checked)
            {
                str.Add($"Кількість реченнь: {CountSentenses(TextRTB.Text).Result}\n");
            }
            if (SymbolsCB.Checked)
            {
                str.Add($"Кількість символів: {CountSymbols(TextRTB.Text).Result}\n");
            }
            if (WordsCB.Checked)
            {
                str.Add($"Кількість слів: {CountWords(TextRTB.Text).Result}\n");
            }
            if (InterrogativeCB.Checked)
            {
                str.Add($"Кількість питальних реченнь: {CountInterrogative(TextRTB.Text).Result}\n");
            }
            if (ExclamatoryCB.Checked)
            {
                str.Add($"Кількість окличних реченнь: {CountExclamatory(TextRTB.Text).Result}\n");
            }

            string strin = " ";
            foreach(string item  in str)
            {
                strin += item;
            }

            MessageBox.Show(strin, "Result", MessageBoxButtons.OK);
        }
    }
}