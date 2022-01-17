namespace ATC
{
    partial class UserEntry
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
            this.panelEntryHeader = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelRole_Passcode = new System.Windows.Forms.Panel();
            this.txtRolePasscode = new System.Windows.Forms.TextBox();
            this.labelRolePasscode = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.labelChooseAction = new System.Windows.Forms.Label();
            this.labelATC = new System.Windows.Forms.Label();
            this.labelSimulator = new System.Windows.Forms.Label();
            this.userControlEnter1 = new ATC.UserControlEnter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEntryHeader.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.panelRole_Passcode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntryHeader
            // 
            this.panelEntryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEntryHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelEntryHeader.Controls.Add(this.btnSignIn);
            this.panelEntryHeader.Controls.Add(this.btnSignUp);
            this.panelEntryHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelEntryHeader.Location = new System.Drawing.Point(0, 30);
            this.panelEntryHeader.Name = "panelEntryHeader";
            this.panelEntryHeader.Size = new System.Drawing.Size(892, 40);
            this.panelEntryHeader.TabIndex = 0;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(453, 0);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(436, 40);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(1, 0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(439, 40);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelChild.Controls.Add(this.btnExit);
            this.panelChild.Controls.Add(this.userControlEnter1);
            this.panelChild.Controls.Add(this.panelRole_Passcode);
            this.panelChild.Controls.Add(this.btnEnter);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChild.Location = new System.Drawing.Point(0, 96);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(892, 415);
            this.panelChild.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(498, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 44);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelRole_Passcode
            // 
            this.panelRole_Passcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRole_Passcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelRole_Passcode.Controls.Add(this.txtRolePasscode);
            this.panelRole_Passcode.Controls.Add(this.labelRolePasscode);
            this.panelRole_Passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRole_Passcode.Location = new System.Drawing.Point(74, 246);
            this.panelRole_Passcode.Name = "panelRole_Passcode";
            this.panelRole_Passcode.Size = new System.Drawing.Size(745, 50);
            this.panelRole_Passcode.TabIndex = 17;
            this.panelRole_Passcode.Visible = false;
            // 
            // txtRolePasscode
            // 
            this.txtRolePasscode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRolePasscode.Location = new System.Drawing.Point(239, 13);
            this.txtRolePasscode.Name = "txtRolePasscode";
            this.txtRolePasscode.Size = new System.Drawing.Size(487, 24);
            this.txtRolePasscode.TabIndex = 17;
            this.txtRolePasscode.UseSystemPasswordChar = true;
            // 
            // labelRolePasscode
            // 
            this.labelRolePasscode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRolePasscode.AutoSize = true;
            this.labelRolePasscode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRolePasscode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelRolePasscode.Location = new System.Drawing.Point(21, 21);
            this.labelRolePasscode.Name = "labelRolePasscode";
            this.labelRolePasscode.Size = new System.Drawing.Size(94, 14);
            this.labelRolePasscode.TabIndex = 16;
            this.labelRolePasscode.Text = "Role Passcode";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEnter.FlatAppearance.BorderSize = 2;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Lime;
            this.btnEnter.Location = new System.Drawing.Point(113, 338);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(262, 44);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // labelChooseAction
            // 
            this.labelChooseAction.AutoSize = true;
            this.labelChooseAction.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseAction.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseAction.ForeColor = System.Drawing.Color.Gold;
            this.labelChooseAction.Location = new System.Drawing.Point(331, 70);
            this.labelChooseAction.Name = "labelChooseAction";
            this.labelChooseAction.Size = new System.Drawing.Size(221, 23);
            this.labelChooseAction.TabIndex = 18;
            this.labelChooseAction.Text = "<-    Choose Action   ->";
            // 
            // labelATC
            // 
            this.labelATC.AutoSize = true;
            this.labelATC.BackColor = System.Drawing.Color.Transparent;
            this.labelATC.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelATC.ForeColor = System.Drawing.Color.Lime;
            this.labelATC.Location = new System.Drawing.Point(359, 3);
            this.labelATC.Name = "labelATC";
            this.labelATC.Size = new System.Drawing.Size(57, 24);
            this.labelATC.TabIndex = 21;
            this.labelATC.Text = "ATC";
            // 
            // labelSimulator
            // 
            this.labelSimulator.AutoSize = true;
            this.labelSimulator.BackColor = System.Drawing.Color.Transparent;
            this.labelSimulator.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimulator.ForeColor = System.Drawing.Color.Lime;
            this.labelSimulator.Location = new System.Drawing.Point(422, 3);
            this.labelSimulator.Name = "labelSimulator";
            this.labelSimulator.Size = new System.Drawing.Size(117, 27);
            this.labelSimulator.TabIndex = 22;
            this.labelSimulator.Text = "Simulator";
            // 
            // userControlEnter1
            // 
            this.userControlEnter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlEnter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.userControlEnter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlEnter1.Location = new System.Drawing.Point(74, 27);
            this.userControlEnter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlEnter1.Name = "userControlEnter1";
            this.userControlEnter1.Size = new System.Drawing.Size(727, 220);
            this.userControlEnter1.TabIndex = 18;
            this.userControlEnter1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSimulator);
            this.panel1.Controls.Add(this.labelATC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 30);
            this.panel1.TabIndex = 19;
            // 
            // UserEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelChooseAction);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelEntryHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserEntry";
            this.Text = "UserEntry";
            this.panelEntryHeader.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.panelRole_Passcode.ResumeLayout(false);
            this.panelRole_Passcode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntryHeader;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel panelRole_Passcode;
        private System.Windows.Forms.TextBox txtRolePasscode;
        private System.Windows.Forms.Label labelRolePasscode;
        private System.Windows.Forms.Label labelChooseAction;
        private UserControlEnter userControlEnter1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelATC;
        private System.Windows.Forms.Label labelSimulator;
        private System.Windows.Forms.Panel panel1;
    }
}