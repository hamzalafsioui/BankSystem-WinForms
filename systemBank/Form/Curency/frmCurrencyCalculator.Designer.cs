namespace systemBank
{
    partial class frmCurrencyCalculator
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
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlExchange = new System.Windows.Forms.Panel();
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.btnSearchF = new System.Windows.Forms.Button();
            this.txtCurrencyFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.btnSearchT = new System.Windows.Forms.Button();
            this.txtCurrencyTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrencyFrom = new System.Windows.Forms.Label();
            this.lblAmountFrom = new System.Windows.Forms.Label();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmountTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.pnlExchange.SuspendLayout();
            this.pnlFrom.SuspendLayout();
            this.pnlTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(209, 32);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(162, 33);
            this.nudAmount.TabIndex = 31;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExchange
            // 
            this.btnExchange.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.Location = new System.Drawing.Point(418, 32);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(91, 43);
            this.btnExchange.TabIndex = 32;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Exchange Amount";
            // 
            // pnlExchange
            // 
            this.pnlExchange.Controls.Add(this.btnExchange);
            this.pnlExchange.Controls.Add(this.nudAmount);
            this.pnlExchange.Controls.Add(this.label7);
            this.pnlExchange.Enabled = false;
            this.pnlExchange.Location = new System.Drawing.Point(46, 262);
            this.pnlExchange.Name = "pnlExchange";
            this.pnlExchange.Size = new System.Drawing.Size(539, 110);
            this.pnlExchange.TabIndex = 33;
            // 
            // pnlFrom
            // 
            this.pnlFrom.Controls.Add(this.btnSearchF);
            this.pnlFrom.Controls.Add(this.txtCurrencyFrom);
            this.pnlFrom.Controls.Add(this.label1);
            this.pnlFrom.Location = new System.Drawing.Point(132, 28);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(453, 100);
            this.pnlFrom.TabIndex = 35;
            // 
            // btnSearchF
            // 
            this.btnSearchF.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchF.Location = new System.Drawing.Point(313, 29);
            this.btnSearchF.Name = "btnSearchF";
            this.btnSearchF.Size = new System.Drawing.Size(91, 43);
            this.btnSearchF.TabIndex = 29;
            this.btnSearchF.Text = "Search";
            this.btnSearchF.UseVisualStyleBackColor = true;
            this.btnSearchF.Click += new System.EventHandler(this.btnSearchF_Click);
            // 
            // txtCurrencyFrom
            // 
            this.txtCurrencyFrom.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyFrom.Location = new System.Drawing.Point(104, 29);
            this.txtCurrencyFrom.Name = "txtCurrencyFrom";
            this.txtCurrencyFrom.Size = new System.Drawing.Size(167, 38);
            this.txtCurrencyFrom.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "From";
            // 
            // pnlTo
            // 
            this.pnlTo.Controls.Add(this.btnSearchT);
            this.pnlTo.Controls.Add(this.txtCurrencyTo);
            this.pnlTo.Controls.Add(this.label2);
            this.pnlTo.Location = new System.Drawing.Point(132, 134);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(453, 100);
            this.pnlTo.TabIndex = 30;
            // 
            // btnSearchT
            // 
            this.btnSearchT.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchT.Location = new System.Drawing.Point(313, 29);
            this.btnSearchT.Name = "btnSearchT";
            this.btnSearchT.Size = new System.Drawing.Size(91, 43);
            this.btnSearchT.TabIndex = 32;
            this.btnSearchT.Text = "Search";
            this.btnSearchT.UseVisualStyleBackColor = true;
            this.btnSearchT.Click += new System.EventHandler(this.btnSearchT_Click);
            // 
            // txtCurrencyTo
            // 
            this.txtCurrencyTo.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyTo.Location = new System.Drawing.Point(104, 29);
            this.txtCurrencyTo.Name = "txtCurrencyTo";
            this.txtCurrencyTo.Size = new System.Drawing.Size(167, 38);
            this.txtCurrencyTo.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "To";
            // 
            // lblCurrencyFrom
            // 
            this.lblCurrencyFrom.AutoSize = true;
            this.lblCurrencyFrom.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyFrom.Location = new System.Drawing.Point(218, 395);
            this.lblCurrencyFrom.Name = "lblCurrencyFrom";
            this.lblCurrencyFrom.Size = new System.Drawing.Size(48, 21);
            this.lblCurrencyFrom.TabIndex = 36;
            this.lblCurrencyFrom.Text = "From";
            // 
            // lblAmountFrom
            // 
            this.lblAmountFrom.AutoSize = true;
            this.lblAmountFrom.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountFrom.Location = new System.Drawing.Point(143, 395);
            this.lblAmountFrom.Name = "lblAmountFrom";
            this.lblAmountFrom.Size = new System.Drawing.Size(69, 21);
            this.lblAmountFrom.TabIndex = 33;
            this.lblAmountFrom.Text = "Amount";
            // 
            // lblCurrencyTo
            // 
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyTo.Location = new System.Drawing.Point(408, 395);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(28, 21);
            this.lblCurrencyTo.TabIndex = 37;
            this.lblCurrencyTo.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "==";
            // 
            // lblAmountTo
            // 
            this.lblAmountTo.AutoSize = true;
            this.lblAmountTo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountTo.Location = new System.Drawing.Point(333, 395);
            this.lblAmountTo.Name = "lblAmountTo";
            this.lblAmountTo.Size = new System.Drawing.Size(69, 21);
            this.lblAmountTo.TabIndex = 39;
            this.lblAmountTo.Text = "Amount";
            // 
            // frmCurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.lblAmountTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCurrencyTo);
            this.Controls.Add(this.lblAmountFrom);
            this.Controls.Add(this.lblCurrencyFrom);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.pnlFrom);
            this.Controls.Add(this.pnlExchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrencyCalculator";
            this.Text = "frmCurrencyCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.pnlExchange.ResumeLayout(false);
            this.pnlExchange.PerformLayout();
            this.pnlFrom.ResumeLayout(false);
            this.pnlFrom.PerformLayout();
            this.pnlTo.ResumeLayout(false);
            this.pnlTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlExchange;
        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.Button btnSearchF;
        private System.Windows.Forms.TextBox txtCurrencyFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.Button btnSearchT;
        private System.Windows.Forms.TextBox txtCurrencyTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrencyFrom;
        private System.Windows.Forms.Label lblAmountFrom;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmountTo;
    }
}