using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TFCalc
{
    public partial class Form1 : Form
    {
        decimal input, output, total;

        bool cashClick, visaClick, mcClick, amexClick, itClick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            cashClick = true;
            onClick();
        }

        private void visa_Click(object sender, EventArgs e)
        {
            visaClick = true;
            onClick();
        }

        private void mc_Click(object sender, EventArgs e)
        {
            mcClick = true;
            onClick();
        }

        private void amex_Click(object sender, EventArgs e)
        {
            amexClick = true;
            onClick();
        }

        private void it_Click(object sender, EventArgs e)
        {
            itClick = true;
            onClick();
        }

        private void Convert(decimal fee, decimal input)
        {
            output = input-(input*(fee/100));
            total += output;
        }

        private void onClick()
        {
            if (!Decimal.TryParse(cinText.Text, out input))
            {
                coutText.Text = "$Error!";
            }
            else
            {
                if (cashClick)
                {
                    Convert(cashFee.Value, input);
                    cashClick = false;
                }
                if (visaClick)
                {
                    Convert(visaFee.Value, input);
                    visaClick = false;
                }
                if (mcClick)
                {
                    Convert(mcFee.Value, input);
                    mcClick = false;
                }
                if (amexClick)
                {
                    Convert(amexFee.Value, input);
                }
                if (itClick)
                {
                    Convert(itFee.Value, input);
                }

                coutText.Text = $"${output.ToString("#.##")}";
                totText.Text = $"${total.ToString("#.##")}";
                cinText.Clear();
            }            
        }
    }
}
