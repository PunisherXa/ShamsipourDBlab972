namespace Project
{
    partial class Insert_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_insert = new System.Windows.Forms.Button();
            this.combo_team1 = new System.Windows.Forms.ComboBox();
            this.combo_team2 = new System.Windows.Forms.ComboBox();
            this.num_team1_goals = new System.Windows.Forms.NumericUpDown();
            this.num_team2_goals = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_goals = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_week = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_date_day = new System.Windows.Forms.ComboBox();
            this.combo_date_month = new System.Windows.Forms.ComboBox();
            this.combo_date_year = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_team1_goals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_team2_goals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_week)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(158, 269);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(90, 46);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Action";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // combo_team1
            // 
            this.combo_team1.FormattingEnabled = true;
            this.combo_team1.Location = new System.Drawing.Point(52, 37);
            this.combo_team1.Name = "combo_team1";
            this.combo_team1.Size = new System.Drawing.Size(252, 21);
            this.combo_team1.TabIndex = 1;
            this.combo_team1.SelectedIndexChanged += new System.EventHandler(this.combo_team1_SelectedIndexChanged);
            // 
            // combo_team2
            // 
            this.combo_team2.FormattingEnabled = true;
            this.combo_team2.Location = new System.Drawing.Point(52, 76);
            this.combo_team2.Name = "combo_team2";
            this.combo_team2.Size = new System.Drawing.Size(252, 21);
            this.combo_team2.TabIndex = 2;
            this.combo_team2.SelectedIndexChanged += new System.EventHandler(this.combo_team2_SelectedIndexChanged);
            // 
            // num_team1_goals
            // 
            this.num_team1_goals.Location = new System.Drawing.Point(52, 150);
            this.num_team1_goals.Name = "num_team1_goals";
            this.num_team1_goals.Size = new System.Drawing.Size(252, 20);
            this.num_team1_goals.TabIndex = 3;
            // 
            // num_team2_goals
            // 
            this.num_team2_goals.Location = new System.Drawing.Point(52, 188);
            this.num_team2_goals.Name = "num_team2_goals";
            this.num_team2_goals.Size = new System.Drawing.Size(252, 20);
            this.num_team2_goals.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(311, 186);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "گل های تیم دوم:";
            // 
            // num_goals
            // 
            this.num_goals.AutoSize = true;
            this.num_goals.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num_goals.Location = new System.Drawing.Point(310, 152);
            this.num_goals.Name = "num_goals";
            this.num_goals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.num_goals.Size = new System.Drawing.Size(112, 18);
            this.num_goals.TabIndex = 11;
            this.num_goals.Text = "گل های تیم اول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(328, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "تیم دوم:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(328, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "تیم اول:";
            // 
            // num_week
            // 
            this.num_week.Location = new System.Drawing.Point(52, 223);
            this.num_week.Name = "num_week";
            this.num_week.Size = new System.Drawing.Size(252, 20);
            this.num_week.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(311, 221);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "شماره هفته:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "/";
            // 
            // combo_date_day
            // 
            this.combo_date_day.FormattingEnabled = true;
            this.combo_date_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.combo_date_day.Location = new System.Drawing.Point(229, 115);
            this.combo_date_day.Name = "combo_date_day";
            this.combo_date_day.Size = new System.Drawing.Size(43, 21);
            this.combo_date_day.TabIndex = 18;
            // 
            // combo_date_month
            // 
            this.combo_date_month.FormattingEnabled = true;
            this.combo_date_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_date_month.Location = new System.Drawing.Point(158, 115);
            this.combo_date_month.Name = "combo_date_month";
            this.combo_date_month.Size = new System.Drawing.Size(43, 21);
            this.combo_date_month.TabIndex = 18;
            // 
            // combo_date_year
            // 
            this.combo_date_year.FormattingEnabled = true;
            this.combo_date_year.Items.AddRange(new object[] {
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420",
            "1421",
            "1422",
            "1423",
            "1424",
            "1425",
            "1426",
            "1427",
            "1428",
            "1429",
            "1430",
            "1431",
            "1432",
            "1433",
            "1434",
            "1435",
            "1436",
            "1437",
            "1438",
            "1439",
            "1440"});
            this.combo_date_year.Location = new System.Drawing.Point(71, 115);
            this.combo_date_year.Name = "combo_date_year";
            this.combo_date_year.Size = new System.Drawing.Size(59, 21);
            this.combo_date_year.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(328, 114);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "تاریخ:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(212, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 19;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(92, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(10, 4);
            this.listBox2.TabIndex = 19;
            this.listBox2.Visible = false;
            // 
            // Insert_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 350);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.combo_date_year);
            this.Controls.Add(this.combo_date_month);
            this.Controls.Add(this.combo_date_day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_week);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_goals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_team2_goals);
            this.Controls.Add(this.num_team1_goals);
            this.Controls.Add(this.combo_team2);
            this.Controls.Add(this.combo_team1);
            this.Controls.Add(this.btn_insert);
            this.Name = "Insert_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Insert_game";
            this.Load += new System.EventHandler(this.Insert_game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_team1_goals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_team2_goals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_week)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox combo_team1;
        private System.Windows.Forms.ComboBox combo_team2;
        private System.Windows.Forms.NumericUpDown num_team1_goals;
        private System.Windows.Forms.NumericUpDown num_team2_goals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label num_goals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_week;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_date_day;
        private System.Windows.Forms.ComboBox combo_date_month;
        private System.Windows.Forms.ComboBox combo_date_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}