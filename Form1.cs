using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2023
{
    public partial class Calculator : Form
    {
        double num1, num2, result;
        string operation;

        public Calculator()
        {
            InitializeComponent();

            this.lblScreen.Focus();

            this.btnOne.Click += BtnOne_Click;
            this.btnTwo.Click += BtnTwo_Click;
            this.btnThree.Click += BtnThree_Click;
            this.btnFour.Click += BtnFour_Click;
            this.btnFive.Click += BtnFive_Click;
            this.btnSix.Click += BtnSix_Click;
            this.btnSeven.Click += BtnSeven_Click;
            this.btnEight.Click += BtnEight_Click;
            this.btnNine.Click += BtnNine_Click;
            this.btnZero.Click += BtnZero_Click;

            this.btnAddition.Click += BtnAddition_Click;
            this.btnSubtraction.Click += BtnSubtraction_Click;
            this.btnSlash.Click += BtnSlash_Click;
            this.btnMultiplication.Click += BtnMultiplication_Click;

            this.btnClear.Click += BtnClear_Click;

            this.btnEqual.Click += BtnEqual_Click;
        }

        /// <summary>
        /// Handles the Click event of the Equal button.
        /// </summary>
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(lblScreen.Text);

            if (operation == "*")
            {
                result = num1 * num2;
                lblScreen.Text = Convert.ToString(result);
            }
            else if (operation == "/")
            {
                result = num1 / num2;
                lblScreen.Text = Convert.ToString(result);
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                lblScreen.Text = Convert.ToString(result);
            }
            else if (operation == "+")
            {
                result = num1 + num2;
                lblScreen.Text = Convert.ToString(result);
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button.
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblScreen.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the * button.
        /// </summary>
        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            operation = "*";

            num1 = double.Parse(lblScreen.Text);

            lblScreen.Text = "0";
            
        }

        /// <summary>
        /// Handles the Click event of the Slash button.
        /// </summary>
        private void BtnSlash_Click(object sender, EventArgs e)
        {
            operation = "/";

            num1 = double.Parse(lblScreen.Text);

            lblScreen.Text = "0";
        }

        /// <summary>
        /// Handles the Click event of the Subtraction button.
        /// </summary>
        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            operation = "-";

            num1 = double.Parse(lblScreen.Text);

            lblScreen.Text = "0";
        }

        /// <summary>
        /// Handles the Click event of the Addition button.
        /// </summary>
        private void BtnAddition_Click(object sender, EventArgs e)
        {
            operation = "+";

            num1 = double.Parse(lblScreen.Text);

            lblScreen.Text = "0";
        }

        /// <summary>
        /// Handles the Click event of the Zero button.
        /// </summary>
        private void BtnZero_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 0;
        }

        /// <summary>
        /// Handles the Click event of the Nine button.
        /// </summary>
        private void BtnNine_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 9;
        }

        /// <summary>
        /// Handles the Click event of the Eight button.
        /// </summary>
        private void BtnEight_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 8;
        }

        /// <summary>
        /// Handles the Click event of the Seven button.
        /// </summary>
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 7;
        }

        /// <summary>
        /// Handles the Click event of the Six button.
        /// </summary>
        private void BtnSix_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 6;
        }

        /// <summary>
        /// Handles the Click event of the Five button.
        /// </summary>
        private void BtnFive_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 5;
        }

        /// <summary>
        /// Handles the Click event of the Four button.
        /// </summary>
        private void BtnFour_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 4;
        }

        /// <summary>
        /// Handles the Click event of the Three button.
        /// </summary>
        private void BtnThree_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 3;
        }

        /// <summary>
        /// Handles the Click event of the Two button.
        /// </summary>
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 2;
        }

        /// <summary>
        /// Handles the Click event of the One button.
        /// </summary>
        private void BtnOne_Click(object sender, EventArgs e)
        {
            lblScreen.Text += 1;
        }
    }
}
