namespace ATM.Forms
{
    partial class frmTransactionEntry
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSavingsTitle = new System.Windows.Forms.Label();
            this.lblTransactionTitle = new System.Windows.Forms.Label();
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnSavingsWithdraw = new System.Windows.Forms.Button();
            this.btnSavingsBalance = new System.Windows.Forms.Button();
            this.btnSavingsToChecking = new System.Windows.Forms.Button();
            this.btnCheckingToSavings = new System.Windows.Forms.Button();
            this.btnCheckingBalance = new System.Windows.Forms.Button();
            this.btnCheckingWithdraw = new System.Windows.Forms.Button();
            this.btnCheckingDeposit = new System.Windows.Forms.Button();
            this.lblCheckingTitle = new System.Windows.Forms.Label();
            this.lblVerifyTransactionInput = new System.Windows.Forms.Label();
            this.txtTransactionInput = new System.Windows.Forms.TextBox();
            this.btnTransactionGo = new System.Windows.Forms.Button();
            this.btnTransactionNo = new System.Windows.Forms.Button();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.btnTransactionAmountOK = new System.Windows.Forms.Button();
            this.pnlTransactionList = new System.Windows.Forms.Panel();
            this.pnlValueInput = new System.Windows.Forms.Panel();
            this.pnlVerifyAmount = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTransactionList.SuspendLayout();
            this.pnlValueInput.SuspendLayout();
            this.pnlVerifyAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblSavingsTitle
            // 
            this.lblSavingsTitle.AutoSize = true;
            this.lblSavingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsTitle.Location = new System.Drawing.Point(164, 238);
            this.lblSavingsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingsTitle.Name = "lblSavingsTitle";
            this.lblSavingsTitle.Size = new System.Drawing.Size(124, 29);
            this.lblSavingsTitle.TabIndex = 5;
            this.lblSavingsTitle.Text = "SAVINGS";
            // 
            // lblTransactionTitle
            // 
            this.lblTransactionTitle.AutoSize = true;
            this.lblTransactionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTitle.Location = new System.Drawing.Point(398, 168);
            this.lblTransactionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionTitle.Name = "lblTransactionTitle";
            this.lblTransactionTitle.Size = new System.Drawing.Size(350, 32);
            this.lblTransactionTitle.TabIndex = 4;
            this.lblTransactionTitle.Text = "SELECT TRANSACTION";
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Location = new System.Drawing.Point(64, 24);
            this.btnSavingsDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(356, 46);
            this.btnSavingsDeposit.TabIndex = 6;
            this.btnSavingsDeposit.TabStop = false;
            this.btnSavingsDeposit.Text = "Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnSavingsWithdraw
            // 
            this.btnSavingsWithdraw.Location = new System.Drawing.Point(64, 95);
            this.btnSavingsWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavingsWithdraw.Name = "btnSavingsWithdraw";
            this.btnSavingsWithdraw.Size = new System.Drawing.Size(356, 46);
            this.btnSavingsWithdraw.TabIndex = 7;
            this.btnSavingsWithdraw.TabStop = false;
            this.btnSavingsWithdraw.Text = "Withdraw";
            this.btnSavingsWithdraw.UseVisualStyleBackColor = true;
            this.btnSavingsWithdraw.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnSavingsBalance
            // 
            this.btnSavingsBalance.Location = new System.Drawing.Point(64, 166);
            this.btnSavingsBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavingsBalance.Name = "btnSavingsBalance";
            this.btnSavingsBalance.Size = new System.Drawing.Size(356, 46);
            this.btnSavingsBalance.TabIndex = 8;
            this.btnSavingsBalance.TabStop = false;
            this.btnSavingsBalance.Text = "View Balance";
            this.btnSavingsBalance.UseVisualStyleBackColor = true;
            this.btnSavingsBalance.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnSavingsToChecking
            // 
            this.btnSavingsToChecking.Location = new System.Drawing.Point(64, 235);
            this.btnSavingsToChecking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSavingsToChecking.Name = "btnSavingsToChecking";
            this.btnSavingsToChecking.Size = new System.Drawing.Size(356, 46);
            this.btnSavingsToChecking.TabIndex = 9;
            this.btnSavingsToChecking.TabStop = false;
            this.btnSavingsToChecking.Text = "Transfer to Checking";
            this.btnSavingsToChecking.UseVisualStyleBackColor = true;
            this.btnSavingsToChecking.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnCheckingToSavings
            // 
            this.btnCheckingToSavings.Location = new System.Drawing.Point(552, 235);
            this.btnCheckingToSavings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckingToSavings.Name = "btnCheckingToSavings";
            this.btnCheckingToSavings.Size = new System.Drawing.Size(356, 46);
            this.btnCheckingToSavings.TabIndex = 14;
            this.btnCheckingToSavings.TabStop = false;
            this.btnCheckingToSavings.Text = "Transfer to Savings";
            this.btnCheckingToSavings.UseVisualStyleBackColor = true;
            this.btnCheckingToSavings.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnCheckingBalance
            // 
            this.btnCheckingBalance.Location = new System.Drawing.Point(552, 166);
            this.btnCheckingBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckingBalance.Name = "btnCheckingBalance";
            this.btnCheckingBalance.Size = new System.Drawing.Size(356, 46);
            this.btnCheckingBalance.TabIndex = 13;
            this.btnCheckingBalance.TabStop = false;
            this.btnCheckingBalance.Text = "View Balance";
            this.btnCheckingBalance.UseVisualStyleBackColor = true;
            this.btnCheckingBalance.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnCheckingWithdraw
            // 
            this.btnCheckingWithdraw.Location = new System.Drawing.Point(552, 95);
            this.btnCheckingWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckingWithdraw.Name = "btnCheckingWithdraw";
            this.btnCheckingWithdraw.Size = new System.Drawing.Size(356, 46);
            this.btnCheckingWithdraw.TabIndex = 12;
            this.btnCheckingWithdraw.TabStop = false;
            this.btnCheckingWithdraw.Text = "Withdraw";
            this.btnCheckingWithdraw.UseVisualStyleBackColor = true;
            this.btnCheckingWithdraw.Click += new System.EventHandler(this.transaction_Click);
            // 
            // btnCheckingDeposit
            // 
            this.btnCheckingDeposit.Location = new System.Drawing.Point(552, 24);
            this.btnCheckingDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckingDeposit.Name = "btnCheckingDeposit";
            this.btnCheckingDeposit.Size = new System.Drawing.Size(356, 46);
            this.btnCheckingDeposit.TabIndex = 11;
            this.btnCheckingDeposit.TabStop = false;
            this.btnCheckingDeposit.Text = "Deposit";
            this.btnCheckingDeposit.UseVisualStyleBackColor = true;
            this.btnCheckingDeposit.Click += new System.EventHandler(this.transaction_Click);
            // 
            // lblCheckingTitle
            // 
            this.lblCheckingTitle.AutoSize = true;
            this.lblCheckingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingTitle.Location = new System.Drawing.Point(652, 238);
            this.lblCheckingTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckingTitle.Name = "lblCheckingTitle";
            this.lblCheckingTitle.Size = new System.Drawing.Size(146, 29);
            this.lblCheckingTitle.TabIndex = 10;
            this.lblCheckingTitle.Text = "CHECKING";
            // 
            // lblVerifyTransactionInput
            // 
            this.lblVerifyTransactionInput.AutoSize = true;
            this.lblVerifyTransactionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyTransactionInput.Location = new System.Drawing.Point(64, 19);
            this.lblVerifyTransactionInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerifyTransactionInput.Name = "lblVerifyTransactionInput";
            this.lblVerifyTransactionInput.Size = new System.Drawing.Size(829, 29);
            this.lblVerifyTransactionInput.TabIndex = 15;
            this.lblVerifyTransactionInput.Text = "You selected the marked transaction and                                    . Is t" +
    "his correct?";
            // 
            // txtTransactionInput
            // 
            this.txtTransactionInput.Location = new System.Drawing.Point(521, 19);
            this.txtTransactionInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransactionInput.Name = "txtTransactionInput";
            this.txtTransactionInput.ReadOnly = true;
            this.txtTransactionInput.Size = new System.Drawing.Size(193, 26);
            this.txtTransactionInput.TabIndex = 16;
            // 
            // btnTransactionGo
            // 
            this.btnTransactionGo.BackColor = System.Drawing.Color.Green;
            this.btnTransactionGo.Enabled = false;
            this.btnTransactionGo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransactionGo.Location = new System.Drawing.Point(372, 785);
            this.btnTransactionGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactionGo.Name = "btnTransactionGo";
            this.btnTransactionGo.Size = new System.Drawing.Size(201, 58);
            this.btnTransactionGo.TabIndex = 17;
            this.btnTransactionGo.Text = "Yes - Process Request";
            this.btnTransactionGo.UseVisualStyleBackColor = false;
            this.btnTransactionGo.Click += new System.EventHandler(this.btnTransactionGo_Click);
            // 
            // btnTransactionNo
            // 
            this.btnTransactionNo.BackColor = System.Drawing.Color.DarkRed;
            this.btnTransactionNo.Enabled = false;
            this.btnTransactionNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransactionNo.Location = new System.Drawing.Point(621, 785);
            this.btnTransactionNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactionNo.Name = "btnTransactionNo";
            this.btnTransactionNo.Size = new System.Drawing.Size(201, 58);
            this.btnTransactionNo.TabIndex = 18;
            this.btnTransactionNo.Text = "No - Select Again";
            this.btnTransactionNo.UseVisualStyleBackColor = false;
            this.btnTransactionNo.Click += new System.EventHandler(this.btnTransactionNo_Click);
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionAmount.Location = new System.Drawing.Point(63, 5);
            this.lblTransactionAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(308, 29);
            this.lblTransactionAmount.TabIndex = 19;
            this.lblTransactionAmount.Text = "Select an amount in dollars:";
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(380, 5);
            this.txtTransactionAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(193, 26);
            this.txtTransactionAmount.TabIndex = 20;
            // 
            // btnTransactionAmountOK
            // 
            this.btnTransactionAmountOK.Location = new System.Drawing.Point(602, 2);
            this.btnTransactionAmountOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactionAmountOK.Name = "btnTransactionAmountOK";
            this.btnTransactionAmountOK.Size = new System.Drawing.Size(112, 35);
            this.btnTransactionAmountOK.TabIndex = 21;
            this.btnTransactionAmountOK.Text = "OK";
            this.btnTransactionAmountOK.UseVisualStyleBackColor = true;
            this.btnTransactionAmountOK.Click += new System.EventHandler(this.btnTransactionAmountOK_Click);
            // 
            // pnlTransactionList
            // 
            this.pnlTransactionList.Controls.Add(this.btnCheckingBalance);
            this.pnlTransactionList.Controls.Add(this.btnSavingsDeposit);
            this.pnlTransactionList.Controls.Add(this.btnSavingsWithdraw);
            this.pnlTransactionList.Controls.Add(this.btnSavingsBalance);
            this.pnlTransactionList.Controls.Add(this.btnSavingsToChecking);
            this.pnlTransactionList.Controls.Add(this.btnCheckingDeposit);
            this.pnlTransactionList.Controls.Add(this.btnCheckingWithdraw);
            this.pnlTransactionList.Controls.Add(this.btnCheckingToSavings);
            this.pnlTransactionList.Location = new System.Drawing.Point(105, 270);
            this.pnlTransactionList.Name = "pnlTransactionList";
            this.pnlTransactionList.Size = new System.Drawing.Size(984, 316);
            this.pnlTransactionList.TabIndex = 22;
            // 
            // pnlValueInput
            // 
            this.pnlValueInput.Controls.Add(this.btnTransactionAmountOK);
            this.pnlValueInput.Controls.Add(this.txtTransactionAmount);
            this.pnlValueInput.Controls.Add(this.lblTransactionAmount);
            this.pnlValueInput.Enabled = false;
            this.pnlValueInput.Location = new System.Drawing.Point(108, 626);
            this.pnlValueInput.Name = "pnlValueInput";
            this.pnlValueInput.Size = new System.Drawing.Size(980, 45);
            this.pnlValueInput.TabIndex = 23;
            // 
            // pnlVerifyAmount
            // 
            this.pnlVerifyAmount.Controls.Add(this.txtTransactionInput);
            this.pnlVerifyAmount.Controls.Add(this.lblVerifyTransactionInput);
            this.pnlVerifyAmount.Location = new System.Drawing.Point(108, 693);
            this.pnlVerifyAmount.Name = "pnlVerifyAmount";
            this.pnlVerifyAmount.Size = new System.Drawing.Size(981, 61);
            this.pnlVerifyAmount.TabIndex = 24;
            this.pnlVerifyAmount.Visible = false;
            // 
            // frmTransactionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 885);
            this.Controls.Add(this.pnlValueInput);
            this.Controls.Add(this.btnTransactionNo);
            this.Controls.Add(this.btnTransactionGo);
            this.Controls.Add(this.lblCheckingTitle);
            this.Controls.Add(this.lblSavingsTitle);
            this.Controls.Add(this.lblTransactionTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTransactionList);
            this.Controls.Add(this.pnlVerifyAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTransactionEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeBank - Select Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTransactionList.ResumeLayout(false);
            this.pnlValueInput.ResumeLayout(false);
            this.pnlValueInput.PerformLayout();
            this.pnlVerifyAmount.ResumeLayout(false);
            this.pnlVerifyAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSavingsTitle;
        private System.Windows.Forms.Label lblTransactionTitle;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnSavingsWithdraw;
        private System.Windows.Forms.Button btnSavingsBalance;
        private System.Windows.Forms.Button btnSavingsToChecking;
        private System.Windows.Forms.Button btnCheckingToSavings;
        private System.Windows.Forms.Button btnCheckingBalance;
        private System.Windows.Forms.Button btnCheckingWithdraw;
        private System.Windows.Forms.Button btnCheckingDeposit;
        private System.Windows.Forms.Label lblCheckingTitle;
        private System.Windows.Forms.Label lblVerifyTransactionInput;
        private System.Windows.Forms.TextBox txtTransactionInput;
        private System.Windows.Forms.Button btnTransactionGo;
        private System.Windows.Forms.Button btnTransactionNo;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Button btnTransactionAmountOK;
        private System.Windows.Forms.Panel pnlTransactionList;
        private System.Windows.Forms.Panel pnlValueInput;
        private System.Windows.Forms.Panel pnlVerifyAmount;
    }
}