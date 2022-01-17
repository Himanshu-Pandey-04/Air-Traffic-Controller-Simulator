namespace ATC
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
            this.components = new System.ComponentModel.Container();
            this.panelWholeSideMenu = new System.Windows.Forms.Panel();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnAnalyticalHistory = new FontAwesome.Sharp.IconButton();
            this.btnViewHoldingStack = new FontAwesome.Sharp.IconButton();
            this.panelNewSubMenu = new System.Windows.Forms.Panel();
            this.btnNewAirport = new FontAwesome.Sharp.IconButton();
            this.btnNewRunaway = new FontAwesome.Sharp.IconButton();
            this.btnNewAircraft = new FontAwesome.Sharp.IconButton();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTimeSec = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnSimulate_Stop = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.SimulateTimer = new System.Windows.Forms.Timer(this.components);
            this.panelWholeSideMenu.SuspendLayout();
            this.PanelSideMenu.SuspendLayout();
            this.panelNewSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWholeSideMenu
            // 
            this.panelWholeSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.panelWholeSideMenu.Controls.Add(this.PanelSideMenu);
            this.panelWholeSideMenu.Controls.Add(this.panelLogo);
            this.panelWholeSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWholeSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelWholeSideMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelWholeSideMenu.Name = "panelWholeSideMenu";
            this.panelWholeSideMenu.Size = new System.Drawing.Size(403, 894);
            this.panelWholeSideMenu.TabIndex = 6;
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.PanelSideMenu.Controls.Add(this.btnHelp);
            this.PanelSideMenu.Controls.Add(this.btnAnalyticalHistory);
            this.PanelSideMenu.Controls.Add(this.btnViewHoldingStack);
            this.PanelSideMenu.Controls.Add(this.panelNewSubMenu);
            this.PanelSideMenu.Controls.Add(this.btnAddNew);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 86);
            this.PanelSideMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(403, 506);
            this.PanelSideMenu.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.HandsHelping;
            this.btnHelp.IconColor = System.Drawing.Color.LightGray;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 32;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 424);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(403, 69);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAnalyticalHistory
            // 
            this.btnAnalyticalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalyticalHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalyticalHistory.FlatAppearance.BorderSize = 0;
            this.btnAnalyticalHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAnalyticalHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyticalHistory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyticalHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnalyticalHistory.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnAnalyticalHistory.IconColor = System.Drawing.Color.LightGray;
            this.btnAnalyticalHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalyticalHistory.IconSize = 32;
            this.btnAnalyticalHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyticalHistory.Location = new System.Drawing.Point(0, 355);
            this.btnAnalyticalHistory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAnalyticalHistory.Name = "btnAnalyticalHistory";
            this.btnAnalyticalHistory.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAnalyticalHistory.Size = new System.Drawing.Size(403, 69);
            this.btnAnalyticalHistory.TabIndex = 12;
            this.btnAnalyticalHistory.Text = "Analytical History";
            this.btnAnalyticalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalyticalHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalyticalHistory.UseVisualStyleBackColor = true;
            this.btnAnalyticalHistory.Click += new System.EventHandler(this.btnAnalyticalHistory_Click);
            // 
            // btnViewHoldingStack
            // 
            this.btnViewHoldingStack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewHoldingStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewHoldingStack.FlatAppearance.BorderSize = 0;
            this.btnViewHoldingStack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnViewHoldingStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHoldingStack.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHoldingStack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewHoldingStack.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnViewHoldingStack.IconColor = System.Drawing.Color.LightGray;
            this.btnViewHoldingStack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewHoldingStack.IconSize = 32;
            this.btnViewHoldingStack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewHoldingStack.Location = new System.Drawing.Point(0, 286);
            this.btnViewHoldingStack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnViewHoldingStack.Name = "btnViewHoldingStack";
            this.btnViewHoldingStack.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnViewHoldingStack.Size = new System.Drawing.Size(403, 69);
            this.btnViewHoldingStack.TabIndex = 11;
            this.btnViewHoldingStack.Text = "View Holding Stack";
            this.btnViewHoldingStack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewHoldingStack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewHoldingStack.UseVisualStyleBackColor = true;
            this.btnViewHoldingStack.Click += new System.EventHandler(this.btnViewHoldingStack_Click);
            // 
            // panelNewSubMenu
            // 
            this.panelNewSubMenu.Controls.Add(this.btnNewAirport);
            this.panelNewSubMenu.Controls.Add(this.btnNewRunaway);
            this.panelNewSubMenu.Controls.Add(this.btnNewAircraft);
            this.panelNewSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewSubMenu.Location = new System.Drawing.Point(0, 69);
            this.panelNewSubMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelNewSubMenu.Name = "panelNewSubMenu";
            this.panelNewSubMenu.Size = new System.Drawing.Size(403, 217);
            this.panelNewSubMenu.TabIndex = 10;
            // 
            // btnNewAirport
            // 
            this.btnNewAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.btnNewAirport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAirport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAirport.FlatAppearance.BorderSize = 0;
            this.btnNewAirport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNewAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAirport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAirport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewAirport.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.btnNewAirport.IconColor = System.Drawing.Color.LightGray;
            this.btnNewAirport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewAirport.IconSize = 32;
            this.btnNewAirport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAirport.Location = new System.Drawing.Point(0, 138);
            this.btnNewAirport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewAirport.Name = "btnNewAirport";
            this.btnNewAirport.Padding = new System.Windows.Forms.Padding(55, 0, 55, 0);
            this.btnNewAirport.Size = new System.Drawing.Size(403, 69);
            this.btnNewAirport.TabIndex = 12;
            this.btnNewAirport.Text = "Airport";
            this.btnNewAirport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAirport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAirport.UseVisualStyleBackColor = false;
            this.btnNewAirport.Click += new System.EventHandler(this.btnNewAirport_Click);
            // 
            // btnNewRunaway
            // 
            this.btnNewRunaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.btnNewRunaway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRunaway.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRunaway.FlatAppearance.BorderSize = 0;
            this.btnNewRunaway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNewRunaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRunaway.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRunaway.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewRunaway.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.btnNewRunaway.IconColor = System.Drawing.Color.LightGray;
            this.btnNewRunaway.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewRunaway.IconSize = 32;
            this.btnNewRunaway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRunaway.Location = new System.Drawing.Point(0, 69);
            this.btnNewRunaway.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewRunaway.Name = "btnNewRunaway";
            this.btnNewRunaway.Padding = new System.Windows.Forms.Padding(55, 0, 55, 0);
            this.btnNewRunaway.Size = new System.Drawing.Size(403, 69);
            this.btnNewRunaway.TabIndex = 11;
            this.btnNewRunaway.Text = "Runaway";
            this.btnNewRunaway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRunaway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewRunaway.UseVisualStyleBackColor = false;
            this.btnNewRunaway.Click += new System.EventHandler(this.btnNewRunaway_Click);
            // 
            // btnNewAircraft
            // 
            this.btnNewAircraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.btnNewAircraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAircraft.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAircraft.FlatAppearance.BorderSize = 0;
            this.btnNewAircraft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnNewAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAircraft.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAircraft.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewAircraft.IconChar = FontAwesome.Sharp.IconChar.FighterJet;
            this.btnNewAircraft.IconColor = System.Drawing.Color.LightGray;
            this.btnNewAircraft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewAircraft.IconSize = 32;
            this.btnNewAircraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAircraft.Location = new System.Drawing.Point(0, 0);
            this.btnNewAircraft.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNewAircraft.Name = "btnNewAircraft";
            this.btnNewAircraft.Padding = new System.Windows.Forms.Padding(55, 0, 55, 0);
            this.btnNewAircraft.Size = new System.Drawing.Size(403, 69);
            this.btnNewAircraft.TabIndex = 10;
            this.btnNewAircraft.Text = "Aircraft";
            this.btnNewAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAircraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAircraft.UseVisualStyleBackColor = false;
            this.btnNewAircraft.Click += new System.EventHandler(this.btnNewAircraft_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddNew.IconColor = System.Drawing.Color.LightGray;
            this.btnAddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNew.IconSize = 32;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(0, 0);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnAddNew.Size = new System.Drawing.Size(403, 69);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Indigo;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.Lime;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(403, 86);
            this.panelLogo.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(93, 18);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.labelTitleChildForm);
            this.panelTop.Controls.Add(this.IconCurrentChildForm);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.panelTime);
            this.panelTop.Controls.Add(this.btnSimulate_Stop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(403, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1275, 86);
            this.panelTop.TabIndex = 7;
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Aqua;
            this.labelTitleChildForm.Location = new System.Drawing.Point(583, 32);
            this.labelTitleChildForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(82, 29);
            this.labelTitleChildForm.TabIndex = 5;
            this.labelTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.Aqua;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.Aqua;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 45;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(513, 22);
            this.IconCurrentChildForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(59, 45);
            this.IconCurrentChildForm.TabIndex = 4;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(27, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 5);
            this.panel1.TabIndex = 3;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.panelTime.Controls.Add(this.labelTimeSec);
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Location = new System.Drawing.Point(5, 26);
            this.panelTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(372, 49);
            this.panelTime.TabIndex = 1;
            // 
            // labelTimeSec
            // 
            this.labelTimeSec.AutoSize = true;
            this.labelTimeSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.labelTimeSec.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSec.ForeColor = System.Drawing.Color.Yellow;
            this.labelTimeSec.Location = new System.Drawing.Point(142, 8);
            this.labelTimeSec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTimeSec.Name = "labelTimeSec";
            this.labelTimeSec.Size = new System.Drawing.Size(41, 29);
            this.labelTimeSec.TabIndex = 1;
            this.labelTimeSec.Text = "0 s";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.labelTime.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(27, 8);
            this.labelTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 29);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "TIME : ";
            // 
            // btnSimulate_Stop
            // 
            this.btnSimulate_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimulate_Stop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSimulate_Stop.FlatAppearance.BorderSize = 0;
            this.btnSimulate_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.btnSimulate_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulate_Stop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate_Stop.ForeColor = System.Drawing.Color.White;
            this.btnSimulate_Stop.Location = new System.Drawing.Point(953, 17);
            this.btnSimulate_Stop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSimulate_Stop.Name = "btnSimulate_Stop";
            this.btnSimulate_Stop.Size = new System.Drawing.Size(281, 58);
            this.btnSimulate_Stop.TabIndex = 0;
            this.btnSimulate_Stop.Text = "SIMULATE";
            this.btnSimulate_Stop.UseVisualStyleBackColor = false;
            this.btnSimulate_Stop.Click += new System.EventHandler(this.btnSimulate_Stop_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChildForm.Location = new System.Drawing.Point(403, 86);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1275, 808);
            this.panelChildForm.TabIndex = 8;
            // 
            // SimulateTimer
            // 
            this.SimulateTimer.Interval = 1000;
            this.SimulateTimer.Tick += new System.EventHandler(this.SimulateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1678, 894);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelWholeSideMenu);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1700, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATC Simulator";
            this.panelWholeSideMenu.ResumeLayout(false);
            this.PanelSideMenu.ResumeLayout(false);
            this.panelNewSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWholeSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Timer SimulateTimer;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTimeSec;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnSimulate_Stop;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.Panel panelNewSubMenu;
        private FontAwesome.Sharp.IconButton btnNewAirport;
        private FontAwesome.Sharp.IconButton btnNewRunaway;
        private FontAwesome.Sharp.IconButton btnNewAircraft;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnAnalyticalHistory;
        private FontAwesome.Sharp.IconButton btnViewHoldingStack;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.PictureBox btnHome;
    }
}