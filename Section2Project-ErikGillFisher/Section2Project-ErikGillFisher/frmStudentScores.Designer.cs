
namespace Section2Project_ErikGillFisher
{
    partial class frmStudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblScoreTot = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lstbStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(12, 12);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(56, 15);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students:";
            // 
            // lblScoreTot
            // 
            this.lblScoreTot.Location = new System.Drawing.Point(102, 163);
            this.lblScoreTot.Name = "lblScoreTot";
            this.lblScoreTot.Size = new System.Drawing.Size(70, 15);
            this.lblScoreTot.TabIndex = 1;
            this.lblScoreTot.Text = "Score Total: ";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.Location = new System.Drawing.Point(94, 192);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(78, 15);
            this.lblScoreCount.TabIndex = 2;
            this.lblScoreCount.Text = "Score Count: ";
            // 
            // lblAvg
            // 
            this.lblAvg.Location = new System.Drawing.Point(116, 221);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(56, 15);
            this.lblAvg.TabIndex = 3;
            this.lblAvg.Text = "Average: ";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(241, 30);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(241, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(241, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(178, 160);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.ReadOnly = true;
            this.txtTotalScore.Size = new System.Drawing.Size(57, 23);
            this.txtTotalScore.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(178, 189);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(57, 23);
            this.txtScoreCount.TabIndex = 9;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(178, 218);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(57, 23);
            this.txtAverage.TabIndex = 10;
            // 
            // lstbStudents
            // 
            this.lstbStudents.BackColor = System.Drawing.SystemColors.Info;
            this.lstbStudents.FormattingEnabled = true;
            this.lstbStudents.ItemHeight = 15;
            this.lstbStudents.Location = new System.Drawing.Point(12, 30);
            this.lstbStudents.Name = "lstbStudents";
            this.lstbStudents.Size = new System.Drawing.Size(223, 124);
            this.lstbStudents.TabIndex = 11;
            this.lstbStudents.SelectedIndexChanged += new System.EventHandler(this.lstbStudents_SelectedIndexChanged);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(339, 255);
            this.Controls.Add(this.lstbStudents);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtTotalScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTot);
            this.Controls.Add(this.lblStudents);
            this.Name = "frmStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblScoreTot;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.ListBox lstbStudents;
    }
}

