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
        List<IncomeTaxCalFinder> CalcHistory = new List<IncomeTaxCalFinder>();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncomeTaxCalFinder calc = new IncomeTaxCalFinder();
            calc.Income = decimal.Parse(txtIncomeBox.Text);
            if(calc.Income < 0)
            {
                MessageBox.Show("Income can not be less then zero.");
                Application.Exit();
            }
            calc.State = combState.Text;
            txtNewIncome.Text = calc.taxableIncome().ToString("c");
            CalcHistory.Count();
            CalcHistory.Add(calc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IncomeTaxCalFinder calc = new IncomeTaxCalFinder();
            combState.Items.Clear();
            combState.Items.AddRange(calc.ListOfStates.ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabSystem.SelectedTab == historyTab)
            {
                dataGridView1.Rows.Clear();
                foreach (var c in CalcHistory)
                {
                    dataGridView1.Rows.Add(c.Income, c.State, c.NewIncome);
                }
            }
        }
    }
}
