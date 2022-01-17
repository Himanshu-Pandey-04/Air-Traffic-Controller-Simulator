using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace ATC
{
    public partial class MainForm : Form
    {
        public static Double Timer_Time = 0;

        public static HoldingStackDisplay HSD = new HoldingStackDisplay();
        public static List<Airport> Airports = new List<Airport>();

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public MainForm()
        {
            Application.Run(new UserEntry());

            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelNewSubMenu.Controls.Add(leftBorderBtn);
            /*Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;*/

            Airports.Add(new Airport());
            btnNewAirport.Enabled = false;
            btnNewRunaway.Enabled = false;
            HideSubMenu();

            if (HSD.Hold_stack.Columns.Count == 0) HSD.InitializeDataTable();
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Boreder Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Current Child Form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
                labelTitleChildForm.Text = currentBtn.Text;
                labelTitleChildForm.ForeColor = currentBtn.ForeColor;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(4, 17, 56);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private struct RGBColors
        {
            public static Color Color1 = Color.FromArgb(250, 5, 5);
            public static Color Color2 = Color.FromArgb(255, 90, 5);
            public static Color Color3 = Color.FromArgb(40, 240, 75);
            public static Color Color4 = Color.FromArgb(112, 88, 255);
            public static Color Color5 = Color.FromArgb(249, 88, 155);
            public static Color Color6 = Color.FromArgb(24, 161, 251);
        }



        private void HideSubMenu()
        {
            panelNewSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel ShowPanel)
        {
            HideSubMenu();
            ShowPanel.Visible = true;
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);
            HideSubMenu();
            ShowSubMenu(panelNewSubMenu);
        }
        #region Add New Element
        private void btnNewAircraft_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color5);
            HideSubMenu();
            openChildForm(new NewAircraft());
        }

        private void btnNewRunaway_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);
            HideSubMenu();
        }

        private void btnNewAirport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);
            HideSubMenu();
        }
        #endregion


        private void btnViewHoldingStack_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color2);
            HideSubMenu();
            openChildForm(HSD);
        }

        private void btnAnalyticalHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color3);
            HideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color4);
            HideSubMenu();
        }

        private void SimulateTimer_Tick(object sender, EventArgs e)
        {
            labelTimeSec.Text = (Timer_Time++).ToString() + " s";

            int CompletedOnes = 0;
            foreach (Aircraft aircraft in Airports[0].Holding_Stacks[0].AirPlanes) if (aircraft.Activity_Status == 2) CompletedOnes++;
            if (CompletedOnes == Airports[0].Holding_Stacks[0].AirPlanes.Count) return;

            if (Airports[0].Holding_Stacks[0].AirPlanes.Count != 0)
            {

                if (Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status == 0)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status = 1;
                    Airports[0].Holding_Stacks[0].AirPlanes[0].StartTime = Timer_Time;
                }

                else if (Airports[0].Holding_Stacks[0].AirPlanes[0].StartTime + 6 < Timer_Time)// && Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status==2)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status = 2;
                    Airports[0].Holding_Stacks[0].AirPlanes.Add(Airports[0].Holding_Stacks[0].AirPlanes[0]);
                    Airports[0].Holding_Stacks[0].AirPlanes.RemoveAt(0);
                    Airports[0].Holding_Stacks[0].DeQueue();
                    //Airports[0].Holding_Stacks[0].DeQueue();
                }

                HSD.UpdateDataTable();
            }
        }

        private void btnSimulate_Stop_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            DisableButton();

            if (SimulateTimer.Enabled == false)
            {
                SimulateTimer.Enabled = true;
                btnSimulate_Stop.Text = "STOP";
                btnSimulate_Stop.BackColor = Color.IndianRed;

                if(Airports[0].Holding_Stacks[0].DynamicCount!=0)
                {
                    Airports[0].Holding_Stacks[0].AirPlanes[0].UpdateActivityStatus(1);
                    HSD.UpdateDataTable();
                }

                //btnStop.Visible = true;
            }

            else
            {
                SimulateTimer.Enabled = false;
                btnSimulate_Stop.Text = "SIMULATE";
                //Timer_Time = 0;
                btnSimulate_Stop.BackColor = Color.Black;
                //btnStop.Visible = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            activeForm.Hide();

            // Current Child Form
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.Aqua;
            labelTitleChildForm.Text = "Home";
            labelTitleChildForm.ForeColor = Color.Aqua;
        }

        /*
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Drag Form
        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            catch(Exception E)
            {

            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        */


        /*
        private void btnStop_Click(object sender, EventArgs e)
        {
           SimulateTimer.Enabled = false;
           Timer_Time = 0;
           btnSimulate_Stop_Click(sender, e);
        }*/
    }
}

