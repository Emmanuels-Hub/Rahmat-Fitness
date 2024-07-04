namespace Rahmat_Fitness
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            regPage = new Button();
            label5 = new Label();
            loginbtn = new Button();
            getlogpass = new TextBox();
            label3 = new Label();
            getloguser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            closelog = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // regPage
            // 
            regPage.BackColor = Color.FromArgb(116, 86, 174);
            regPage.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regPage.ForeColor = Color.White;
            regPage.Location = new Point(117, 470);
            regPage.Name = "regPage";
            regPage.Size = new Size(211, 46);
            regPage.TabIndex = 19;
            regPage.Text = "Create Account";
            regPage.UseVisualStyleBackColor = false;
            regPage.Click += regPage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 430);
            label5.Name = "label5";
            label5.Size = new Size(266, 27);
            label5.TabIndex = 18;
            label5.Text = "Don't have an Account?";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(116, 86, 174);
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(51, 352);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(350, 47);
            loginbtn.TabIndex = 17;
            loginbtn.Text = "Submit";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // getlogpass
            // 
            getlogpass.Location = new Point(61, 277);
            getlogpass.Name = "getlogpass";
            getlogpass.PasswordChar = '*';
            getlogpass.Size = new Size(340, 35);
            getlogpass.TabIndex = 14;
            getlogpass.TextChanged += getlogpass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 247);
            label3.Name = "label3";
            label3.Size = new Size(124, 27);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // getloguser
            // 
            getloguser.Location = new Point(61, 178);
            getloguser.Name = "getloguser";
            getloguser.Size = new Size(340, 35);
            getloguser.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 148);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(467, 46);
            label1.TabIndex = 10;
            label1.Text = "Welcome to Rahmat Fit";
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(918, 12);
            closelog.Name = "closelog";
            closelog.Size = new Size(42, 34);
            closelog.TabIndex = 20;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(452, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(972, 556);
            Controls.Add(pictureBox1);
            Controls.Add(closelog);
            Controls.Add(regPage);
            Controls.Add(label5);
            Controls.Add(loginbtn);
            Controls.Add(getlogpass);
            Controls.Add(label3);
            Controls.Add(getloguser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regPage;
        private Label label5;
        private Button loginbtn;
        private TextBox getlogpass;
        private Label label3;
        private TextBox getloguser;
        private Label label2;
        private Label label1;
        private Button closelog;
        private PictureBox pictureBox1;
    }
}