using System.Text;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string? numbers = string.Empty;
        private List<string>? numbersList = new();
        private string? resultText = string.Empty;
        private Dictionary<char, int> totalValues = new()
        {
            {'1', 2 },
            {'2', 4 },
            {'3', 4 },
            {'4', 4 },
            {'5', 4 },
            {'6', 4 },
            {'7', 5 },
            {'8', 4 },
            {'9', 5 },
            {'0', 3 },
            {'*', 2 },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private List<string>? GetCharacterCodes(string? input)
        {
            var res = new List<string>();

            if (input is not null)
            {
                var temp = input.Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var c in temp)
                {
                    if (c.All(t => t == c.Last()))
                    {
                        res.Add(c);
                    }
                    else
                    {
                        int i = c.Length - 1;
                        var currentChar = c.Last();
                        int j = 1;

                        while (c[i] == currentChar && i > 0)
                        {
                            j++;
                            i--;
                        }
                        res.Add(c.Substring(i + 1, j - 1));
                    }

                }
            }

            return res;
        }

        private string? GetText(List<string>? input)
        {
            var str = new StringBuilder();

            if (input is not null)
            {

                foreach (var code in input)
                {
                    var codeLength = code.Length;

                    switch (code.First())
                    {
                        case '1':
                            {
                                switch (codeLength % totalValues['1'])
                                {
                                    case 1: str.Append("1"); break;
                                    case 0: str.Append("@"); break;
                                }
                                break;
                            }
                        case '2':
                            {
                                switch (codeLength % totalValues['2'])
                                {
                                    case 1: str.Append("2"); break;
                                    case 2: str.Append("a"); break;
                                    case 3: str.Append("b"); break;
                                    case 0: str.Append("c"); break;
                                }
                                break;
                            }
                        case '3':
                            {
                                switch (codeLength % totalValues['3'])
                                {
                                    case 1: str.Append("3"); break;
                                    case 2: str.Append("d"); break;
                                    case 3: str.Append("e"); break;
                                    case 0: str.Append("f"); break;
                                }
                                break;
                            }
                        case '4':
                            {
                                switch (codeLength % totalValues['4'])
                                {
                                    case 0: str.Append("4"); break;
                                    case 1: str.Append("g"); break;
                                    case 2: str.Append("h"); break;
                                    case 3: str.Append("i"); break;
                                }
                                break;
                            }
                        case '5':
                            {
                                switch (codeLength % totalValues['5'])
                                {
                                    case 1: str.Append("5"); break;
                                    case 2: str.Append("j"); break;
                                    case 3: str.Append("k"); break;
                                    case 0: str.Append("l"); break;
                                }
                                break;
                            }
                        case '6':
                            {
                                switch (codeLength % totalValues['6'])
                                {
                                    case 1: str.Append("6"); break;
                                    case 2: str.Append("m"); break;
                                    case 3: str.Append("n"); break;
                                    case 0: str.Append("o"); break;
                                }
                                break;
                            }
                        case '7':
                            {
                                switch (codeLength % totalValues['7'])
                                {
                                    case 1: str.Append("7"); break;
                                    case 2: str.Append("p"); break;
                                    case 3: str.Append("q"); break;
                                    case 4: str.Append("r"); break;
                                    case 0: str.Append("s"); break;
                                }
                                break;
                            }
                        case '8':
                            {
                                switch (codeLength % totalValues['8'])
                                {
                                    case 1: str.Append("8"); break;
                                    case 2: str.Append("t"); break;
                                    case 3: str.Append("u"); break;
                                    case 0: str.Append("v"); break;
                                }
                                break;
                            }
                        case '9':
                            {
                                switch (codeLength % totalValues['9'])
                                {
                                    case 1: str.Append("9"); break;
                                    case 2: str.Append("w"); break;
                                    case 3: str.Append("x"); break;
                                    case 4: str.Append("y"); break;
                                    case 0: str.Append("z"); break;
                                }
                                break;
                            }
                        case '0':
                            {
                                switch (codeLength % totalValues['0'])
                                {
                                    case 1: str.Append("0"); break;
                                    case 2: str.Append("+"); break;
                                    case 0: str.Append(" "); break;
                                }
                                break;
                            }
                        case '*':
                            {
                                switch (codeLength % totalValues['*'])
                                {
                                    case 1: str.Append("*"); break;
                                    case 0:
                                        {
                                            //TODO

                                            break;
                                        }
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
            numbersList = GetCharacterCodes(numbers);
            resultText = GetText(numbersList);
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            numbers += "|";
            UpdateResultTextLabel();
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            numbers += "*";
            UpdateResultTextLabel();
        }
    }
}