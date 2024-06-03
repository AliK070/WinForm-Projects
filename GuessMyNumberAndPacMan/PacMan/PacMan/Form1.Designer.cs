namespace PacMan
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
            this.button1 = new System.Windows.Forms.Button();
            this.PacManDeful = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PacManDeful)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PacManDeful
            // 
            this.PacManDeful.BackgroundImage = global::PacMan.Properties.Resources.pacMouthClosed;
            this.PacManDeful.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PacManDeful.Location = new System.Drawing.Point(12, 12);
            this.PacManDeful.Name = "PacManDeful";
            this.PacManDeful.Size = new System.Drawing.Size(58, 50);
            this.PacManDeful.TabIndex = 1;
            this.PacManDeful.TabStop = false;
            this.PacManDeful.Click += new System.EventHandler(this.PacManDeful_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(752, 412);
            this.Controls.Add(this.PacManDeful);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PacManDeful)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PacManDeful;
    }
}

