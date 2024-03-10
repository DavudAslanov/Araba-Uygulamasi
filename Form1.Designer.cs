namespace Araba_Uygulamasi
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            road = new Panel();
            car = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            breakPanel10 = new Panel();
            gasPanel11 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            road.SuspendLayout();
            car.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // road
            // 
            road.BackColor = Color.Gray;
            road.Controls.Add(car);
            road.Controls.Add(panel3);
            road.Controls.Add(panel2);
            road.Controls.Add(panel1);
            road.Dock = DockStyle.Left;
            road.Location = new Point(0, 0);
            road.Name = "road";
            road.Size = new Size(250, 636);
            road.TabIndex = 0;
            // 
            // car
            // 
            car.BackColor = Color.Black;
            car.Controls.Add(panel9);
            car.Controls.Add(panel8);
            car.Controls.Add(panel5);
            car.Location = new Point(140, 429);
            car.Name = "car";
            car.Size = new Size(90, 177);
            car.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Red;
            panel9.Location = new Point(0, 156);
            panel9.Name = "panel9";
            panel9.Size = new Size(26, 21);
            panel9.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Red;
            panel8.Location = new Point(64, 156);
            panel8.Name = "panel8";
            panel8.Size = new Size(26, 21);
            panel8.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 45);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Yellow;
            panel7.Location = new Point(64, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(26, 29);
            panel7.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(26, 29);
            panel6.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(91, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(28, 125);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(91, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 125);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(91, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(28, 125);
            panel1.TabIndex = 1;
            // 
            // breakPanel10
            // 
            breakPanel10.BackColor = Color.DarkRed;
            breakPanel10.Location = new Point(279, 22);
            breakPanel10.Name = "breakPanel10";
            breakPanel10.Size = new Size(250, 172);
            breakPanel10.TabIndex = 1;
            breakPanel10.MouseEnter += breakPanel10_MouseEnter;
            // 
            // gasPanel11
            // 
            gasPanel11.BackColor = Color.ForestGreen;
            gasPanel11.Location = new Point(279, 224);
            gasPanel11.Name = "gasPanel11";
            gasPanel11.Size = new Size(250, 193);
            gasPanel11.TabIndex = 2;
            gasPanel11.MouseEnter += breakPanel11_MouseEnter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(279, 429);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 193);
            panel4.TabIndex = 3;
            panel4.MouseEnter += panel4_MouseEnter;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 636);
            Controls.Add(panel4);
            Controls.Add(gasPanel11);
            Controls.Add(breakPanel10);
            Controls.Add(road);
            Name = "Form1";
            Text = "Form1";
            road.ResumeLayout(false);
            car.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel road;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel car;
        private Panel panel9;
        private Panel panel8;
        private Panel panel5;
        private Panel breakPanel10;
        private Panel gasPanel11;
        private System.Windows.Forms.Timer timer1;
        private Panel panel4;
        private System.Windows.Forms.Timer timer2;
    }
}