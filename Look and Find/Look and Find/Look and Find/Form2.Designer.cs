namespace Look_and_Find
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPillow = new System.Windows.Forms.PictureBox();
            this.pbSofa = new System.Windows.Forms.PictureBox();
            this.pbPlaque = new System.Windows.Forms.PictureBox();
            this.pbBorder = new System.Windows.Forms.PictureBox();
            this.pbVase = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPillow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSofa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(956, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spot at least Five Diffrences";
            // 
            // lblCount
            // 
            this.lblCount.AccessibleName = "lblCount";
            this.lblCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(1058, 183);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(105, 128);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AccessibleName = "lblCount";
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(990, 500);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(286, 128);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "1:12";
            // 
            // pb3
            // 
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Location = new System.Drawing.Point(1176, 339);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 100);
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.MouseEnter += new System.EventHandler(this.pb3_MouseEnter);
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb2.Location = new System.Drawing.Point(1070, 339);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 100);
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            this.pb2.MouseEnter += new System.EventHandler(this.pb2_MouseEnter);
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb1.Location = new System.Drawing.Point(961, 339);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 100);
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            this.pb1.MouseEnter += new System.EventHandler(this.pb1_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Look_and_Find.Properties.Resources.spotdiff;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pbPillow);
            this.panel1.Controls.Add(this.pbSofa);
            this.panel1.Controls.Add(this.pbPlaque);
            this.panel1.Controls.Add(this.pbBorder);
            this.panel1.Controls.Add(this.pbVase);
            this.panel1.Controls.Add(this.pbHead);
            this.panel1.Location = new System.Drawing.Point(31, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 651);
            this.panel1.TabIndex = 3;
            // 
            // pbPillow
            // 
            this.pbPillow.BackColor = System.Drawing.Color.Transparent;
            this.pbPillow.Location = new System.Drawing.Point(862, 337);
            this.pbPillow.Name = "pbPillow";
            this.pbPillow.Size = new System.Drawing.Size(34, 65);
            this.pbPillow.TabIndex = 5;
            this.pbPillow.TabStop = false;
            this.pbPillow.MouseEnter += new System.EventHandler(this.pbPillow_MouseEnter);
            // 
            // pbSofa
            // 
            this.pbSofa.BackColor = System.Drawing.Color.Transparent;
            this.pbSofa.Location = new System.Drawing.Point(567, 453);
            this.pbSofa.Name = "pbSofa";
            this.pbSofa.Size = new System.Drawing.Size(54, 23);
            this.pbSofa.TabIndex = 4;
            this.pbSofa.TabStop = false;
            this.pbSofa.MouseEnter += new System.EventHandler(this.pbSofa_MouseEnter);
            // 
            // pbPlaque
            // 
            this.pbPlaque.BackColor = System.Drawing.Color.Transparent;
            this.pbPlaque.Location = new System.Drawing.Point(535, 319);
            this.pbPlaque.Name = "pbPlaque";
            this.pbPlaque.Size = new System.Drawing.Size(34, 41);
            this.pbPlaque.TabIndex = 3;
            this.pbPlaque.TabStop = false;
            this.pbPlaque.MouseEnter += new System.EventHandler(this.pbPlaque_MouseEnter);
            // 
            // pbBorder
            // 
            this.pbBorder.BackColor = System.Drawing.Color.Transparent;
            this.pbBorder.Location = new System.Drawing.Point(693, 201);
            this.pbBorder.Name = "pbBorder";
            this.pbBorder.Size = new System.Drawing.Size(155, 107);
            this.pbBorder.TabIndex = 2;
            this.pbBorder.TabStop = false;
            this.pbBorder.MouseEnter += new System.EventHandler(this.pbBorder_MouseEnter);
            // 
            // pbVase
            // 
            this.pbVase.BackColor = System.Drawing.Color.Transparent;
            this.pbVase.Location = new System.Drawing.Point(470, 267);
            this.pbVase.Name = "pbVase";
            this.pbVase.Size = new System.Drawing.Size(34, 41);
            this.pbVase.TabIndex = 1;
            this.pbVase.TabStop = false;
            this.pbVase.MouseEnter += new System.EventHandler(this.pbVase_MouseEnter);
            // 
            // pbHead
            // 
            this.pbHead.BackColor = System.Drawing.Color.Transparent;
            this.pbHead.Location = new System.Drawing.Point(587, 213);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(34, 41);
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            this.pbHead.MouseEnter += new System.EventHandler(this.pbHead_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 722);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Part Two | Find the Difference";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPillow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSofa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPillow;
        private System.Windows.Forms.PictureBox pbSofa;
        private System.Windows.Forms.PictureBox pbPlaque;
        private System.Windows.Forms.PictureBox pbBorder;
        private System.Windows.Forms.PictureBox pbVase;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}