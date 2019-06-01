using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Project
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            #region search sql

            string query = @"select * from account_tbl where username='"+ logtxt.Text + "' and password='"+passtxt.Text+"';";
            SqlConnection connection;
            try
            {


                using (connection = new SqlConnection(Info.DB_connect))
                {
                    connection.Open();


                    using (SqlDataAdapter a = new SqlDataAdapter(query, connection))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        listBox1.DisplayMember = "username";
                        listBox1.ValueMember = "username";
                        listBox1.DataSource = t;

                        listBox2.DisplayMember = "password";
                        listBox2.ValueMember = "password";
                        listBox2.DataSource = t;


                        if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 0)
                        {
                            Main main = new Main();
                            main.Show();                           
                            this.Hide();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");

                        }
                        
                       

                    }


                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "textBox1_TextChanged:\n" + exc.ToString() + "\n\n");

            }

            #endregion


            

        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            #region Text Auto Size
            logtxt.AutoSize = false;
            logtxt.Height = 30;
            passtxt.AutoSize = false;
            passtxt.Height = 30;
            #endregion
            #region Label Auto Size
            loglabel.Height = 50;
            passlabel.Height = 50;
            #endregion
            #region Picture Box Size Edit
            logpb.Height = 50;
            logpb.Width = 52;
            passpb.Height = 50;
            passpb.Width = 52;
            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Sign_in signin = new Sign_in();
            signin.ShowDialog();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.Blue)
            {
                label1.ForeColor = Color.Red;
            }
            else if (label1.ForeColor==Color.Red)
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void logpb_Click(object sender, EventArgs e)
        {

        }

        private void loglabel_Click(object sender, EventArgs e)
        {

        }

        private void logtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passpb_Click(object sender, EventArgs e)
        {

        }

        private void passlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
