namespace ATC
{
    partial class NewAircraft
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
            this.panelSelectAttributes = new System.Windows.Forms.Panel();
            this.panelSelectHoldingStack = new System.Windows.Forms.Panel();
            this.cboSelectHoldingStack = new System.Windows.Forms.ComboBox();
            this.labelSelectHoldingStack = new System.Windows.Forms.Label();
            this.panelSelectRunawayDirection = new System.Windows.Forms.Panel();
            this.cboSelectRunawayDirection = new System.Windows.Forms.ComboBox();
            this.labelSelectRunawayDirection = new System.Windows.Forms.Label();
            this.panelSelectEmerLevel = new System.Windows.Forms.Panel();
            this.cboSelectEmerLevel = new System.Windows.Forms.ComboBox();
            this.labelSelectEmerLevel = new System.Windows.Forms.Label();
            this.panelSelectCraftType = new System.Windows.Forms.Panel();
            this.cboSelectCraftType = new System.Windows.Forms.ComboBox();
            this.labelCraftType = new System.Windows.Forms.Label();
            this.panelSelectActivity = new System.Windows.Forms.Panel();
            this.cboSelectActivity = new System.Windows.Forms.ComboBox();
            this.labelSelectActivity = new System.Windows.Forms.Label();
            this.panelSelectAirport = new System.Windows.Forms.Panel();
            this.cboSelectAirport = new System.Windows.Forms.ComboBox();
            this.labelSelectAirport = new System.Windows.Forms.Label();
            this.btnAddAircraft = new System.Windows.Forms.Button();
            this.btnCancelAircraft = new System.Windows.Forms.Button();
            this.panelSelectAttributes.SuspendLayout();
            this.panelSelectHoldingStack.SuspendLayout();
            this.panelSelectRunawayDirection.SuspendLayout();
            this.panelSelectEmerLevel.SuspendLayout();
            this.panelSelectCraftType.SuspendLayout();
            this.panelSelectActivity.SuspendLayout();
            this.panelSelectAirport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelectAttributes
            // 
            this.panelSelectAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectAttributes.AutoScroll = true;
            this.panelSelectAttributes.Controls.Add(this.panelSelectHoldingStack);
            this.panelSelectAttributes.Controls.Add(this.panelSelectRunawayDirection);
            this.panelSelectAttributes.Controls.Add(this.panelSelectEmerLevel);
            this.panelSelectAttributes.Controls.Add(this.panelSelectCraftType);
            this.panelSelectAttributes.Controls.Add(this.panelSelectActivity);
            this.panelSelectAttributes.Controls.Add(this.panelSelectAirport);
            this.panelSelectAttributes.Location = new System.Drawing.Point(16, 17);
            this.panelSelectAttributes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectAttributes.Name = "panelSelectAttributes";
            this.panelSelectAttributes.Size = new System.Drawing.Size(1066, 649);
            this.panelSelectAttributes.TabIndex = 0;
            // 
            // panelSelectHoldingStack
            // 
            this.panelSelectHoldingStack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(103)))), ((int)(((byte)(50)))));
            this.panelSelectHoldingStack.Controls.Add(this.cboSelectHoldingStack);
            this.panelSelectHoldingStack.Controls.Add(this.labelSelectHoldingStack);
            this.panelSelectHoldingStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectHoldingStack.Enabled = false;
            this.panelSelectHoldingStack.Location = new System.Drawing.Point(0, 310);
            this.panelSelectHoldingStack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectHoldingStack.Name = "panelSelectHoldingStack";
            this.panelSelectHoldingStack.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectHoldingStack.TabIndex = 5;
            // 
            // cboSelectHoldingStack
            // 
            this.cboSelectHoldingStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectHoldingStack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectHoldingStack.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectHoldingStack.FormattingEnabled = true;
            this.cboSelectHoldingStack.Location = new System.Drawing.Point(335, 12);
            this.cboSelectHoldingStack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectHoldingStack.Name = "cboSelectHoldingStack";
            this.cboSelectHoldingStack.Size = new System.Drawing.Size(698, 34);
            this.cboSelectHoldingStack.TabIndex = 1;
            // 
            // labelSelectHoldingStack
            // 
            this.labelSelectHoldingStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectHoldingStack.AutoSize = true;
            this.labelSelectHoldingStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectHoldingStack.ForeColor = System.Drawing.Color.Gold;
            this.labelSelectHoldingStack.Location = new System.Drawing.Point(9, 12);
            this.labelSelectHoldingStack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectHoldingStack.Name = "labelSelectHoldingStack";
            this.labelSelectHoldingStack.Size = new System.Drawing.Size(256, 29);
            this.labelSelectHoldingStack.TabIndex = 0;
            this.labelSelectHoldingStack.Text = "Select Holding Stack";
            // 
            // panelSelectRunawayDirection
            // 
            this.panelSelectRunawayDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(123)))), ((int)(((byte)(180)))));
            this.panelSelectRunawayDirection.Controls.Add(this.cboSelectRunawayDirection);
            this.panelSelectRunawayDirection.Controls.Add(this.labelSelectRunawayDirection);
            this.panelSelectRunawayDirection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectRunawayDirection.Location = new System.Drawing.Point(0, 248);
            this.panelSelectRunawayDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectRunawayDirection.Name = "panelSelectRunawayDirection";
            this.panelSelectRunawayDirection.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectRunawayDirection.TabIndex = 4;
            // 
            // cboSelectRunawayDirection
            // 
            this.cboSelectRunawayDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectRunawayDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectRunawayDirection.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectRunawayDirection.FormattingEnabled = true;
            this.cboSelectRunawayDirection.Location = new System.Drawing.Point(335, 12);
            this.cboSelectRunawayDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectRunawayDirection.Name = "cboSelectRunawayDirection";
            this.cboSelectRunawayDirection.Size = new System.Drawing.Size(698, 34);
            this.cboSelectRunawayDirection.TabIndex = 1;
            // 
            // labelSelectRunawayDirection
            // 
            this.labelSelectRunawayDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectRunawayDirection.AutoSize = true;
            this.labelSelectRunawayDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectRunawayDirection.ForeColor = System.Drawing.Color.Gold;
            this.labelSelectRunawayDirection.Location = new System.Drawing.Point(9, 12);
            this.labelSelectRunawayDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectRunawayDirection.Name = "labelSelectRunawayDirection";
            this.labelSelectRunawayDirection.Size = new System.Drawing.Size(311, 29);
            this.labelSelectRunawayDirection.TabIndex = 0;
            this.labelSelectRunawayDirection.Text = "Select Runaway Direction";
            // 
            // panelSelectEmerLevel
            // 
            this.panelSelectEmerLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.panelSelectEmerLevel.Controls.Add(this.cboSelectEmerLevel);
            this.panelSelectEmerLevel.Controls.Add(this.labelSelectEmerLevel);
            this.panelSelectEmerLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectEmerLevel.Location = new System.Drawing.Point(0, 186);
            this.panelSelectEmerLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectEmerLevel.Name = "panelSelectEmerLevel";
            this.panelSelectEmerLevel.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectEmerLevel.TabIndex = 3;
            // 
            // cboSelectEmerLevel
            // 
            this.cboSelectEmerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectEmerLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectEmerLevel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectEmerLevel.FormattingEnabled = true;
            this.cboSelectEmerLevel.Location = new System.Drawing.Point(335, 12);
            this.cboSelectEmerLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectEmerLevel.Name = "cboSelectEmerLevel";
            this.cboSelectEmerLevel.Size = new System.Drawing.Size(698, 34);
            this.cboSelectEmerLevel.TabIndex = 1;
            // 
            // labelSelectEmerLevel
            // 
            this.labelSelectEmerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectEmerLevel.AutoSize = true;
            this.labelSelectEmerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectEmerLevel.ForeColor = System.Drawing.Color.Gold;
            this.labelSelectEmerLevel.Location = new System.Drawing.Point(9, 12);
            this.labelSelectEmerLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectEmerLevel.Name = "labelSelectEmerLevel";
            this.labelSelectEmerLevel.Size = new System.Drawing.Size(295, 29);
            this.labelSelectEmerLevel.TabIndex = 0;
            this.labelSelectEmerLevel.Text = "Select Emergency Level";
            // 
            // panelSelectCraftType
            // 
            this.panelSelectCraftType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(73)))), ((int)(((byte)(150)))));
            this.panelSelectCraftType.Controls.Add(this.cboSelectCraftType);
            this.panelSelectCraftType.Controls.Add(this.labelCraftType);
            this.panelSelectCraftType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectCraftType.Location = new System.Drawing.Point(0, 124);
            this.panelSelectCraftType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectCraftType.Name = "panelSelectCraftType";
            this.panelSelectCraftType.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectCraftType.TabIndex = 2;
            // 
            // cboSelectCraftType
            // 
            this.cboSelectCraftType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectCraftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCraftType.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectCraftType.FormattingEnabled = true;
            this.cboSelectCraftType.Location = new System.Drawing.Point(335, 12);
            this.cboSelectCraftType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectCraftType.Name = "cboSelectCraftType";
            this.cboSelectCraftType.Size = new System.Drawing.Size(698, 34);
            this.cboSelectCraftType.TabIndex = 1;
            // 
            // labelCraftType
            // 
            this.labelCraftType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCraftType.AutoSize = true;
            this.labelCraftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCraftType.ForeColor = System.Drawing.Color.Gold;
            this.labelCraftType.Location = new System.Drawing.Point(9, 12);
            this.labelCraftType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCraftType.Name = "labelCraftType";
            this.labelCraftType.Size = new System.Drawing.Size(254, 29);
            this.labelCraftType.TabIndex = 0;
            this.labelCraftType.Text = "Select Air Craft Type";
            // 
            // panelSelectActivity
            // 
            this.panelSelectActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.panelSelectActivity.Controls.Add(this.cboSelectActivity);
            this.panelSelectActivity.Controls.Add(this.labelSelectActivity);
            this.panelSelectActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectActivity.Location = new System.Drawing.Point(0, 62);
            this.panelSelectActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectActivity.Name = "panelSelectActivity";
            this.panelSelectActivity.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectActivity.TabIndex = 1;
            // 
            // cboSelectActivity
            // 
            this.cboSelectActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectActivity.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectActivity.FormattingEnabled = true;
            this.cboSelectActivity.Location = new System.Drawing.Point(335, 12);
            this.cboSelectActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectActivity.Name = "cboSelectActivity";
            this.cboSelectActivity.Size = new System.Drawing.Size(698, 34);
            this.cboSelectActivity.TabIndex = 1;
            // 
            // labelSelectActivity
            // 
            this.labelSelectActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectActivity.AutoSize = true;
            this.labelSelectActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectActivity.ForeColor = System.Drawing.Color.Gold;
            this.labelSelectActivity.Location = new System.Drawing.Point(9, 12);
            this.labelSelectActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectActivity.Name = "labelSelectActivity";
            this.labelSelectActivity.Size = new System.Drawing.Size(175, 29);
            this.labelSelectActivity.TabIndex = 0;
            this.labelSelectActivity.Text = "Select Activity";
            // 
            // panelSelectAirport
            // 
            this.panelSelectAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(100)))));
            this.panelSelectAirport.Controls.Add(this.cboSelectAirport);
            this.panelSelectAirport.Controls.Add(this.labelSelectAirport);
            this.panelSelectAirport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelectAirport.Location = new System.Drawing.Point(0, 0);
            this.panelSelectAirport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectAirport.Name = "panelSelectAirport";
            this.panelSelectAirport.Size = new System.Drawing.Size(1066, 62);
            this.panelSelectAirport.TabIndex = 0;
            // 
            // cboSelectAirport
            // 
            this.cboSelectAirport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectAirport.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectAirport.FormattingEnabled = true;
            this.cboSelectAirport.Location = new System.Drawing.Point(335, 12);
            this.cboSelectAirport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSelectAirport.Name = "cboSelectAirport";
            this.cboSelectAirport.Size = new System.Drawing.Size(698, 34);
            this.cboSelectAirport.TabIndex = 1;
            // 
            // labelSelectAirport
            // 
            this.labelSelectAirport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectAirport.AutoSize = true;
            this.labelSelectAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectAirport.ForeColor = System.Drawing.Color.Gold;
            this.labelSelectAirport.Location = new System.Drawing.Point(9, 12);
            this.labelSelectAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectAirport.Name = "labelSelectAirport";
            this.labelSelectAirport.Size = new System.Drawing.Size(172, 29);
            this.labelSelectAirport.TabIndex = 0;
            this.labelSelectAirport.Text = "Select Airport";
            // 
            // btnAddAircraft
            // 
            this.btnAddAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAircraft.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddAircraft.FlatAppearance.BorderSize = 0;
            this.btnAddAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAircraft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAircraft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAircraft.Location = new System.Drawing.Point(860, 676);
            this.btnAddAircraft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAircraft.Name = "btnAddAircraft";
            this.btnAddAircraft.Size = new System.Drawing.Size(222, 45);
            this.btnAddAircraft.TabIndex = 1;
            this.btnAddAircraft.Text = "ADD AIRCRAFT";
            this.btnAddAircraft.UseVisualStyleBackColor = false;
            this.btnAddAircraft.Click += new System.EventHandler(this.btnAddAircraft_Click);
            // 
            // btnCancelAircraft
            // 
            this.btnCancelAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelAircraft.BackColor = System.Drawing.Color.Red;
            this.btnCancelAircraft.FlatAppearance.BorderSize = 0;
            this.btnCancelAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAircraft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAircraft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelAircraft.Location = new System.Drawing.Point(16, 676);
            this.btnCancelAircraft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelAircraft.Name = "btnCancelAircraft";
            this.btnCancelAircraft.Size = new System.Drawing.Size(222, 45);
            this.btnCancelAircraft.TabIndex = 2;
            this.btnCancelAircraft.Text = "CANCEL";
            this.btnCancelAircraft.UseVisualStyleBackColor = false;
            this.btnCancelAircraft.Click += new System.EventHandler(this.btnCancelAircraft_Click);
            // 
            // NewAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1095, 740);
            this.Controls.Add(this.btnCancelAircraft);
            this.Controls.Add(this.btnAddAircraft);
            this.Controls.Add(this.panelSelectAttributes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAircraft";
            this.Text = "NewAircraft";
            this.Load += new System.EventHandler(this.NewAircraft_Load);
            this.panelSelectAttributes.ResumeLayout(false);
            this.panelSelectHoldingStack.ResumeLayout(false);
            this.panelSelectHoldingStack.PerformLayout();
            this.panelSelectRunawayDirection.ResumeLayout(false);
            this.panelSelectRunawayDirection.PerformLayout();
            this.panelSelectEmerLevel.ResumeLayout(false);
            this.panelSelectEmerLevel.PerformLayout();
            this.panelSelectCraftType.ResumeLayout(false);
            this.panelSelectCraftType.PerformLayout();
            this.panelSelectActivity.ResumeLayout(false);
            this.panelSelectActivity.PerformLayout();
            this.panelSelectAirport.ResumeLayout(false);
            this.panelSelectAirport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelectAttributes;
        private System.Windows.Forms.Panel panelSelectAirport;
        private System.Windows.Forms.ComboBox cboSelectAirport;
        private System.Windows.Forms.Label labelSelectAirport;
        private System.Windows.Forms.Panel panelSelectEmerLevel;
        private System.Windows.Forms.ComboBox cboSelectEmerLevel;
        private System.Windows.Forms.Label labelSelectEmerLevel;
        private System.Windows.Forms.Panel panelSelectCraftType;
        private System.Windows.Forms.ComboBox cboSelectCraftType;
        private System.Windows.Forms.Label labelCraftType;
        private System.Windows.Forms.Panel panelSelectActivity;
        private System.Windows.Forms.ComboBox cboSelectActivity;
        private System.Windows.Forms.Label labelSelectActivity;
        private System.Windows.Forms.Button btnAddAircraft;
        private System.Windows.Forms.Button btnCancelAircraft;
        private System.Windows.Forms.Panel panelSelectRunawayDirection;
        private System.Windows.Forms.ComboBox cboSelectRunawayDirection;
        private System.Windows.Forms.Label labelSelectRunawayDirection;
        private System.Windows.Forms.Panel panelSelectHoldingStack;
        private System.Windows.Forms.ComboBox cboSelectHoldingStack;
        private System.Windows.Forms.Label labelSelectHoldingStack;
    }
}