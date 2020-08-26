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
            this.txtInflation = new System.Windows.Forms.TextBox();
            this.lblBondsPercentage = new System.Windows.Forms.Label();
            this.lblStocksPercentage = new System.Windows.Forms.Label();
            this.txtStockFraction = new System.Windows.Forms.TextBox();
            this.txtBondFraction = new System.Windows.Forms.TextBox();
            this.lblPortfolioBreakdown = new System.Windows.Forms.Label();
            this.carcInvestment = new LiveCharts.WinForms.CartesianChart();
            this.cboProjection = new System.Windows.Forms.ComboBox();
            this.lblProjectionMethod = new System.Windows.Forms.Label();
            this.lblExpectedReturns = new System.Windows.Forms.Label();
            this.lblBondReturns = new System.Windows.Forms.Label();
            this.lblStockReturns = new System.Windows.Forms.Label();
            this.txtStockReturns = new System.Windows.Forms.TextBox();
            this.txtBondReturns = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtPrincipal.TabIndex = 2;
            this.txtPrincipal.Tag = "dollar";
            this.txtPrincipal.Text = "0";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtPrincipal.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtPrincipal.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(194, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.Tag = "period";
            this.txtAge.Text = "20";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(194, 64);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 3;
            this.txtIncome.Tag = "dollar";
            this.txtIncome.Text = "$75 000.00";
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIncome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtIncome.Leave += new System.EventHandler(this.txtIncome_Leave);
            this.txtIncome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
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
            this.txtSavings.Location = new System.Drawing.Point(177, 116);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(117, 20);
            this.txtSavings.TabIndex = 5;
            this.txtSavings.Tag = "dollar";
            this.txtSavings.Text = "$15 000.00 (20.0%)";
            this.txtSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSavings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSavings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSavings.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtSavings.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
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
            this.txtSpending.Location = new System.Drawing.Point(194, 90);
            this.txtSpending.Name = "txtSpending";
            this.txtSpending.Size = new System.Drawing.Size(100, 20);
            this.txtSpending.TabIndex = 4;
            this.txtSpending.Tag = "dollar";
            this.txtSpending.Text = "$60 000.00";
            this.txtSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpending.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSpending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSpending.Leave += new System.EventHandler(this.txtIncome_Leave);
            this.txtSpending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // lblRetirementSpending
            // 
            this.lblRetirementSpending.AutoSize = true;
            this.lblRetirementSpending.Location = new System.Drawing.Point(329, 93);
            this.lblRetirementSpending.Name = "lblRetirementSpending";
            this.lblRetirementSpending.Size = new System.Drawing.Size(166, 13);
            this.lblRetirementSpending.TabIndex = 10;
            this.lblRetirementSpending.Text = "1st Year Retirement Spending ($):";
            // 
            // txtRetirementSpending
            // 
            this.txtRetirementSpending.Location = new System.Drawing.Point(501, 90);
            this.txtRetirementSpending.Name = "txtRetirementSpending";
            this.txtRetirementSpending.Size = new System.Drawing.Size(100, 20);
            this.txtRetirementSpending.TabIndex = 10;
            this.txtRetirementSpending.Tag = "dollar";
            this.txtRetirementSpending.Text = "$40 000.00";
            this.txtRetirementSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetirementSpending.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtRetirementSpending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtRetirementSpending.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtRetirementSpending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // chkInflationRetirementSpendingPeg
            // 
            this.chkInflationRetirementSpendingPeg.AutoSize = true;
            this.chkInflationRetirementSpendingPeg.Enabled = false;
            this.chkInflationRetirementSpendingPeg.Location = new System.Drawing.Point(613, 92);
            this.chkInflationRetirementSpendingPeg.Name = "chkInflationRetirementSpendingPeg";
            this.chkInflationRetirementSpendingPeg.Size = new System.Drawing.Size(97, 17);
            this.chkInflationRetirementSpendingPeg.TabIndex = 11;
            this.chkInflationRetirementSpendingPeg.Text = "Peg to Inflation";
            this.chkInflationRetirementSpendingPeg.UseVisualStyleBackColor = true;
            this.chkInflationRetirementSpendingPeg.CheckedChanged += new System.EventHandler(this.chkInflationIncomeGrowthPeg_CheckedChanged);
            // 
            // txtWithdrawlRate
            // 
            this.txtWithdrawlRate.Location = new System.Drawing.Point(500, 116);
            this.txtWithdrawlRate.Name = "txtWithdrawlRate";
            this.txtWithdrawlRate.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawlRate.TabIndex = 12;
            this.txtWithdrawlRate.Tag = "rate";
            this.txtWithdrawlRate.Text = "3.00";
            this.txtWithdrawlRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWithdrawlRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtWithdrawlRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtWithdrawlRate.Leave += new System.EventHandler(this.txtAge_Leave);
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
            this.lblTaxRate.Location = new System.Drawing.Point(762, 15);
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
            this.txtTaxRate.TabIndex = 14;
            this.txtTaxRate.Tag = "rate";
            this.txtTaxRate.Text = "10.00";
            this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtTaxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtTaxRate.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // lblSavingsGoal
            // 
            this.lblSavingsGoal.AutoSize = true;
            this.lblSavingsGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsGoal.Location = new System.Drawing.Point(762, 67);
            this.lblSavingsGoal.Name = "lblSavingsGoal";
            this.lblSavingsGoal.Size = new System.Drawing.Size(105, 13);
            this.lblSavingsGoal.TabIndex = 17;
            this.lblSavingsGoal.Text = "Savings Goal ($):";
            // 
            // txtSavingsGoal
            // 
            this.txtSavingsGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsGoal.Location = new System.Drawing.Point(955, 64);
            this.txtSavingsGoal.Name = "txtSavingsGoal";
            this.txtSavingsGoal.ReadOnly = true;
            this.txtSavingsGoal.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsGoal.TabIndex = 15;
            this.txtSavingsGoal.Tag = "dollar";
            this.txtSavingsGoal.Text = "$1 000.00";
            this.txtSavingsGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncomeGrowth
            // 
            this.txtIncomeGrowth.Location = new System.Drawing.Point(498, 12);
            this.txtIncomeGrowth.Name = "txtIncomeGrowth";
            this.txtIncomeGrowth.Size = new System.Drawing.Size(102, 20);
            this.txtIncomeGrowth.TabIndex = 6;
            this.txtIncomeGrowth.Tag = "rate";
            this.txtIncomeGrowth.Text = "2.50";
            this.txtIncomeGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIncomeGrowth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtIncomeGrowth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtIncomeGrowth.Leave += new System.EventHandler(this.txtAge_Leave);
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
            this.txtSpendingFractionGrowth.Location = new System.Drawing.Point(666, 38);
            this.txtSpendingFractionGrowth.Name = "txtSpendingFractionGrowth";
            this.txtSpendingFractionGrowth.Size = new System.Drawing.Size(70, 20);
            this.txtSpendingFractionGrowth.TabIndex = 8;
            this.txtSpendingFractionGrowth.Tag = "rate,fraction";
            this.txtSpendingFractionGrowth.Text = "50.0";
            this.txtSpendingFractionGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpendingFractionGrowth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSpendingFractionGrowth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSpendingFractionGrowth.Leave += new System.EventHandler(this.txtSpendingFractionGrowth_Leave);
            // 
            // txtSavingFractionGrowth
            // 
            this.txtSavingFractionGrowth.Location = new System.Drawing.Point(666, 64);
            this.txtSavingFractionGrowth.Name = "txtSavingFractionGrowth";
            this.txtSavingFractionGrowth.Size = new System.Drawing.Size(70, 20);
            this.txtSavingFractionGrowth.TabIndex = 9;
            this.txtSavingFractionGrowth.Tag = "rate,fraction";
            this.txtSavingFractionGrowth.Text = "50.0";
            this.txtSavingFractionGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSavingFractionGrowth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSavingFractionGrowth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSavingFractionGrowth.Leave += new System.EventHandler(this.txtSpendingFractionGrowth_Leave);
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
            this.lblSpendingFractionGrowth.Location = new System.Drawing.Point(605, 41);
            this.lblSpendingFractionGrowth.Name = "lblSpendingFractionGrowth";
            this.lblSpendingFractionGrowth.Size = new System.Drawing.Size(55, 13);
            this.lblSpendingFractionGrowth.TabIndex = 25;
            this.lblSpendingFractionGrowth.Text = "Spending:";
            // 
            // lblSavingFractionGrowth
            // 
            this.lblSavingFractionGrowth.AutoSize = true;
            this.lblSavingFractionGrowth.Location = new System.Drawing.Point(617, 67);
            this.lblSavingFractionGrowth.Name = "lblSavingFractionGrowth";
            this.lblSavingFractionGrowth.Size = new System.Drawing.Size(43, 13);
            this.lblSavingFractionGrowth.TabIndex = 26;
            this.lblSavingFractionGrowth.Text = "Saving:";
            // 
            // chkInflationIncomeGrowthPeg
            // 
            this.chkInflationIncomeGrowthPeg.AutoSize = true;
            this.chkInflationIncomeGrowthPeg.Enabled = false;
            this.chkInflationIncomeGrowthPeg.Location = new System.Drawing.Point(613, 14);
            this.chkInflationIncomeGrowthPeg.Name = "chkInflationIncomeGrowthPeg";
            this.chkInflationIncomeGrowthPeg.Size = new System.Drawing.Size(130, 17);
            this.chkInflationIncomeGrowthPeg.TabIndex = 7;
            this.chkInflationIncomeGrowthPeg.Text = "In Excess of Inflation?";
            this.chkInflationIncomeGrowthPeg.UseVisualStyleBackColor = true;
            this.chkInflationIncomeGrowthPeg.CheckedChanged += new System.EventHandler(this.chkInflationIncomeGrowthPeg_CheckedChanged);
            // 
            // lblAverageInflation
            // 
            this.lblAverageInflation.AutoSize = true;
            this.lblAverageInflation.Location = new System.Drawing.Point(762, 41);
            this.lblAverageInflation.Name = "lblAverageInflation";
            this.lblAverageInflation.Size = new System.Drawing.Size(133, 13);
            this.lblAverageInflation.TabIndex = 28;
            this.lblAverageInflation.Text = "Average Inflation Rate (%):";
            // 
            // txtInflation
            // 
            this.txtInflation.Enabled = false;
            this.txtInflation.Location = new System.Drawing.Point(955, 38);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(100, 20);
            this.txtInflation.TabIndex = 16;
            this.txtInflation.Tag = "rate";
            this.txtInflation.Text = "2.00";
            this.txtInflation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInflation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtInflation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtInflation.Leave += new System.EventHandler(this.txtAge_Leave);
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
            this.lblStocksPercentage.Location = new System.Drawing.Point(762, 119);
            this.lblStocksPercentage.Name = "lblStocksPercentage";
            this.lblStocksPercentage.Size = new System.Drawing.Size(43, 13);
            this.lblStocksPercentage.TabIndex = 32;
            this.lblStocksPercentage.Text = "Stocks:";
            // 
            // txtStockFraction
            // 
            this.txtStockFraction.Location = new System.Drawing.Point(811, 116);
            this.txtStockFraction.Name = "txtStockFraction";
            this.txtStockFraction.Size = new System.Drawing.Size(77, 20);
            this.txtStockFraction.TabIndex = 17;
            this.txtStockFraction.Tag = "rate,fraction";
            this.txtStockFraction.Text = "90.0";
            this.txtStockFraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockFraction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtStockFraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtStockFraction.Leave += new System.EventHandler(this.txtStockFraction_Leave);
            // 
            // txtBondFraction
            // 
            this.txtBondFraction.Location = new System.Drawing.Point(978, 116);
            this.txtBondFraction.Name = "txtBondFraction";
            this.txtBondFraction.Size = new System.Drawing.Size(77, 20);
            this.txtBondFraction.TabIndex = 18;
            this.txtBondFraction.Tag = "rate,fraction";
            this.txtBondFraction.Text = "10.0";
            this.txtBondFraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBondFraction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtBondFraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtBondFraction.Leave += new System.EventHandler(this.txtStockFraction_Leave);
            // 
            // lblPortfolioBreakdown
            // 
            this.lblPortfolioBreakdown.AutoSize = true;
            this.lblPortfolioBreakdown.Location = new System.Drawing.Point(762, 93);
            this.lblPortfolioBreakdown.Name = "lblPortfolioBreakdown";
            this.lblPortfolioBreakdown.Size = new System.Drawing.Size(189, 13);
            this.lblPortfolioBreakdown.TabIndex = 34;
            this.lblPortfolioBreakdown.Text = "Fraction of Portfolio as (% out of 100)...";
            // 
            // carcInvestment
            // 
            this.carcInvestment.Location = new System.Drawing.Point(12, 196);
            this.carcInvestment.Name = "carcInvestment";
            this.carcInvestment.Size = new System.Drawing.Size(1043, 349);
            this.carcInvestment.TabIndex = 35;
            this.carcInvestment.Text = "cartesianChart1";
            // 
            // cboProjection
            // 
            this.cboProjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjection.FormattingEnabled = true;
            this.cboProjection.Items.AddRange(new object[] {
            "Fixed Rate Returns",
            "Monte Carlo Simulations"});
            this.cboProjection.Location = new System.Drawing.Point(146, 158);
            this.cboProjection.Name = "cboProjection";
            this.cboProjection.Size = new System.Drawing.Size(149, 21);
            this.cboProjection.TabIndex = 19;
            // 
            // lblProjectionMethod
            // 
            this.lblProjectionMethod.AutoSize = true;
            this.lblProjectionMethod.Location = new System.Drawing.Point(13, 161);
            this.lblProjectionMethod.Name = "lblProjectionMethod";
            this.lblProjectionMethod.Size = new System.Drawing.Size(96, 13);
            this.lblProjectionMethod.TabIndex = 37;
            this.lblProjectionMethod.Text = "Projection Method:";
            // 
            // lblExpectedReturns
            // 
            this.lblExpectedReturns.AutoSize = true;
            this.lblExpectedReturns.Location = new System.Drawing.Point(328, 161);
            this.lblExpectedReturns.Name = "lblExpectedReturns";
            this.lblExpectedReturns.Size = new System.Drawing.Size(159, 13);
            this.lblExpectedReturns.TabIndex = 38;
            this.lblExpectedReturns.Text = "Expected rate of return for (%) ...";
            // 
            // lblBondReturns
            // 
            this.lblBondReturns.AutoSize = true;
            this.lblBondReturns.Location = new System.Drawing.Point(610, 161);
            this.lblBondReturns.Name = "lblBondReturns";
            this.lblBondReturns.Size = new System.Drawing.Size(40, 13);
            this.lblBondReturns.TabIndex = 42;
            this.lblBondReturns.Text = "Bonds:";
            // 
            // lblStockReturns
            // 
            this.lblStockReturns.AutoSize = true;
            this.lblStockReturns.Location = new System.Drawing.Point(495, 161);
            this.lblStockReturns.Name = "lblStockReturns";
            this.lblStockReturns.Size = new System.Drawing.Size(43, 13);
            this.lblStockReturns.TabIndex = 41;
            this.lblStockReturns.Text = "Stocks:";
            // 
            // txtStockReturns
            // 
            this.txtStockReturns.Location = new System.Drawing.Point(545, 158);
            this.txtStockReturns.Name = "txtStockReturns";
            this.txtStockReturns.Size = new System.Drawing.Size(56, 20);
            this.txtStockReturns.TabIndex = 20;
            this.txtStockReturns.Tag = "rate";
            this.txtStockReturns.Text = "7.50";
            this.txtStockReturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockReturns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtStockReturns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtStockReturns.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtBondReturns
            // 
            this.txtBondReturns.Location = new System.Drawing.Point(656, 158);
            this.txtBondReturns.Name = "txtBondReturns";
            this.txtBondReturns.Size = new System.Drawing.Size(56, 20);
            this.txtBondReturns.TabIndex = 21;
            this.txtBondReturns.Tag = "rate";
            this.txtBondReturns.Text = "2.50";
            this.txtBondReturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBondReturns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtBondReturns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtBondReturns.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line2.Location = new System.Drawing.Point(12, 141);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1043, 2);
            this.line2.TabIndex = 43;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(966, 156);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(89, 23);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(333, 86);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(403, 2);
            this.line1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lblBondReturns);
            this.Controls.Add(this.lblStockReturns);
            this.Controls.Add(this.txtStockReturns);
            this.Controls.Add(this.txtBondReturns);
            this.Controls.Add(this.lblExpectedReturns);
            this.Controls.Add(this.lblProjectionMethod);
            this.Controls.Add(this.cboProjection);
            this.Controls.Add(this.carcInvestment);
            this.Controls.Add(this.lblPortfolioBreakdown);
            this.Controls.Add(this.lblBondsPercentage);
            this.Controls.Add(this.lblStocksPercentage);
            this.Controls.Add(this.txtStockFraction);
            this.Controls.Add(this.txtBondFraction);
            this.Controls.Add(this.txtInflation);
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
            this.Click += new System.EventHandler(this.Form2_Click);
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
        private System.Windows.Forms.TextBox txtInflation;
        private System.Windows.Forms.Label lblBondsPercentage;
        private System.Windows.Forms.Label lblStocksPercentage;
        private System.Windows.Forms.TextBox txtStockFraction;
        private System.Windows.Forms.TextBox txtBondFraction;
        private System.Windows.Forms.Label lblPortfolioBreakdown;
        private LiveCharts.WinForms.CartesianChart carcInvestment;
        private System.Windows.Forms.ComboBox cboProjection;
        private System.Windows.Forms.Label lblProjectionMethod;
        private System.Windows.Forms.Label lblExpectedReturns;
        private System.Windows.Forms.Label lblBondReturns;
        private System.Windows.Forms.Label lblStockReturns;
        private System.Windows.Forms.TextBox txtStockReturns;
        private System.Windows.Forms.TextBox txtBondReturns;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label label1;
    }
}