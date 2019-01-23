namespace OceanBank.Codes.GUI
{
    partial class SelectCard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.User1OK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.User2OK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.User3OK = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 332);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.User1OK);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User 1";
            // 
            // User1OK
            // 
            this.User1OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User1OK.Location = new System.Drawing.Point(3, 18);
            this.User1OK.Name = "User1OK";
            this.User1OK.Size = new System.Drawing.Size(233, 79);
            this.User1OK.TabIndex = 0;
            this.User1OK.Text = "Insert Card";
            this.User1OK.UseVisualStyleBackColor = true;
            this.User1OK.Click += new System.EventHandler(this.User1OK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.User2OK);
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User 2";
            // 
            // User2OK
            // 
            this.User2OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User2OK.Location = new System.Drawing.Point(3, 18);
            this.User2OK.Name = "User2OK";
            this.User2OK.Size = new System.Drawing.Size(233, 79);
            this.User2OK.TabIndex = 0;
            this.User2OK.Text = "Insert Card";
            this.User2OK.UseVisualStyleBackColor = true;
            this.User2OK.Click += new System.EventHandler(this.User2OK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.User3OK);
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User 3";
            // 
            // User3OK
            // 
            this.User3OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User3OK.Location = new System.Drawing.Point(3, 18);
            this.User3OK.Name = "User3OK";
            this.User3OK.Size = new System.Drawing.Size(233, 79);
            this.User3OK.TabIndex = 0;
            this.User3OK.Text = "Insert Card";
            this.User3OK.UseVisualStyleBackColor = true;
            this.User3OK.Click += new System.EventHandler(this.User3OK_Click);
            // 
            // SelectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 332);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectCard";
            this.Text = "SelectCard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button User1OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button User2OK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button User3OK;
    }
}