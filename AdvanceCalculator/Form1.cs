using System.Linq.Expressions;

namespace AdvanceCalculator
{
    public partial class Form1 : Form
    {
        double First_Value, Second_Value;
        String Operation;
        List<string> historyList = new List<string>();
        private double MemoryVariable = 0;


        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 832;
            txtResult.Width = 767;
            ExitBtn.Location = new Point(707, 28);
            MaximizeButton.Location = new Point(600, 28);
            MinimizeButton.Location = new Point(484, 28);
            Historybutton.Location = new Point(735, 23);
        }


        private void NumbersEntry(object sender, EventArgs e)
        {
            Button numberButton = (Button)sender;

            if (numberButton.Text == ".")
            {
                if (!txtResult.Text.Contains('.'))
                {
                    txtResult.Text += numberButton.Text;
                }
            }
            else
            {
                if (txtResult.Text == "0")
                {
                    txtResult.Text = numberButton.Text;
                }
                else
                {
                    txtResult.Text += numberButton.Text;
                }
            }
        }



        private void HandleOperations(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;

            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                First_Value = double.Parse(txtResult.Text);
                Operation = operatorButton.Text;
                txtResult.Text = "0";
            }

        }

        private void HandleEquals(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                Second_Value = double.Parse(txtResult.Text);

                string expression = $"{First_Value} {Operation} {Second_Value}";
                string result = "";

                switch (Operation)
                {
                    case "+":
                        result = (First_Value + Second_Value).ToString();
                        break;
                    case "-":
                        result = (First_Value - Second_Value).ToString();
                        break;
                    case "X":
                        result = (First_Value * Second_Value).ToString();
                        break;
                    case "/":
                        if (Second_Value != 0)
                        {
                            result = (First_Value / Second_Value).ToString();
                        }
                        else
                        {
                            result = "Error";
                        }
                        break;
                    case "^":
                        double powerResult = Math.Pow(First_Value, Second_Value);
                        result = powerResult.ToString();
                        break;
                }

                txtResult.Text = result;

                string historyEntry = $"{expression} = {result}";
                historyList.Add(historyEntry);
            }
        }


        private void HandleClear(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void handlePms(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text) && txtResult.Text != "0")
            {
                double currentValue = double.Parse(txtResult.Text);
                txtResult.Text = (currentValue * -1).ToString();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 832;
            txtResult.Width = 767;
            ExitBtn.Location = new Point(707, 28);
            MaximizeButton.Location = new Point(600, 28);
            MinimizeButton.Location = new Point(484, 28);
            Historybutton.Location = new Point(735, 23);
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1632;
            txtResult.Width = 1568;
            ExitBtn.Location = new Point(1486, 25);
            MaximizeButton.Location = new Point(1379, 25);
            MinimizeButton.Location = new Point(1263, 25);
            Historybutton.Location = new Point(1537, 32);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Exit_calculator;
            Exit_calculator = MessageBox.Show("Are you Sure you want to Exit?", "Umair's Calculaor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit_calculator == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void HandlePi(object sender, EventArgs e)
        {
            double piValue = Math.PI;
            txtResult.Text = piValue.ToString();
        }

        private void handleLog(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text) && txtResult.Text != "0")
            {
                double currentValue = double.Parse(txtResult.Text);

                double result = Math.Log10(currentValue);
                txtResult.Text = result.ToString();
            }
            else
            {
                txtResult.Text = "Error";
            }
        }


        private void HandleSqrt(object sender, EventArgs e)
        {
            string expression = $"Sqrt of {txtResult.Text} ";
            double result = 0;
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                if (currentValue >= 0)
                {
                    result = Math.Sqrt(currentValue);
                    txtResult.Text = result.ToString();
                }
                else
                {
                    txtResult.Text = "Error";
                }

            }
            string historyEntry = $"{expression} = {result}";
            historyList.Add(historyEntry);
        }

        private void HandleSquare(object sender, EventArgs e)
        {
            string expression = $"Square of {txtResult.Text} ";
            double result = 0;
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                result = currentValue * currentValue;
                txtResult.Text = result.ToString();
            }
            string historyEntry = $"{expression} = {result}";
            historyList.Add(historyEntry);
        }

        private void HandleSinh(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                string expression = $"Sinh of {txtResult.Text} ";
                double result = Math.Sinh(double.Parse(txtResult.Text));
                txtResult.Text = result.ToString();

                string historyEntry = $"{expression}= {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleCosh(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);
                double result = Math.Cosh(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Cosh of {currentValue} = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleTanh(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);
                double result = Math.Tanh(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Tanh of {currentValue} = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleExp(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);
                double result = Math.Exp(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Exp of {currentValue} = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleMod(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                if (Second_Value != 0)
                {
                    double result = currentValue % Second_Value;
                    txtResult.Text = result.ToString();

                    string historyEntry = $"{currentValue} % {Second_Value} = {result}";
                    historyList.Add(historyEntry);
                }
                else
                {
                    txtResult.Text = "Error: Division by zero";
                }
            }
        }

        private void HandleOcta(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);
                int baseValue = 8;
                string octalResult = Convert.ToString((int)currentValue, baseValue);
                txtResult.Text = octalResult;

                string historyEntry = $"{currentValue} in octal = {octalResult}";
                historyList.Add(historyEntry);
            }
        }


        private void HandlePercentage(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);
                double percentageValue = currentValue / 100.0;

                txtResult.Text = percentageValue.ToString();

                string historyEntry = $"{currentValue} % = {percentageValue}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleLnX(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                if (currentValue > 0)
                {
                    double result = Math.Log(currentValue);
                    txtResult.Text = result.ToString();

                    string historyEntry = $"ln({currentValue}) = {result}";
                    historyList.Add(historyEntry);
                }
                else
                {
                    txtResult.Text = "Error";
                }
            }
        }

        private void HandleHexa(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                int baseValue = 16;
                string hexResult = Convert.ToString((int)currentValue, baseValue);
                txtResult.Text = hexResult;

                string historyEntry = $"{currentValue} in hexadecimal = {hexResult}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleTan(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                double result = Math.Tan(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Tan({currentValue}) = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleCos(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                double result = Math.Cos(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Cos({currentValue}) = {result}";
                historyList.Add(historyEntry);
            }
        }
        private void HandleBin(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                int baseValue = 2;

                string binResult = Convert.ToString((int)currentValue, baseValue);
                txtResult.Text = binResult;

                string historyEntry = $"{currentValue} in binary = {binResult}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleOneByX(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                if (currentValue != 0)
                {
                    double result = 1 / currentValue;
                    txtResult.Text = result.ToString();

                    string historyEntry = $"1 / {currentValue} = {result}";
                    historyList.Add(historyEntry);
                }
                else
                {
                    txtResult.Text = "Error";
                }
            }
        }

        private void HandleSin(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                double result = Math.Sin(currentValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"Sin({currentValue}) = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void HandleDec(object sender, EventArgs e)
        {
            double dec = double.Parse(txtResult.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = i2.ToString();

            string historyEntry = $"{dec} converted to integer = {i2}";
            historyList.Add(historyEntry);
        }

        private void HandleCube(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                double result = currentValue * currentValue * currentValue;
                txtResult.Text = result.ToString();

                string historyEntry = $"Cube of {currentValue} = {result}";
                historyList.Add(historyEntry);
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private double Factorial(double n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private void FactBtn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                double currentValue = double.Parse(txtResult.Text);

                if (currentValue >= 0 && currentValue == Math.Floor(currentValue))
                {
                    double result = Factorial(currentValue);
                    txtResult.Text = result.ToString();

                    string historyEntry = $"Factorial({currentValue}) = {result}";
                    historyList.Add(historyEntry);
                }
                else
                {
                    txtResult.Text = "Error: Invalid input for factorial";
                }
            }
        }

        private void HandleHistory(object sender, EventArgs e)
        {
            if (historyList.Count > 0)
            {
                string historyText = string.Join("\n", historyList);
                MessageBox.Show(historyText, "Operation History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No history available.", "Operation History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HandleMPlusButton(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtResult.Text))
                {
                    double currentValue = double.Parse(txtResult.Text);

                    MemoryVariable += currentValue;

                    txtResult.Text = "Memory Set: " + MemoryVariable.ToString();

                    string historyEntry = $"Memory added: {currentValue}, Total: {MemoryVariable}";
                    historyList.Add(historyEntry);
                }
            }
            catch (FormatException)
            {
                txtResult.Text = "Error: Invalid Input";
            }
        }

        private void HandleMMinusButton(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtResult.Text))
                {
                    double currentValue = double.Parse(txtResult.Text);

                    MemoryVariable -= currentValue;

                    txtResult.Text = "Memory Set: " + MemoryVariable.ToString();

                    string historyEntry = $"Memory subtracted: {currentValue}, Total: {MemoryVariable}";
                    historyList.Add(historyEntry);
                }
            }
            catch (FormatException)
            {
                txtResult.Text = "Error: Invalid Input";
            }
        }

        private void HandleMRButton(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = MemoryVariable.ToString();

                txtResult.Text = "Memory Recalled: " + MemoryVariable.ToString();
            }
            catch (FormatException)
            {
                txtResult.Text = "Error: Invalid Memory Value";
            }
        }

        private void HandleMCButton(object sender, EventArgs e)
        {
            try
            {
                MemoryVariable = 0;

                txtResult.Text = "Memory Cleared";

                string historyEntry = "Memory Cleared";
                historyList.Add(historyEntry);
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error: " + ex.Message;
            }
        }


        private bool isLightTheme = false;

        private void ChangeTheme(object sender, EventArgs e)
        {
            Color backgroundColor, textColor;

            if (isLightTheme)
            {
                backgroundColor = Color.FromArgb(33, 33, 33);
                textColor = Color.White;
                isLightTheme = false;
                MenuTitle.ForeColor = Color.White;

            }
            else
            {
                backgroundColor = Color.White;
                MenuTitle.ForeColor = Color.Black;
                textColor = Color.Black;
                isLightTheme = true;
            }

            SetColors(this, backgroundColor, textColor);
        }

        private void SetColors(Control control, Color backgroundColor, Color textColor)
        {
            control.BackColor = backgroundColor;

            if (control is TextBox)
            {
                ((TextBox)control).ForeColor = textColor;
            }
            else if (control is Button)
            {
                ((Button)control).ForeColor = textColor;
            }
            foreach (Control childControl in control.Controls)
            {
                SetColors(childControl, backgroundColor, textColor);
            }
        }
    }
}
