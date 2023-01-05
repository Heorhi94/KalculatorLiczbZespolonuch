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
       

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if(z1.Minus(z1, z2).xI > 0)
            {
                textResult.Text = Convert.ToString(z1.Minus(z1, z2).xR) + " + i" + Convert.ToString(z1.Minus(z1, z2).xI);
            }
            else
            {
                textResult.Text = Convert.ToString(z1.Minus(z1, z2).xR) + " + i(" + Convert.ToString(z1.Minus(z1, z2).xI+")");
            }
            
        }

        private void bmultiply_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if(z1.Multipl(z1, z2).xI > 0)
            {
                textResult.Text = Convert.ToString(z1.Multipl(z1, z2).xR) + " + i" + Convert.ToString(z1.Multipl(z1, z2).xI);
            }
            else
            {
                textResult.Text = Convert.ToString(z1.Multipl(z1, z2).xR) + " + i(" + Convert.ToString(z1.Multipl(z1, z2).xI)+")";
            }
            
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if(z1.Divine(z1, z2).xI > 0)
            {
                textResult.Text = Convert.ToString(z1.Divine(z1, z2).xR) + " + i" + Convert.ToString(z1.Divine(z1, z2).xI);
            }
            else
            {
                textResult.Text = Convert.ToString(z1.Divine(z1, z2).xR) + " + i(" + Convert.ToString(z1.Divine(z1, z2).xI)+")";
            }
            
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if (z1.Sum(z1, z2).xI > 0)
            {
                textResult.Text = Convert.ToString(z1.Sum(z1, z2).xR) + " + i" + Convert.ToString(z1.Sum(z1, z2).xI);
            }
            else
            {
                textResult.Text = Convert.ToString(z1.Sum(z1, z2).xR) + " + i(" + Convert.ToString(z1.Sum(z1, z2).xI + ")");
            }

        }

        private void ComplexData(Complexs z1,Complexs z2, double x1,double i1, double x2, double i2)
        {
            x1 = Convert.ToDouble(textVal1Real.Text);
            i1 = Convert.ToDouble(textVal1Imgnr.Text);
            x2 = Convert.ToDouble(textVal2Real.Text);
            i2 = Convert.ToDouble(textVal2Imgnr.Text);
            z1.xR = x1;
            z2.xR = x2;
            z1.xI = i1;
            z2.xI = i2;
        }

        private void textVal1Real_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 13 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textVal1Imgnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 13 && number != 45)
            {
                e.Handled = true;
            }

        }

        private void textVal2Real_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 13 && number != 45)
            {
                e.Handled = true;
            }

        }


        private void blogicequals_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if(z1.xR==z2.xR && z1.xI == z2.xI)
            {
                textResult.Text = "true";
            }
            else
            {
                textResult.Text = "false";
            }

        }

        private void bnotEquals_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if (z1.xR == z2.xR && z1.xI == z2.xI)
            {
                textResult.Text = "false";
            }
            else
            {
                textResult.Text = "true";
            }
        }

        private void bMore_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if (z1.xR > z2.xR && z1.xI > z2.xI)
            {
                textResult.Text = "true";
            }
            else
            {
                textResult.Text = "false";
            }
        }

        private void bLess_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            if (z1.xR < z2.xR && z1.xI < z2.xI)
            {
                textResult.Text = "true";
            }
            else
            {
                textResult.Text = "false";
            }
        }

        private void textVal2Imgnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 13 && number!=45)
            {
                e.Handled = true;
            }
        }

        private void bGetHashCode_Click(object sender, EventArgs e)
        {
            int r = z1.GetHashCode();
            int g = z2.GetHashCode();
            if (r > g)
            {
                textResult.Text = "Z1 > Z2";
            }
            else if(g > r)
            {
                textResult.Text = "Z1 < Z2";
            }
            else
            {
                textResult.Text = "Z1 = Z2";
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bEquals_Click(object sender, EventArgs e)
        {
            ComplexData(z1, z2, x1, i1, x2, i2);
            textResult.Text = z1.Equals(z2).ToString();
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

     

      
    }
}
