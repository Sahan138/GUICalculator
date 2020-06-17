using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class GUICalculator : Form
    {
        public GUICalculator()
        {
            InitializeComponent();
        }

        private void funcadd_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToDouble(textNum1.Text);
            Global.num2 = Convert.ToDouble(textNum2.Text);

            lblDisplay.Text = (Global.num1 + Global.num2).ToString();
        }

        private void funcsub_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToDouble(textNum1.Text);
            Global.num2 = Convert.ToDouble(textNum2.Text);

            lblDisplay.Text = (Global.num1 - Global.num2).ToString();
        }

        private void funcmul_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToDouble(textNum1.Text);
            Global.num2 = Convert.ToDouble(textNum2.Text);

            lblDisplay.Text = (Global.num1 * Global.num2).ToString();
        }

        private void funcdiv_Click(object sender, EventArgs e)
        {
            Global.num1 = Convert.ToDouble(textNum1.Text);
            Global.num2 = Convert.ToDouble(textNum2.Text);

            lblDisplay.Text = (Global.num1 / Global.num2).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = null;
            textNum1.Text = null;
            textNum2.Text = null;
        }
    }
}
