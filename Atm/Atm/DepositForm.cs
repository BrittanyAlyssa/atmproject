using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{
    public partial class DepositForm : Form
    {

        SQLQueries queries = new SQLQueries();
        public int UserId;
        public DepositForm(int userid)
        {
            InitializeComponent();
            UserId = userid;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AmountBox.Text == "" && DescriptionBox.Text == "" && comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Required fields missing");
            }
            else
            {
                try
                {
                    double amount = Convert.ToDouble(AmountBox.Text);
                    queries.InsertDeposit(amount, dateTimePicker1.Value, DescriptionBox.Text, comboBox1.Text, UserId);
                    MessageBox.Show("Deposit Captured");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
