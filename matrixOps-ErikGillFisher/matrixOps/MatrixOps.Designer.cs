
namespace matrixOps
{
    partial class frmMatrixOps
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
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.btnClearMatrices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnMakeBIden = new System.Windows.Forms.Button();
            this.btnMakeA = new System.Windows.Forms.Button();
            this.btnMakeB = new System.Windows.Forms.Button();
            this.txtRowsA = new System.Windows.Forms.TextBox();
            this.txtColsB = new System.Windows.Forms.TextBox();
            this.txtColsA = new System.Windows.Forms.TextBox();
            this.txtRowsB = new System.Windows.Forms.TextBox();
            this.grpboxOperation = new System.Windows.Forms.GroupBox();
            this.rBtnSubtract = new System.Windows.Forms.RadioButton();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.rBtnMult = new System.Windows.Forms.RadioButton();
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.grpboxOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(12, 10);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(52, 15);
            this.lblMatrixA.TabIndex = 0;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(173, 10);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(51, 15);
            this.lblMatrixB.TabIndex = 1;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(333, 10);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(52, 15);
            this.lblMatrixC.TabIndex = 2;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // btnClearMatrices
            // 
            this.btnClearMatrices.Location = new System.Drawing.Point(312, 310);
            this.btnClearMatrices.Name = "btnClearMatrices";
            this.btnClearMatrices.Size = new System.Drawing.Size(101, 23);
            this.btnClearMatrices.TabIndex = 12;
            this.btnClearMatrices.Text = "Clear Matrices";
            this.btnClearMatrices.UseVisualStyleBackColor = true;
            this.btnClearMatrices.Click += new System.EventHandler(this.btnClearMatrices_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(7, 310);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMakeBIden
            // 
            this.btnMakeBIden.Location = new System.Drawing.Point(336, 230);
            this.btnMakeBIden.Name = "btnMakeBIden";
            this.btnMakeBIden.Size = new System.Drawing.Size(123, 23);
            this.btnMakeBIden.TabIndex = 7;
            this.btnMakeBIden.Text = "Make B Identity";
            this.btnMakeBIden.UseVisualStyleBackColor = true;
            this.btnMakeBIden.Click += new System.EventHandler(this.btnMakeBIden_Click);
            // 
            // btnMakeA
            // 
            this.btnMakeA.Location = new System.Drawing.Point(7, 200);
            this.btnMakeA.Name = "btnMakeA";
            this.btnMakeA.Size = new System.Drawing.Size(111, 23);
            this.btnMakeA.TabIndex = 3;
            this.btnMakeA.Text = "Make Matrix A";
            this.btnMakeA.UseVisualStyleBackColor = true;
            this.btnMakeA.Click += new System.EventHandler(this.btnMakeA_Click);
            // 
            // btnMakeB
            // 
            this.btnMakeB.Location = new System.Drawing.Point(7, 229);
            this.btnMakeB.Name = "btnMakeB";
            this.btnMakeB.Size = new System.Drawing.Size(111, 23);
            this.btnMakeB.TabIndex = 6;
            this.btnMakeB.Text = "Make Matrix B";
            this.btnMakeB.UseVisualStyleBackColor = true;
            this.btnMakeB.Click += new System.EventHandler(this.btnMakeB_Click);
            // 
            // txtRowsA
            // 
            this.txtRowsA.Location = new System.Drawing.Point(124, 200);
            this.txtRowsA.Name = "txtRowsA";
            this.txtRowsA.Size = new System.Drawing.Size(100, 23);
            this.txtRowsA.TabIndex = 1;
            this.txtRowsA.Text = "3";
            this.txtRowsA.TextChanged += new System.EventHandler(this.txtRowsA_TextChanged);
            // 
            // txtColsB
            // 
            this.txtColsB.Location = new System.Drawing.Point(230, 230);
            this.txtColsB.Name = "txtColsB";
            this.txtColsB.Size = new System.Drawing.Size(100, 23);
            this.txtColsB.TabIndex = 5;
            this.txtColsB.Text = "3";
            this.txtColsB.TextChanged += new System.EventHandler(this.txtColsB_TextChanged);
            // 
            // txtColsA
            // 
            this.txtColsA.Location = new System.Drawing.Point(230, 201);
            this.txtColsA.Name = "txtColsA";
            this.txtColsA.Size = new System.Drawing.Size(100, 23);
            this.txtColsA.TabIndex = 2;
            this.txtColsA.Text = "3";
            this.txtColsA.TextChanged += new System.EventHandler(this.txtColsA_TextChanged);
            // 
            // txtRowsB
            // 
            this.txtRowsB.Location = new System.Drawing.Point(124, 229);
            this.txtRowsB.Name = "txtRowsB";
            this.txtRowsB.Size = new System.Drawing.Size(100, 23);
            this.txtRowsB.TabIndex = 4;
            this.txtRowsB.Text = "3";
            this.txtRowsB.TextChanged += new System.EventHandler(this.txtRowsB_TextChanged);
            // 
            // grpboxOperation
            // 
            this.grpboxOperation.Controls.Add(this.rBtnSubtract);
            this.grpboxOperation.Controls.Add(this.rBtnAdd);
            this.grpboxOperation.Controls.Add(this.rBtnMult);
            this.grpboxOperation.Location = new System.Drawing.Point(7, 258);
            this.grpboxOperation.Name = "grpboxOperation";
            this.grpboxOperation.Size = new System.Drawing.Size(217, 46);
            this.grpboxOperation.TabIndex = 13;
            this.grpboxOperation.TabStop = false;
            this.grpboxOperation.Text = "Select Operation";
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
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(13, 28);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixA.TabIndex = 0;
            this.txtMatrixA.TabStop = false;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(173, 28);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixB.TabIndex = 0;
            this.txtMatrixB.TabStop = false;
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(333, 28);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(150, 150);
            this.txtMatrixC.TabIndex = 0;
            this.txtMatrixC.TabStop = false;
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(235, 182);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(55, 15);
            this.lblCols.TabIndex = 17;
            this.lblCols.Text = "Columns";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(132, 182);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 15);
            this.lblRows.TabIndex = 18;
            this.lblRows.Text = "Rows";
            // 
            // frmMatrixOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 346);
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
            this.Name = "frmMatrixOps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Ops";
            this.grpboxOperation.ResumeLayout(false);
            this.grpboxOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Button btnClearMatrices;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnMakeBIden;
        private System.Windows.Forms.Button btnMakeA;
        private System.Windows.Forms.Button btnMakeB;
        private System.Windows.Forms.TextBox txtRowsA;
        private System.Windows.Forms.TextBox txtColsB;
        private System.Windows.Forms.TextBox txtColsA;
        private System.Windows.Forms.TextBox txtRowsB;
        private System.Windows.Forms.GroupBox grpboxOperation;
        private System.Windows.Forms.RadioButton rBtnSubtract;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.RadioButton rBtnMult;
        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Label lblRows;
    }
}

