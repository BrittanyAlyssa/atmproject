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
    public partial class MainForm : Form
    {
        public int UserId;
        SQLQueries queries = new SQLQueries();
        public MainForm(string userid, string username)
        {
            InitializeComponent();
            label2.Text = username;
            UserId = Convert.ToInt32(userid);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DepositBox_Click(object sender, EventArgs e)
        {
            DepositForm newDeposit = new DepositForm(UserId);
            newDeposit.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WithdrawForm newWithdraw = new WithdrawForm(UserId);
            newWithdraw.ShowDialog();

        }
    }
}
