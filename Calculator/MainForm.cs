using System.Text;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string? numbers = string.Empty;
        private string? resultText = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private List<string>? GetCharacterCodes(string? input)
        {
            var res = new List<string>();
            int i = 0;

            if (input is not null)
            {
                while (i < input.Length)
                {
                    char currentChar = input[i];
                    int j = i + 1;
                    int maxSize = 0;

                    switch (currentChar)
                    {
                        case '1': maxSize = 1; break;
                        case '2': maxSize = 4; break;
                        case '3': maxSize = 4; break;
                        case '4': maxSize = 4; break;
                        case '5': maxSize = 4; break;
                        case '6': maxSize = 4; break;
                        case '7': maxSize = 5; break;
                        case '8': maxSize = 4; break;
                        case '9': maxSize = 5; break;
                        case '0': maxSize = 2; break;
                    }

                    while (j < input.Length && input[j] == currentChar && j - i < maxSize)
                    {
                        j++;
                    }

                    res.Add(input.Substring(i, j - i));

                    i = j;
                }
            }

            return res;
        }

        private string? GetText(List<string>? input)
        {
            var str = new StringBuilder();

            if(input is not null) {

                foreach (var code in input)
                {
                    var codeLength = code.Length;

                    switch (code.First())
                    {
                        case '1':
                            {
                                str.Append("1");
                                break;
                            }
                        case '2':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("2"); break;
                                    case 2: str.Append("a"); break;
                                    case 3: str.Append("b"); break;
                                    case 4: str.Append("c"); break;
                                }
                                break;
                            }
                        case '3':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("3"); break;
                                    case 2: str.Append("d"); break;
                                    case 3: str.Append("e"); break;
                                    case 4: str.Append("f"); break;
                                }
                                break;
                            }
                        case '4':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("4"); break;
                                    case 2: str.Append("g"); break;
                                    case 3: str.Append("h"); break;
                                    case 4: str.Append("i"); break;
                                }
                                break;
                            }
                        case '5':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("5"); break;
                                    case 2: str.Append("j"); break;
                                    case 3: str.Append("k"); break;
                                    case 4: str.Append("l"); break;
                                }
                                break;
                            }
                        case '6':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("6"); break;
                                    case 2: str.Append("m"); break;
                                    case 3: str.Append("n"); break;
                                    case 4: str.Append("o"); break;
                                }
                                break;
                            }
                        case '7':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("7"); break;
                                    case 2: str.Append("p"); break;
                                    case 3: str.Append("q"); break;
                                    case 4: str.Append("r"); break;
                                    case 5: str.Append("s"); break;
                                }
                                break;
                            }
                        case '8':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("8"); break;
                                    case 2: str.Append("t"); break;
                                    case 3: str.Append("u"); break;
                                    case 4: str.Append("v"); break;
                                }
                                break;
                            }
                        case '9':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("9"); break;
                                    case 2: str.Append("w"); break;
                                    case 3: str.Append("x"); break;
                                    case 4: str.Append("y"); break;
                                    case 5: str.Append("z"); break;
                                }
                                break;
                            }
                        case '0':
                            {
                                switch (codeLength)
                                {
                                    case 1: str.Append("0"); break;
                                    case 2: str.Append(" "); break;
                                }
                                break;
                            }
                    }
                }
            }

            return str.ToString();
        }

        private void UpdateResultTextLabel()
        {
            resultText = GetText(GetCharacterCodes(numbers));
            resultTextLabel.Text = resultText;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numbers += "1";
            UpdateResultTextLabel();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numbers += "2";
            UpdateResultTextLabel();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numbers += "3";
            UpdateResultTextLabel();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numbers += "4";
            UpdateResultTextLabel();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numbers += "5";
            UpdateResultTextLabel();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numbers += "6";
            UpdateResultTextLabel();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numbers += "7";
            UpdateResultTextLabel();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numbers += "8";
            UpdateResultTextLabel();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numbers += "9";
            UpdateResultTextLabel();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            numbers += "0";
            UpdateResultTextLabel();
        }
    }
}