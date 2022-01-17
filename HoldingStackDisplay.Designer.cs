namespace ATC
{
    partial class HoldingStackDisplay
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
            this.dgvHoldStack = new System.Windows.Forms.DataGridView();
            this.panelHSHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldStack)).BeginInit();
            this.panelHSHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoldStack
            // 
            this.dgvHoldStack.AllowUserToAddRows = false;
            this.dgvHoldStack.AllowUserToDeleteRows = false;
            this.dgvHoldStack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoldStack.BackgroundColor = System.Drawing.Color.Black;
            this.dgvHoldStack.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvHoldStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoldStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvHoldStack.GridColor = System.Drawing.Color.White;
            this.dgvHoldStack.Location = new System.Drawing.Point(12, 53);
            this.dgvHoldStack.Name = "dgvHoldStack";
            this.dgvHoldStack.Size = new System.Drawing.Size(868, 315);
            this.dgvHoldStack.TabIndex = 0;
            // 
            // panelHSHeader
            // 
            this.panelHSHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHSHeader.Controls.Add(this.btnClose);
            this.panelHSHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHSHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelHSHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHSHeader.Name = "panelHSHeader";
            this.panelHSHeader.Size = new System.Drawing.Size(892, 30);
            this.panelHSHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(852, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(721, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoldingStackDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(892, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelHSHeader);
            this.Controls.Add(this.dgvHoldStack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoldingStackDisplay";
            this.Text = "HoldingStackDisplay";
            this.Load += new System.EventHandler(this.HoldingStackDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoldStack)).EndInit();
            this.panelHSHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoldStack;
        private System.Windows.Forms.Panel panelHSHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}