namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbody = new System.Windows.Forms.ComboBox();
            this.cbhead = new System.Windows.Forms.ComboBox();
            this.btnVis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbHead);
            this.groupBox1.Controls.Add(this.pbBody);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(65, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image View";
            // 
            // pbHead
            // 
            this.pbHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHead.Location = new System.Drawing.Point(105, 52);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(160, 161);
            this.pbHead.TabIndex = 6;
            this.pbHead.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBody.Location = new System.Drawing.Point(105, 165);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(160, 121);
            this.pbBody.TabIndex = 7;
            this.pbBody.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SELECT_A_CHARACTER_6_7_2024;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-22, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 129);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbody);
            this.groupBox2.Controls.Add(this.cbhead);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(510, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 29);
            this.txtName.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Orchid;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(99, 272);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(156, 40);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Head:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Body";
            // 
            // cbbody
            // 
            this.cbbody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbody.FormattingEnabled = true;
            this.cbbody.Items.AddRange(new object[] {
            "Body1",
            "Body2",
            "Body3",
            "Body4",
            "Body5",
            "Body6"});
            this.cbbody.Location = new System.Drawing.Point(58, 150);
            this.cbbody.Name = "cbbody";
            this.cbbody.Size = new System.Drawing.Size(233, 30);
            this.cbbody.TabIndex = 3;
            // 
            // cbhead
            // 
            this.cbhead.BackColor = System.Drawing.SystemColors.Window;
            this.cbhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbhead.FormattingEnabled = true;
            this.cbhead.Items.AddRange(new object[] {
            "Head1",
            "Head2",
            "Head3",
            "Head4",
            "Head5",
            "Head6"});
            this.cbhead.Location = new System.Drawing.Point(58, 67);
            this.cbhead.Name = "cbhead";
            this.cbhead.Size = new System.Drawing.Size(233, 30);
            this.cbhead.TabIndex = 2;
            this.cbhead.SelectedIndexChanged += new System.EventHandler(this.cbhead_SelectedIndexChanged);
            // 
            // btnVis
            // 
            this.btnVis.BackColor = System.Drawing.Color.Orchid;
            this.btnVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVis.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVis.ForeColor = System.Drawing.Color.White;
            this.btnVis.Location = new System.Drawing.Point(623, 472);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(129, 34);
            this.btnVis.TabIndex = 7;
            this.btnVis.Text = "PROCEED";
            this.btnVis.UseVisualStyleBackColor = false;
            this.btnVis.Visible = false;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 525);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wheel of Fortune | Select Character";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbody;
        private System.Windows.Forms.ComboBox cbhead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
    }
}