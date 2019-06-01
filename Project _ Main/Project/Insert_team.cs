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
    public partial class Insert_team : Form
    {
        public Insert_team()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                #region Insert Query
                SqlConnection connection = new SqlConnection(Info.DB_connect);
                connection.Open();

                string query = @"insert into team_tbl(name,cloth_color_1 ,cloth_color_2,rank,point) values (N'" + txt_name.Text + "',N'" + txt_color1.Text + "',N'" + txt_color2.Text + "',0,0);";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetString(0);
                }
                #endregion

                MessageBox.Show("تیم جدید با موفقیت اضافه شد");

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

        private void Insert_team_Load(object sender, EventArgs e)
        {

        }
    }
}
