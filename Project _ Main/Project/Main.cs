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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_insert_player_Click(object sender, EventArgs e)
        {
            Insert_player player = new Insert_player();
            player.ShowDialog();
        }

        private void btn_insert_team_Click(object sender, EventArgs e)
        {
            Insert_team team = new Insert_team();
            team.ShowDialog();
        }

        private void btn_insert_game_Click(object sender, EventArgs e)
        {
            Insert_game game = new Insert_game();
            game.ShowDialog();
        }

        private void btn_insert_goal_Click(object sender, EventArgs e)
        {
            Insert_goal goal = new Insert_goal();
            goal.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Sign_in signin = new Sign_in();
            signin.ShowDialog();
        }              

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region Select Query
            string query3 = @"select * from team_tbl order by point desc;";
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
                    dataGridView1.DataSource = t;

                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["cloth_color_1"].Visible = false;
                    dataGridView1.Columns["cloth_color_2"].Visible = false;
                    dataGridView1.Columns["name"].HeaderText = "نام تیم";
                    dataGridView1.Columns["point"].HeaderText = "امتیاز";
                    dataGridView1.Columns["rank"].HeaderText = "رتبه";
                    

                }
            }
            #endregion

            listBox1.SelectedIndex = 0;
            int count = listBox1.Items.Count;

            for (int i = 1; i <= count; i++)
            {
                listBox1.SelectedIndex = i-1;
                int point=Convert.ToInt32(listBox1.SelectedValue);
                #region Insert Query
            SqlConnection connection8 = new SqlConnection(Info.DB_connect);
            connection8.Open();

            string query8 = @"update team_tbl set rank="+(i)+" where point="+point+"; ";
               
            SqlCommand cmd8 = new SqlCommand(query8, connection8);

            SqlDataReader reader8 = cmd8.ExecuteReader();

            while (reader8.Read())
            {
                reader8.GetString(0);
            }
            #endregion
            
            }
            

            #region Select Query
            string query2 = @"select * from team_tbl order by point desc;";
            SqlConnection connection2;
            using (connection2 = new SqlConnection(Info.DB_connect))
            {
                connection2.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(query2, connection2))
                {
                    var t = new DataTable();
                    a.Fill(t);

                    listBox1.DisplayMember = "point";
                    listBox1.ValueMember = "point";
                    listBox1.DataSource = t;
                    dataGridView1.DataSource = t;

                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["cloth_color_1"].Visible = false;
                    dataGridView1.Columns["cloth_color_2"].Visible = false;
                    dataGridView1.Columns["name"].HeaderText = "نام تیم";
                    dataGridView1.Columns["point"].HeaderText = "امتیاز";
                    dataGridView1.Columns["rank"].HeaderText = "رتبه";


                }
            }
            #endregion

        }

        private void Main_Enter(object sender, EventArgs e)
        {
           
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            try
            {
                #region Select Query
                string query3 = @"select * from team_tbl order by point desc;";
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
                        dataGridView1.DataSource = t;

                        dataGridView1.Columns["ID"].Visible = false;
                        dataGridView1.Columns["cloth_color_1"].Visible = false;
                        dataGridView1.Columns["cloth_color_2"].Visible = false;
                        dataGridView1.Columns["name"].HeaderText = "نام تیم";
                        dataGridView1.Columns["point"].HeaderText = "امتیاز";
                        dataGridView1.Columns["rank"].HeaderText = "رتبه";


                    }
                }
                #endregion

                listBox1.SelectedIndex = 0;
                int count = listBox1.Items.Count;

                for (int i = 1; i <= count; i++)
                {
                    listBox1.SelectedIndex = i - 1;
                    int point = Convert.ToInt32(listBox1.SelectedValue);
                    #region Insert Query
                    SqlConnection connection8 = new SqlConnection(Info.DB_connect);
                    connection8.Open();

                    string query8 = @"update team_tbl set rank=" + (i) + " where point=" + point + "; ";

                    SqlCommand cmd8 = new SqlCommand(query8, connection8);

                    SqlDataReader reader8 = cmd8.ExecuteReader();

                    while (reader8.Read())
                    {
                        reader8.GetString(0);
                    }
                    #endregion

                }


                #region Select Query
                string query2 = @"select * from team_tbl order by point desc;";
                SqlConnection connection2;
                using (connection2 = new SqlConnection(Info.DB_connect))
                {
                    connection2.Open();
                    using (SqlDataAdapter a = new SqlDataAdapter(query2, connection2))
                    {
                        var t = new DataTable();
                        a.Fill(t);

                        listBox1.DisplayMember = "point";
                        listBox1.ValueMember = "point";
                        listBox1.DataSource = t;
                        dataGridView1.DataSource = t;

                        dataGridView1.Columns["ID"].Visible = false;
                        dataGridView1.Columns["cloth_color_1"].Visible = false;
                        dataGridView1.Columns["cloth_color_2"].Visible = false;
                        dataGridView1.Columns["name"].HeaderText = "نام تیم";
                        dataGridView1.Columns["point"].HeaderText = "امتیاز";
                        dataGridView1.Columns["rank"].HeaderText = "رتبه";


                    }
                }
                #endregion
            }
            catch { }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Delete_form delete = new Delete_form();
            delete.ShowDialog();
        }
    }
}
