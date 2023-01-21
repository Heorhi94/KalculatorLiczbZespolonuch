using Microsoft.Win32.SafeHandles;
using System;
using System.Numerics;
using System.Windows.Forms;

namespace KalculatorLiczbZespolonuch
{
    public partial class MainForm : Form
    {
       
        
        double x1, i1, x2, i2;
        Complexs z1 = new Complexs();
        Complexs z2 = new Complexs();
        Complexs result = new Complexs();


        public MainForm()
        {
            InitializeComponent();

        }

        private void ComplexData(Complexs z1, Complexs z2, double x1, double i1, double x2, double i2)
        {
            x1 = Convert.ToDouble(textVal1Real.Text);
            i1 = Convert.ToDouble(textVal1Imgnr.Text);
            x2 = Convert.ToDouble(textVal2Real.Text);
            i2 = Convert.ToDouble(textVal2Imgnr.Text);
            z1['r'] = x1;
            z2['r'] = x2;
            z1['i'] = i1;
            z2['i'] = i2;
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                result = z1 - z2;
                if (result['i'] >= 0)
                {

                    textResult.Text = $"{result['r']}+{result['i']}i";
                }
                else
                {
                    textResult.Text = $"{result['r']}{result['i']}i";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }
        }

        private void bmultiply_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                result = z1 * z2;
                if (result['i'] >= 0)
                {
                    textResult.Text = $"{result['r']}+{result['i']}i";

                }
                else
                {
                    textResult.Text = $"{result['r']}{result['i']}i";

                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }


        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                result = z1 / z2;
                if (result['i'] >= 0)
                {
                    textResult.Text = $"{result['r']}+{result['i']}i";
                }
                else
                {
                    textResult.Text = $"{result['r']}{result['i']}i";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }


        }

        private void bplus_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                result = z1 + z2;
                if (result['i'] >= 0)
                {
                    textResult.Text = $"{result['r']}+{result['i']}i";
                }
                else
                {
                    textResult.Text = $"{result['r']}{result['i']}i";
                }

            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }
        }
        private void blogicequals_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                if (z1 == z2)
                {
                    textResult.Text = "true";
                }
                else
                {
                    textResult.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }
        }

        private void bnotEquals_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                if (z1 != z2)
                {
                    textResult.Text = "true";
                }
                else
                {
                    textResult.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bMore_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);

                if (z1 > z2)
                {
                    textResult.Text = "true";
                }
                else
                {
                    textResult.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bLess_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);

                if (z1 < z2)
                {
                    textResult.Text = "true";
                }
                else
                {
                    textResult.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }



        private void bGetHashCode_Click(object sender, EventArgs e)
        {
            try
            {
                int r = z1.GetHashCode();
                int g = z2.GetHashCode();
                if (r > g)
                {
                    textResult.Text = "Z1 > Z2";
                }
                else if (g > r)
                {
                    textResult.Text = "Z1 < Z2";
                }
                else
                {
                    textResult.Text = "Z1 = Z2";
                }
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bInDouble_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                textResult.Clear();
                textResult.Text = Complexs.Indouble(z1, z2);
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bOnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                textResult.Clear();
                textResult.Text = Complexs.FromDouble(z1, z2);
               
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexData(z1, z2, x1, i1, x2, i2);
                textResult.Text = z1.Equals(z2).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter the data");
            }

        }

        private void bclear_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textResult.Clear();
            textVal1Real.Clear();
            textVal1Imgnr.Clear();
            textVal2Real.Clear();
            textVal2Imgnr.Clear();
        }

        private void textVal1Real_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 13 && number != 45)
            {
                e.Handled = true;
            }
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
