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
    public partial class WithdrawForm : Form
    {

        SQLQueries queries = new SQLQueries();
        public int UserId;
        public WithdrawForm(string id)
        {
            InitializeComponent();
            UserId = Convert.ToInt32(id);
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
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
                    queries.ExpenseInsert(amount, dateTimePicker1.Value, DescriptionBox.Text, comboBox1.Text, UserId);
                    MessageBox.Show("Expense Captured");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
