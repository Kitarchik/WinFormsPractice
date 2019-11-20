namespace WinFormsPractice
{
    partial class MainForm
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
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInsertMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(12, 186);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(149, 60);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "Просмотреть баланс";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInsertMoney
            // 
            this.btnInsertMoney.Location = new System.Drawing.Point(639, 186);
            this.btnInsertMoney.Name = "btnInsertMoney";
            this.btnInsertMoney.Size = new System.Drawing.Size(149, 60);
            this.btnInsertMoney.TabIndex = 2;
            this.btnInsertMoney.Text = "Внести деньги";
            this.btnInsertMoney.UseVisualStyleBackColor = true;
            this.btnInsertMoney.Click += new System.EventHandler(this.btnInsertMoney_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertMoney);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBalance);
            this.Name = "MainForm";
            this.Text = "Банкомат";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInsertMoney;
    }
}

