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
            this.cboProjection = new System.Windows.Forms.ComboBox();
            this.lblProjectionMethod = new System.Windows.Forms.Label();
            this.lblExpectedReturns = new System.Windows.Forms.Label();
            this.lblBondReturns = new System.Windows.Forms.Label();
            this.txtStockReturns = new System.Windows.Forms.TextBox();
            this.txtBondReturns = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.carcInvestment = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 19);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(86, 17);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age (years):";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(15, 51);
            this.lblPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(160, 17);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "Current Investments ($):";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(15, 84);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(174, 17);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Current Yearly Income ($):";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(242, 48);
            this.txtPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(124, 22);
            this.txtPrincipal.TabIndex = 2;
            this.txtPrincipal.Tag = "dollar";
            this.txtPrincipal.Text = "$0.00";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtPrincipal.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtPrincipal.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(242, 15);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(124, 22);
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
            this.txtIncome.Location = new System.Drawing.Point(242, 80);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(124, 22);
            this.txtIncome.TabIndex = 3;
            this.txtIncome.Tag = "dollar";
            this.txtIncome.Text = "$75000.00";
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIncome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtIncome.Leave += new System.EventHandler(this.txtIncome_Leave);
            this.txtIncome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // lblSpending
            // 
            this.lblSpending.AutoSize = true;
            this.lblSpending.Location = new System.Drawing.Point(15, 116);
            this.lblSpending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpending.Name = "lblSpending";
            this.lblSpending.Size = new System.Drawing.Size(189, 17);
            this.lblSpending.TabIndex = 6;
            this.lblSpending.Text = "Current Yearly Spending ($):";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(242, 145);
            this.txtSavings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(124, 22);
            this.txtSavings.TabIndex = 5;
            this.txtSavings.Tag = "";
            this.txtSavings.Text = "$15000.00 (20.0%)";
            this.txtSavings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSavings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSavings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSavings.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtSavings.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Location = new System.Drawing.Point(15, 149);
            this.lblSavings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(212, 17);
            this.lblSavings.TabIndex = 8;
            this.lblSavings.Text = "Immediate Yearly Savings ($/%):";
            // 
            // txtSpending
            // 
            this.txtSpending.Location = new System.Drawing.Point(242, 112);
            this.txtSpending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpending.Name = "txtSpending";
            this.txtSpending.Size = new System.Drawing.Size(124, 22);
            this.txtSpending.TabIndex = 4;
            this.txtSpending.Tag = "dollar";
            this.txtSpending.Text = "$60000.00";
            this.txtSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpending.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtSpending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtSpending.Leave += new System.EventHandler(this.txtIncome_Leave);
            this.txtSpending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // lblRetirementSpending
            // 
            this.lblRetirementSpending.AutoSize = true;
            this.lblRetirementSpending.Location = new System.Drawing.Point(411, 116);
            this.lblRetirementSpending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetirementSpending.Name = "lblRetirementSpending";
            this.lblRetirementSpending.Size = new System.Drawing.Size(224, 17);
            this.lblRetirementSpending.TabIndex = 10;
            this.lblRetirementSpending.Text = "1st Year Retirement Spending ($):";
            // 
            // txtRetirementSpending
            // 
            this.txtRetirementSpending.Location = new System.Drawing.Point(634, 112);
            this.txtRetirementSpending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRetirementSpending.Name = "txtRetirementSpending";
            this.txtRetirementSpending.Size = new System.Drawing.Size(124, 22);
            this.txtRetirementSpending.TabIndex = 10;
            this.txtRetirementSpending.Tag = "dollar";
            this.txtRetirementSpending.Text = "$40000.00";
            this.txtRetirementSpending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetirementSpending.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtRetirementSpending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtRetirementSpending.Leave += new System.EventHandler(this.txtAge_Leave);
            this.txtRetirementSpending.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPrincipal_PreviewKeyDown);
            // 
            // chkInflationRetirementSpendingPeg
            // 
            this.chkInflationRetirementSpendingPeg.AutoSize = true;
            this.chkInflationRetirementSpendingPeg.Location = new System.Drawing.Point(766, 115);
            this.chkInflationRetirementSpendingPeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInflationRetirementSpendingPeg.Name = "chkInflationRetirementSpendingPeg";
            this.chkInflationRetirementSpendingPeg.Size = new System.Drawing.Size(124, 21);
            this.chkInflationRetirementSpendingPeg.TabIndex = 11;
            this.chkInflationRetirementSpendingPeg.Text = "Peg to Inflation";
            this.chkInflationRetirementSpendingPeg.UseVisualStyleBackColor = true;
            this.chkInflationRetirementSpendingPeg.CheckedChanged += new System.EventHandler(this.chkInflationIncomeGrowthPeg_CheckedChanged);
            // 
            // txtWithdrawlRate
            // 
            this.txtWithdrawlRate.Location = new System.Drawing.Point(634, 146);
            this.txtWithdrawlRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWithdrawlRate.Name = "txtWithdrawlRate";
            this.txtWithdrawlRate.Size = new System.Drawing.Size(124, 22);
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
            this.lblWithdrawlRate.Location = new System.Drawing.Point(410, 149);
            this.lblWithdrawlRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWithdrawlRate.Name = "lblWithdrawlRate";
            this.lblWithdrawlRate.Size = new System.Drawing.Size(217, 17);
            this.lblWithdrawlRate.TabIndex = 14;
            this.lblWithdrawlRate.Text = "Percentage of Total Savings (%):";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(952, 19);
            this.lblTaxRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(168, 17);
            this.lblTaxRate.TabIndex = 15;
            this.lblTaxRate.Text = "Retirement Tax Rate (%):";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(1194, 15);
            this.txtTaxRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(124, 22);
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
            this.lblSavingsGoal.Location = new System.Drawing.Point(952, 84);
            this.lblSavingsGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingsGoal.Name = "lblSavingsGoal";
            this.lblSavingsGoal.Size = new System.Drawing.Size(135, 17);
            this.lblSavingsGoal.TabIndex = 17;
            this.lblSavingsGoal.Text = "Savings Goal ($):";
            // 
            // txtSavingsGoal
            // 
            this.txtSavingsGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsGoal.Location = new System.Drawing.Point(1194, 80);
            this.txtSavingsGoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSavingsGoal.Name = "txtSavingsGoal";
            this.txtSavingsGoal.ReadOnly = true;
            this.txtSavingsGoal.Size = new System.Drawing.Size(124, 23);
            this.txtSavingsGoal.TabIndex = 15;
            this.txtSavingsGoal.Tag = "dollar";
            this.txtSavingsGoal.Text = "$1466667";
            this.txtSavingsGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncomeGrowth
            // 
            this.txtIncomeGrowth.Location = new System.Drawing.Point(632, 14);
            this.txtIncomeGrowth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncomeGrowth.Name = "txtIncomeGrowth";
            this.txtIncomeGrowth.Size = new System.Drawing.Size(126, 22);
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
            this.lblIncomeGrowth.Location = new System.Drawing.Point(410, 19);
            this.lblIncomeGrowth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeGrowth.Name = "lblIncomeGrowth";
            this.lblIncomeGrowth.Size = new System.Drawing.Size(176, 17);
            this.lblIncomeGrowth.TabIndex = 20;
            this.lblIncomeGrowth.Text = "Yearly Income Growth (%):";
            // 
            // txtSpendingFractionGrowth
            // 
            this.txtSpendingFractionGrowth.Location = new System.Drawing.Point(832, 48);
            this.txtSpendingFractionGrowth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpendingFractionGrowth.Name = "txtSpendingFractionGrowth";
            this.txtSpendingFractionGrowth.Size = new System.Drawing.Size(86, 22);
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
            this.txtSavingFractionGrowth.Location = new System.Drawing.Point(832, 80);
            this.txtSavingFractionGrowth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSavingFractionGrowth.Name = "txtSavingFractionGrowth";
            this.txtSavingFractionGrowth.Size = new System.Drawing.Size(86, 22);
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
            this.lblFraction.Location = new System.Drawing.Point(410, 51);
            this.lblFraction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFraction.Name = "lblFraction";
            this.lblFraction.Size = new System.Drawing.Size(344, 17);
            this.lblFraction.TabIndex = 24;
            this.lblFraction.Text = "Fraction of Income Growth Spent on  (% out of 100)...";
            // 
            // lblSpendingFractionGrowth
            // 
            this.lblSpendingFractionGrowth.AutoSize = true;
            this.lblSpendingFractionGrowth.Location = new System.Drawing.Point(756, 51);
            this.lblSpendingFractionGrowth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpendingFractionGrowth.Name = "lblSpendingFractionGrowth";
            this.lblSpendingFractionGrowth.Size = new System.Drawing.Size(72, 17);
            this.lblSpendingFractionGrowth.TabIndex = 25;
            this.lblSpendingFractionGrowth.Text = "Spending:";
            // 
            // lblSavingFractionGrowth
            // 
            this.lblSavingFractionGrowth.AutoSize = true;
            this.lblSavingFractionGrowth.Location = new System.Drawing.Point(771, 84);
            this.lblSavingFractionGrowth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingFractionGrowth.Name = "lblSavingFractionGrowth";
            this.lblSavingFractionGrowth.Size = new System.Drawing.Size(55, 17);
            this.lblSavingFractionGrowth.TabIndex = 26;
            this.lblSavingFractionGrowth.Text = "Saving:";
            // 
            // chkInflationIncomeGrowthPeg
            // 
            this.chkInflationIncomeGrowthPeg.AutoSize = true;
            this.chkInflationIncomeGrowthPeg.Location = new System.Drawing.Point(766, 18);
            this.chkInflationIncomeGrowthPeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInflationIncomeGrowthPeg.Name = "chkInflationIncomeGrowthPeg";
            this.chkInflationIncomeGrowthPeg.Size = new System.Drawing.Size(166, 21);
            this.chkInflationIncomeGrowthPeg.TabIndex = 7;
            this.chkInflationIncomeGrowthPeg.Text = "In Excess of Inflation?";
            this.chkInflationIncomeGrowthPeg.UseVisualStyleBackColor = true;
            this.chkInflationIncomeGrowthPeg.CheckedChanged += new System.EventHandler(this.chkInflationIncomeGrowthPeg_CheckedChanged);
            // 
            // lblAverageInflation
            // 
            this.lblAverageInflation.AutoSize = true;
            this.lblAverageInflation.Location = new System.Drawing.Point(952, 51);
            this.lblAverageInflation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageInflation.Name = "lblAverageInflation";
            this.lblAverageInflation.Size = new System.Drawing.Size(178, 17);
            this.lblAverageInflation.TabIndex = 28;
            this.lblAverageInflation.Text = "Average Inflation Rate (%):";
            // 
            // txtInflation
            // 
            this.txtInflation.Location = new System.Drawing.Point(1194, 48);
            this.txtInflation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.Size = new System.Drawing.Size(124, 22);
            this.txtInflation.TabIndex = 16;
            this.txtInflation.Tag = "rate";
            this.txtInflation.Text = "2.19";
            this.txtInflation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInflation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtInflation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtInflation.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // lblBondsPercentage
            // 
            this.lblBondsPercentage.AutoSize = true;
            this.lblBondsPercentage.Location = new System.Drawing.Point(1165, 149);
            this.lblBondsPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBondsPercentage.Name = "lblBondsPercentage";
            this.lblBondsPercentage.Size = new System.Drawing.Size(52, 17);
            this.lblBondsPercentage.TabIndex = 33;
            this.lblBondsPercentage.Text = "Bonds:";
            // 
            // lblStocksPercentage
            // 
            this.lblStocksPercentage.AutoSize = true;
            this.lblStocksPercentage.Location = new System.Drawing.Point(952, 149);
            this.lblStocksPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStocksPercentage.Name = "lblStocksPercentage";
            this.lblStocksPercentage.Size = new System.Drawing.Size(54, 17);
            this.lblStocksPercentage.TabIndex = 32;
            this.lblStocksPercentage.Text = "Stocks:";
            // 
            // txtStockFraction
            // 
            this.txtStockFraction.Location = new System.Drawing.Point(1014, 145);
            this.txtStockFraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockFraction.Name = "txtStockFraction";
            this.txtStockFraction.Size = new System.Drawing.Size(95, 22);
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
            this.txtBondFraction.Location = new System.Drawing.Point(1222, 145);
            this.txtBondFraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBondFraction.Name = "txtBondFraction";
            this.txtBondFraction.Size = new System.Drawing.Size(95, 22);
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
            this.lblPortfolioBreakdown.Location = new System.Drawing.Point(952, 116);
            this.lblPortfolioBreakdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortfolioBreakdown.Name = "lblPortfolioBreakdown";
            this.lblPortfolioBreakdown.Size = new System.Drawing.Size(256, 17);
            this.lblPortfolioBreakdown.TabIndex = 34;
            this.lblPortfolioBreakdown.Text = "Fraction of Portfolio as (% out of 100)...";
            // 
            // cboProjection
            // 
            this.cboProjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjection.FormattingEnabled = true;
            this.cboProjection.Items.AddRange(new object[] {
            "Fixed Rate Returns",
            "Monte Carlo Simulations"});
            this.cboProjection.Location = new System.Drawing.Point(182, 198);
            this.cboProjection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProjection.Name = "cboProjection";
            this.cboProjection.Size = new System.Drawing.Size(185, 24);
            this.cboProjection.TabIndex = 19;
            // 
            // lblProjectionMethod
            // 
            this.lblProjectionMethod.AutoSize = true;
            this.lblProjectionMethod.Location = new System.Drawing.Point(16, 201);
            this.lblProjectionMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectionMethod.Name = "lblProjectionMethod";
            this.lblProjectionMethod.Size = new System.Drawing.Size(126, 17);
            this.lblProjectionMethod.TabIndex = 37;
            this.lblProjectionMethod.Text = "Projection Method:";
            // 
            // lblExpectedReturns
            // 
            this.lblExpectedReturns.AutoSize = true;
            this.lblExpectedReturns.Location = new System.Drawing.Point(410, 201);
            this.lblExpectedReturns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpectedReturns.Name = "lblExpectedReturns";
            this.lblExpectedReturns.Size = new System.Drawing.Size(266, 17);
            this.lblExpectedReturns.TabIndex = 38;
            this.lblExpectedReturns.Text = "Expected rate of return for (%) ... Stocks:";
            // 
            // lblBondReturns
            // 
            this.lblBondReturns.AutoSize = true;
            this.lblBondReturns.Location = new System.Drawing.Point(762, 201);
            this.lblBondReturns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBondReturns.Name = "lblBondReturns";
            this.lblBondReturns.Size = new System.Drawing.Size(52, 17);
            this.lblBondReturns.TabIndex = 42;
            this.lblBondReturns.Text = "Bonds:";
            // 
            // txtStockReturns
            // 
            this.txtStockReturns.Location = new System.Drawing.Point(681, 198);
            this.txtStockReturns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockReturns.Name = "txtStockReturns";
            this.txtStockReturns.Size = new System.Drawing.Size(69, 22);
            this.txtStockReturns.TabIndex = 20;
            this.txtStockReturns.Tag = "rate";
            this.txtStockReturns.Text = "8.55";
            this.txtStockReturns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockReturns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            this.txtStockReturns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtStockReturns.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtBondReturns
            // 
            this.txtBondReturns.Location = new System.Drawing.Point(820, 198);
            this.txtBondReturns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBondReturns.Name = "txtBondReturns";
            this.txtBondReturns.Size = new System.Drawing.Size(69, 22);
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
            this.line2.Location = new System.Drawing.Point(15, 176);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1303, 2);
            this.line2.TabIndex = 43;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(1208, 195);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 29);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line1.Location = new System.Drawing.Point(416, 108);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(503, 2);
            this.line1.TabIndex = 45;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(134, 274);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(15, 20);
            this.lblResults.TabIndex = 46;
            this.lblResults.Text = ".";
            // 
            // carcInvestment
            // 
            this.carcInvestment.Location = new System.Drawing.Point(20, 245);
            this.carcInvestment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carcInvestment.Name = "carcInvestment";
            this.carcInvestment.Size = new System.Drawing.Size(1304, 436);
            this.carcInvestment.TabIndex = 35;
            this.carcInvestment.Text = "cartesianChart1";
            // 
            // Form2
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1334, 696);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lblBondReturns);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cboProjection;
        private System.Windows.Forms.Label lblProjectionMethod;
        private System.Windows.Forms.Label lblExpectedReturns;
        private System.Windows.Forms.Label lblBondReturns;
        private System.Windows.Forms.TextBox txtStockReturns;
        private System.Windows.Forms.TextBox txtBondReturns;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label lblResults;
        private LiveCharts.WinForms.CartesianChart carcInvestment;
    }
}