namespace ATM.Forms
{
    partial class frmUserAccountEntry
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
            this.lblAccNum = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.btnAccStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccNum
            // 
            this.lblAccNum.AutoSize = true;
            this.lblAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNum.Location = new System.Drawing.Point(81, 245);
            this.lblAccNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNum.Name = "lblAccNum";
            this.lblAccNum.Size = new System.Drawing.Size(792, 32);
            this.lblAccNum.TabIndex = 1;
            this.lblAccNum.Text = "To begin, enter your five digit account number and press start.";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(304, 349);
            this.txtAccNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(164, 26);
            this.txtAccNum.TabIndex = 2;
            // 
            // btnAccStart
            // 
            this.btnAccStart.BackColor = System.Drawing.Color.Green;
            this.btnAccStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccStart.Location = new System.Drawing.Point(507, 342);
            this.btnAccStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccStart.Name = "btnAccStart";
            this.btnAccStart.Size = new System.Drawing.Size(132, 43);
            this.btnAccStart.TabIndex = 3;
            this.btnAccStart.Text = "Start";
            this.btnAccStart.UseVisualStyleBackColor = false;
            this.btnAccStart.Click += new System.EventHandler(this.btnAccStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserAccountEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 515);
            this.Controls.Add(this.btnAccStart);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.lblAccNum);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUserAccountEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeBank - Enter Account Number";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccNum;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Button btnAccStart;
    }
}