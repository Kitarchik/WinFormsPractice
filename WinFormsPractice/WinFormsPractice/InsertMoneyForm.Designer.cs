namespace WinFormsPractice
{
    partial class InsertMoneyForm
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
            this.lblInsertMoney = new System.Windows.Forms.Label();
            this.txtInsertMoney = new System.Windows.Forms.TextBox();
            this.errorInsertMoney = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsertMoney
            // 
            this.lblInsertMoney.AutoSize = true;
            this.lblInsertMoney.Location = new System.Drawing.Point(42, 26);
            this.lblInsertMoney.Name = "lblInsertMoney";
            this.lblInsertMoney.Size = new System.Drawing.Size(211, 13);
            this.lblInsertMoney.TabIndex = 0;
            this.lblInsertMoney.Text = "Внесите наличные (не больше 400 000): ";
            // 
            // txtInsertMoney
            // 
            this.txtInsertMoney.Location = new System.Drawing.Point(259, 23);
            this.txtInsertMoney.Name = "txtInsertMoney";
            this.txtInsertMoney.Size = new System.Drawing.Size(147, 20);
            this.txtInsertMoney.TabIndex = 1;
            this.txtInsertMoney.Validating += new System.ComponentModel.CancelEventHandler(this.txtInsertMoney_Validating);
            this.txtInsertMoney.Validated += new System.EventHandler(this.txtInsertMoney_Validated);
            // 
            // errorInsertMoney
            // 
            this.errorInsertMoney.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorInsertMoney.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(331, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.CausesValidation = false;
            this.btnOk.Location = new System.Drawing.Point(236, 62);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // InsertMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 102);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtInsertMoney);
            this.Controls.Add(this.lblInsertMoney);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertMoneyForm";
            this.Text = "InsertMoneyForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorInsertMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsertMoney;
        private System.Windows.Forms.TextBox txtInsertMoney;
        private System.Windows.Forms.ErrorProvider errorInsertMoney;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}