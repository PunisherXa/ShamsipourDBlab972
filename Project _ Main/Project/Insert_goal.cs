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
    public partial class Insert_goal : Form
    {
        public Insert_goal()
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

                string query = @"insert into goal_tbl(game,player,minute) values (N'" + combo_game.Text + "',N'" + combo_player.SelectedText + "'," + num_minute.Value + ");";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetString(0);
                }
                #endregion

                MessageBox.Show("گل جدید با موفقیت اضافه شد");

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

        private void Insert_goal_Load(object sender, EventArgs e)
        {
            #region Select Query
            string query1 = @"select * from game_tbl order by Id;";
            SqlConnection connection1;
            using (connection1 = new SqlConnection(Info.DB_connect))
            {
                connection1.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    combo_game.DisplayMember ="Id";
                    combo_game.ValueMember = "Id";
                    combo_game.DataSource = t;


                }


            }
            #endregion
            #region Select Query
            string query2 = @"select * from player_tbl order by name;";
            SqlConnection connection2;
            using (connection2 = new SqlConnection(Info.DB_connect))
            {
                connection2.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(query2, connection2))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    combo_player.DisplayMember = "name";
                    combo_player.ValueMember = "name";
                    combo_player.DataSource = t;


                }


            }
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
