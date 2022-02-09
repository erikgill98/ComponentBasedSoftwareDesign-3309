namespace LunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtnHamb = new System.Windows.Forms.RadioButton();
            this.rbtnPizza = new System.Windows.Forms.RadioButton();
            this.rbtnSalad = new System.Windows.Forms.RadioButton();
            this.gbxAddOn = new System.Windows.Forms.GroupBox();
            this.cbxLTO = new System.Windows.Forms.CheckBox();
            this.cbxKMM = new System.Windows.Forms.CheckBox();
            this.cbxFF = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(265, 142);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 23);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 134);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 104);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(104, 72);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 20);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(104, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(88, 20);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(104, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rbtnSalad);
            this.gbxMainCourse.Controls.Add(this.rbtnPizza);
            this.gbxMainCourse.Controls.Add(this.rbtnHamb);
            this.gbxMainCourse.Location = new System.Drawing.Point(17, 14);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(144, 104);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtnHamb
            // 
            this.rbtnHamb.AutoSize = true;
            this.rbtnHamb.Checked = true;
            this.rbtnHamb.Location = new System.Drawing.Point(7, 20);
            this.rbtnHamb.Name = "rbtnHamb";
            this.rbtnHamb.Size = new System.Drawing.Size(113, 17);
            this.rbtnHamb.TabIndex = 0;
            this.rbtnHamb.TabStop = true;
            this.rbtnHamb.Text = "Hamburger - $6.95";
            this.rbtnHamb.UseVisualStyleBackColor = true;
            this.rbtnHamb.CheckedChanged += new System.EventHandler(this.rbtnHamb_CheckedChanged);
            // 
            // rbtnPizza
            // 
            this.rbtnPizza.AutoSize = true;
            this.rbtnPizza.Location = new System.Drawing.Point(7, 44);
            this.rbtnPizza.Name = "rbtnPizza";
            this.rbtnPizza.Size = new System.Drawing.Size(86, 17);
            this.rbtnPizza.TabIndex = 1;
            this.rbtnPizza.Text = "Pizza - $5.95";
            this.rbtnPizza.UseVisualStyleBackColor = true;
            this.rbtnPizza.CheckedChanged += new System.EventHandler(this.rbtnPizza_CheckedChanged);
            // 
            // rbtnSalad
            // 
            this.rbtnSalad.AutoSize = true;
            this.rbtnSalad.Location = new System.Drawing.Point(7, 68);
            this.rbtnSalad.Name = "rbtnSalad";
            this.rbtnSalad.Size = new System.Drawing.Size(88, 17);
            this.rbtnSalad.TabIndex = 2;
            this.rbtnSalad.Text = "Salad - $4.95";
            this.rbtnSalad.UseVisualStyleBackColor = true;
            this.rbtnSalad.CheckedChanged += new System.EventHandler(this.rbtnSalad_CheckedChanged);
            // 
            // gbxAddOn
            // 
            this.gbxAddOn.Controls.Add(this.cbxFF);
            this.gbxAddOn.Controls.Add(this.cbxKMM);
            this.gbxAddOn.Controls.Add(this.cbxLTO);
            this.gbxAddOn.Location = new System.Drawing.Point(180, 14);
            this.gbxAddOn.Name = "gbxAddOn";
            this.gbxAddOn.Size = new System.Drawing.Size(187, 104);
            this.gbxAddOn.TabIndex = 3;
            this.gbxAddOn.TabStop = false;
            this.gbxAddOn.Text = "Add-on Items ($0.75/each)";
            // 
            // cbxLTO
            // 
            this.cbxLTO.AutoSize = true;
            this.cbxLTO.Location = new System.Drawing.Point(6, 23);
            this.cbxLTO.Name = "cbxLTO";
            this.cbxLTO.Size = new System.Drawing.Size(161, 17);
            this.cbxLTO.TabIndex = 0;
            this.cbxLTO.Text = "Lettuce, Tomato and Onions";
            this.cbxLTO.UseVisualStyleBackColor = true;
            this.cbxLTO.CheckedChanged += new System.EventHandler(this.cbxLTO_CheckedChanged);
            // 
            // cbxKMM
            // 
            this.cbxKMM.AutoSize = true;
            this.cbxKMM.Location = new System.Drawing.Point(6, 46);
            this.cbxKMM.Name = "cbxKMM";
            this.cbxKMM.Size = new System.Drawing.Size(160, 17);
            this.cbxKMM.TabIndex = 1;
            this.cbxKMM.Text = "Ketchup, Mustard and Mayo";
            this.cbxKMM.UseVisualStyleBackColor = true;
            this.cbxKMM.CheckedChanged += new System.EventHandler(this.cbxKMM_CheckedChanged);
            // 
            // cbxFF
            // 
            this.cbxFF.AutoSize = true;
            this.cbxFF.Location = new System.Drawing.Point(6, 69);
            this.cbxFF.Name = "cbxFF";
            this.cbxFF.Size = new System.Drawing.Size(84, 17);
            this.cbxFF.TabIndex = 2;
            this.cbxFF.Text = "French Fries";
            this.cbxFF.UseVisualStyleBackColor = true;
            this.cbxFF.CheckedChanged += new System.EventHandler(this.cbxFF_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.gbxAddOn);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOn.ResumeLayout(false);
            this.gbxAddOn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbtnSalad;
        private System.Windows.Forms.RadioButton rbtnPizza;
        private System.Windows.Forms.RadioButton rbtnHamb;
        private System.Windows.Forms.GroupBox gbxAddOn;
        private System.Windows.Forms.CheckBox cbxFF;
        private System.Windows.Forms.CheckBox cbxKMM;
        private System.Windows.Forms.CheckBox cbxLTO;
    }
}

