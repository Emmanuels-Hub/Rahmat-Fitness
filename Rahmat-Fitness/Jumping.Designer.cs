namespace Rahmat_Fitness
{
    partial class Jumping
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
            getDur = new TextBox();
            getWeight = new TextBox();
            weight = new Label();
            minWin = new Button();
            closelog = new Button();
            intensity = new Label();
            label1 = new Label();
            levelInt = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)levelInt).BeginInit();
            SuspendLayout();
            // 
            // goHome
            // 
            goHome.FlatAppearance.BorderSize = 0;
            goHome.FlatStyle = FlatStyle.Popup;
            goHome.Location = new Point(30, 23);
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
            calCal.Location = new Point(473, 414);
            calCal.Name = "calCal";
            calCal.Size = new Size(215, 34);
            calCal.TabIndex = 41;
            calCal.Text = "Check";
            calCal.UseVisualStyleBackColor = false;
            calCal.Click += calCal_Click;
            // 
            // getDur
            // 
            getDur.Location = new Point(473, 329);
            getDur.Name = "getDur";
            getDur.Size = new Size(215, 30);
            getDur.TabIndex = 40;
            // 
            // getWeight
            // 
            getWeight.Location = new Point(473, 249);
            getWeight.Name = "getWeight";
            getWeight.Size = new Size(215, 30);
            getWeight.TabIndex = 39;
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weight.Location = new Point(214, 245);
            weight.Name = "weight";
            weight.Size = new Size(158, 32);
            weight.TabIndex = 38;
            weight.Text = "Weight (kg)";
            // 
            // minWin
            // 
            minWin.FlatAppearance.BorderSize = 0;
            minWin.FlatStyle = FlatStyle.Popup;
            minWin.Location = new Point(915, 30);
            minWin.Margin = new Padding(4, 3, 4, 3);
            minWin.Name = "minWin";
            minWin.Size = new Size(55, 29);
            minWin.TabIndex = 35;
            minWin.Text = "--";
            minWin.UseVisualStyleBackColor = true;
            minWin.Click += minWin_Click;
            // 
            // closelog
            // 
            closelog.FlatAppearance.BorderSize = 0;
            closelog.FlatStyle = FlatStyle.Popup;
            closelog.Location = new Point(978, 30);
            closelog.Margin = new Padding(4, 3, 4, 3);
            closelog.Name = "closelog";
            closelog.Size = new Size(55, 29);
            closelog.TabIndex = 34;
            closelog.Text = "X";
            closelog.UseVisualStyleBackColor = true;
            closelog.Click += closelog_Click;
            // 
            // intensity
            // 
            intensity.AutoSize = true;
            intensity.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intensity.Location = new Point(214, 160);
            intensity.Name = "intensity";
            intensity.Size = new Size(221, 32);
            intensity.TabIndex = 33;
            intensity.Text = "Level of Intensity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(84, 75);
            label1.Name = "label1";
            label1.Size = new Size(866, 42);
            label1.TabIndex = 32;
            label1.Text = "How much Calories do you spend while Jumping";
            // 
            // levelInt
            // 
            levelInt.BorderStyle = BorderStyle.None;
            levelInt.Location = new Point(473, 165);
            levelInt.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            levelInt.Name = "levelInt";
            levelInt.Size = new Size(215, 26);
            levelInt.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 329);
            label2.Name = "label2";
            label2.Size = new Size(135, 36);
            label2.TabIndex = 44;
            label2.Text = "Duration";
            // 
            // Jumping
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 490);
            Controls.Add(label2);
            Controls.Add(levelInt);
            Controls.Add(goHome);
            Controls.Add(calCal);
            Controls.Add(getDur);
            Controls.Add(getWeight);
            Controls.Add(weight);
            Controls.Add(minWin);
            Controls.Add(closelog);
            Controls.Add(intensity);
            Controls.Add(label1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Jumping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jumping";
            ((System.ComponentModel.ISupportInitialize)levelInt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goHome;
        private Button calCal;
        private TextBox getDur;
        private TextBox getWeight;
        private Label weight;
        private Label time;
        private TextBox getDis;
        private Button minWin;
        private Button closelog;
        private Label intensity;
        private Label label1;
        private NumericUpDown levelInt;
        private Label label2;
    }
}