using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeTaxCal.WinForms
{
    public partial class Form1 : Form
    {
        IncomeTaxCalFinder calc = new IncomeTaxCalFinder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            calc.Income = decimal.Parse(txtIncomeBox.Text);
            //if(calc.Income < 0)
            //{

            //}
            calc.State = combState.Text;
            txtNewIncome.Text = calc.taxableIncome().ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combState.Items.Clear();
            combState.Items.AddRange(calc.ListOfStates.ToArray());
        }
    }
}
