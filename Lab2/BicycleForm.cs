using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start, end;
            int total = 0;

            bool validStart = int.TryParse(txtStart.Text, out start);
            bool validEnd = int.TryParse(txtEnd.Text, out end);

            txtTotal.Text = "";
            lblDuration.Text = "Rental duration: -";

            if (!validStart || !validEnd)
            {
                MessageBox.Show("Invalid input. Enter whole numbers only.");
                return;
            }
            else if (start < 0 || start > 23 || end < 1 || end > 24 || start >= end)
            {
                MessageBox.Show("Start must be 0-23, end must be 1-24, and end must be after start.");
                return;
            }
            else
            {
                for (int hour = start; hour < end; hour++)
                {
                    if (hour < 7 || hour >= 21)
                    {
                        total = total + 500;
                    }
                    else if (hour < 14 || hour >= 19)
                    {
                        total = total + 1000;
                    }
                    else
                    {
                        total = total + 1500;
                    }
                }
            }

            lblDuration.Text = "Rental duration: " + (end - start) + " hours";
            txtTotal.Text = total + " RWF";
            MessageBox.Show("Rental from " + start + "h to " + end + "h\nTotal to pay: " + total + " RWF", "Bicycle Rental", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnBack_Click(object? sender, EventArgs e)
        {
            Close(); 
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort; 
            Close();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            txtTotal.Clear();
            lblDuration.Text = "Rental duration: -";
            txtStart.Focus();
        }

        private void inputs_TextChanged(object? sender, EventArgs e)
        {
            txtTotal.Clear();
            lblDuration.Text = "Rental duration: -";
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
