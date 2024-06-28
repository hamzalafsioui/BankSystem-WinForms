namespace systemBank
{
    partial class frmShowAllCurrencies
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
			this.dgvCurrencies = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtCurrencyCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCurrencies
			// 
			this.dgvCurrencies.AllowUserToAddRows = false;
			this.dgvCurrencies.AllowUserToDeleteRows = false;
			this.dgvCurrencies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCurrencies.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvCurrencies.Location = new System.Drawing.Point(0, 125);
			this.dgvCurrencies.Name = "dgvCurrencies";
			this.dgvCurrencies.ReadOnly = true;
			this.dgvCurrencies.Size = new System.Drawing.Size(684, 310);
			this.dgvCurrencies.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(476, 35);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(91, 43);
			this.btnSearch.TabIndex = 26;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtCurrencyCode
			// 
			this.txtCurrencyCode.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrencyCode.Location = new System.Drawing.Point(267, 35);
			this.txtCurrencyCode.Name = "txtCurrencyCode";
			this.txtCurrencyCode.Size = new System.Drawing.Size(167, 38);
			this.txtCurrencyCode.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(115, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 21);
			this.label1.TabIndex = 24;
			this.label1.Text = "Currency Code";
			// 
			// frmShowAllCurrencies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 435);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtCurrencyCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCurrencies);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmShowAllCurrencies";
			this.Text = "frmShowAllCurrencies";
			this.Load += new System.EventHandler(this.frmShowAllCurrencies_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.Label label1;
    }
}