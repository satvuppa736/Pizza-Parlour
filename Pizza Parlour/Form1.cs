using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class pizzaParlour : Form
    {
        const double LABOUR = 1.00;
        const double STORE = 1.50;
        const double MATERIAL = 0.5;
        double diameter;
        double cost;


        public pizzaParlour()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                diameter = Convert.ToInt16(inputBox.Text);
                cost = LABOUR + STORE + MATERIAL * diameter;
                outputLabel.Text = "The total cost for  your pizza is " + cost.ToString("C");
            }

            catch
            {
                outputLabel.Text = "Stop wasting my time and enter a diameter amount!";
            }





        }
    }
}