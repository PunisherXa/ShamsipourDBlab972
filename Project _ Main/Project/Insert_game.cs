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
    public partial class Insert_game : Form
    {
        public Insert_game()
        {
            InitializeComponent();
        }
        int team1_point = 0, team2_point = 0;
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                
                string date = combo_date_year.SelectedItem + "/" + combo_date_month.SelectedItem + "/" + combo_date_day.SelectedItem;
               
                #region Insert Query
                SqlConnection connection = new SqlConnection(Info.DB_connect);
                connection.Open();

                string query = @"insert into game_tbl(first_team,second_team,date,first_team_goals,second_team_goals,week_num) values (N'" + combo_team1.SelectedValue + "',N'" + combo_team2.SelectedValue + "',N'" + date + "'," + num_team1_goals.Value + "," + num_team2_goals.Value + "," + num_week.Value + ");";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetString(0);
                }
                #endregion

                #region point
                if (num_team1_goals.Value < num_team2_goals.Value)
                {
                    #region Select Query
                    string query1 = @"select * from team_tbl where name='" + combo_team2.SelectedValue + "';";
                    SqlConnection connection1;
                    using (connection1 = new SqlConnection(Info.DB_connect))
                    {
                        connection1.Open();
                        using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            listBox2.DisplayMember = "point";
                            listBox2.ValueMember = "point";
                            listBox2.DataSource = t;

                            team2_point = Convert.ToInt32(listBox2.SelectedValue);
                            team2_point += 3;

                        }
                    }
                    #endregion

                    #region Insert Query
                    SqlConnection connection2 = new SqlConnection(Info.DB_connect);
                    connection2.Open();

                    string query2 = @"update team_tbl set point='" + team2_point + "' where name='" + combo_team2.SelectedValue + "' ";
                    SqlCommand cmd2 = new SqlCommand(query2, connection2);

                    SqlDataReader reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        reader2.GetString(0);
                    }
                    #endregion
                }
                if (num_team1_goals.Value == num_team2_goals.Value)
                {
                    #region Select Query
                    string query3 = @"select * from team_tbl where name='" + combo_team1.SelectedValue + "';";
                    SqlConnection connection3;
                    using (connection3 = new SqlConnection(Info.DB_connect))
                    {
                        connection3.Open();
                        using (SqlDataAdapter a = new SqlDataAdapter(query3, connection3))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            listBox1.DisplayMember = "point";
                            listBox1.ValueMember = "point";
                            listBox1.DataSource = t;
                            team1_point = Convert.ToInt32(listBox1.SelectedValue);
                            team1_point += 1;

                        }
                    }
                    #endregion
                    #region Insert Query
                    SqlConnection connection5 = new SqlConnection(Info.DB_connect);
                    connection5.Open();

                    string query5 = @"update team_tbl set point='" + team1_point + "' where name='" + combo_team1.SelectedValue + "' ";
                    SqlCommand cmd5 = new SqlCommand(query5, connection5);

                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read())
                    {
                        reader5.GetString(0);
                    }
                    #endregion

                    #region Select Query
                    string query4 = @"select * from team_tbl where name='" + combo_team2.SelectedValue + "';";
                    SqlConnection connection4;
                    using (connection4 = new SqlConnection(Info.DB_connect))
                    {
                        connection4.Open();
                        using (SqlDataAdapter a = new SqlDataAdapter(query4, connection4))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            listBox2.DisplayMember = "point";
                            listBox2.ValueMember = "point";
                            listBox2.DataSource = t;
                            team2_point = Convert.ToInt32(listBox2.SelectedValue);
                            team2_point += 1;

                        }
                    }
                    #endregion
                    #region Insert Query
                    SqlConnection connection6 = new SqlConnection(Info.DB_connect);
                    connection6.Open();

                    string query6 = @"update team_tbl set point='" + team2_point + "' where name='" + combo_team2.SelectedValue + "' ";
                    SqlCommand cmd6 = new SqlCommand(query6, connection6);

                    SqlDataReader reader6 = cmd6.ExecuteReader();

                    while (reader6.Read())
                    {
                        reader6.GetString(0);
                    }
                    #endregion
                }
                if (num_team1_goals.Value > num_team2_goals.Value)
                {
                    #region Select Query
                    string query7 = @"select * from team_tbl where name='" + combo_team1.SelectedValue + "';";
                    SqlConnection connection7;
                    using (connection7 = new SqlConnection(Info.DB_connect))
                    {
                        connection7.Open();
                        using (SqlDataAdapter a = new SqlDataAdapter(query7, connection7))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            listBox1.DisplayMember = "point";
                            listBox1.ValueMember = "point";
                            listBox1.DataSource = t;

                            team1_point = Convert.ToInt32(listBox1.SelectedValue);
                            team1_point += 3;

                        }
                    }
                    #endregion

                    #region Insert Query
                    SqlConnection connection8 = new SqlConnection(Info.DB_connect);
                    connection8.Open();

                    string query8 = @"update team_tbl set point='" + team1_point + "' where name='" + combo_team1.SelectedValue + "' ";
                    SqlCommand cmd8 = new SqlCommand(query8, connection8);

                    SqlDataReader reader8 = cmd8.ExecuteReader();

                    while (reader8.Read())
                    {
                        reader8.GetString(0);
                    }
                    #endregion
                }
                #endregion

                MessageBox.Show("بازی جدید با موفقیت اضافه شد");

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

        private void Insert_game_Load(object sender, EventArgs e)
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

                    combo_team1.DisplayMember = "name";
                    combo_team1.ValueMember = "name";
                    combo_team1.DataSource = t;
                    

                }


            }
            #endregion
            #region Select Query
            string query2 = @"select * from team_tbl order by name;";
            SqlConnection connection2;
            using (connection2 = new SqlConnection(Info.DB_connect))
            {
                connection2.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(query2, connection2))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    
                    combo_team2.DisplayMember = "name";
                    combo_team2.ValueMember = "name";
                    combo_team2.DataSource = t;

                }


            }
            #endregion
        }

        private void combo_team1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_team1.SelectedIndex == combo_team2.SelectedIndex)
            {
                combo_team1.SelectedIndex = -1;
            }
        }

        private void combo_team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_team2.SelectedIndex == combo_team1.SelectedIndex)
            {                
                combo_team2.SelectedIndex = -1;
            }
        }

    }
}
