namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StudenID = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.BirthyearTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.gradeTextbox = new System.Windows.Forms.TextBox();
            this.branchTextbox = new System.Windows.Forms.TextBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ClassScore = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Hscroe = new System.Windows.Forms.TextBox();
            this.Lscore = new System.Windows.Forms.TextBox();
            this.total_input = new System.Windows.Forms.TextBox();
            this.ClassScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อมูลประกอบนักศึกษา";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "รหัสนักศึกษา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ปีเกิด";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "ส่วนสูง";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "เกรด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "สาขา";
            // 
            // StudenID
            // 
            this.StudenID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StudenID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudenID.Location = new System.Drawing.Point(153, 130);
            this.StudenID.Name = "StudenID";
            this.StudenID.Size = new System.Drawing.Size(195, 22);
            this.StudenID.TabIndex = 7;
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextbox.Location = new System.Drawing.Point(153, 182);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(195, 22);
            this.NameTextbox.TabIndex = 8;
            // 
            // BirthyearTextbox
            // 
            this.BirthyearTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BirthyearTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthyearTextbox.Location = new System.Drawing.Point(153, 225);
            this.BirthyearTextbox.Name = "BirthyearTextbox";
            this.BirthyearTextbox.Size = new System.Drawing.Size(195, 22);
            this.BirthyearTextbox.TabIndex = 9;
            // 
            // heightTextbox
            // 
            this.heightTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.heightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightTextbox.Location = new System.Drawing.Point(495, 134);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(173, 22);
            this.heightTextbox.TabIndex = 10;
            // 
            // gradeTextbox
            // 
            this.gradeTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gradeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeTextbox.Location = new System.Drawing.Point(495, 174);
            this.gradeTextbox.Name = "gradeTextbox";
            this.gradeTextbox.Size = new System.Drawing.Size(173, 22);
            this.gradeTextbox.TabIndex = 11;
            // 
            // branchTextbox
            // 
            this.branchTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.branchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.branchTextbox.Location = new System.Drawing.Point(495, 225);
            this.branchTextbox.Name = "branchTextbox";
            this.branchTextbox.Size = new System.Drawing.Size(173, 22);
            this.branchTextbox.TabIndex = 12;
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(52, 297);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(324, 75);
            this.Createbutton.TabIndex = 13;
            this.Createbutton.Text = "สร้าง";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 75);
            this.button1.TabIndex = 14;
            this.button1.Text = "แสดง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassScore
            // 
            this.ClassScore.Controls.Add(this.total_input);
            this.ClassScore.Controls.Add(this.Lscore);
            this.ClassScore.Controls.Add(this.Hscroe);
            this.ClassScore.Controls.Add(this.label10);
            this.ClassScore.Controls.Add(this.label9);
            this.ClassScore.Controls.Add(this.label8);
            this.ClassScore.Location = new System.Drawing.Point(52, 122);
            this.ClassScore.Name = "ClassScore";
            this.ClassScore.Size = new System.Drawing.Size(616, 133);
            this.ClassScore.TabIndex = 15;
            this.ClassScore.TabStop = false;
            this.ClassScore.Text = "ClassScore";
            this.ClassScore.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hightest Score";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lowest Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(311, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total student";
            // 
            // Hscroe
            // 
            this.Hscroe.HideSelection = false;
            this.Hscroe.Location = new System.Drawing.Point(152, 21);
            this.Hscroe.Name = "Hscroe";
            this.Hscroe.ReadOnly = true;
            this.Hscroe.Size = new System.Drawing.Size(144, 22);
            this.Hscroe.TabIndex = 3;
            // 
            // Lscore
            // 
            this.Lscore.HideSelection = false;
            this.Lscore.Location = new System.Drawing.Point(152, 75);
            this.Lscore.Name = "Lscore";
            this.Lscore.ReadOnly = true;
            this.Lscore.Size = new System.Drawing.Size(144, 22);
            this.Lscore.TabIndex = 4;
            // 
            // total_input
            // 
            this.total_input.HideSelection = false;
            this.total_input.Location = new System.Drawing.Point(442, 22);
            this.total_input.Name = "total_input";
            this.total_input.ReadOnly = true;
            this.total_input.Size = new System.Drawing.Size(144, 22);
            this.total_input.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.branchTextbox);
            this.Controls.Add(this.gradeTextbox);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.BirthyearTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.StudenID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClassScore.ResumeLayout(false);
            this.ClassScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StudenID;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox BirthyearTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TextBox gradeTextbox;
        private System.Windows.Forms.TextBox branchTextbox;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ClassScore;
        private System.Windows.Forms.TextBox total_input;
        private System.Windows.Forms.TextBox Lscore;
        private System.Windows.Forms.TextBox Hscroe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

