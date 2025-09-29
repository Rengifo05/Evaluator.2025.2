namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClear, btnEquals, btnDecimal;
        private System.Windows.Forms.Button[] btnNumbers;
        private System.Windows.Forms.Button btnAdd, btnSubtract, btnMultiply, btnDivide;
        private System.Windows.Forms.Button btnParenOpen, btnParenClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button[10];
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnParenOpen = new System.Windows.Forms.Button();
            this.btnParenClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 23);
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.btnClear.Location = new System.Drawing.Point(12, 50);
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnEquals.Location = new System.Drawing.Point(212, 238);
            this.btnEquals.Size = new System.Drawing.Size(60, 40);
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            int x = 12, y = 100;
            for (int i = 1; i <= 9; i++)
            {
                this.btnNumbers[i] = new System.Windows.Forms.Button();
                this.btnNumbers[i].Size = new System.Drawing.Size(60, 40);
                this.btnNumbers[i].Location = new System.Drawing.Point(x, y);
                this.btnNumbers[i].Text = i.ToString();
                this.btnNumbers[i].Click += new System.EventHandler(this.BtnNumber_Click);

                x += 66;
                if (i % 3 == 0)
                {
                    x = 12;
                    y += 46;
                }
            }

            this.btnNumbers[0] = new System.Windows.Forms.Button();
            this.btnNumbers[0].Location = new System.Drawing.Point(78, 238);
            this.btnNumbers[0].Size = new System.Drawing.Size(60, 40);
            this.btnNumbers[0].Text = "0";
            this.btnNumbers[0].Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnDecimal.Location = new System.Drawing.Point(144, 238);
            this.btnDecimal.Size = new System.Drawing.Size(60, 40);
            this.btnDecimal.Text = ".";
            this.btnDecimal.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnAdd.Location = new System.Drawing.Point(212, 100);
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnSubtract.Location = new System.Drawing.Point(212, 146);
            this.btnSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnMultiply.Location = new System.Drawing.Point(212, 192);
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnDivide.Location = new System.Drawing.Point(144, 50);
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnParenOpen.Location = new System.Drawing.Point(78, 50);
            this.btnParenOpen.Size = new System.Drawing.Size(30, 40);
            this.btnParenOpen.Text = "(";
            this.btnParenOpen.Click += new System.EventHandler(this.BtnNumber_Click);

            this.btnParenClose.Location = new System.Drawing.Point(114, 50);
            this.btnParenClose.Size = new System.Drawing.Size(30, 40);
            this.btnParenClose.Text = ")";
            this.btnParenClose.Click += new System.EventHandler(this.BtnNumber_Click);

            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnParenOpen);
            this.Controls.Add(this.btnParenClose);

            for (int i = 0; i <= 9; i++)
                this.Controls.Add(this.btnNumbers[i]);

            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Text = "Evaluador de Funciones";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
