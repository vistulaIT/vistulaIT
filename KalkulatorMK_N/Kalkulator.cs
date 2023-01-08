using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace KalkulatorMK
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtOperation.Clear();
            txtOperation.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text.Length > 0)
            {
                txtOperation.Text = txtOperation.Text.Remove(txtOperation.Text.Length - 1, 1);
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

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}