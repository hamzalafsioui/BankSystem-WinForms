namespace systemBank
{
    partial class frmDeposit
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
			this.txtAccountNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nudAmount = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAccountBalance = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDeposit = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAccountNumber
			// 
			this.txtAccountNumber.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountNumber.Location = new System.Drawing.Point(287, 34);
			this.txtAccountNumber.Name = "txtAccountNumber";
			this.txtAccountNumber.Size = new System.Drawing.Size(167, 38);
			this.txtAccountNumber.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(135, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Account Number";
			// 
			// nudAmount
			// 
			this.nudAmount.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudAmount.Location = new System.Drawing.Point(245, 86);
			this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nudAmount.Name = "nudAmount";
			this.nudAmount.Size = new System.Drawing.Size(162, 33);
			this.nudAmount.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(99, 86);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 21);
			this.label7.TabIndex = 21;
			this.label7.Text = "Amount";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(496, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(91, 43);
			this.btnSearch.TabIndex = 23;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDeposit
			// 
			this.btnDeposit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeposit.Location = new System.Drawing.Point(454, 86);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(91, 43);
			this.btnDeposit.TabIndex = 24;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = true;
			this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtAccountBalance);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nudAmount);
			this.panel1.Controls.Add(this.btnDeposit);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(42, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(581, 139);
			this.panel1.TabIndex = 25;
			this.panel1.Visible = false;
			// 
			// txtAccountBalance
			// 
			this.txtAccountBalance.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountBalance.Location = new System.Drawing.Point(245, 21);
			this.txtAccountBalance.Name = "txtAccountBalance";
			this.txtAccountBalance.ReadOnly = true;
			this.txtAccountBalance.Size = new System.Drawing.Size(167, 38);
			this.txtAccountBalance.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(93, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 21);
			this.label2.TabIndex = 26;
			this.label2.Text = "Account Balance";
			// 
			// dgvDeposit
			// 
			this.dgvDeposit.AllowUserToAddRows = false;
			this.dgvDeposit.AllowUserToDeleteRows = false;
			this.dgvDeposit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDeposit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvDeposit.Location = new System.Drawing.Point(0, 265);
			this.dgvDeposit.Name = "dgvDeposit";
			this.dgvDeposit.ReadOnly = true;
			this.dgvDeposit.Size = new System.Drawing.Size(684, 170);
			this.dgvDeposit.TabIndex = 43;
			// 
			// frmDeposit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 435);
			this.Controls.Add(this.dgvDeposit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtAccountNumber);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDeposit";
			this.Text = "frmDeposit";
			this.Load += new System.EventHandler(this.frmDeposit_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDeposit;
    }
}