using System;
using System.Windows.Forms;
using Evaluator.Core;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
                txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = txtDisplay.Text;
                double result = ExpressionEvaluator.Evaluate(expr);
                txtDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Evaluador");
            }
        }
    }
}
