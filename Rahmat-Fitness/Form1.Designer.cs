namespace Rahmat_Fitness
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            getuser = new TextBox();
            getpass = new TextBox();
            label3 = new Label();
            getcompass = new TextBox();
            label4 = new Label();
            registerbtn = new Button();
            label5 = new Label();
            logPage = new Button();
            closereg = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 103);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // getuser
            // 
            getuser.Location = new Point(53, 133);
            getuser.Name = "getuser";
            getuser.Size = new Size(340, 35);
            getuser.TabIndex = 2;
            getuser.TextChanged += textBox1_TextChanged;
            // 
            // getpass
            // 
            getpass.Location = new Point(53, 232);
            getpass.Name = "getpass";
            getpass.PasswordChar = '*';
            getpass.Size = new Size(340, 35);
            getpass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 202);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // getcompass
            // 
            getcompass.Location = new Point(53, 330);
            getcompass.Name = "getcompass";
            getcompass.PasswordChar = '*';
            getcompass.Size = new Size(340, 35);
            getcompass.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 300);
            label4.Name = "label4";
            label4.Size = new Size(221, 27);
            label4.TabIndex = 5;
            label4.Text = "Comfirm Password:";
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.FromArgb(116, 86, 174);
            registerbtn.Cursor = Cursors.Hand;
            registerbtn.FlatAppearance.BorderSize = 0;
            registerbtn.ForeColor = Color.White;
            registerbtn.Location = new Point(43, 400);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(350, 47);
            registerbtn.TabIndex = 7;
            registerbtn.Text = "Submit";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += registerbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 481);
            label5.Name = "label5";
            label5.Size = new Size(180, 27);
            label5.TabIndex = 8;
            label5.Text = "Already a user?";
            // 
            // logPage
            // 
            logPage.BackColor = Color.FromArgb(116, 86, 174);
            logPage.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logPage.ForeColor = Color.White;
            logPage.Location = new Point(260, 473);
            logPage.Name = "logPage";
            logPage.Size = new Size(133, 46);
            logPage.TabIndex = 9;
            logPage.Text = "Sign in";
            logPage.UseVisualStyleBackColor = false;
            logPage.Click += logPage_Click;
            // 
            // closereg
            // 
            closereg.FlatAppearance.BorderSize = 0;
            closereg.FlatStyle = FlatStyle.Popup;
            closereg.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closereg.Location = new Point(918, 21);
            closereg.Name = "closereg";
            closereg.Size = new Size(42, 34);
            closereg.TabIndex = 21;
            closereg.Text = "X";
            closereg.UseVisualStyleBackColor = true;
            closereg.Click += closelog_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(423, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(972, 594);
            Controls.Add(pictureBox1);
            Controls.Add(closereg);
            Controls.Add(logPage);
            Controls.Add(label5);
            Controls.Add(registerbtn);
            Controls.Add(getcompass);
            Controls.Add(label4);
            Controls.Add(getpass);
            Controls.Add(label3);
            Controls.Add(getuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            Load += registerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox getuser;
        private TextBox getpass;
        private Label label3;
        private TextBox getcompass;
        private Label label4;
        private Button registerbtn;
        private Label label5;
        private Button logPage;
        private Button closereg;
        private PictureBox pictureBox1;
    }
}
