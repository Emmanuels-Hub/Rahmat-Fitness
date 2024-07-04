namespace Rahmat_Fitness
{
    partial class Yoga
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
            levelInt = new NumericUpDown();
            goHome = new Button();
            calCal = new Button();
            getDur = new TextBox();
            getWeight = new TextBox();
            weight = new Label();
            duration = new Label();
            minWin = new Button();
            closelog = new Button();
            intensity = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)levelInt).BeginInit();
            SuspendLayout();
            // 
            // levelInt
            // 
            levelInt.BorderStyle = BorderStyle.None;
            levelInt.Location = new Point(462, 156);
            levelInt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levelInt.Name = "levelInt";
            levelInt.Size = new Size(215, 27);
            levelInt.TabIndex = 54;
            // 
            // goHome
            // 
            goHome.FlatAppearance.BorderSize = 0;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.Location = new Point(19, 14);
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
            calCal.Location = new Point(462, 400);
            calCal.Name = "calCal";
            calCal.Size = new Size(215, 34);
            calCal.TabIndex = 52;
            calCal.Text = "check";
            calCal.UseVisualStyleBackColor = false;
            calCal.Click += calCal_Click;
            // 
            // getDur
            // 
            getDur.Location = new Point(462, 320);
            getDur.Name = "getDur";
            getDur.Size = new Size(215, 31);
            getDur.TabIndex = 51;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(462, 240);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(215, 31);
            getWeight.TabIndex = 50;
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weight.Location = new Point(203, 236);
            weight.Name = "weight";
            weight.Size = new Size(158, 32);
            weight.TabIndex = 49;
            weight.Text = "Weight (kg)";
            // 
            // duration
            // 
            duration.AutoSize = true;
            duration.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duration.Location = new Point(203, 318);
            duration.Name = "duration";
            duration.Size = new Size(119, 32);
            duration.TabIndex = 48;
            duration.Text = "Duration";
            // 
            // minWin
            // 
            minWin.FlatAppearance.BorderSize = 0;
            minWin.FlatStyle = FlatStyle.Popup;
            minWin.Location = new Point(904, 21);
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
            closelog.Location = new Point(967, 21);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 29);
            closelog.TabIndex = 46;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // intensity
            // 
            intensity.AutoSize = true;
            intensity.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intensity.Location = new Point(203, 151);
            intensity.Name = "intensity";
            intensity.Size = new Size(221, 32);
            intensity.TabIndex = 45;
            intensity.Text = "Level of Intensity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(73, 66);
            label1.Name = "label1";
            label1.Size = new Size(802, 42);
            label1.TabIndex = 44;
            label1.Text = "How much Calories do you spend while Yoga";
            // 
            // Yoga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 476);
            Controls.Add(levelInt);
            Controls.Add(goHome);
            Controls.Add(calCal);
            Controls.Add(getDur);
            Controls.Add(getWeight);
            Controls.Add(weight);
            Controls.Add(duration);
            Controls.Add(minWin);
            Controls.Add(closelog);
            Controls.Add(intensity);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Yoga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yoga";
            ((System.ComponentModel.ISupportInitialize)levelInt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown levelInt;
        private Button goHome;
        private Button calCal;
        private TextBox getDur;
        private TextBox getWeight;
        private Label weight;
        private Label duration;
        private Button minWin;
        private Button closelog;
        private Label intensity;
        private Label label1;
    }
}