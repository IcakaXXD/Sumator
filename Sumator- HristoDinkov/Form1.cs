using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator__HristoDinkov
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            try
            {
                var num1= decimal.Parse(this.number1.Text);
                var num2 = decimal.Parse(this.number2.Text);
                var sum = num1 + num2;
                Sum.Text= sum.ToString();
            }
            catch (Exception)
            {

                Sum.Text = "error";
            }
            
        }
    }
}
