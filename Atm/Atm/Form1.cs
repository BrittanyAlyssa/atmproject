using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{
    public partial class Form1 : Form
    {

        SQLQueries myQueries = new SQLQueries();
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = myQueries.IdentifierUser(userNamebox.Text, passwordBox.Text);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm startMain = new MainForm(dt.Rows[0][0].ToString(), dt.Rows[0][3].ToString());
                    startMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
