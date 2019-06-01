namespace Project
{
    partial class Sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            this.ruser = new System.Windows.Forms.TextBox();
            this.rpass = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pbruser = new System.Windows.Forms.PictureBox();
            this.rpasslabel = new System.Windows.Forms.Label();
            this.ruserlabel = new System.Windows.Forms.Label();
            this.pbrpass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbruser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrpass)).BeginInit();
            this.SuspendLayout();
            // 
            // ruser
            // 
            this.ruser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruser.Location = new System.Drawing.Point(175, 70);
            this.ruser.Name = "ruser";
            this.ruser.Size = new System.Drawing.Size(194, 25);
            this.ruser.TabIndex = 0;
            this.ruser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rpass
            // 
            this.rpass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpass.Location = new System.Drawing.Point(175, 133);
            this.rpass.Name = "rpass";
            this.rpass.Size = new System.Drawing.Size(194, 25);
            this.rpass.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_submit.Location = new System.Drawing.Point(156, 213);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(147, 33);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "ثبت نام";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pbruser
            // 
            this.pbruser.Image = ((System.Drawing.Image)(resources.GetObject("pbruser.Image")));
            this.pbruser.Location = new System.Drawing.Point(12, 55);
            this.pbruser.Name = "pbruser";
            this.pbruser.Size = new System.Drawing.Size(50, 52);
            this.pbruser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbruser.TabIndex = 4;
            this.pbruser.TabStop = false;
            // 
            // rpasslabel
            // 
            this.rpasslabel.AutoSize = true;
            this.rpasslabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rpasslabel.Location = new System.Drawing.Point(93, 141);
            this.rpasslabel.Name = "rpasslabel";
            this.rpasslabel.Size = new System.Drawing.Size(63, 18);
            this.rpasslabel.TabIndex = 11;
            this.rpasslabel.Text = "رمز عبور :";
            // 
            // ruserlabel
            // 
            this.ruserlabel.AutoSize = true;
            this.ruserlabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ruserlabel.Location = new System.Drawing.Point(84, 70);
            this.ruserlabel.Name = "ruserlabel";
            this.ruserlabel.Size = new System.Drawing.Size(68, 18);
            this.ruserlabel.TabIndex = 12;
            this.ruserlabel.Text = "نام کاربری :";
            // 
            // pbrpass
            // 
            this.pbrpass.Image = ((System.Drawing.Image)(resources.GetObject("pbrpass.Image")));
            this.pbrpass.Location = new System.Drawing.Point(12, 127);
            this.pbrpass.Name = "pbrpass";
            this.pbrpass.Size = new System.Drawing.Size(50, 52);
            this.pbrpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbrpass.TabIndex = 13;
            this.pbrpass.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(-2, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "اگر قبلا ثبت نام کردید کلیک کنید";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 56);
            this.listBox1.TabIndex = 16;
            this.listBox1.Visible = false;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 337);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrpass);
            this.Controls.Add(this.ruserlabel);
            this.Controls.Add(this.rpasslabel);
            this.Controls.Add(this.pbruser);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rpass);
            this.Controls.Add(this.ruser);
            this.Name = "Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_in";
            this.Load += new System.EventHandler(this.Sign_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbruser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ruser;
        private System.Windows.Forms.TextBox rpass;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox pbruser;
        private System.Windows.Forms.Label rpasslabel;
        private System.Windows.Forms.Label ruserlabel;
        private System.Windows.Forms.PictureBox pbrpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}