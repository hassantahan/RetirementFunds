namespace RetirementFunds
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
            this.EnterPrincipleLabel = new System.Windows.Forms.Label();
            this.txtPrinciple = new System.Windows.Forms.TextBox();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.lblEnterInterest = new System.Windows.Forms.Label();
            this.txtEnterYears = new System.Windows.Forms.TextBox();
            this.txtEnterInterest = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.lblAnnuity = new System.Windows.Forms.Label();
            this.txtAnnuity = new System.Windows.Forms.TextBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.lblEnterPeriods = new System.Windows.Forms.Label();
            this.chkAnnuity = new System.Windows.Forms.CheckBox();
            this.lblAnnuityFixed = new System.Windows.Forms.Label();
            this.chkPaymentAt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnterPrincipleLabel
            // 
            this.EnterPrincipleLabel.AutoSize = true;
            this.EnterPrincipleLabel.Location = new System.Drawing.Point(12, 9);
            this.EnterPrincipleLabel.Name = "EnterPrincipleLabel";
            this.EnterPrincipleLabel.Size = new System.Drawing.Size(132, 13);
            this.EnterPrincipleLabel.TabIndex = 0;
            this.EnterPrincipleLabel.Text = "Enter Principle Amount ($):";
            // 
            // txtPrinciple
            // 
            this.txtPrinciple.Location = new System.Drawing.Point(241, 5);
            this.txtPrinciple.Name = "txtPrinciple";
            this.txtPrinciple.Size = new System.Drawing.Size(100, 20);
            this.txtPrinciple.TabIndex = 1;
            this.txtPrinciple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrinciple_KeyPress);
            this.txtPrinciple.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrinciple_KeyUp);
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Location = new System.Drawing.Point(12, 34);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(103, 13);
            this.lblEnterTime.TabIndex = 2;
            this.lblEnterTime.Text = "Enter no. of Periods:";
            // 
            // lblEnterInterest
            // 
            this.lblEnterInterest.AutoSize = true;
            this.lblEnterInterest.Location = new System.Drawing.Point(12, 58);
            this.lblEnterInterest.Name = "lblEnterInterest";
            this.lblEnterInterest.Size = new System.Drawing.Size(103, 13);
            this.lblEnterInterest.TabIndex = 3;
            this.lblEnterInterest.Text = "Enter Gain Rate (%):";
            // 
            // txtEnterYears
            // 
            this.txtEnterYears.Location = new System.Drawing.Point(241, 31);
            this.txtEnterYears.Name = "txtEnterYears";
            this.txtEnterYears.Size = new System.Drawing.Size(100, 20);
            this.txtEnterYears.TabIndex = 4;
            this.txtEnterYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterYears_KeyPress);
            this.txtEnterYears.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnterYears_KeyUp);
            // 
            // txtEnterInterest
            // 
            this.txtEnterInterest.Location = new System.Drawing.Point(241, 55);
            this.txtEnterInterest.Name = "txtEnterInterest";
            this.txtEnterInterest.Size = new System.Drawing.Size(100, 20);
            this.txtEnterInterest.TabIndex = 5;
            this.txtEnterInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterInterest_KeyPress);
            this.txtEnterInterest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnterInterest_KeyUp);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(15, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Go!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFutureValue.Location = new System.Drawing.Point(564, 6);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(100, 23);
            this.lblFutureValue.TabIndex = 7;
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPresentValue.Location = new System.Drawing.Point(564, 58);
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.Size = new System.Drawing.Size(100, 23);
            this.lblPresentValue.TabIndex = 8;
            // 
            // lblAnnuity
            // 
            this.lblAnnuity.AutoSize = true;
            this.lblAnnuity.Location = new System.Drawing.Point(12, 110);
            this.lblAnnuity.Name = "lblAnnuity";
            this.lblAnnuity.Size = new System.Drawing.Size(127, 13);
            this.lblAnnuity.TabIndex = 9;
            this.lblAnnuity.Text = "Enter Period Payment ($):";
            // 
            // txtAnnuity
            // 
            this.txtAnnuity.Enabled = false;
            this.txtAnnuity.Location = new System.Drawing.Point(241, 107);
            this.txtAnnuity.Name = "txtAnnuity";
            this.txtAnnuity.Size = new System.Drawing.Size(100, 20);
            this.txtAnnuity.TabIndex = 10;
            this.txtAnnuity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnnuity_KeyPress);
            this.txtAnnuity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnnuity_KeyUp);
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(241, 81);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(100, 20);
            this.txtPeriods.TabIndex = 12;
            this.txtPeriods.Text = "1";
            this.txtPeriods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriods_KeyPress);
            this.txtPeriods.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPeriods_KeyUp);
            // 
            // lblEnterPeriods
            // 
            this.lblEnterPeriods.AutoSize = true;
            this.lblEnterPeriods.Location = new System.Drawing.Point(12, 84);
            this.lblEnterPeriods.Name = "lblEnterPeriods";
            this.lblEnterPeriods.Size = new System.Drawing.Size(202, 13);
            this.lblEnterPeriods.TabIndex = 11;
            this.lblEnterPeriods.Text = "Number of Time Compounded per Period:";
            // 
            // chkAnnuity
            // 
            this.chkAnnuity.AutoSize = true;
            this.chkAnnuity.Location = new System.Drawing.Point(394, 110);
            this.chkAnnuity.Name = "chkAnnuity";
            this.chkAnnuity.Size = new System.Drawing.Size(113, 17);
            this.chkAnnuity.TabIndex = 13;
            this.chkAnnuity.Text = "Periodic Payments";
            this.chkAnnuity.UseVisualStyleBackColor = true;
            this.chkAnnuity.CheckedChanged += new System.EventHandler(this.chkAnnuity_CheckedChanged);
            // 
            // lblAnnuityFixed
            // 
            this.lblAnnuityFixed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnnuityFixed.Location = new System.Drawing.Point(564, 122);
            this.lblAnnuityFixed.Name = "lblAnnuityFixed";
            this.lblAnnuityFixed.Size = new System.Drawing.Size(100, 23);
            this.lblAnnuityFixed.TabIndex = 14;
            // 
            // chkPaymentAt
            // 
            this.chkPaymentAt.AutoSize = true;
            this.chkPaymentAt.Enabled = false;
            this.chkPaymentAt.Location = new System.Drawing.Point(394, 133);
            this.chkPaymentAt.Name = "chkPaymentAt";
            this.chkPaymentAt.Size = new System.Drawing.Size(135, 17);
            this.chkPaymentAt.TabIndex = 15;
            this.chkPaymentAt.Text = "Payment at Beginning?";
            this.chkPaymentAt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPaymentAt);
            this.Controls.Add(this.lblAnnuityFixed);
            this.Controls.Add(this.chkAnnuity);
            this.Controls.Add(this.txtPeriods);
            this.Controls.Add(this.lblEnterPeriods);
            this.Controls.Add(this.txtAnnuity);
            this.Controls.Add(this.lblAnnuity);
            this.Controls.Add(this.lblPresentValue);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterInterest);
            this.Controls.Add(this.txtEnterYears);
            this.Controls.Add(this.lblEnterInterest);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.txtPrinciple);
            this.Controls.Add(this.EnterPrincipleLabel);
            this.Name = "Form1";
            this.Text = "Retirement Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPrincipleLabel;
        private System.Windows.Forms.TextBox txtPrinciple;
        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.Label lblEnterInterest;
        private System.Windows.Forms.TextBox txtEnterYears;
        private System.Windows.Forms.TextBox txtEnterInterest;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.Label lblPresentValue;
        private System.Windows.Forms.Label lblAnnuity;
        private System.Windows.Forms.TextBox txtAnnuity;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.Label lblEnterPeriods;
        private System.Windows.Forms.CheckBox chkAnnuity;
        private System.Windows.Forms.Label lblAnnuityFixed;
        private System.Windows.Forms.CheckBox chkPaymentAt;
    }
}

