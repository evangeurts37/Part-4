using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        int rando;
        int intmax;
        int intmin;
        double dmin;
        double dmax;
        string randoString;
        double randoDouble;
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {

            lblAnswer.Visible = true;
            intmin = Convert.ToInt32(txtMin.Text);
            intmax = Convert.ToInt32(txtMax.Text);
            rando = generator.Next(intmin, intmax + 1);
            randoString = Convert.ToString(rando);
            lblAnswer.Text = randoString;
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {

            lblAnswer.Visible = true;
            dmin = Convert.ToDouble(txtMin.Text);
            dmax = Convert.ToDouble(txtMax.Text);
            randoDouble = generator.NextDouble() *(dmax-dmin) + dmin;
            randoString = Convert.ToString(randoDouble);
            lblAnswer.Text = randoString;

        }
    }
}
