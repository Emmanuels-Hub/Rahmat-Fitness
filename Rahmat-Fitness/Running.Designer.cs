namespace Rahmat_Fitness
{
    partial class Running
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
            distance = new Label();
            minWin = new Button();
            closelog = new Button();
            getDis = new TextBox();
            time = new Label();
            weight = new Label();
            getWeight = new TextBox();
            getTime = new TextBox();
            calCal = new Button();
            goHome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(67, 64);
            label1.Name = "label1";
            label1.Size = new Size(860, 42);
            label1.TabIndex = 0;
            label1.Text = "How much Calories do you spend while Running";
            // 
            // distance
            // 
            distance.AutoSize = true;
            distance.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            distance.Location = new Point(197, 149);
            distance.Name = "distance";
            distance.Size = new Size(172, 32);
            distance.TabIndex = 1;
            distance.Text = "Distance (m)";
            distance.Click += distance_Click;
            // 
            // minWin
            // 
            minWin.FlatAppearance.BorderSize = 0;
            minWin.FlatStyle = FlatStyle.Popup;
            minWin.Location = new Point(898, 19);
            minWin.Margin = new Padding(4, 3, 4, 3);
            minWin.Name = "minWin";
            minWin.Size = new Size(55, 29);
            minWin.TabIndex = 24;
            minWin.Text = "--";
            minWin.UseVisualStyleBackColor = true;
            minWin.Click += minWin_Click;
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(961, 19);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 29);
            closelog.TabIndex = 23;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // getDis
            // 
            getDis.Location = new Point(426, 155);
            getDis.Name = "getDis";
            getDis.Size = new Size(215, 28);
            getDis.TabIndex = 25;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.Location = new Point(197, 316);
            time.Name = "time";
            time.Size = new Size(143, 32);
            time.TabIndex = 26;
            time.Text = "Time (sec)";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weight.Location = new Point(197, 234);
            weight.Name = "weight";
            weight.Size = new Size(158, 32);
            weight.TabIndex = 27;
            weight.Text = "Weight (kg)";
            // 
            // getWeight
            // 
            getWeight.Location = new Point(426, 240);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(215, 28);
            getWeight.TabIndex = 28;
            // 
            // getTime
            // 
            getTime.Location = new Point(426, 316);
            getTime.Name = "getTime";
            getTime.Size = new Size(215, 28);
            getTime.TabIndex = 29;
            // 
            // calCal
            // 
            calCal.BackColor = Color.FromArgb(116, 86, 174);
            calCal.FlatStyle = FlatStyle.Popup;
            calCal.ForeColor = Color.White;
            calCal.Location = new Point(426, 403);
            calCal.Name = "calCal";
            calCal.Size = new Size(215, 34);
            calCal.TabIndex = 30;
            calCal.Text = "Check";
            calCal.UseVisualStyleBackColor = false;
            calCal.Click += calCal_Click;
            // 
            // goHome
            // 
            goHome.FlatAppearance.BorderSize = 0;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.Location = new Point(13, 12);
            goHome.Margin = new Padding(4, 3, 4, 3);
            goHome.Name = "goHome";
            goHome.Size = new Size(75, 29);
            goHome.TabIndex = 31;
            goHome.Text = "back";
            goHome.UseVisualStyleBackColor = true;
            goHome.Click += goHome_Click;
            // 
            // Running
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 479);
            Controls.Add(goHome);
            Controls.Add(calCal);
            Controls.Add(getTime);
            Controls.Add(getWeight);
            Controls.Add(weight);
            Controls.Add(time);
            Controls.Add(getDis);
            Controls.Add(minWin);
            Controls.Add(closelog);
            Controls.Add(distance);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Running";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Running";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label distance;
        private Button minWin;
        private Button closelog;
        private TextBox getDis;
        private Label time;
        private Label weight;
        private TextBox getWeight;
        private TextBox getTime;
        private Button calCal;
        private Button goHome;
    }
}