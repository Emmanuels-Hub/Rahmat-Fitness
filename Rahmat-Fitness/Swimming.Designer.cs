namespace Rahmat_Fitness
{
    partial class Swimming
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
            levellap = new NumericUpDown();
            goHome = new Button();
            calCal = new Button();
            getStorke = new TextBox();
            getWeight = new TextBox();
            weight = new Label();
            stroke = new Label();
            minWin = new Button();
            closelog = new Button();
            lap = new Label();
            label1 = new Label();
            getTime = new TextBox();
            time = new Label();
            ((System.ComponentModel.ISupportInitialize)levellap).BeginInit();
            SuspendLayout();
            // 
            // levellap
            // 
            levellap.BorderStyle = BorderStyle.None;
            levellap.Location = new Point(460, 155);
            levellap.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levellap.Name = "levellap";
            levellap.Size = new Size(215, 27);
            levellap.TabIndex = 54;
            // 
            // goHome
            // 
            goHome.FlatAppearance.BorderSize = 0;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.Location = new Point(17, 13);
            goHome.Margin = new Padding(4, 3, 4, 3);
            goHome.Name = "goHome";
            goHome.Size = new Size(75, 29);
            goHome.TabIndex = 53;
            goHome.Text = "back";
            goHome.UseVisualStyleBackColor = true;
            goHome.Click += goHome_Click;
            // 
            // calCal
            // 
            calCal.BackColor = Color.FromArgb(116, 86, 174);
            calCal.FlatStyle = FlatStyle.Popup;
            calCal.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calCal.ForeColor = Color.White;
            calCal.Location = new Point(460, 473);
            calCal.Name = "calCal";
            calCal.Size = new Size(215, 34);
            calCal.TabIndex = 52;
            calCal.Text = "Check";
            calCal.UseVisualStyleBackColor = false;
            calCal.Click += calCal_Click;
            // 
            // getStorke
            // 
            getStorke.Location = new Point(460, 319);
            getStorke.Name = "getStorke";
            getStorke.Size = new Size(215, 31);
            getStorke.TabIndex = 51;
            getStorke.TextChanged += getStorke_TextChanged;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(460, 239);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(215, 31);
            getWeight.TabIndex = 50;
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weight.Location = new Point(201, 235);
            weight.Name = "weight";
            weight.Size = new Size(158, 32);
            weight.TabIndex = 49;
            weight.Text = "Weight (kg)";
            // 
            // stroke
            // 
            stroke.AutoSize = true;
            stroke.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stroke.Location = new Point(201, 317);
            stroke.Name = "stroke";
            stroke.Size = new Size(86, 32);
            stroke.TabIndex = 48;
            stroke.Text = "Sroke";
            // 
            // minWin
            // 
            minWin.FlatAppearance.BorderSize = 0;
            minWin.FlatStyle = FlatStyle.Popup;
            minWin.Location = new Point(902, 20);
            minWin.Margin = new Padding(4, 3, 4, 3);
            minWin.Name = "minWin";
            minWin.Size = new Size(55, 29);
            minWin.TabIndex = 47;
            minWin.Text = "--";
            minWin.UseVisualStyleBackColor = true;
            minWin.Click += minWin_Click;
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(965, 20);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 29);
            closelog.TabIndex = 46;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // lap
            // 
            lap.AutoSize = true;
            lap.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lap.Location = new Point(201, 150);
            lap.Name = "lap";
            lap.Size = new Size(61, 32);
            lap.TabIndex = 45;
            lap.Text = "Lap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(71, 65);
            label1.Name = "label1";
            label1.Size = new Size(895, 42);
            label1.TabIndex = 44;
            label1.Text = "How much Calories do you spend while Swimming";
            // 
            // getTime
            // 
            getTime.Location = new Point(460, 399);
            getTime.Name = "getTime";
            getTime.Size = new Size(215, 31);
            getTime.TabIndex = 55;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.Location = new Point(201, 415);
            time.Name = "time";
            time.Size = new Size(143, 32);
            time.TabIndex = 56;
            time.Text = "Time (sec)";
            // 
            // Swimming
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 554);
            Controls.Add(time);
            Controls.Add(getTime);
            Controls.Add(levellap);
            Controls.Add(goHome);
            Controls.Add(calCal);
            Controls.Add(getStorke);
            Controls.Add(getWeight);
            Controls.Add(weight);
            Controls.Add(stroke);
            Controls.Add(minWin);
            Controls.Add(closelog);
            Controls.Add(lap);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Swimming";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Swimming";
            ((System.ComponentModel.ISupportInitialize)levellap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown levellap;
        private Button goHome;
        private Button calCal;
        private TextBox getStorke;
        private TextBox getWeight;
        private Label weight;
        private Label stroke;
        private Button minWin;
        private Button closelog;
        private Label lap;
        private Label label1;
        private TextBox getTime;
        private Label time;
    }
}