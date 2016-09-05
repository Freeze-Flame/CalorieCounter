using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTotalCalories.Text = "0";
        }

        private void lblTotalCalories_Click(object sender, EventArgs e)
        {

        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            int totalCalories = int.Parse(lblTotalCalories.Text);
            totalCalories += 115;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            int totalCalories = int.Parse(lblTotalCalories.Text);
            totalCalories += 80;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            int totalCalories = int.Parse(lblTotalCalories.Text);
            totalCalories += 90;
            lblTotalCalories.Text = totalCalories.ToString();
        }

        private void btnPear_Click(object sender, EventArgs e)
        {
            int totalCalories = int.Parse(lblTotalCalories.Text);
            totalCalories += 120;
            lblTotalCalories.Text = totalCalories.ToString();
        }
    }
}
