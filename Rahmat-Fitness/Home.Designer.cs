namespace Rahmat_Fitness
{
    partial class Home
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
            label1 = new Label();
            closelog = new Button();
            button1 = new Button();
            label2 = new Label();
            runPage = new Button();
            swimPage = new Button();
            cycPage = new Button();
            yogaPage = new Button();
            walkPage = new Button();
            jogPage = new Button();
            label3 = new Label();
            getCal = new TextBox();
            setCal = new Button();
            label4 = new Label();
            calData = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(255, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(693, 46);
            label1.TabIndex = 0;
            label1.Text = "Choose a Suitable Fitness Activity.";
            label1.Click += label1_Click;
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(1024, 31);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 34);
            closelog.TabIndex = 21;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(961, 31);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(55, 34);
            button1.TabIndex = 22;
            button1.Text = "--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 142);
            label2.Name = "label2";
            label2.Size = new Size(276, 25);
            label2.TabIndex = 23;
            label2.Text = "Health is Wealth. Good luck";
            label2.Click += label2_Click;
            // 
            // runPage
            // 
            runPage.BackColor = Color.FromArgb(116, 86, 174);
            runPage.Cursor = Cursors.Hand;
            runPage.FlatStyle = FlatStyle.Popup;
            runPage.ForeColor = Color.White;
            runPage.Location = new Point(93, 210);
            runPage.Name = "runPage";
            runPage.Size = new Size(245, 81);
            runPage.TabIndex = 24;
            runPage.Text = "Running";
            runPage.UseVisualStyleBackColor = false;
            runPage.Click += runPage_Click;
            // 
            // swimPage
            // 
            swimPage.BackColor = Color.FromArgb(116, 86, 174);
            swimPage.Cursor = Cursors.Hand;
            swimPage.FlatStyle = FlatStyle.Popup;
            swimPage.ForeColor = Color.White;
            swimPage.Location = new Point(421, 210);
            swimPage.Name = "swimPage";
            swimPage.Size = new Size(245, 81);
            swimPage.TabIndex = 25;
            swimPage.Text = "Swimming";
            swimPage.UseVisualStyleBackColor = false;
            swimPage.Click += swimPage_Click;
            // 
            // cycPage
            // 
            cycPage.BackColor = Color.FromArgb(116, 86, 174);
            cycPage.Cursor = Cursors.Hand;
            cycPage.FlatStyle = FlatStyle.Popup;
            cycPage.ForeColor = Color.White;
            cycPage.Location = new Point(749, 210);
            cycPage.Name = "cycPage";
            cycPage.Size = new Size(245, 81);
            cycPage.TabIndex = 26;
            cycPage.Text = "Cycling";
            cycPage.UseVisualStyleBackColor = false;
            cycPage.Click += cycPage_Click;
            // 
            // yogaPage
            // 
            yogaPage.BackColor = Color.FromArgb(116, 86, 174);
            yogaPage.Cursor = Cursors.Hand;
            yogaPage.FlatStyle = FlatStyle.Popup;
            yogaPage.ForeColor = Color.White;
            yogaPage.Location = new Point(93, 371);
            yogaPage.Name = "yogaPage";
            yogaPage.Size = new Size(245, 81);
            yogaPage.TabIndex = 27;
            yogaPage.Text = "Yoga";
            yogaPage.UseVisualStyleBackColor = false;
            yogaPage.Click += yogaPage_Click;
            // 
            // walkPage
            // 
            walkPage.BackColor = Color.FromArgb(116, 86, 174);
            walkPage.Cursor = Cursors.Hand;
            walkPage.FlatStyle = FlatStyle.Popup;
            walkPage.ForeColor = Color.White;
            walkPage.Location = new Point(421, 371);
            walkPage.Name = "walkPage";
            walkPage.Size = new Size(245, 81);
            walkPage.TabIndex = 28;
            walkPage.Text = "Walking";
            walkPage.UseVisualStyleBackColor = false;
            walkPage.Click += walkPage_Click;
            // 
            // jogPage
            // 
            jogPage.BackColor = Color.FromArgb(116, 86, 174);
            jogPage.Cursor = Cursors.Hand;
            jogPage.FlatStyle = FlatStyle.Popup;
            jogPage.ForeColor = Color.White;
            jogPage.Location = new Point(749, 371);
            jogPage.Name = "jogPage";
            jogPage.Size = new Size(245, 81);
            jogPage.TabIndex = 29;
            jogPage.Text = "Jumping";
            jogPage.UseVisualStyleBackColor = false;
            jogPage.Click += jogPage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 531);
            label3.Name = "label3";
            label3.Size = new Size(432, 25);
            label3.TabIndex = 30;
            label3.Text = "Set the amount of Calories you want to burn";
            // 
            // getCal
            // 
            getCal.Location = new Point(550, 524);
            getCal.Name = "getCal";
            getCal.Size = new Size(222, 33);
            getCal.TabIndex = 31;
            getCal.TextChanged += getCal_TextChanged;
            // 
            // setCal
            // 
            setCal.BackColor = Color.FromArgb(116, 86, 174);
            setCal.FlatStyle = FlatStyle.Popup;
            setCal.ForeColor = Color.White;
            setCal.Location = new Point(805, 522);
            setCal.Name = "setCal";
            setCal.Size = new Size(112, 34);
            setCal.TabIndex = 32;
            setCal.Text = "Submit";
            setCal.UseVisualStyleBackColor = false;
            setCal.Click += setCal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 592);
            label4.Name = "label4";
            label4.Size = new Size(170, 36);
            label4.TabIndex = 33;
            label4.Text = "Set Calory:";
            label4.Click += label4_Click;
            // 
            // calData
            // 
            calData.AutoSize = true;
            calData.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calData.Location = new Point(345, 583);
            calData.Name = "calData";
            calData.Size = new Size(44, 46);
            calData.TabIndex = 34;
            calData.Text = "0";
            calData.Click += calData_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 650);
            Controls.Add(calData);
            Controls.Add(label4);
            Controls.Add(setCal);
            Controls.Add(getCal);
            Controls.Add(label3);
            Controls.Add(jogPage);
            Controls.Add(walkPage);
            Controls.Add(yogaPage);
            Controls.Add(cycPage);
            Controls.Add(swimPage);
            Controls.Add(runPage);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(closelog);
            Controls.Add(label1);
            Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button closelog;
        private Button button1;
        private Label label2;
        private Button runPage;
        private Button swimPage;
        private Button cycPage;
        private Button yogaPage;
        private Button walkPage;
        private Button jogPage;
        private Label label3;
        private TextBox getCal;
        private Button setCal;
        private Label label4;
        private Label calData;
    }
}