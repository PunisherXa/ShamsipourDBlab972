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
    public partial class Delete_form : Form
    {
        public Delete_form()
        {
            InitializeComponent();
        }

        private void Delete_form_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Info.DB_connect);
                connection.Open();
                #region Select Query Player_TBL



                string query1 = @"select * from player_tbl order by name;";
                SqlConnection connection1;

                using (connection1 = new SqlConnection(Info.DB_connect))
                {
                    connection1.Open();


                    using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        list_name.DisplayMember = "name";
                        list_name.ValueMember = "name";
                        list_birth.DisplayMember = "Birthday";
                        list_birth.ValueMember = "Birthday";
                        list_role.DisplayMember = "Role";
                        list_role.ValueMember = "Role";
                        list_goals.DisplayMember = "goals";
                        list_goals.ValueMember = "goals";
                        list_team.DisplayMember = "team";
                        list_team.ValueMember = "team";

                        list_name.DataSource = t;
                        list_birth.DataSource = t;
                        list_role.DataSource = t;
                        list_goals.DataSource = t;
                        list_team.DataSource = t;

                    }


                }

                #endregion

                #region Select Query Game_TBL



                string query2 = @"select * from game_tbl order by date;";
                SqlConnection connection3;

                using (connection3 = new SqlConnection(Info.DB_connect))
                {
                    connection3.Open();


                    using (SqlDataAdapter a = new SqlDataAdapter(query2, connection3))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        list_first_team.DisplayMember = "first_team";
                        list_first_team.ValueMember = "first_team";
                        list_second_team.DisplayMember = "second_team";
                        list_second_team.ValueMember = "second_team";
                        list_date.DisplayMember = "date";
                        list_date.ValueMember = "date";
                        list_first_team_goals.DisplayMember = "first_team_goals";
                        list_first_team_goals.ValueMember = "first_team_goals";
                        list_second_team_goals.DisplayMember = "second_team_goals";
                        list_second_team_goals.ValueMember = "second_team_goals";
                        list_week_num.DisplayMember = "week_num";
                        list_week_num.ValueMember = "week_num";

                        list_first_team.DataSource = t;
                        list_second_team.DataSource = t;
                        list_date.DataSource = t;
                        list_first_team_goals.DataSource = t;
                        list_second_team_goals.DataSource = t;
                        list_week_num.DataSource = t;

                    }


                }

                #endregion

                #region Select Query Goal_TBL



                string query3 = @"select * from goal_tbl order by player;";
                SqlConnection connection5;

                using (connection5 = new SqlConnection(Info.DB_connect))
                {
                    connection5.Open();


                    using (SqlDataAdapter a = new SqlDataAdapter(query3, connection5))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        list_player.DisplayMember = "player";
                        list_player.ValueMember = "player";
                        list_game.DisplayMember = "game";
                        list_game.ValueMember = "game";
                        list_minute.DisplayMember = "minute";
                        list_minute.ValueMember = "minute";


                        list_player.DataSource = t;
                        list_game.DataSource = t;
                        list_minute.DataSource = t;


                    }


                }

                #endregion

                #region Select Query Team_TBL



                string query4 = @"select * from team_tbl order by name;";
                SqlConnection connection7;

                using (connection7 = new SqlConnection(Info.DB_connect))
                {
                    connection7.Open();


                    using (SqlDataAdapter a = new SqlDataAdapter(query4, connection7))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        list_tname.DisplayMember = "name";
                        list_tname.ValueMember = "name";
                        list_cloth_color_1.DisplayMember = "cloth_color_1";
                        list_cloth_color_1.ValueMember = "cloth_color_1";
                        list_cloth_color_2.DisplayMember = "cloth_color_2";
                        list_cloth_color_2.ValueMember = "cloth_color_2";
                        list_rank.DisplayMember = "rank";
                        list_rank.ValueMember = "rank";
                        list_point.DisplayMember = "point";
                        list_point.ValueMember = "point";


                        list_tname.DataSource = t;
                        list_cloth_color_1.DataSource = t;
                        list_cloth_color_2.DataSource = t;
                        list_rank.DataSource = t;
                        list_point.DataSource = t;


                    }


                }

                #endregion




            }

            catch { }







        }//event(Form_load)  

        private void player_btn_Click(object sender, EventArgs e)
        {

            DialogResult deletedialog = MessageBox.Show("از حذف این بازیکن اطمینان دارید؟", "حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deletedialog == DialogResult.Yes)
            {
                try
                {
                    #region Delete Query
                    SqlConnection connection5 = new SqlConnection(Info.DB_connect);
                    connection5.Open();

                    string query5 = @"delete from player_tbl where name=N'" + list_name.SelectedValue + "' ;";
                    SqlCommand cmd5 = new SqlCommand(query5, connection5);

                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read())
                    {
                        reader5.GetString(0);
                    }
                    #endregion

                    #region Select Query Player_TBL



                    string query1 = @"select * from player_tbl order by name;";
                    SqlConnection connection1;

                    using (connection1 = new SqlConnection(Info.DB_connect))
                    {
                        connection1.Open();


                        using (SqlDataAdapter a = new SqlDataAdapter(query1, connection1))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            list_name.DisplayMember = "name";
                            list_name.ValueMember = "name";
                            list_birth.DisplayMember = "Birthday";
                            list_birth.ValueMember = "Birthday";
                            list_role.DisplayMember = "Role";
                            list_role.ValueMember = "Role";
                            list_goals.DisplayMember = "goals";
                            list_goals.ValueMember = "goals";
                            list_team.DisplayMember = "team";
                            list_team.ValueMember = "team";

                            list_name.DataSource = t;
                            list_birth.DataSource = t;
                            list_role.DataSource = t;
                            list_goals.DataSource = t;
                            list_team.DataSource = t;

                        }


                    }

                    #endregion


                    MessageBox.Show("بازیکن با موفقیت حذف شد");

                }
                catch (SqlException sqlexc)
                {
                    File.AppendAllText(@"Errors.err", "player_btn(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
                }
                catch (Exception exc)
                {
                    File.AppendAllText(@"Errors.err", "player_btn:\n" + exc.ToString() + "\n\n");
                }

            }
        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            DialogResult deletedialog = MessageBox.Show("از حذف این بازی اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deletedialog == DialogResult.Yes)
            {
                try
                {
                    #region Delete Query
                    SqlConnection connection5 = new SqlConnection(Info.DB_connect);
                    connection5.Open();

                    string query5 = @"delete from game_tbl where first_team=N'" + list_first_team.SelectedValue + "' AND second_team=N'" + list_second_team.SelectedValue + "' AND date=N'" + list_date.SelectedValue + "' ;";
                    SqlCommand cmd5 = new SqlCommand(query5, connection5);

                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read())
                    {
                        reader5.GetString(0);
                    }
                    #endregion

                    #region Select Query Game_TBL



                    string query2 = @"select * from game_tbl order by date;";
                    SqlConnection connection3;

                    using (connection3 = new SqlConnection(Info.DB_connect))
                    {
                        connection3.Open();


                        using (SqlDataAdapter a = new SqlDataAdapter(query2, connection3))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            list_first_team.DisplayMember = "first_team";
                            list_first_team.ValueMember = "first_team";
                            list_second_team.DisplayMember = "second_team";
                            list_second_team.ValueMember = "second_team";
                            list_date.DisplayMember = "date";
                            list_date.ValueMember = "date";
                            list_first_team_goals.DisplayMember = "first_team_goals";
                            list_first_team_goals.ValueMember = "first_team_goals";
                            list_second_team_goals.DisplayMember = "second_team_goals";
                            list_second_team_goals.ValueMember = "second_team_goals";
                            list_week_num.DisplayMember = "week_num";
                            list_week_num.ValueMember = "week_num";

                            list_first_team.DataSource = t;
                            list_second_team.DataSource = t;
                            list_date.DataSource = t;
                            list_first_team_goals.DataSource = t;
                            list_second_team_goals.DataSource = t;
                            list_week_num.DataSource = t;

                        }


                    }

                    #endregion


                    MessageBox.Show("بازی با موفقیت حذف شد");

                }
                catch (SqlException sqlexc)
                {
                    File.AppendAllText(@"Errors.err", "game_btn(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
                }
                catch (Exception exc)
                {
                    File.AppendAllText(@"Errors.err", "game_btn:\n" + exc.ToString() + "\n\n");
                }

            }
        } //public

        private void goal_btn_Click(object sender, EventArgs e)
        {
            DialogResult deletedialog = MessageBox.Show("از حذف این گل اطمینان دارید؟", "حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deletedialog == DialogResult.Yes)
            {
                try
                {
                    #region Delete Query
                    SqlConnection connection5 = new SqlConnection(Info.DB_connect);
                    connection5.Open();

                    string query5 = @"delete from goal_tbl where player=N'" + list_player.SelectedValue + "' AND game=N'" + list_game.SelectedValue + "' AND minute=N'" + list_minute.SelectedValue + "' ;";
                    SqlCommand cmd5 = new SqlCommand(query5, connection5);

                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read())
                    {
                        reader5.GetString(0);
                    }
                    #endregion

                    #region Select Query Goal_TBL



                    string query3 = @"select * from goal_tbl order by player;";
                    SqlConnection connection8;

                    using (connection8 = new SqlConnection(Info.DB_connect))
                    {
                        connection8.Open();


                        using (SqlDataAdapter a = new SqlDataAdapter(query3, connection8))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            list_player.DisplayMember = "player";
                            list_player.ValueMember = "player";
                            list_game.DisplayMember = "game";
                            list_game.ValueMember = "game";
                            list_minute.DisplayMember = "minute";
                            list_minute.ValueMember = "minute";


                            list_player.DataSource = t;
                            list_game.DataSource = t;
                            list_minute.DataSource = t;


                        }


                    }

                    #endregion


                    MessageBox.Show("گل با موفقیت حذف شد");

                }
                catch (SqlException sqlexc)
                {
                    File.AppendAllText(@"Errors.err", "goal_btn(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
                }
                catch (Exception exc)
                {
                    File.AppendAllText(@"Errors.err", "goal_btn:\n" + exc.ToString() + "\n\n");
                }
            }
        }

        private void team_btn_Click(object sender, EventArgs e)
        {
            DialogResult deletedialog = MessageBox.Show("از حذف این تیم اطمینان دارید؟", "حدف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deletedialog == DialogResult.Yes)
            {
                try
                {
                    #region Delete Query
                    SqlConnection connection5 = new SqlConnection(Info.DB_connect);
                    connection5.Open();

                    string query5 = @"delete from team_tbl where name=N'" + list_tname.SelectedValue + "' AND cloth_color_1=N'" + list_cloth_color_1.SelectedValue + "' AND cloth_color_2=N'" + list_cloth_color_2.SelectedValue + "' ;";
                    SqlCommand cmd5 = new SqlCommand(query5, connection5);

                    SqlDataReader reader5 = cmd5.ExecuteReader();

                    while (reader5.Read())
                    {
                        reader5.GetString(0);
                    }
                    #endregion


                    #region Select Query Goal_TBL



                    string query4 = @"select * from team_tbl order by name;";
                    SqlConnection connection7;

                    using (connection7 = new SqlConnection(Info.DB_connect))
                    {
                        connection7.Open();


                        using (SqlDataAdapter a = new SqlDataAdapter(query4, connection7))
                        {
                            var t = new DataTable();
                            a.Fill(t);

                            list_tname.DisplayMember = "name";
                            list_tname.ValueMember = "name";
                            list_cloth_color_1.DisplayMember = "cloth_color_1";
                            list_cloth_color_1.ValueMember = "cloth_color_1";
                            list_cloth_color_2.DisplayMember = "cloth_color_2";
                            list_cloth_color_2.ValueMember = "cloth_color_2";
                            list_rank.DisplayMember = "rank";
                            list_rank.ValueMember = "rank";
                            list_point.DisplayMember = "point";
                            list_point.ValueMember = "point";


                            list_tname.DataSource = t;
                            list_cloth_color_1.DataSource = t;
                            list_cloth_color_2.DataSource = t;
                            list_rank.DataSource = t;
                            list_point.DataSource = t;


                        }


                    }

                    #endregion


                    MessageBox.Show("تیم با موفقیت حذف شد");

                }
                catch (SqlException sqlexc)
                {
                    File.AppendAllText(@"Errors.err", "team_btn(SQL_ERROR):\n" + sqlexc.ToString() + "\n\n");
                }
                catch (Exception exc)
                {
                    File.AppendAllText(@"Errors.err", "team_btn:\n" + exc.ToString() + "\n\n");
                }
            }
        }
    }
}//namespace

