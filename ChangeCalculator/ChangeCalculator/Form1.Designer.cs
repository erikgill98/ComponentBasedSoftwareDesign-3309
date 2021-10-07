
namespace ChangeCalculator
{
    partial class CalculateChange
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
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuart = new System.Windows.Forms.Label();
            this.lblbDimes = new System.Windows.Forms.Label();
            this.lblNickles = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.txtChangeDue = new System.Windows.Forms.TextBox();
            this.txtQuarter = new System.Windows.Forms.TextBox();
            this.txtDime = new System.Windows.Forms.TextBox();
            this.txtNickel = new System.Windows.Forms.TextBox();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(12, 9);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(170, 15);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Amount of change due (0-99): ";
            // 
            // lblQuart
            // 
            this.lblQuart.AutoSize = true;
            this.lblQuart.Location = new System.Drawing.Point(124, 38);
            this.lblQuart.Name = "lblQuart";
            this.lblQuart.Size = new System.Drawing.Size(58, 15);
            this.lblQuart.TabIndex = 1;
            this.lblQuart.Text = "Quarters: ";
            // 
            // lblbDimes
            // 
            this.lblbDimes.AutoSize = true;
            this.lblbDimes.Location = new System.Drawing.Point(136, 67);
            this.lblbDimes.Name = "lblbDimes";
            this.lblbDimes.Size = new System.Drawing.Size(46, 15);
            this.lblbDimes.TabIndex = 2;
            this.lblbDimes.Text = "Dimes: ";
            // 
            // lblNickles
            // 
            this.lblNickles.AutoSize = true;
            this.lblNickles.Location = new System.Drawing.Point(131, 96);
            this.lblNickles.Name = "lblNickles";
            this.lblNickles.Size = new System.Drawing.Size(51, 15);
            this.lblNickles.TabIndex = 3;
            this.lblNickles.Text = "Nickels: ";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(128, 125);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(54, 15);
            this.lblPennies.TabIndex = 4;
            this.lblPennies.Text = "Pennies: ";
            // 
            // txtChangeDue
            // 
            this.txtChangeDue.Location = new System.Drawing.Point(188, 6);
            this.txtChangeDue.Name = "txtChangeDue";
            this.txtChangeDue.Size = new System.Drawing.Size(100, 23);
            this.txtChangeDue.TabIndex = 0;
            // 
            // txtQuarter
            // 
            this.txtQuarter.Location = new System.Drawing.Point(188, 35);
            this.txtQuarter.Name = "txtQuarter";
            this.txtQuarter.ReadOnly = true;
            this.txtQuarter.Size = new System.Drawing.Size(100, 23);
            this.txtQuarter.TabIndex = 19;
            // 
            // txtDime
            // 
            this.txtDime.Location = new System.Drawing.Point(188, 64);
            this.txtDime.Name = "txtDime";
            this.txtDime.ReadOnly = true;
            this.txtDime.Size = new System.Drawing.Size(100, 23);
            this.txtDime.TabIndex = 7;
            // 
            // txtNickel
            // 
            this.txtNickel.Location = new System.Drawing.Point(188, 93);
            this.txtNickel.Name = "txtNickel";
            this.txtNickel.ReadOnly = true;
            this.txtNickel.Size = new System.Drawing.Size(100, 23);
            this.txtNickel.TabIndex = 8;
            // 
            // txtPenny
            // 
            this.txtPenny.Location = new System.Drawing.Point(188, 122);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.ReadOnly = true;
            this.txtPenny.Size = new System.Drawing.Size(100, 23);
            this.txtPenny.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(128, 151);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(213, 151);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CalculateChange
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(309, 191);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.txtNickel);
            this.Controls.Add(this.txtDime);
            this.Controls.Add(this.txtQuarter);
            this.Controls.Add(this.txtChangeDue);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickles);
            this.Controls.Add(this.lblbDimes);
            this.Controls.Add(this.lblQuart);
            this.Controls.Add(this.lblChange);
            this.Name = "CalculateChange";
            this.Text = "Change Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblQuart;
        private System.Windows.Forms.Label lblbDimes;
        private System.Windows.Forms.Label lblNickles;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.TextBox txtQuarter;
        private System.Windows.Forms.TextBox txtDime;
        private System.Windows.Forms.TextBox txtNickel;
        private System.Windows.Forms.TextBox txtPenny;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

