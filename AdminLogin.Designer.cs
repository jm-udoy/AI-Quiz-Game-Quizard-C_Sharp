namespace WindowsFormsAppQuizard
{
    partial class AdminLogin
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
            this.lblRegistration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.tbPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lblPassworAdmin = new System.Windows.Forms.Label();
            this.tbUsernameAdmin = new System.Windows.Forms.TextBox();
            this.lblUsernameAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Olympia Deco", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblRegistration.Location = new System.Drawing.Point(136, 51);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(129, 21);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "Admin login";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoginAdmin);
            this.panel1.Controls.Add(this.tbPasswordAdmin);
            this.panel1.Controls.Add(this.lblPassworAdmin);
            this.panel1.Controls.Add(this.tbUsernameAdmin);
            this.panel1.Controls.Add(this.lblUsernameAdmin);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 303);
            this.panel1.TabIndex = 1;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnLoginAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnLoginAdmin.FlatAppearance.BorderSize = 3;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(125, 202);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(150, 31);
            this.btnLoginAdmin.TabIndex = 12;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            // 
            // tbPasswordAdmin
            // 
            this.tbPasswordAdmin.Location = new System.Drawing.Point(78, 156);
            this.tbPasswordAdmin.Name = "tbPasswordAdmin";
            this.tbPasswordAdmin.Size = new System.Drawing.Size(245, 20);
            this.tbPasswordAdmin.TabIndex = 9;
            // 
            // lblPassworAdmin
            // 
            this.lblPassworAdmin.AutoSize = true;
            this.lblPassworAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassworAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblPassworAdmin.Location = new System.Drawing.Point(75, 140);
            this.lblPassworAdmin.Name = "lblPassworAdmin";
            this.lblPassworAdmin.Size = new System.Drawing.Size(53, 13);
            this.lblPassworAdmin.TabIndex = 8;
            this.lblPassworAdmin.Text = "Password";
            // 
            // tbUsernameAdmin
            // 
            this.tbUsernameAdmin.Location = new System.Drawing.Point(78, 108);
            this.tbUsernameAdmin.Name = "tbUsernameAdmin";
            this.tbUsernameAdmin.Size = new System.Drawing.Size(245, 20);
            this.tbUsernameAdmin.TabIndex = 7;
            // 
            // lblUsernameAdmin
            // 
            this.lblUsernameAdmin.AutoSize = true;
            this.lblUsernameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblUsernameAdmin.Location = new System.Drawing.Point(75, 92);
            this.lblUsernameAdmin.Name = "lblUsernameAdmin";
            this.lblUsernameAdmin.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameAdmin.TabIndex = 6;
            this.lblUsernameAdmin.Text = "Username";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(417, 327);
            this.Controls.Add(this.panel1);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.TextBox tbPasswordAdmin;
        private System.Windows.Forms.Label lblPassworAdmin;
        private System.Windows.Forms.TextBox tbUsernameAdmin;
        private System.Windows.Forms.Label lblUsernameAdmin;
    }
}