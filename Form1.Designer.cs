namespace Racing_Project
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
            pnlCar = new Panel();
            pnl = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            pnlHut1 = new Panel();
            pnlHut2 = new Panel();
            tmrBeschl = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            tmrLinks = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            TmrVerz = new System.Windows.Forms.Timer(components);
            pnl.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCar
            // 
            pnlCar.BackColor = Color.FromArgb(0, 0, 192);
            pnlCar.Location = new Point(486, 369);
            pnlCar.Name = "pnlCar";
            pnlCar.Size = new Size(102, 139);
            pnlCar.TabIndex = 0;
            // 
            // pnl
            // 
            pnl.Controls.Add(panel7);
            pnl.Controls.Add(pnlHut1);
            pnl.Controls.Add(pnlHut2);
            pnl.Location = new Point(292, 99);
            pnl.Name = "pnl";
            pnl.Size = new Size(329, 156);
            pnl.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(8, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 0);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 128, 0);
            panel8.Location = new Point(270, 68);
            panel8.Name = "panel8";
            panel8.Size = new Size(26, 25);
            panel8.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 128, 0);
            panel9.Location = new Point(24, 68);
            panel9.Name = "panel9";
            panel9.Size = new Size(28, 25);
            panel9.TabIndex = 0;
            // 
            // pnlHut1
            // 
            pnlHut1.BackColor = Color.FromArgb(255, 128, 0);
            pnlHut1.Location = new Point(270, 68);
            pnlHut1.Name = "pnlHut1";
            pnlHut1.Size = new Size(26, 25);
            pnlHut1.TabIndex = 1;
            pnlHut1.Paint += pnlHut1_Paint;
            // 
            // pnlHut2
            // 
            pnlHut2.BackColor = Color.FromArgb(255, 128, 0);
            pnlHut2.Location = new Point(24, 68);
            pnlHut2.Name = "pnlHut2";
            pnlHut2.Size = new Size(28, 25);
            pnlHut2.TabIndex = 0;
            // 
            // tmrBeschl
            // 
            tmrBeschl.Interval = 50;
            tmrBeschl.Tick += tmrBeschl_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 3;
            label1.Text = "Geschwindigkeiten";
            // 
            // tmrLinks
            // 
            tmrLinks.Interval = 50;
            tmrLinks.Tick += tmrLinks_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(42, -200);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 156);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(270, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 25);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Location = new Point(24, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(28, 25);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(674, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 156);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Location = new Point(270, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(26, 25);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Location = new Point(24, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(28, 25);
            panel6.TabIndex = 0;
            // 
            // TmrVerz
            // 
            TmrVerz.Interval = 50;
            TmrVerz.Tick += TmrVerz_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 520);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(pnl);
            Controls.Add(pnlCar);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Steuerung_KeyDown;
            KeyUp += Steuerung_KeyUp;
            pnl.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCar;
        private Panel pnl;
        private Panel pnlHut1;
        private Panel pnlHut2;
        private System.Windows.Forms.Timer tmrBeschl;
        private Label label1;
        private System.Windows.Forms.Timer tmrLinks;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private System.Windows.Forms.Timer TmrVerz;
    }
}
