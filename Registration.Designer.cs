namespace WindowsFormsAppQuizard
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbEmailReg = new System.Windows.Forms.TextBox();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.lblEnterPasswor = new System.Windows.Forms.Label();
            this.tbUsernameReg = new System.Windows.Forms.TextBox();
            this.lblEnterUsername = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.tbEmailReg);
            this.panel1.Controls.Add(this.lblEnterEmail);
            this.panel1.Controls.Add(this.tbPasswordReg);
            this.panel1.Controls.Add(this.lblEnterPasswor);
            this.panel1.Controls.Add(this.tbUsernameReg);
            this.panel1.Controls.Add(this.lblEnterUsername);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 303);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnSubmit.FlatAppearance.BorderSize = 3;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(122, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 31);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // tbEmailReg
            // 
            this.tbEmailReg.Location = new System.Drawing.Point(75, 84);
            this.tbEmailReg.Name = "tbEmailReg";
            this.tbEmailReg.Size = new System.Drawing.Size(245, 20);
            this.tbEmailReg.TabIndex = 11;
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblEnterEmail.Location = new System.Drawing.Point(72, 68);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEnterEmail.TabIndex = 10;
            this.lblEnterEmail.Text = "Enter Email";
            this.lblEnterEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Location = new System.Drawing.Point(75, 180);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.Size = new System.Drawing.Size(245, 20);
            this.tbPasswordReg.TabIndex = 9;
            // 
            // lblEnterPasswor
            // 
            this.lblEnterPasswor.AutoSize = true;
            this.lblEnterPasswor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPasswor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblEnterPasswor.Location = new System.Drawing.Point(74, 164);
            this.lblEnterPasswor.Name = "lblEnterPasswor";
            this.lblEnterPasswor.Size = new System.Drawing.Size(81, 13);
            this.lblEnterPasswor.TabIndex = 8;
            this.lblEnterPasswor.Text = "Enter Password";
            // 
            // tbUsernameReg
            // 
            this.tbUsernameReg.Location = new System.Drawing.Point(75, 132);
            this.tbUsernameReg.Name = "tbUsernameReg";
            this.tbUsernameReg.Size = new System.Drawing.Size(245, 20);
            this.tbUsernameReg.TabIndex = 7;
            // 
            // lblEnterUsername
            // 
            this.lblEnterUsername.AutoSize = true;
            this.lblEnterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblEnterUsername.Location = new System.Drawing.Point(72, 116);
            this.lblEnterUsername.Name = "lblEnterUsername";
            this.lblEnterUsername.Size = new System.Drawing.Size(83, 13);
            this.lblEnterUsername.TabIndex = 6;
            this.lblEnterUsername.Text = "Enter Username";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Olympia Deco", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblRegistration.Location = new System.Drawing.Point(125, 26);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(144, 21);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "Registration";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(417, 327);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox tbEmailReg;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.TextBox tbPasswordReg;
        private System.Windows.Forms.Label lblEnterPasswor;
        private System.Windows.Forms.TextBox tbUsernameReg;
        private System.Windows.Forms.Label lblEnterUsername;
        private System.Windows.Forms.Button btnSubmit;
    }
}