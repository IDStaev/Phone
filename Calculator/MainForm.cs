using System.Text;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private StringBuilder numbers = new();
        private StringBuilder resultText = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private List<string> GetCharacterCodes(string input)
        {
            var res = new List<string>();
            int i = 0;

            while (i < input.Length)
            {
                char currentChar = input[i];
                int j = i + 1;

                while (j < input.Length && input[j] == currentChar)
                {
                    j++;
                }

                res.Add(input.Substring(i, j - i));

                i = j;
            }

            return res;
        }

        private void UpdateResultTextLabel()
        {
            resultTextLabel.Text = resultText.ToString();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numbers.Append("1");
            UpdateResultTextLabel();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numbers.Append("2");
            UpdateResultTextLabel();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numbers.Append("3");
            UpdateResultTextLabel();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numbers.Append("4");
            UpdateResultTextLabel();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numbers.Append("5");
            UpdateResultTextLabel();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numbers.Append("6");
            UpdateResultTextLabel();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numbers.Append("7");
            UpdateResultTextLabel();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numbers.Append("8");
            UpdateResultTextLabel();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numbers.Append("9");
            UpdateResultTextLabel();
        }
    }
}