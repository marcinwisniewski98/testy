using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInsurance.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void calcCar_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(tValue.Text);
            double years = Double.Parse(tYears.Text);
            double volume = Double.Parse(tValue.Text);
            double hp = Double.Parse(tHP.Text);

            Calculator c = new Calculator();
            
            double result = c.calcCarValue(value, years, volume, hp);
            tInsuranceValue.Text = result.ToString();
        }

        private void driverCalc_Click(object sender, EventArgs e)
        {
            double age = Double.Parse(tAge.Text);
            double driverLicense = Double.Parse(tDriverLicense.Text);

            Calculator c = new Calculator();

            double result = c.calcDriverMod(age, driverLicense);
            tDriverModificator.Text = result.ToString();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(tValue.Text);
            double years = Double.Parse(tYears.Text);
            double volume = Double.Parse(tValue.Text);
            double hp = Double.Parse(tHP.Text);
            double age = Double.Parse(tAge.Text);
            double driverLicense = Double.Parse(tDriverLicense.Text);

            Calculator c = new Calculator();

            double result = c.calcResult(value, years, volume, hp, age, driverLicense);
            tTotalPrice.Text = result.ToString();
        }
    }
}
