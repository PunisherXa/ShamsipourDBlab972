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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        bool userexist = false;
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ruser.Text == "" || rpass.Text == "")
            {
                MessageBox.Show("لطفا فیلد ها را پر نمایید");
            }
            #region Creating Account (If Its Filled)
            else
            {
                try
                {

                    if (userexist)
                    {
                        MessageBox.Show("نام کاربری وجود دارد");
                    }
                    else
                    {
                        userexist = false;
                        #region Insert Query
                        SqlConnection connection = new SqlConnection(Info.DB_connect);
                        connection.Open();

                        string query = @"insert into account_tbl(username,password) values ('" + ruser.Text + "','" + rpass.Text + "');";
                        SqlCommand cmd = new SqlCommand(query, connection);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            reader.GetString(0);
                        }
                        #endregion
                        MessageBox.Show("اکانت جدید با موفقیت اضافه شد");

                        ruser.Clear();
                        rpass.Clear();
                   //     textBox3.Clear();

                    }

                }
                catch (SqlException sqlexc)
                {
                    File.AppendAllText(@"Errors.err", "btn_insert_Click(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
                }
                catch (Exception exc)
                {
                    File.AppendAllText(@"Errors.err", "btn_insert_Click:\n" + exc.ToString() + "\n\n");
                }                
                
                this.Close();

            }
            #endregion
            

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            login.ShowDialog();
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                #region Select Query
                string query1 = @"select * from account_tbl where username='" + ruser.Text + "' ;";
                SqlConnection connection1;
                using (connection1 = new SqlConnection(Info.DB_connect))
                {
                    connection1.Open();
                    using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        listBox1.DisplayMember = "username";
                        listBox1.ValueMember = "username";
                        listBox1.DataSource = t;

                        if (listBox1.Items.Count >= 1)
                        {
                            userexist = true;
                        }
                        else
                        {
                            userexist = false;
                        }
                }
                #endregion
                
                }
            }
            catch (SqlException sqlexc)
            {
                File.AppendAllText(@"Errors.err", "btn_insert_Click(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "btn_insert_Click:\n" + exc.ToString() + "\n\n");
            }
        }
    }
}
