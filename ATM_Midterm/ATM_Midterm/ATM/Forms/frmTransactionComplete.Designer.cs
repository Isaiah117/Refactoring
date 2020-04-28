namespace ATM.Forms
{
    partial class frmTransactionComplete
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
            this.lblTransactionComplete = new System.Windows.Forms.Label();
            this.lblNewTransaction = new System.Windows.Forms.Label();
            this.btnNoNewTransaction = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.txtSavingsBalance = new System.Windows.Forms.TextBox();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.txtCheckingBalance = new System.Windows.Forms.TextBox();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.pnlBalancesView = new System.Windows.Forms.Panel();
            this.lblViewBalances = new System.Windows.Forms.Label();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBalancesView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTransactionComplete
            // 
            this.lblTransactionComplete.AutoSize = true;
            this.lblTransactionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionComplete.Location = new System.Drawing.Point(402, 186);
            this.lblTransactionComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionComplete.Name = "lblTransactionComplete";
            this.lblTransactionComplete.Size = new System.Drawing.Size(397, 32);
            this.lblTransactionComplete.TabIndex = 4;
            this.lblTransactionComplete.Text = "TRANSACTION COMPLETE";
            // 
            // lblNewTransaction
            // 
            this.lblNewTransaction.AutoSize = true;
            this.lblNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTransaction.Location = new System.Drawing.Point(87, 495);
            this.lblNewTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewTransaction.Name = "lblNewTransaction";
            this.lblNewTransaction.Size = new System.Drawing.Size(507, 29);
            this.lblNewTransaction.TabIndex = 5;
            this.lblNewTransaction.Text = "Would you like to perform another transaction?";
            // 
            // btnNoNewTransaction
            // 
            this.btnNoNewTransaction.BackColor = System.Drawing.Color.DarkRed;
            this.btnNoNewTransaction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNoNewTransaction.Location = new System.Drawing.Point(886, 483);
            this.btnNoNewTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNoNewTransaction.Name = "btnNoNewTransaction";
            this.btnNoNewTransaction.Size = new System.Drawing.Size(201, 58);
            this.btnNoNewTransaction.TabIndex = 20;
            this.btnNoNewTransaction.Text = "No";
            this.btnNoNewTransaction.UseVisualStyleBackColor = false;
            this.btnNoNewTransaction.Click += new System.EventHandler(this.btnNoNewTransaction_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.Green;
            this.btnNewTransaction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewTransaction.Location = new System.Drawing.Point(638, 483);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(201, 58);
            this.btnNewTransaction.TabIndex = 19;
            this.btnNewTransaction.Text = "Yes";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // txtSavingsBalance
            // 
            this.txtSavingsBalance.Location = new System.Drawing.Point(320, 26);
            this.txtSavingsBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSavingsBalance.Name = "txtSavingsBalance";
            this.txtSavingsBalance.ReadOnly = true;
            this.txtSavingsBalance.Size = new System.Drawing.Size(148, 26);
            this.txtSavingsBalance.TabIndex = 22;
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsBalance.Location = new System.Drawing.Point(189, 26);
            this.lblSavingsBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(98, 29);
            this.lblSavingsBalance.TabIndex = 21;
            this.lblSavingsBalance.Text = "Savings";
            // 
            // txtCheckingBalance
            // 
            this.txtCheckingBalance.Location = new System.Drawing.Point(672, 26);
            this.txtCheckingBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckingBalance.Name = "txtCheckingBalance";
            this.txtCheckingBalance.ReadOnly = true;
            this.txtCheckingBalance.Size = new System.Drawing.Size(148, 26);
            this.txtCheckingBalance.TabIndex = 24;
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingBalance.Location = new System.Drawing.Point(542, 26);
            this.lblCheckingBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(114, 29);
            this.lblCheckingBalance.TabIndex = 23;
            this.lblCheckingBalance.Text = "Checking";
            // 
            // pnlBalancesView
            // 
            this.pnlBalancesView.Controls.Add(this.txtCheckingBalance);
            this.pnlBalancesView.Controls.Add(this.lblCheckingBalance);
            this.pnlBalancesView.Controls.Add(this.lblSavingsBalance);
            this.pnlBalancesView.Controls.Add(this.txtSavingsBalance);
            this.pnlBalancesView.Location = new System.Drawing.Point(93, 360);
            this.pnlBalancesView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBalancesView.Name = "pnlBalancesView";
            this.pnlBalancesView.Size = new System.Drawing.Size(994, 85);
            this.pnlBalancesView.TabIndex = 25;
            this.pnlBalancesView.Visible = false;
            // 
            // lblViewBalances
            // 
            this.lblViewBalances.AutoSize = true;
            this.lblViewBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBalances.Location = new System.Drawing.Point(90, 288);
            this.lblViewBalances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewBalances.Name = "lblViewBalances";
            this.lblViewBalances.Size = new System.Drawing.Size(507, 29);
            this.lblViewBalances.TabIndex = 26;
            this.lblViewBalances.Text = "Would you like to view your account balances?";
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.BackColor = System.Drawing.Color.Green;
            this.btnShowBalance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowBalance.Location = new System.Drawing.Point(640, 275);
            this.btnShowBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(201, 58);
            this.btnShowBalance.TabIndex = 27;
            this.btnShowBalance.Text = "Yes";
            this.btnShowBalance.UseVisualStyleBackColor = false;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(447, 223);
            this.lblThanks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(294, 25);
            this.lblThanks.TabIndex = 28;
            this.lblThanks.Text = "Thanks for choosing MazeBank!";
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 663);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.lblViewBalances);
            this.Controls.Add(this.btnNoNewTransaction);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.lblNewTransaction);
            this.Controls.Add(this.lblTransactionComplete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBalancesView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTransactionComplete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeBank - Transaction Complete";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBalancesView.ResumeLayout(false);
            this.pnlBalancesView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransactionComplete;
        private System.Windows.Forms.Label lblNewTransaction;
        private System.Windows.Forms.Button btnNoNewTransaction;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.TextBox txtSavingsBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.TextBox txtCheckingBalance;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Panel pnlBalancesView;
        private System.Windows.Forms.Label lblViewBalances;
        private System.Windows.Forms.Button btnShowBalance;
        private System.Windows.Forms.Label lblThanks;
    }
}