namespace systemBank
{
    partial class frmAllClients
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
			this.dgvAllClients = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAllClients
			// 
			this.dgvAllClients.AllowUserToAddRows = false;
			this.dgvAllClients.AllowUserToDeleteRows = false;
			this.dgvAllClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAllClients.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvAllClients.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAllClients.Location = new System.Drawing.Point(0, 0);
			this.dgvAllClients.Name = "dgvAllClients";
			this.dgvAllClients.ReadOnly = true;
			this.dgvAllClients.Size = new System.Drawing.Size(684, 435);
			this.dgvAllClients.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(97, 48);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// frmAllClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 435);
			this.Controls.Add(this.dgvAllClients);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAllClients";
			this.Text = "frmAllClients";
			((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}