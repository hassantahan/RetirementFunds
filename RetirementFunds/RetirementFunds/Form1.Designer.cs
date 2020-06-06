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
            this.PrincipleLabel = new System.Windows.Forms.Label();
            this.PrincipleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrincipleLabel
            // 
            this.PrincipleLabel.AutoSize = true;
            this.PrincipleLabel.Location = new System.Drawing.Point(12, 9);
            this.PrincipleLabel.Name = "PrincipleLabel";
            this.PrincipleLabel.Size = new System.Drawing.Size(117, 13);
            this.PrincipleLabel.TabIndex = 0;
            this.PrincipleLabel.Text = "Enter Principle Amount:";
            // 
            // PrincipleTextBox
            // 
            this.PrincipleTextBox.Location = new System.Drawing.Point(135, 6);
            this.PrincipleTextBox.Name = "PrincipleTextBox";
            this.PrincipleTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrincipleTextBox.TabIndex = 1;
            this.PrincipleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrincipleTextBox.TextChanged += new System.EventHandler(this.PrincipleTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrincipleTextBox);
            this.Controls.Add(this.PrincipleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrincipleLabel;
        private System.Windows.Forms.TextBox PrincipleTextBox;
    }
}

