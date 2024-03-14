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
                str.Add($"ʳ������ �������: {CountSentenses(TextRTB.Text).Result}\n");
            }
            if (SymbolsCB.Checked)
            {
                str.Add($"ʳ������ �������: {CountSymbols(TextRTB.Text).Result}\n");
            }
            if (WordsCB.Checked)
            {
                str.Add($"ʳ������ ���: {CountWords(TextRTB.Text).Result}\n");
            }
            if (InterrogativeCB.Checked)
            {
                str.Add($"ʳ������ ��������� �������: {CountInterrogative(TextRTB.Text).Result}\n");
            }
            if (ExclamatoryCB.Checked)
            {
                str.Add($"ʳ������ �������� �������: {CountExclamatory(TextRTB.Text).Result}\n");
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