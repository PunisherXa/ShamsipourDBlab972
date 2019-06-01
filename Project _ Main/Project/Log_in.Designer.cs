namespace Project
{
    partial class Log_in
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.logtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logpb = new System.Windows.Forms.PictureBox();
            this.passpb = new System.Windows.Forms.PictureBox();
            this.loglabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passpb)).BeginInit();
            this.SuspendLayout();
            // 
            // logtxt
            // 
            this.logtxt.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtxt.Location = new System.Drawing.Point(150, 40);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(194, 25);
            this.logtxt.TabIndex = 0;
            this.logtxt.TextChanged += new System.EventHandler(this.logtxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(150, 117);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(194, 25);
            this.passtxt.TabIndex = 1;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(110, 183);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(147, 33);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "ورود";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(223, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(77, 56);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(300, 222);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(77, 56);
            this.listBox2.TabIndex = 4;
            this.listBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(-1, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "در صورتی که هنوز ثبت نام نکردید کلیک کنید\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logpb
            // 
            this.logpb.Image = ((System.Drawing.Image)(resources.GetObject("logpb.Image")));
            this.logpb.Location = new System.Drawing.Point(5, 27);
            this.logpb.Name = "logpb";
            this.logpb.Size = new System.Drawing.Size(34, 32);
            this.logpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logpb.TabIndex = 6;
            this.logpb.TabStop = false;
            this.logpb.Click += new System.EventHandler(this.logpb_Click);
            // 
            // passpb
            // 
            this.passpb.Image = ((System.Drawing.Image)(resources.GetObject("passpb.Image")));
            this.passpb.Location = new System.Drawing.Point(5, 107);
            this.passpb.Name = "passpb";
            this.passpb.Size = new System.Drawing.Size(34, 32);
            this.passpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passpb.TabIndex = 7;
            this.passpb.TabStop = false;
            this.passpb.Click += new System.EventHandler(this.passpb_Click);
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loglabel.Location = new System.Drawing.Point(64, 43);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(68, 18);
            this.loglabel.TabIndex = 8;
            this.loglabel.Text = "نام کاربری :";
            this.loglabel.Click += new System.EventHandler(this.loglabel_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passlabel.Location = new System.Drawing.Point(66, 121);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(63, 18);
            this.passlabel.TabIndex = 9;
            this.passlabel.Text = "رمز عبور :";
            this.passlabel.Click += new System.EventHandler(this.passlabel_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 290);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.passpb);
            this.Controls.Add(this.logpb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.logtxt);
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logpb;
        private System.Windows.Forms.PictureBox passpb;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Label passlabel;
    }
}