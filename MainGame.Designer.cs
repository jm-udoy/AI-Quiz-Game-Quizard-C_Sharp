namespace WindowsFormsAppQuizard
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnsterOptA = new System.Windows.Forms.Button();
            this.btnAnsterOptC = new System.Windows.Forms.Button();
            this.btnAnsterOptD = new System.Windows.Forms.Button();
            this.btnAnsterOptB = new System.Windows.Forms.Button();
            this.lvlLevel1 = new System.Windows.Forms.Label();
            this.lvlLevel2 = new System.Windows.Forms.Label();
            this.lvlLevel3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lvlLevel3);
            this.panel1.Controls.Add(this.lvlLevel2);
            this.panel1.Controls.Add(this.lvlLevel1);
            this.panel1.Controls.Add(this.btnAnsterOptD);
            this.panel1.Controls.Add(this.btnAnsterOptB);
            this.panel1.Controls.Add(this.btnAnsterOptC);
            this.panel1.Controls.Add(this.btnAnsterOptA);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Olympia Deco", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.lblQuestion.Location = new System.Drawing.Point(3, 228);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(770, 54);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnsterOptA
            // 
            this.btnAnsterOptA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnAnsterOptA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnAnsterOptA.FlatAppearance.BorderSize = 5;
            this.btnAnsterOptA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsterOptA.Font = new System.Drawing.Font("Olympia Deco", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnsterOptA.Location = new System.Drawing.Point(3, 297);
            this.btnAnsterOptA.Name = "btnAnsterOptA";
            this.btnAnsterOptA.Size = new System.Drawing.Size(354, 55);
            this.btnAnsterOptA.TabIndex = 7;
            this.btnAnsterOptA.Text = "a: option 1";
            this.btnAnsterOptA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnsterOptA.UseVisualStyleBackColor = false;
            // 
            // btnAnsterOptC
            // 
            this.btnAnsterOptC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnAnsterOptC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnAnsterOptC.FlatAppearance.BorderSize = 5;
            this.btnAnsterOptC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsterOptC.Font = new System.Drawing.Font("Olympia Deco", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnsterOptC.Location = new System.Drawing.Point(3, 365);
            this.btnAnsterOptC.Name = "btnAnsterOptC";
            this.btnAnsterOptC.Size = new System.Drawing.Size(354, 55);
            this.btnAnsterOptC.TabIndex = 8;
            this.btnAnsterOptC.Text = "c: option 3";
            this.btnAnsterOptC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnsterOptC.UseVisualStyleBackColor = false;
            // 
            // btnAnsterOptD
            // 
            this.btnAnsterOptD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnAnsterOptD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnAnsterOptD.FlatAppearance.BorderSize = 5;
            this.btnAnsterOptD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsterOptD.Font = new System.Drawing.Font("Olympia Deco", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnsterOptD.Location = new System.Drawing.Point(422, 365);
            this.btnAnsterOptD.Name = "btnAnsterOptD";
            this.btnAnsterOptD.Size = new System.Drawing.Size(354, 55);
            this.btnAnsterOptD.TabIndex = 10;
            this.btnAnsterOptD.Text = "d: option 4";
            this.btnAnsterOptD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnsterOptD.UseVisualStyleBackColor = false;
            // 
            // btnAnsterOptB
            // 
            this.btnAnsterOptB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(187)))));
            this.btnAnsterOptB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.btnAnsterOptB.FlatAppearance.BorderSize = 5;
            this.btnAnsterOptB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnsterOptB.Font = new System.Drawing.Font("Olympia Deco", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnsterOptB.Location = new System.Drawing.Point(422, 297);
            this.btnAnsterOptB.Name = "btnAnsterOptB";
            this.btnAnsterOptB.Size = new System.Drawing.Size(354, 55);
            this.btnAnsterOptB.TabIndex = 9;
            this.btnAnsterOptB.Text = "b: option 2";
            this.btnAnsterOptB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnsterOptB.UseVisualStyleBackColor = false;
            // 
            // lvlLevel1
            // 
            this.lvlLevel1.BackColor = System.Drawing.Color.LimeGreen;
            this.lvlLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlLevel1.Font = new System.Drawing.Font("Olympia Deco", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlLevel1.ForeColor = System.Drawing.Color.Black;
            this.lvlLevel1.Location = new System.Drawing.Point(52, 0);
            this.lvlLevel1.Name = "lvlLevel1";
            this.lvlLevel1.Size = new System.Drawing.Size(228, 24);
            this.lvlLevel1.TabIndex = 11;
            this.lvlLevel1.Text = "level 1";
            this.lvlLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvlLevel2
            // 
            this.lvlLevel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lvlLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlLevel2.Font = new System.Drawing.Font("Olympia Deco", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlLevel2.ForeColor = System.Drawing.Color.Black;
            this.lvlLevel2.Location = new System.Drawing.Point(286, 0);
            this.lvlLevel2.Name = "lvlLevel2";
            this.lvlLevel2.Size = new System.Drawing.Size(228, 24);
            this.lvlLevel2.TabIndex = 12;
            this.lvlLevel2.Text = "level 2";
            this.lvlLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvlLevel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvlLevel3
            // 
            this.lvlLevel3.BackColor = System.Drawing.Color.Red;
            this.lvlLevel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlLevel3.Font = new System.Drawing.Font("Olympia Deco", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvlLevel3.ForeColor = System.Drawing.Color.Black;
            this.lvlLevel3.Location = new System.Drawing.Point(520, 0);
            this.lvlLevel3.Name = "lvlLevel3";
            this.lvlLevel3.Size = new System.Drawing.Size(228, 24);
            this.lvlLevel3.TabIndex = 13;
            this.lvlLevel3.Text = "level 3";
            this.lvlLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(13)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnsterOptD;
        private System.Windows.Forms.Button btnAnsterOptB;
        private System.Windows.Forms.Button btnAnsterOptC;
        private System.Windows.Forms.Button btnAnsterOptA;
        private System.Windows.Forms.Label lvlLevel3;
        private System.Windows.Forms.Label lvlLevel2;
        private System.Windows.Forms.Label lvlLevel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}