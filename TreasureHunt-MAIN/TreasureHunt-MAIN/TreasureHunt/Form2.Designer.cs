namespace TreasureHunt
{
    partial class Form2
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
            panel5 = new Panel();
            button2 = new Button();
            pictureBox6 = new PictureBox();
            lblscore = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(18, 65, 42);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(lblscore);
            panel5.Location = new Point(-35, -50);
            panel5.Name = "panel5";
            panel5.Size = new Size(1173, 590);
            panel5.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(18, 65, 42);
            button2.Cursor = Cursors.No;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(504, 446);
            button2.Name = "button2";
            button2.Size = new Size(175, 60);
            button2.TabIndex = 28;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.CONGRATULATIONS_YOU_HAVE_FOU_4_5_2024;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(172, 172);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(851, 248);
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblscore.ForeColor = Color.White;
            lblscore.Location = new Point(172, 132);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(0, 55);
            lblscore.TabIndex = 5;
            lblscore.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 490);
            Controls.Add(panel5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minecraft Treasure Hunt";
            Load += Form2_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label lblscore;
        private PictureBox pictureBox6;
        private Button button2;
    }
}