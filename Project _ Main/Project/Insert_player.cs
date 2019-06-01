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
    public partial class Insert_player : Form
    {
        public Insert_player()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {
                string date = combo_date_year.SelectedItem + "/" + combo_date_month.SelectedItem + "/" + combo_date_day.SelectedItem;

                #region Insert Query
                SqlConnection connection = new SqlConnection(Info.DB_connect);
                connection.Open();

                string query = @"insert into player_tbl(name,Birthday,Role,goals,team) values (N'" + txt_name.Text + "','" + date + "',N'" + combo_role.Text + "'," + num_goals.Value + ",N'" + combo_team.SelectedValue + "');";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetString(0);
                }
                #endregion


                MessageBox.Show("بازیکن جدید با موفقیت اضافه شد");
                
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

        private void Insert_player_Load(object sender, EventArgs e)
        {
            #region Select Query
            string query1 = @"select * from team_tbl order by name;";
            SqlConnection connection1;
            using (connection1 = new SqlConnection(Info.DB_connect))
            {
                connection1.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    combo_team.DisplayMember = "name";
                    combo_team.ValueMember = "name";
                    combo_team.DataSource = t;

                }


            }
            #endregion
               
        }
    }
}
