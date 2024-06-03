namespace RanNumGenLottery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.rbNum5 = new System.Windows.Forms.RadioButton();
            this.rbNum4 = new System.Windows.Forms.RadioButton();
            this.rbNum3 = new System.Windows.Forms.RadioButton();
            this.btnGen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lotto468";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RanNumGenLottery.Properties.Resources.lottery__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(298, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbGame
            // 
            this.gbGame.BackColor = System.Drawing.Color.Linen;
            this.gbGame.Controls.Add(this.rbNum5);
            this.gbGame.Controls.Add(this.rbNum4);
            this.gbGame.Controls.Add(this.rbNum3);
            this.gbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbGame.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGame.ForeColor = System.Drawing.Color.IndianRed;
            this.gbGame.Location = new System.Drawing.Point(28, 145);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(353, 281);
            this.gbGame.TabIndex = 2;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Pick a following Game:";
            // 
            // rbNum5
            // 
            this.rbNum5.AutoSize = true;
            this.rbNum5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNum5.Location = new System.Drawing.Point(56, 204);
            this.rbNum5.Name = "rbNum5";
            this.rbNum5.Size = new System.Drawing.Size(239, 35);
            this.rbNum5.TabIndex = 5;
            this.rbNum5.Text = "5-Number Lottery";
            this.rbNum5.UseVisualStyleBackColor = true;
            // 
            // rbNum4
            // 
            this.rbNum4.AutoSize = true;
            this.rbNum4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNum4.Location = new System.Drawing.Point(56, 135);
            this.rbNum4.Name = "rbNum4";
            this.rbNum4.Size = new System.Drawing.Size(239, 35);
            this.rbNum4.TabIndex = 4;
            this.rbNum4.Text = "4-Number Lottery";
            this.rbNum4.UseVisualStyleBackColor = true;
            // 
            // rbNum3
            // 
            this.rbNum3.AutoSize = true;
            this.rbNum3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNum3.Location = new System.Drawing.Point(56, 58);
            this.rbNum3.Name = "rbNum3";
            this.rbNum3.Size = new System.Drawing.Size(239, 35);
            this.rbNum3.TabIndex = 3;
            this.rbNum3.Text = "3-Number Lottery";
            this.rbNum3.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.Linen;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.btnGen.ForeColor = System.Drawing.Color.IndianRed;
            this.btnGen.Location = new System.Drawing.Point(28, 432);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(247, 45);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.lblGen);
            this.panel2.Location = new System.Drawing.Point(-2, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 38);
            this.panel2.TabIndex = 2;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.lblGen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGen.Location = new System.Drawing.Point(155, 5);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(0, 31);
            this.lblGen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(281, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(411, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto468 | Clean_UI-V4_AK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.RadioButton rbNum5;
        private System.Windows.Forms.RadioButton rbNum4;
        private System.Windows.Forms.RadioButton rbNum3;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Button button1;
    }
}

