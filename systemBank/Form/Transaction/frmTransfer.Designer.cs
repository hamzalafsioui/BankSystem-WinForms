namespace systemBank
{
    partial class frmTransfer
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
            this.btnSearchF = new System.Windows.Forms.Button();
            this.txtAccountNumberF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountBalanceF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchT = new System.Windows.Forms.Button();
            this.txtAccountNumberT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountBalanceT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTransfer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchF
            // 
            this.btnSearchF.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchF.Location = new System.Drawing.Point(468, 6);
            this.btnSearchF.Name = "btnSearchF";
            this.btnSearchF.Size = new System.Drawing.Size(91, 43);
            this.btnSearchF.TabIndex = 31;
            this.btnSearchF.Text = "Search";
            this.btnSearchF.UseVisualStyleBackColor = true;
            this.btnSearchF.Click += new System.EventHandler(this.btnSearchF_Click);
            // 
            // txtAccountNumberF
            // 
            this.txtAccountNumberF.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberF.Location = new System.Drawing.Point(259, 6);
            this.txtAccountNumberF.Name = "txtAccountNumberF";
            this.txtAccountNumberF.Size = new System.Drawing.Size(167, 38);
            this.txtAccountNumberF.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Transfer From";
            // 
            // txtAccountBalanceF
            // 
            this.txtAccountBalanceF.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalanceF.Location = new System.Drawing.Point(259, 50);
            this.txtAccountBalanceF.Name = "txtAccountBalanceF";
            this.txtAccountBalanceF.ReadOnly = true;
            this.txtAccountBalanceF.Size = new System.Drawing.Size(167, 38);
            this.txtAccountBalanceF.TabIndex = 27;
            this.txtAccountBalanceF.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Account Balance";
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(259, 215);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(162, 33);
            this.nudAmount.TabIndex = 34;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(458, 206);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(101, 43);
            this.btnTransfer.TabIndex = 35;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Amount";
            // 
            // btnSearchT
            // 
            this.btnSearchT.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchT.Location = new System.Drawing.Point(468, 119);
            this.btnSearchT.Name = "btnSearchT";
            this.btnSearchT.Size = new System.Drawing.Size(91, 43);
            this.btnSearchT.TabIndex = 38;
            this.btnSearchT.Text = "Search";
            this.btnSearchT.UseVisualStyleBackColor = true;
            this.btnSearchT.Click += new System.EventHandler(this.btnSearchT_Click);
            // 
            // txtAccountNumberT
            // 
            this.txtAccountNumberT.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberT.Location = new System.Drawing.Point(259, 119);
            this.txtAccountNumberT.Name = "txtAccountNumberT";
            this.txtAccountNumberT.Size = new System.Drawing.Size(167, 38);
            this.txtAccountNumberT.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Transfer To";
            // 
            // txtAccountBalanceT
            // 
            this.txtAccountBalanceT.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalanceT.Location = new System.Drawing.Point(259, 163);
            this.txtAccountBalanceT.Name = "txtAccountBalanceT";
            this.txtAccountBalanceT.ReadOnly = true;
            this.txtAccountBalanceT.Size = new System.Drawing.Size(167, 38);
            this.txtAccountBalanceT.TabIndex = 40;
            this.txtAccountBalanceT.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Account Balance";
            // 
            // dgvTransfer
            // 
            this.dgvTransfer.AllowUserToAddRows = false;
            this.dgvTransfer.AllowUserToDeleteRows = false;
            this.dgvTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransfer.Location = new System.Drawing.Point(0, 265);
            this.dgvTransfer.Name = "dgvTransfer";
            this.dgvTransfer.ReadOnly = true;
            this.dgvTransfer.Size = new System.Drawing.Size(684, 170);
            this.dgvTransfer.TabIndex = 41;
            this.dgvTransfer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransfer_CellContentClick);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 435);
            this.Controls.Add(this.dgvTransfer);
            this.Controls.Add(this.txtAccountBalanceT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchT);
            this.Controls.Add(this.txtAccountNumberT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccountBalanceF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchF);
            this.Controls.Add(this.txtAccountNumberF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchF;
        private System.Windows.Forms.TextBox txtAccountNumberF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountBalanceF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchT;
        private System.Windows.Forms.TextBox txtAccountNumberT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountBalanceT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTransfer;
    }
}