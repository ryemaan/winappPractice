namespace table
{
    partial class Frmreg
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
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.PhoneNumbertxt = new System.Windows.Forms.TextBox();
            this.Logintxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.tablebtn = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(6, 65);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(185, 20);
            this.UserNametxt.TabIndex = 0;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(6, 104);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(185, 20);
            this.Emailtxt.TabIndex = 1;
            // 
            // PhoneNumbertxt
            // 
            this.PhoneNumbertxt.Location = new System.Drawing.Point(6, 143);
            this.PhoneNumbertxt.Name = "PhoneNumbertxt";
            this.PhoneNumbertxt.Size = new System.Drawing.Size(185, 20);
            this.PhoneNumbertxt.TabIndex = 2;
            // 
            // Logintxt
            // 
            this.Logintxt.Location = new System.Drawing.Point(5, 182);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(185, 20);
            this.Logintxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PhoneNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(5, 221);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(185, 20);
            this.Passwordtxt.TabIndex = 9;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(6, 247);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(185, 23);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // tablebtn
            // 
            this.tablebtn.Location = new System.Drawing.Point(6, 276);
            this.tablebtn.Name = "tablebtn";
            this.tablebtn.Size = new System.Drawing.Size(185, 23);
            this.tablebtn.TabIndex = 11;
            this.tablebtn.Text = "Open Table";
            this.tablebtn.UseVisualStyleBackColor = true;
            this.tablebtn.Click += new System.EventHandler(this.tablebtn_Click);
            // 
            // dgvData
            // 
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvData.Location = new System.Drawing.Point(197, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(603, 450);
            this.dgvData.TabIndex = 12;
            // 
            // Frmreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tablebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logintxt);
            this.Controls.Add(this.PhoneNumbertxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.UserNametxt);
            this.Name = "Frmreg";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox PhoneNumbertxt;
        private System.Windows.Forms.TextBox Logintxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button tablebtn;
        private System.Windows.Forms.DataGridView dgvData;
    }
}