using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace KalkulatorMK
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
            txtOperation.Text = "0";
        }

        enum Signs
        {
            Add,
            Deduct,
            Multiply,
            Divide,
            None
        }

        private string FirstValue = string.Empty;
        private string SecondValue = string.Empty;
        private Signs _signs = Signs.None;

        private void button_Click(object sender, EventArgs e)
        {
            var ClickNumber = (sender as Button)!.Text;

            if (txtOperation.Text == "0")
            {
                txtOperation.Text = "";

                if (ClickNumber == ",")
                {
                    txtOperation.Text = "0";
                    btnPoint.Enabled = false;
                }
            }
            else if (ClickNumber == ",")
            {
                btnPoint.Enabled = false;
            }

            txtOperation.Text += ClickNumber;
            SetResultButtonState(true);

            if (_signs != Signs.None)
                SecondValue += ClickNumber;
            else
                SetOperationButtonState(true);
        }

        private void SetResultButtonState(bool value)
        {
            btnEqual.Enabled = value;
        }

        private void SetOperationButtonState(bool value)
        {
            btnAdd.Enabled = value;
            btnMultiply.Enabled = value;
            btnDivide.Enabled = value;
            btnDeduct.Enabled = value;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            FirstValue = txtOperation.Text;

            var ClickOperation = (sender as Button)!.Text;

            _signs = ClickOperation switch
            {
                "+" => Signs.Add,
                "-" => Signs.Deduct,
                "/" => Signs.Divide,
                "*" => Signs.Multiply,
                _ => Signs.None,
            };

            btnPoint.Enabled = true;

            txtOperation.Text += $" {ClickOperation} ";

            SetOperationButtonState(false);
            SetResultButtonState(false);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (_signs == Signs.None)
                return;

            var FirstNumber = double.Parse(FirstValue);
            var SecondNumber = double.Parse(SecondValue);

            var Result = Calculate(FirstNumber, SecondNumber);

            txtOperation.Text = Result.ToString();
            SecondValue = string.Empty;
            _signs = Signs.None;
            SetOperationButtonState(true);
            SetResultButtonState(true);
        }

        private double Calculate(double FirstNumber, double SecondNumber)
        {
            switch (_signs)
            {
                case Signs.None:
                    return FirstNumber;
                case Signs.Add:
                    return FirstNumber + SecondNumber;
                case Signs.Deduct:
                    return FirstNumber - SecondNumber;
                case Signs.Divide:
                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0!", "B³¹d dzia³ania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return 0;
                    }
                    return FirstNumber / SecondNumber;
                case Signs.Multiply:
                    return FirstNumber * SecondNumber;
            }

            return 0;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtOperation.Clear();
            txtOperation.Text = "0";
            btnPoint.Enabled = true;
            SetOperationButtonState(true);
            SetResultButtonState(true);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text.Length > 0)
            {
                txtOperation.Text = txtOperation.Text.Remove(txtOperation.Text.Length - 1, 1);
            }
            if (txtOperation.Text == "")
            {
                txtOperation.Text = "0";
            }
        }

        private void buttonNWW_Click(object sender, EventArgs e)
        {
            var Operation = (sender as Button)!.Text;

            string FirstNumber = Microsoft.VisualBasic.Interaction.InputBox("Podaj pierwsz¹ liczbê do policzenia NWW:", "Kalkulator NWW");
            string SecondNumber = Microsoft.VisualBasic.Interaction.InputBox("Podaj drug¹ liczbê do policzenia NWW:", "Kalkulator NWW");

            double a, b;

            if (double.TryParse(FirstNumber, out a) && a > 0 && double.TryParse(SecondNumber, out b) && b > 0)
            {
                if (Operation == "NWW")
                {
                    double NWW = Calc_NWW(a, b);
                    txtOperation.Text = "NWW: " + NWW;
                }
            }
        }

        private void buttonNWD_Click(object sender, EventArgs e)
        {
            var Operation = (sender as Button)!.Text;

            string FirstNumber = Microsoft.VisualBasic.Interaction.InputBox("Podaj pierwsz¹ liczbê do policzenia NWD:", "Kalkulator NWD");
            string SecondNumber = Microsoft.VisualBasic.Interaction.InputBox("Podaj drug¹ liczbê do policzenia NWD:", "Kalkulator NWD");

            double a, b;

            if (double.TryParse(FirstNumber, out a) && a > 0 && double.TryParse(SecondNumber, out b) && b > 0)
            {
                if (Operation == "NWD")
                {
                    double NWD = Calc_NWD(a, b);
                    txtOperation.Text = "NWD: " + NWD;
                }
            }
        }

        private double Calc_NWW(double a, double b)
        {
            return a * b / Calc_NWD(a, b);
        }

        private double Calc_NWD(double a, double b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
    }
}