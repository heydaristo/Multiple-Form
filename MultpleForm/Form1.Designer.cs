namespace MultpleForm
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
            this.panelside = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DimGray;
            this.panelside.Controls.Add(this.btnreports);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.btnemp);
            this.panelside.Controls.Add(this.btndashboard);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 420);
            this.panelside.TabIndex = 0;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelheader.Size = new System.Drawing.Size(800, 30);
            this.panelheader.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 420);
            this.mainpanel.TabIndex = 2;
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.DimGray;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(3, 124);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(200, 30);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "DASHBOARD";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.DimGray;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.ForeColor = System.Drawing.Color.White;
            this.btnemp.Location = new System.Drawing.Point(3, 160);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(200, 30);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "EMPLOYEE";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.DimGray;
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.Location = new System.Drawing.Point(3, 196);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(200, 30);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "REPORTS";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gray;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(767, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel mainpanel;
    }
}

