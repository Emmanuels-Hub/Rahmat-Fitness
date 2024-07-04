namespace Rahmat_Fitness
{
    partial class Cycling
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
            goHome = new Button();
            calCal = new Button();
            getTime = new TextBox();
            getWeight = new TextBox();
            weight = new Label();
            time = new Label();
            getDis = new TextBox();
            button1 = new Button();
            closelog = new Button();
            distance = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // goHome
            // 
            goHome.FlatAppearance.BorderSize = 0;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.Location = new Point(15, 16);
            goHome.Margin = new Padding(4, 3, 4, 3);
            goHome.Name = "goHome";
            goHome.Size = new Size(75, 29);
            goHome.TabIndex = 42;
            goHome.Text = "back";
            goHome.UseVisualStyleBackColor = true;
            goHome.Click += goHome_Click;
            // 
            // calCal
            // 
            calCal.BackColor = Color.FromArgb(116, 86, 174);
            calCal.FlatStyle = FlatStyle.Popup;
            calCal.ForeColor = Color.White;
            calCal.Location = new Point(428, 392);
            calCal.Name = "calCal";
            calCal.Size = new Size(215, 34);
            calCal.TabIndex = 41;
            calCal.Text = "Check";
            calCal.UseVisualStyleBackColor = false;
            calCal.Click += calCal_Click;
            // 
            // getTime
            // 
            getTime.Location = new Point(428, 320);
            getTime.Name = "getTime";
            getTime.Size = new Size(215, 30);
            getTime.TabIndex = 40;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(428, 244);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(215, 30);
            getWeight.TabIndex = 39;
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weight.Location = new Point(199, 238);
            weight.Name = "weight";
            weight.Size = new Size(158, 32);
            weight.TabIndex = 38;
            weight.Text = "Weight (kg)";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.Location = new Point(199, 320);
            time.Name = "time";
            time.Size = new Size(143, 32);
            time.TabIndex = 37;
            time.Text = "Time (sec)";
            // 
            // getDis
            // 
            getDis.Location = new Point(428, 159);
            getDis.Name = "getDis";
            getDis.Size = new Size(215, 30);
            getDis.TabIndex = 36;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(900, 23);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(55, 29);
            button1.TabIndex = 35;
            button1.Text = "--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(963, 23);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 29);
            closelog.TabIndex = 34;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // distance
            // 
            distance.AutoSize = true;
            distance.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            distance.Location = new Point(199, 153);
            distance.Name = "distance";
            distance.Size = new Size(172, 32);
            distance.TabIndex = 33;
            distance.Text = "Distance (m)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(69, 68);
            label1.Name = "label1";
            label1.Size = new Size(846, 42);
            label1.TabIndex = 32;
            label1.Text = "How much Calories do you spend while Cycling";
            // 
            // Cycling
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 477);
            Controls.Add(goHome);
            Controls.Add(calCal);
            Controls.Add(getTime);
            Controls.Add(getWeight);
            Controls.Add(weight);
            Controls.Add(time);
            Controls.Add(getDis);
            Controls.Add(button1);
            Controls.Add(closelog);
            Controls.Add(distance);
            Controls.Add(label1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cycling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cycling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goHome;
        private Button calCal;
        private TextBox getTime;
        private TextBox getWeight;
        private Label weight;
        private Label time;
        private TextBox getDis;
        private Button button1;
        private Button closelog;
        private Label distance;
        private Label label1;
    }
}