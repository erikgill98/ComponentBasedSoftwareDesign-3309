
namespace Matrix2
{
    partial class Form1
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
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.grpboxOperation = new System.Windows.Forms.GroupBox();
            this.rBtnEquals = new System.Windows.Forms.RadioButton();
            this.rBtnSubtract = new System.Windows.Forms.RadioButton();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.rBtnMult = new System.Windows.Forms.RadioButton();
            this.txtRowsB = new System.Windows.Forms.TextBox();
            this.txtColsA = new System.Windows.Forms.TextBox();
            this.txtColsB = new System.Windows.Forms.TextBox();
            this.txtRowsA = new System.Windows.Forms.TextBox();
            this.btnMakeB = new System.Windows.Forms.Button();
            this.btnMakeA = new System.Windows.Forms.Button();
            this.btnMakeBIden = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearMatrices = new System.Windows.Forms.Button();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.btnMakeBCopyA = new System.Windows.Forms.Button();
            this.grpboxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(132, 181);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 15);
            this.lblRows.TabIndex = 37;
            this.lblRows.Text = "Rows";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(235, 181);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(55, 15);
            this.lblCols.TabIndex = 36;
            this.lblCols.Text = "Columns";
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(333, 27);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixC.TabIndex = 20;
            this.txtMatrixC.TabStop = false;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(173, 27);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixB.TabIndex = 21;
            this.txtMatrixB.TabStop = false;
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(13, 27);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixA.TabIndex = 22;
            this.txtMatrixA.TabStop = false;
            // 
            // grpboxOperation
            // 
            this.grpboxOperation.Controls.Add(this.rBtnEquals);
            this.grpboxOperation.Controls.Add(this.rBtnSubtract);
            this.grpboxOperation.Controls.Add(this.rBtnAdd);
            this.grpboxOperation.Controls.Add(this.rBtnMult);
            this.grpboxOperation.Location = new System.Drawing.Point(7, 257);
            this.grpboxOperation.Name = "grpboxOperation";
            this.grpboxOperation.Size = new System.Drawing.Size(283, 46);
            this.grpboxOperation.TabIndex = 35;
            this.grpboxOperation.TabStop = false;
            this.grpboxOperation.Text = "Select Operation";
            // 
            // rBtnEquals
            // 
            this.rBtnEquals.AutoSize = true;
            this.rBtnEquals.Location = new System.Drawing.Point(208, 21);
            this.rBtnEquals.Name = "rBtnEquals";
            this.rBtnEquals.Size = new System.Drawing.Size(62, 19);
            this.rBtnEquals.TabIndex = 11;
            this.rBtnEquals.TabStop = true;
            this.rBtnEquals.Text = "A == B";
            this.rBtnEquals.UseVisualStyleBackColor = true;
            // 
            // rBtnSubtract
            // 
            this.rBtnSubtract.AutoSize = true;
            this.rBtnSubtract.Location = new System.Drawing.Point(133, 21);
            this.rBtnSubtract.Name = "rBtnSubtract";
            this.rBtnSubtract.Size = new System.Drawing.Size(69, 19);
            this.rBtnSubtract.TabIndex = 10;
            this.rBtnSubtract.TabStop = true;
            this.rBtnSubtract.Text = "Subtract";
            this.rBtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Location = new System.Drawing.Point(80, 21);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(47, 19);
            this.rBtnAdd.TabIndex = 9;
            this.rBtnAdd.TabStop = true;
            this.rBtnAdd.Text = "Add";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            // 
            // rBtnMult
            // 
            this.rBtnMult.AutoSize = true;
            this.rBtnMult.Checked = true;
            this.rBtnMult.Location = new System.Drawing.Point(5, 21);
            this.rBtnMult.Name = "rBtnMult";
            this.rBtnMult.Size = new System.Drawing.Size(69, 19);
            this.rBtnMult.TabIndex = 8;
            this.rBtnMult.TabStop = true;
            this.rBtnMult.Text = "Multiply";
            this.rBtnMult.UseVisualStyleBackColor = true;
            // 
            // txtRowsB
            // 
            this.txtRowsB.Location = new System.Drawing.Point(124, 228);
            this.txtRowsB.Name = "txtRowsB";
            this.txtRowsB.Size = new System.Drawing.Size(100, 23);
            this.txtRowsB.TabIndex = 28;
            this.txtRowsB.Text = "3";
            // 
            // txtColsA
            // 
            this.txtColsA.Location = new System.Drawing.Point(230, 200);
            this.txtColsA.Name = "txtColsA";
            this.txtColsA.Size = new System.Drawing.Size(100, 23);
            this.txtColsA.TabIndex = 25;
            this.txtColsA.Text = "3";
            // 
            // txtColsB
            // 
            this.txtColsB.Location = new System.Drawing.Point(230, 229);
            this.txtColsB.Name = "txtColsB";
            this.txtColsB.Size = new System.Drawing.Size(100, 23);
            this.txtColsB.TabIndex = 29;
            this.txtColsB.Text = "3";
            // 
            // txtRowsA
            // 
            this.txtRowsA.Location = new System.Drawing.Point(124, 199);
            this.txtRowsA.Name = "txtRowsA";
            this.txtRowsA.Size = new System.Drawing.Size(100, 23);
            this.txtRowsA.TabIndex = 24;
            this.txtRowsA.Text = "3";
            // 
            // btnMakeB
            // 
            this.btnMakeB.Location = new System.Drawing.Point(7, 228);
            this.btnMakeB.Name = "btnMakeB";
            this.btnMakeB.Size = new System.Drawing.Size(111, 23);
            this.btnMakeB.TabIndex = 30;
            this.btnMakeB.Text = "Make Matrix B";
            this.btnMakeB.UseVisualStyleBackColor = true;
            this.btnMakeB.Click += new System.EventHandler(this.btnMakeB_Click);
            // 
            // btnMakeA
            // 
            this.btnMakeA.Location = new System.Drawing.Point(7, 199);
            this.btnMakeA.Name = "btnMakeA";
            this.btnMakeA.Size = new System.Drawing.Size(111, 23);
            this.btnMakeA.TabIndex = 27;
            this.btnMakeA.Text = "Make Matrix A";
            this.btnMakeA.UseVisualStyleBackColor = true;
            this.btnMakeA.Click += new System.EventHandler(this.btnMakeA_Click);
            // 
            // btnMakeBIden
            // 
            this.btnMakeBIden.Location = new System.Drawing.Point(336, 229);
            this.btnMakeBIden.Name = "btnMakeBIden";
            this.btnMakeBIden.Size = new System.Drawing.Size(123, 23);
            this.btnMakeBIden.TabIndex = 31;
            this.btnMakeBIden.Text = "Make B Identity";
            this.btnMakeBIden.UseVisualStyleBackColor = true;
            this.btnMakeBIden.Click += new System.EventHandler(this.btnMakeBIden_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(7, 309);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 32;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearMatrices
            // 
            this.btnClearMatrices.Location = new System.Drawing.Point(312, 309);
            this.btnClearMatrices.Name = "btnClearMatrices";
            this.btnClearMatrices.Size = new System.Drawing.Size(101, 23);
            this.btnClearMatrices.TabIndex = 33;
            this.btnClearMatrices.Text = "Clear Matrices";
            this.btnClearMatrices.UseVisualStyleBackColor = true;
            this.btnClearMatrices.Click += new System.EventHandler(this.btnClearMatrices_Click);
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(333, 9);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(52, 15);
            this.lblMatrixC.TabIndex = 26;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(173, 9);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(51, 15);
            this.lblMatrixB.TabIndex = 23;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(12, 9);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(52, 15);
            this.lblMatrixA.TabIndex = 19;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // btnMakeBCopyA
            // 
            this.btnMakeBCopyA.Location = new System.Drawing.Point(336, 200);
            this.btnMakeBCopyA.Name = "btnMakeBCopyA";
            this.btnMakeBCopyA.Size = new System.Drawing.Size(123, 23);
            this.btnMakeBCopyA.TabIndex = 38;
            this.btnMakeBCopyA.Text = "Make B Copy of A";
            this.btnMakeBCopyA.UseVisualStyleBackColor = true;
            this.btnMakeBCopyA.Click += new System.EventHandler(this.btnMakeBCopyA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 342);
            this.Controls.Add(this.btnMakeBCopyA);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Controls.Add(this.grpboxOperation);
            this.Controls.Add(this.txtRowsB);
            this.Controls.Add(this.txtColsA);
            this.Controls.Add(this.txtColsB);
            this.Controls.Add(this.txtRowsA);
            this.Controls.Add(this.btnMakeB);
            this.Controls.Add(this.btnMakeA);
            this.Controls.Add(this.btnMakeBIden);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearMatrices);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxOperation.ResumeLayout(false);
            this.grpboxOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.GroupBox grpboxOperation;
        private System.Windows.Forms.RadioButton rBtnEquals;
        private System.Windows.Forms.RadioButton rBtnSubtract;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.RadioButton rBtnMult;
        private System.Windows.Forms.TextBox txtRowsB;
        private System.Windows.Forms.TextBox txtColsA;
        private System.Windows.Forms.TextBox txtColsB;
        private System.Windows.Forms.TextBox txtRowsA;
        private System.Windows.Forms.Button btnMakeB;
        private System.Windows.Forms.Button btnMakeA;
        private System.Windows.Forms.Button btnMakeBIden;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearMatrices;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Button btnMakeBCopyA;
    }
}

