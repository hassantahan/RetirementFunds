namespace RetirementFunds
{
    partial class Form2
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
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.lblSpending = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.lblSavings = new System.Windows.Forms.Label();
            this.txtSpending = new System.Windows.Forms.TextBox();
            this.lblRetirementSpending = new System.Windows.Forms.Label();
            this.txtRetirementSpending = new System.Windows.Forms.TextBox();
            this.chkInflationRetirementSpendingPeg = new System.Windows.Forms.CheckBox();
            this.txtWithdrawlRate = new System.Windows.Forms.TextBox();
            this.lblWithdrawlRate = new System.Windows.Forms.Label();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblSavingsGoal = new System.Windows.Forms.Label();
            this.txtSavingsGoal = new System.Windows.Forms.TextBox();
            this.txtIncomeGrowth = new System.Windows.Forms.TextBox();
            this.lblIncomeGrowth = new System.Windows.Forms.Label();
            this.txtSpendingFractionGrowth = new System.Windows.Forms.TextBox();
            this.txtSavingFractionGrowth = new System.Windows.Forms.TextBox();
            this.lblFraction = new System.Windows.Forms.Label();
            this.lblSpendingFractionGrowth = new System.Windows.Forms.Label();
            this.lblSavingFractionGrowth = new System.Windows.Forms.Label();
            this.chkInflationIncomeGrowthPeg = new System.Windows.Forms.CheckBox();
            this.lblAverageInflation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBondsPercentage = new System.Windows.Forms.Label();
            this.lblStocksPercentage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPortfolioBreakdown = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 15);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age (years):";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(12, 41);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(119, 13);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Current Investments ($):";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(12, 67);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(129, 13);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Current Yearly Income ($):";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(194, 38);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 3;
            this.txtPrincipal.Tag = "dollar";
            this.txtPrincipal.Text = "$1 000.00";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(194, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;
            this.txtAge.Tag = "period";
            this.txtAge.Text = "20";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(194, 64);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 5;
            this.txtIncome.Tag = "dollar";
            this.txtIncome.Text = "$1 000.00";
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSpending
            // 
            this.lblSpending.AutoSize = true;
            this.lblSpending.Location = new System.Drawing.Point(12, 93);
            this.lblSpending.Name = "lblSpending";
            this.lblSpending.Size = new System.Drawing.Size(139, 13);
            this.lblSpending.TabIndex = 6;
            this.lblSpending.Text = "Current Yearly Spending ($):";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(194, 116);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.Size = new System.Drawing.Size(100, 20);
            this.txtSavings.TabIndex = 7;
            this.txtSavings.Tag = "dollar";
            this.txtSavings.Text = "$1 000.00";
            this.txtSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(12, 119);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(159, 13);
            this.lblSavings.TabIndex = 8;
            this.lblSavings.Text = "Immediate Yearly Savings ($/%):";
            // 
            // txtSpending
            // 
            this.txtSpending.Enabled = false;
            this.txtSpending.Location = new System.Drawing.Point(194, 90);
            this.txtSpending.Name = "txtSpending";
            this.txtSpending.Size = new System.Drawing.Size(100, 20);
            this.txtSpending.TabIndex = 9;
            this.txtSpending.Tag = "dollar";
            this.txtSpending.Text = "$1 000.00";
            this.txtSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRetirementSpending
            // 
            this.lblRetirementSpending.AutoSize = true;
            this.lblRetirementSpending.Location = new System.Drawing.Point(328, 93);
            this.lblRetirementSpending.Name = "lblRetirementSpending";
            this.lblRetirementSpending.Size = new System.Drawing.Size(166, 13);
            this.lblRetirementSpending.TabIndex = 10;
            this.lblRetirementSpending.Text = "1st Year Retirement Spending ($):";
            // 
            // txtRetirementSpending
            // 
            this.txtRetirementSpending.Location = new System.Drawing.Point(520, 90);
            this.txtRetirementSpending.Name = "txtRetirementSpending";
            this.txtRetirementSpending.Size = new System.Drawing.Size(100, 20);
            this.txtRetirementSpending.TabIndex = 11;
            this.txtRetirementSpending.Tag = "dollar";
            this.txtRetirementSpending.Text = "$1 000.00";
            this.txtRetirementSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkInflationRetirementSpendingPeg
            // 
            this.chkInflationRetirementSpendingPeg.AutoSize = true;
            this.chkInflationRetirementSpendingPeg.Location = new System.Drawing.Point(634, 92);
            this.chkInflationRetirementSpendingPeg.Name = "chkInflationRetirementSpendingPeg";
            this.chkInflationRetirementSpendingPeg.Size = new System.Drawing.Size(97, 17);
            this.chkInflationRetirementSpendingPeg.TabIndex = 12;
            this.chkInflationRetirementSpendingPeg.Text = "Peg to Inflation";
            this.chkInflationRetirementSpendingPeg.UseVisualStyleBackColor = true;
            // 
            // txtWithdrawlRate
            // 
            this.txtWithdrawlRate.Location = new System.Drawing.Point(631, 116);
            this.txtWithdrawlRate.Name = "txtWithdrawlRate";
            this.txtWithdrawlRate.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawlRate.TabIndex = 13;
            this.txtWithdrawlRate.Tag = "rate";
            this.txtWithdrawlRate.Text = "1.00%";
            this.txtWithdrawlRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWithdrawlRate
            // 
            this.lblWithdrawlRate.AutoSize = true;
            this.lblWithdrawlRate.Location = new System.Drawing.Point(328, 119);
            this.lblWithdrawlRate.Name = "lblWithdrawlRate";
            this.lblWithdrawlRate.Size = new System.Drawing.Size(162, 13);
            this.lblWithdrawlRate.TabIndex = 14;
            this.lblWithdrawlRate.Text = "Percentage of Total Savings (%):";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(751, 15);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(125, 13);
            this.lblTaxRate.TabIndex = 15;
            this.lblTaxRate.Text = "Retirement Tax Rate (%):";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(955, 12);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 16;
            this.txtTaxRate.Tag = "rate";
            this.txtTaxRate.Text = "1.00%";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSavingsGoal
            // 
            this.lblSavingsGoal.AutoSize = true;
            this.lblSavingsGoal.Location = new System.Drawing.Point(751, 41);
            this.lblSavingsGoal.Name = "lblSavingsGoal";
            this.lblSavingsGoal.Size = new System.Drawing.Size(88, 13);
            this.lblSavingsGoal.TabIndex = 17;
            this.lblSavingsGoal.Text = "Savings Goal ($):";
            // 
            // txtSavingsGoal
            // 
            this.txtSavingsGoal.Location = new System.Drawing.Point(955, 38);
            this.txtSavingsGoal.Name = "txtSavingsGoal";
            this.txtSavingsGoal.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsGoal.TabIndex = 18;
            this.txtSavingsGoal.Tag = "dollar";
            this.txtSavingsGoal.Text = "$1 000.00";
            this.txtSavingsGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncomeGrowth
            // 
            this.txtIncomeGrowth.Location = new System.Drawing.Point(484, 12);
            this.txtIncomeGrowth.Name = "txtIncomeGrowth";
            this.txtIncomeGrowth.Size = new System.Drawing.Size(102, 20);
            this.txtIncomeGrowth.TabIndex = 19;
            this.txtIncomeGrowth.Tag = "rate";
            this.txtIncomeGrowth.Text = "1.00%";
            this.txtIncomeGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIncomeGrowth
            // 
            this.lblIncomeGrowth.AutoSize = true;
            this.lblIncomeGrowth.Location = new System.Drawing.Point(328, 15);
            this.lblIncomeGrowth.Name = "lblIncomeGrowth";
            this.lblIncomeGrowth.Size = new System.Drawing.Size(131, 13);
            this.lblIncomeGrowth.TabIndex = 20;
            this.lblIncomeGrowth.Text = "Yearly Income Growth (%):";
            // 
            // txtSpendingFractionGrowth
            // 
            this.txtSpendingFractionGrowth.Enabled = false;
            this.txtSpendingFractionGrowth.Location = new System.Drawing.Point(389, 64);
            this.txtSpendingFractionGrowth.Name = "txtSpendingFractionGrowth";
            this.txtSpendingFractionGrowth.Size = new System.Drawing.Size(102, 20);
            this.txtSpendingFractionGrowth.TabIndex = 21;
            this.txtSpendingFractionGrowth.Tag = "rate";
            this.txtSpendingFractionGrowth.Text = "50.0%";
            this.txtSpendingFractionGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSavingFractionGrowth
            // 
            this.txtSavingFractionGrowth.Enabled = false;
            this.txtSavingFractionGrowth.Location = new System.Drawing.Point(566, 64);
            this.txtSavingFractionGrowth.Name = "txtSavingFractionGrowth";
            this.txtSavingFractionGrowth.Size = new System.Drawing.Size(102, 20);
            this.txtSavingFractionGrowth.TabIndex = 22;
            this.txtSavingFractionGrowth.Tag = "rate";
            this.txtSavingFractionGrowth.Text = "50.0%";
            this.txtSavingFractionGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFraction
            // 
            this.lblFraction.AutoSize = true;
            this.lblFraction.Location = new System.Drawing.Point(328, 41);
            this.lblFraction.Name = "lblFraction";
            this.lblFraction.Size = new System.Drawing.Size(258, 13);
            this.lblFraction.TabIndex = 24;
            this.lblFraction.Text = "Fraction of Income Growth Spent on  (% out of 100)...";
            // 
            // lblSpendingFractionGrowth
            // 
            this.lblSpendingFractionGrowth.AutoSize = true;
            this.lblSpendingFractionGrowth.Location = new System.Drawing.Point(328, 67);
            this.lblSpendingFractionGrowth.Name = "lblSpendingFractionGrowth";
            this.lblSpendingFractionGrowth.Size = new System.Drawing.Size(55, 13);
            this.lblSpendingFractionGrowth.TabIndex = 25;
            this.lblSpendingFractionGrowth.Text = "Spending:";
            // 
            // lblSavingFractionGrowth
            // 
            this.lblSavingFractionGrowth.AutoSize = true;
            this.lblSavingFractionGrowth.Location = new System.Drawing.Point(517, 67);
            this.lblSavingFractionGrowth.Name = "lblSavingFractionGrowth";
            this.lblSavingFractionGrowth.Size = new System.Drawing.Size(43, 13);
            this.lblSavingFractionGrowth.TabIndex = 26;
            this.lblSavingFractionGrowth.Text = "Saving:";
            // 
            // chkInflationIncomeGrowthPeg
            // 
            this.chkInflationIncomeGrowthPeg.AutoSize = true;
            this.chkInflationIncomeGrowthPeg.Location = new System.Drawing.Point(601, 14);
            this.chkInflationIncomeGrowthPeg.Name = "chkInflationIncomeGrowthPeg";
            this.chkInflationIncomeGrowthPeg.Size = new System.Drawing.Size(130, 17);
            this.chkInflationIncomeGrowthPeg.TabIndex = 27;
            this.chkInflationIncomeGrowthPeg.Text = "In Excess of Inflation?";
            this.chkInflationIncomeGrowthPeg.UseVisualStyleBackColor = true;
            // 
            // lblAverageInflation
            // 
            this.lblAverageInflation.AutoSize = true;
            this.lblAverageInflation.Location = new System.Drawing.Point(751, 67);
            this.lblAverageInflation.Name = "lblAverageInflation";
            this.lblAverageInflation.Size = new System.Drawing.Size(133, 13);
            this.lblAverageInflation.TabIndex = 28;
            this.lblAverageInflation.Text = "Average Inflation Rate (%):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(955, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Tag = "rate";
            this.textBox1.Text = "1.00%";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBondsPercentage
            // 
            this.lblBondsPercentage.AutoSize = true;
            this.lblBondsPercentage.Location = new System.Drawing.Point(932, 119);
            this.lblBondsPercentage.Name = "lblBondsPercentage";
            this.lblBondsPercentage.Size = new System.Drawing.Size(40, 13);
            this.lblBondsPercentage.TabIndex = 33;
            this.lblBondsPercentage.Text = "Bonds:";
            // 
            // lblStocksPercentage
            // 
            this.lblStocksPercentage.AutoSize = true;
            this.lblStocksPercentage.Location = new System.Drawing.Point(751, 119);
            this.lblStocksPercentage.Name = "lblStocksPercentage";
            this.lblStocksPercentage.Size = new System.Drawing.Size(43, 13);
            this.lblStocksPercentage.TabIndex = 32;
            this.lblStocksPercentage.Text = "Stocks:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(800, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.Tag = "rate";
            this.textBox2.Text = "50.0%";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(978, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 20);
            this.textBox3.TabIndex = 30;
            this.textBox3.Tag = "rate";
            this.textBox3.Text = "50.0%";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPortfolioBreakdown
            // 
            this.lblPortfolioBreakdown.AutoSize = true;
            this.lblPortfolioBreakdown.Location = new System.Drawing.Point(751, 93);
            this.lblPortfolioBreakdown.Name = "lblPortfolioBreakdown";
            this.lblPortfolioBreakdown.Size = new System.Drawing.Size(189, 13);
            this.lblPortfolioBreakdown.TabIndex = 34;
            this.lblPortfolioBreakdown.Text = "Fraction of Portfolio as (% out of 100)...";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 196);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1043, 349);
            this.cartesianChart1.TabIndex = 35;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.lblPortfolioBreakdown);
            this.Controls.Add(this.lblBondsPercentage);
            this.Controls.Add(this.lblStocksPercentage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAverageInflation);
            this.Controls.Add(this.chkInflationIncomeGrowthPeg);
            this.Controls.Add(this.lblSavingFractionGrowth);
            this.Controls.Add(this.lblSpendingFractionGrowth);
            this.Controls.Add(this.lblFraction);
            this.Controls.Add(this.txtSavingFractionGrowth);
            this.Controls.Add(this.txtSpendingFractionGrowth);
            this.Controls.Add(this.lblIncomeGrowth);
            this.Controls.Add(this.txtIncomeGrowth);
            this.Controls.Add(this.txtSavingsGoal);
            this.Controls.Add(this.lblSavingsGoal);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblWithdrawlRate);
            this.Controls.Add(this.txtWithdrawlRate);
            this.Controls.Add(this.chkInflationRetirementSpendingPeg);
            this.Controls.Add(this.txtRetirementSpending);
            this.Controls.Add(this.lblRetirementSpending);
            this.Controls.Add(this.txtSpending);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.lblSpending);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.lblAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Retirement Funds";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label lblSpending;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtSpending;
        private System.Windows.Forms.Label lblRetirementSpending;
        private System.Windows.Forms.TextBox txtRetirementSpending;
        private System.Windows.Forms.CheckBox chkInflationRetirementSpendingPeg;
        private System.Windows.Forms.TextBox txtWithdrawlRate;
        private System.Windows.Forms.Label lblWithdrawlRate;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lblSavingsGoal;
        private System.Windows.Forms.TextBox txtSavingsGoal;
        private System.Windows.Forms.TextBox txtIncomeGrowth;
        private System.Windows.Forms.Label lblIncomeGrowth;
        private System.Windows.Forms.TextBox txtSpendingFractionGrowth;
        private System.Windows.Forms.TextBox txtSavingFractionGrowth;
        private System.Windows.Forms.Label lblFraction;
        private System.Windows.Forms.Label lblSpendingFractionGrowth;
        private System.Windows.Forms.Label lblSavingFractionGrowth;
        private System.Windows.Forms.CheckBox chkInflationIncomeGrowthPeg;
        private System.Windows.Forms.Label lblAverageInflation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBondsPercentage;
        private System.Windows.Forms.Label lblStocksPercentage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPortfolioBreakdown;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}