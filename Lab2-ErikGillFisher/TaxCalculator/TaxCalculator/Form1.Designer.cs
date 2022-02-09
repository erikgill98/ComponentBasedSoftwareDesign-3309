
namespace TaxCalculator
{
    partial class TaxInc
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
            this.lblTaxInc = new System.Windows.Forms.Label();
            this.lblTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxableInc = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxInc
            // 
            this.lblTaxInc.AutoSize = true;
            this.lblTaxInc.Location = new System.Drawing.Point(39, 13);
            this.lblTaxInc.Name = "lblTaxInc";
            this.lblTaxInc.Size = new System.Drawing.Size(95, 15);
            this.lblTaxInc.TabIndex = 0;
            this.lblTaxInc.Text = "Taxable Income: ";
            // 
            // lblTaxOwed
            // 
            this.lblTaxOwed.AutoSize = true;
            this.lblTaxOwed.Location = new System.Drawing.Point(27, 49);
            this.lblTaxOwed.Name = "lblTaxOwed";
            this.lblTaxOwed.Size = new System.Drawing.Size(107, 15);
            this.lblTaxOwed.TabIndex = 1;
            this.lblTaxOwed.Text = "Income Tax Owed: ";
            // 
            // txtTaxableInc
            // 
            this.txtTaxableInc.Location = new System.Drawing.Point(140, 10);
            this.txtTaxableInc.Name = "txtTaxableInc";
            this.txtTaxableInc.Size = new System.Drawing.Size(100, 23);
            this.txtTaxableInc.TabIndex = 0;
            this.txtTaxableInc.TextChanged += new System.EventHandler(this.txtTaxableInc_TextChanged);
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(140, 46);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.ReadOnly = true;
            this.txtTaxOwed.Size = new System.Drawing.Size(100, 23);
            this.txtTaxOwed.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(59, 86);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(165, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TaxInc
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(267, 127);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxableInc);
            this.Controls.Add(this.lblTaxOwed);
            this.Controls.Add(this.lblTaxInc);
            this.Name = "TaxInc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxInc;
        private System.Windows.Forms.Label lblTaxOwed;
        private System.Windows.Forms.TextBox txtTaxableInc;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

