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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            #region search sql

            string query = @"select * from player_tbl where name like N'%" + txt_name.Text + "%' order by name;";
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

                        listBox1.DisplayMember = "name";
                        listBox1.ValueMember = "name";                        
                        listBox1.DataSource = t;

                        listBox2.DisplayMember = "Birthday";
                        listBox2.ValueMember = "Birthday";
                        listBox2.DataSource = t;

                        listBox3.DisplayMember = "Role";
                        listBox3.ValueMember = "Role";
                        listBox3.DataSource = t;

                        listBox4.DisplayMember = "goals";
                        listBox4.ValueMember = "goals";
                        listBox4.DataSource = t;

                        listBox5.DisplayMember = "team";
                        listBox5.ValueMember = "team";
                        listBox5.DataSource = t;

                    }


                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "textBox1_TextChanged:\n" + exc.ToString() + "\n\n");

            }

            #endregion
            
        }
        private void txt__TextChanged(object sender, EventArgs e)
        {
            #region search sql

            string query = @"select * from game_tbl where week_num like N'%" + txt_.Text + "%' order by week_num;";
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

                        listBox6.DisplayMember = "first_team";
                        listBox6.ValueMember = "first_team";
                        listBox6.DataSource = t;

                        listBox21.DisplayMember = "second_team";
                        listBox21.ValueMember = "second_team";
                        listBox21.DataSource = t;

                        listBox7.DisplayMember = "date";
                        listBox7.ValueMember = "date";
                        listBox7.DataSource = t;

                        listBox8.DisplayMember = "first_team_goals";
                        listBox8.ValueMember = "first_team_goals";
                        listBox8.DataSource = t;

                        listBox9.DisplayMember = "second_team_goals";
                        listBox9.ValueMember = "second_team_goals";
                        listBox9.DataSource = t;

                        listBox10.DisplayMember = "week_num";
                        listBox10.ValueMember = "week_num";
                        listBox10.DataSource = t;

                    }


                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "textBox1_TextChanged:\n" + exc.ToString() + "\n\n");

            }

            #endregion
        }

        private void txt_goal_TextChanged(object sender, EventArgs e)
        {
            #region search sql

            string query = @"select * from goal_tbl where player like N'%" + txt_goal.Text + "%' order by player;";
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

                        listBox11.DisplayMember = "player";
                        listBox11.ValueMember = "player";
                        listBox11.DataSource = t;

                        listBox12.DisplayMember = "game";
                        listBox12.ValueMember = "game";
                        listBox12.DataSource = t;

                        listBox13.DisplayMember = "minute";
                        listBox13.ValueMember = "minute";
                        listBox13.DataSource = t;

                        

                    }


                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "textBox1_TextChanged:\n" + exc.ToString() + "\n\n");

            }

            #endregion
        }

        private void txt_team_TextChanged(object sender, EventArgs e)
        {
             #region search sql

            string query = @"select * from team_tbl where name like N'%" + txt_team.Text + "%' order by rank;";
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

                        listBox14.DisplayMember = "name";
                        listBox14.ValueMember = "name";
                        listBox14.DataSource = t;

                        listBox16.DisplayMember = "cloth_color_1";
                        listBox16.ValueMember = "cloth_color_1";
                        listBox16.DataSource = t;

                        listBox17.DisplayMember = "cloth_color_2";
                        listBox17.ValueMember = "cloth_color_2";
                        listBox17.DataSource = t;

                        listBox18.DisplayMember = "rank";
                        listBox18.ValueMember = "rank";
                        listBox18.DataSource = t;

                        listBox19.DisplayMember = "point";
                        listBox19.ValueMember = "point";
                        listBox19.DataSource = t;                      
                       

                    }


                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(@"Errors.err", "textBox1_TextChanged:\n" + exc.ToString() + "\n\n");

            }

            #endregion
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }
    }
}
