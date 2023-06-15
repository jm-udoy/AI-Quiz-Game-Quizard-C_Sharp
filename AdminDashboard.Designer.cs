namespace WindowsFormsAppQuizard
{
    partial class AdminDashboard
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
            this.lblAdminDashboard = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPasswordAdmin = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbQuistionID = new System.Windows.Forms.TextBox();
            this.lblQuistionID = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btbSearch = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnQuestionDetails = new System.Windows.Forms.Button();
            this.btnPlayerDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnPlayerDetails);
            this.panel1.Controls.Add(this.btnQuestionDetails);
            this.panel1.Controls.Add(this.btnDelet);
            this.panel1.Controls.Add(this.btbSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tbAnswer);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbPasswordAdmin);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.tbQuistionID);
            this.panel1.Controls.Add(this.lblQuistionID);
            this.panel1.Controls.Add(this.lblAdminDashboard);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAdminDashboard
            // 
            this.lblAdminDashboard.AutoSize = true;
            this.lblAdminDashboard.Font = new System.Drawing.Font("Olympia Deco", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblAdminDashboard.Location = new System.Drawing.Point(308, 2);
            this.lblAdminDashboard.Name = "lblAdminDashboard";
            this.lblAdminDashboard.Size = new System.Drawing.Size(185, 21);
            this.lblAdminDashboard.TabIndex = 3;
            this.lblAdminDashboard.Text = "Admin Dashboard";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(428, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tbPasswordAdmin
            // 
            this.tbPasswordAdmin.Location = new System.Drawing.Point(30, 115);
            this.tbPasswordAdmin.Name = "tbPasswordAdmin";
            this.tbPasswordAdmin.Size = new System.Drawing.Size(353, 20);
            this.tbPasswordAdmin.TabIndex = 16;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblQuestion.Location = new System.Drawing.Point(27, 99);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 15;
            this.lblQuestion.Text = "Question";
            // 
            // tbQuistionID
            // 
            this.tbQuistionID.Location = new System.Drawing.Point(30, 67);
            this.tbQuistionID.Name = "tbQuistionID";
            this.tbQuistionID.Size = new System.Drawing.Size(353, 20);
            this.tbQuistionID.TabIndex = 14;
            // 
            // lblQuistionID
            // 
            this.lblQuistionID.AutoSize = true;
            this.lblQuistionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuistionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblQuistionID.Location = new System.Drawing.Point(27, 51);
            this.lblQuistionID.Name = "lblQuistionID";
            this.lblQuistionID.Size = new System.Drawing.Size(59, 13);
            this.lblQuistionID.TabIndex = 13;
            this.lblQuistionID.Text = "Quistion ID";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(30, 161);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(353, 20);
            this.tbAnswer.TabIndex = 19;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblAnswer.Location = new System.Drawing.Point(27, 145);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 18;
            this.lblAnswer.Text = "Answer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 28);
            this.textBox1.TabIndex = 20;
            // 
            // btbSearch
            // 
            this.btbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btbSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSearch.Location = new System.Drawing.Point(297, 215);
            this.btbSearch.Name = "btbSearch";
            this.btbSearch.Size = new System.Drawing.Size(86, 28);
            this.btbSearch.TabIndex = 21;
            this.btbSearch.Text = "Search";
            this.btbSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnDelet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnDelet.FlatAppearance.BorderSize = 3;
            this.btnDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelet.Location = new System.Drawing.Point(599, 109);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(150, 31);
            this.btnDelet.TabIndex = 22;
            this.btnDelet.Text = "Delet";
            this.btnDelet.UseVisualStyleBackColor = false;
            // 
            // btnQuestionDetails
            // 
            this.btnQuestionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.btnQuestionDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnQuestionDetails.FlatAppearance.BorderSize = 3;
            this.btnQuestionDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionDetails.Location = new System.Drawing.Point(428, 212);
            this.btnQuestionDetails.Name = "btnQuestionDetails";
            this.btnQuestionDetails.Size = new System.Drawing.Size(150, 31);
            this.btnQuestionDetails.TabIndex = 23;
            this.btnQuestionDetails.Text = "Question Details >>";
            this.btnQuestionDetails.UseVisualStyleBackColor = false;
            // 
            // btnPlayerDetails
            // 
            this.btnPlayerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(175)))), ((int)(((byte)(168)))));
            this.btnPlayerDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnPlayerDetails.FlatAppearance.BorderSize = 3;
            this.btnPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerDetails.Location = new System.Drawing.Point(599, 212);
            this.btnPlayerDetails.Name = "btnPlayerDetails";
            this.btnPlayerDetails.Size = new System.Drawing.Size(150, 31);
            this.btnPlayerDetails.TabIndex = 24;
            this.btnPlayerDetails.Text = "Player Details >>";
            this.btnPlayerDetails.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 172);
            this.dataGridView1.TabIndex = 25;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPlayerDetails;
        private System.Windows.Forms.Button btnQuestionDetails;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btbSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPasswordAdmin;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox tbQuistionID;
        private System.Windows.Forms.Label lblQuistionID;
    }
}