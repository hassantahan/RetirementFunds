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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnterPrincipalLabel = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnnuityPayment = new System.Windows.Forms.Label();
            this.txtAnnuityPayment = new System.Windows.Forms.TextBox();
            this.txtCompoundingFrequency = new System.Windows.Forms.TextBox();
            this.lblCompoundingFrequency = new System.Windows.Forms.Label();
            this.chkAnnuity = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkPaymentAt = new System.Windows.Forms.CheckBox();
            this.txtPaymentFrequency = new System.Windows.Forms.TextBox();
            this.lblPaymentFrequency = new System.Windows.Forms.Label();
            this.txtPaymentGrowth = new System.Windows.Forms.TextBox();
            this.lblPaymentGrowth = new System.Windows.Forms.Label();
            this.tltPrincipalAmount = new System.Windows.Forms.ToolTip(this.components);
            this.tltTotalPeriods = new System.Windows.Forms.ToolTip(this.components);
            this.tltGainRate = new System.Windows.Forms.ToolTip(this.components);
            this.tltEnterPeriods = new System.Windows.Forms.ToolTip(this.components);
            this.tltAnnuity = new System.Windows.Forms.ToolTip(this.components);
            this.tltDueAnnuityCheck = new System.Windows.Forms.ToolTip(this.components);
            this.tltAnnuityAmount = new System.Windows.Forms.ToolTip(this.components);
            this.tltPaymentGrowth = new System.Windows.Forms.ToolTip(this.components);
            this.tltPaymentFrequency = new System.Windows.Forms.ToolTip(this.components);
            this.carcMain = new LiveCharts.WinForms.CartesianChart();
            this.btnInvesting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterPrincipalLabel
            // 
            this.lblEnterPrincipalLabel.AutoSize = true;
            this.lblEnterPrincipalLabel.Location = new System.Drawing.Point(12, 9);
            this.lblEnterPrincipalLabel.Name = "lblEnterPrincipalLabel";
            this.lblEnterPrincipalLabel.Size = new System.Drawing.Size(104, 13);
            this.lblEnterPrincipalLabel.TabIndex = 0;
            this.lblEnterPrincipalLabel.Text = "Principal Amount ($):";
            this.tltPrincipalAmount.SetToolTip(this.lblEnterPrincipalLabel, "The original amount of investment made in an asset.");
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(241, 5);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 1;
            this.txtPrincipal.Tag = "dollar";
            this.txtPrincipal.Text = "$1 000.00";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtPrincipal.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            this.txtPrincipal.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // lblPeriods
            // 
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Location = new System.Drawing.Point(12, 34);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(72, 13);
            this.lblPeriods.TabIndex = 2;
            this.lblPeriods.Text = "Total Periods:";
            this.tltTotalPeriods.SetToolTip(this.lblPeriods, "The length of periods (i.e. time) that the principal and any subsequent investmen" +
        "t will grow.\r\nPeriods will typically be years, but it can be any length of time." +
        "");
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(12, 58);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(75, 13);
            this.lblGain.TabIndex = 3;
            this.lblGain.Text = "Gain Rate (%):";
            this.tltGainRate.SetToolTip(this.lblGain, "The rate at which the investment will grow for every given period.");
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(241, 31);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(100, 20);
            this.txtPeriods.TabIndex = 2;
            this.txtPeriods.Tag = "period";
            this.txtPeriods.Text = "10";
            this.txtPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtPeriods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtPeriods.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            // 
            // txtGain
            // 
            this.txtGain.Location = new System.Drawing.Point(241, 55);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(100, 20);
            this.txtGain.TabIndex = 3;
            this.txtGain.Tag = "rate";
            this.txtGain.Text = "1.00";
            this.txtGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtGain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtGain.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(255, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(238, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnnuityPayment
            // 
            this.lblAnnuityPayment.AutoSize = true;
            this.lblAnnuityPayment.Location = new System.Drawing.Point(386, 31);
            this.lblAnnuityPayment.Name = "lblAnnuityPayment";
            this.lblAnnuityPayment.Size = new System.Drawing.Size(99, 13);
            this.lblAnnuityPayment.TabIndex = 9;
            this.lblAnnuityPayment.Text = "Period Payment ($):";
            this.tltAnnuityAmount.SetToolTip(this.lblAnnuityPayment, "The amount you pay each period.");
            // 
            // txtAnnuityPayment
            // 
            this.txtAnnuityPayment.Enabled = false;
            this.txtAnnuityPayment.Location = new System.Drawing.Point(615, 29);
            this.txtAnnuityPayment.Name = "txtAnnuityPayment";
            this.txtAnnuityPayment.Size = new System.Drawing.Size(100, 20);
            this.txtAnnuityPayment.TabIndex = 6;
            this.txtAnnuityPayment.Tag = "dollar";
            this.txtAnnuityPayment.Text = "$1 000.00";
            this.txtAnnuityPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnnuityPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtAnnuityPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtAnnuityPayment.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            this.txtAnnuityPayment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // txtCompoundingFrequency
            // 
            this.txtCompoundingFrequency.Location = new System.Drawing.Point(241, 81);
            this.txtCompoundingFrequency.Name = "txtCompoundingFrequency";
            this.txtCompoundingFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtCompoundingFrequency.TabIndex = 4;
            this.txtCompoundingFrequency.Tag = "period";
            this.txtCompoundingFrequency.Text = "1";
            this.txtCompoundingFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCompoundingFrequency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtCompoundingFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtCompoundingFrequency.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            // 
            // lblCompoundingFrequency
            // 
            this.lblCompoundingFrequency.AutoSize = true;
            this.lblCompoundingFrequency.Location = new System.Drawing.Point(12, 84);
            this.lblCompoundingFrequency.Name = "lblCompoundingFrequency";
            this.lblCompoundingFrequency.Size = new System.Drawing.Size(128, 13);
            this.lblCompoundingFrequency.TabIndex = 11;
            this.lblCompoundingFrequency.Text = "Compounding Frequency:";
            this.tltEnterPeriods.SetToolTip(this.lblCompoundingFrequency, "The amount of times the investment will be compounded in a period.");
            // 
            // chkAnnuity
            // 
            this.chkAnnuity.AutoSize = true;
            this.chkAnnuity.Location = new System.Drawing.Point(387, 5);
            this.chkAnnuity.Name = "chkAnnuity";
            this.chkAnnuity.Size = new System.Drawing.Size(113, 17);
            this.chkAnnuity.TabIndex = 5;
            this.chkAnnuity.Text = "Periodic Payments";
            this.tltAnnuity.SetToolTip(this.chkAnnuity, "Enabling this will allow for you to put further investments\r\nevery period at eith" +
        "er a fixed or exponentially growing rate.");
            this.chkAnnuity.UseVisualStyleBackColor = true;
            this.chkAnnuity.CheckedChanged += new System.EventHandler(this.chkAnnuity_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(611, 418);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPaymentAt
            // 
            this.chkPaymentAt.AutoSize = true;
            this.chkPaymentAt.Enabled = false;
            this.chkPaymentAt.Location = new System.Drawing.Point(580, 5);
            this.chkPaymentAt.Name = "chkPaymentAt";
            this.chkPaymentAt.Size = new System.Drawing.Size(135, 17);
            this.chkPaymentAt.TabIndex = 9;
            this.chkPaymentAt.Text = "Payment at Beginning?";
            this.tltDueAnnuityCheck.SetToolTip(this.chkPaymentAt, "This option allows you to choose if the payments happen at the beginning or end o" +
        "f a period.");
            this.chkPaymentAt.UseVisualStyleBackColor = true;
            // 
            // txtPaymentFrequency
            // 
            this.txtPaymentFrequency.Enabled = false;
            this.txtPaymentFrequency.Location = new System.Drawing.Point(615, 81);
            this.txtPaymentFrequency.Name = "txtPaymentFrequency";
            this.txtPaymentFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentFrequency.TabIndex = 8;
            this.txtPaymentFrequency.Tag = "period";
            this.txtPaymentFrequency.Text = "1";
            this.txtPaymentFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentFrequency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtPaymentFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtPaymentFrequency.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            // 
            // lblPaymentFrequency
            // 
            this.lblPaymentFrequency.AutoSize = true;
            this.lblPaymentFrequency.Location = new System.Drawing.Point(386, 84);
            this.lblPaymentFrequency.Name = "lblPaymentFrequency";
            this.lblPaymentFrequency.Size = new System.Drawing.Size(107, 13);
            this.lblPaymentFrequency.TabIndex = 16;
            this.lblPaymentFrequency.Text = "Payments per Period:";
            this.tltPaymentFrequency.SetToolTip(this.lblPaymentFrequency, resources.GetString("lblPaymentFrequency.ToolTip"));
            // 
            // txtPaymentGrowth
            // 
            this.txtPaymentGrowth.Enabled = false;
            this.txtPaymentGrowth.Location = new System.Drawing.Point(615, 55);
            this.txtPaymentGrowth.Name = "txtPaymentGrowth";
            this.txtPaymentGrowth.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentGrowth.TabIndex = 7;
            this.txtPaymentGrowth.Tag = "rate";
            this.txtPaymentGrowth.Text = "1.00";
            this.txtPaymentGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaymentGrowth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            this.txtPaymentGrowth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            this.txtPaymentGrowth.Leave += new System.EventHandler(this.txtPrincipal_Leave);
            // 
            // lblPaymentGrowth
            // 
            this.lblPaymentGrowth.AutoSize = true;
            this.lblPaymentGrowth.Location = new System.Drawing.Point(386, 57);
            this.lblPaymentGrowth.Name = "lblPaymentGrowth";
            this.lblPaymentGrowth.Size = new System.Drawing.Size(156, 13);
            this.lblPaymentGrowth.TabIndex = 18;
            this.lblPaymentGrowth.Text = "Payment Growth per Period (%):";
            this.tltPaymentGrowth.SetToolTip(this.lblPaymentGrowth, "The amount that the payment will grow at the end of every period. \r\nFor a fixed p" +
        "ayment, set this to 0.");
            // 
            // tltPrincipalAmount
            // 
            this.tltPrincipalAmount.AutoPopDelay = 5000;
            this.tltPrincipalAmount.InitialDelay = 750;
            this.tltPrincipalAmount.ReshowDelay = 100;
            this.tltPrincipalAmount.ToolTipTitle = "Principal Amount";
            // 
            // tltTotalPeriods
            // 
            this.tltTotalPeriods.ToolTipTitle = "Total Periods";
            // 
            // tltGainRate
            // 
            this.tltGainRate.AutoPopDelay = 7500;
            this.tltGainRate.InitialDelay = 500;
            this.tltGainRate.ReshowDelay = 100;
            this.tltGainRate.ToolTipTitle = "Gain Rate";
            // 
            // tltEnterPeriods
            // 
            this.tltEnterPeriods.AutoPopDelay = 7500;
            this.tltEnterPeriods.InitialDelay = 500;
            this.tltEnterPeriods.ReshowDelay = 100;
            this.tltEnterPeriods.ToolTipTitle = "Compounding Frequency";
            // 
            // tltAnnuity
            // 
            this.tltAnnuity.AutoPopDelay = 10000;
            this.tltAnnuity.InitialDelay = 500;
            this.tltAnnuity.ReshowDelay = 100;
            this.tltAnnuity.ToolTipTitle = "Periodic Payments";
            // 
            // tltDueAnnuityCheck
            // 
            this.tltDueAnnuityCheck.AutoPopDelay = 10000;
            this.tltDueAnnuityCheck.InitialDelay = 500;
            this.tltDueAnnuityCheck.ReshowDelay = 100;
            // 
            // tltAnnuityAmount
            // 
            this.tltAnnuityAmount.ToolTipTitle = "Period Payment";
            // 
            // tltPaymentGrowth
            // 
            this.tltPaymentGrowth.AutoPopDelay = 7500;
            this.tltPaymentGrowth.InitialDelay = 500;
            this.tltPaymentGrowth.ReshowDelay = 100;
            this.tltPaymentGrowth.ToolTipTitle = "Payment Growth";
            // 
            // tltPaymentFrequency
            // 
            this.tltPaymentFrequency.AutoPopDelay = 10000;
            this.tltPaymentFrequency.InitialDelay = 500;
            this.tltPaymentFrequency.ReshowDelay = 100;
            this.tltPaymentFrequency.ToolTipTitle = "Payment Frequency";
            // 
            // carcMain
            // 
            this.carcMain.Location = new System.Drawing.Point(15, 115);
            this.carcMain.Name = "carcMain";
            this.carcMain.Size = new System.Drawing.Size(696, 282);
            this.carcMain.TabIndex = 19;
            this.carcMain.Text = "cartesianChart1";
            // 
            // btnInvesting
            // 
            this.btnInvesting.Location = new System.Drawing.Point(15, 415);
            this.btnInvesting.Name = "btnInvesting";
            this.btnInvesting.Size = new System.Drawing.Size(115, 23);
            this.btnInvesting.TabIndex = 20;
            this.btnInvesting.Text = "Go to Investing";
            this.btnInvesting.UseVisualStyleBackColor = true;
            this.btnInvesting.Click += new System.EventHandler(this.btnInvesting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.btnInvesting);
            this.Controls.Add(this.carcMain);
            this.Controls.Add(this.txtPaymentGrowth);
            this.Controls.Add(this.lblPaymentGrowth);
            this.Controls.Add(this.txtPaymentFrequency);
            this.Controls.Add(this.lblPaymentFrequency);
            this.Controls.Add(this.chkPaymentAt);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkAnnuity);
            this.Controls.Add(this.txtCompoundingFrequency);
            this.Controls.Add(this.lblCompoundingFrequency);
            this.Controls.Add(this.txtAnnuityPayment);
            this.Controls.Add(this.lblAnnuityPayment);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGain);
            this.Controls.Add(this.txtPeriods);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.lblPeriods);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblEnterPrincipalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Retirement Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterPrincipalLabel;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label lblPeriods;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnnuityPayment;
        private System.Windows.Forms.TextBox txtAnnuityPayment;
        private System.Windows.Forms.TextBox txtCompoundingFrequency;
        private System.Windows.Forms.Label lblCompoundingFrequency;
        private System.Windows.Forms.CheckBox chkAnnuity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkPaymentAt;
        private System.Windows.Forms.TextBox txtPaymentFrequency;
        private System.Windows.Forms.Label lblPaymentFrequency;
        private System.Windows.Forms.TextBox txtPaymentGrowth;
        private System.Windows.Forms.Label lblPaymentGrowth;
        private System.Windows.Forms.ToolTip tltPrincipalAmount;
        private System.Windows.Forms.ToolTip tltTotalPeriods;
        private System.Windows.Forms.ToolTip tltGainRate;
        private System.Windows.Forms.ToolTip tltAnnuityAmount;
        private System.Windows.Forms.ToolTip tltEnterPeriods;
        private System.Windows.Forms.ToolTip tltAnnuity;
        private System.Windows.Forms.ToolTip tltDueAnnuityCheck;
        private System.Windows.Forms.ToolTip tltPaymentFrequency;
        private System.Windows.Forms.ToolTip tltPaymentGrowth;
        private LiveCharts.WinForms.CartesianChart carcMain;
        private System.Windows.Forms.Button btnInvesting;
    }
}

