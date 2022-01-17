using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class NewAircraft : Form
    {
        public NewAircraft()
        {
            InitializeComponent();
        }

        private void NewAircraft_Load(object sender, EventArgs e)
        {
            //    FOR Combo Box Select Airport
            List<CBOoptions> airports = new List<CBOoptions>();
            foreach (Airport port in MainForm.Airports) airports.Add(new CBOoptions(port.Airport_Name));
            cboSelectAirport.DisplayMember = "Data";
            cboSelectAirport.ValueMember = "ID";
            cboSelectAirport.DataSource = airports;

            //    FOR Combo Box Select Activity
            List<CBOoptions> activity = new List<CBOoptions>();
            foreach (Activity acti in Consts.Activities) activity.Add(new CBOoptions(acti.ActivityType));
            cboSelectActivity.DisplayMember = "Data";
            cboSelectActivity.ValueMember = "ID";
            cboSelectActivity.DataSource = activity;
            
            //    FOR Combo Box Select Airport
            List<CBOoptions> aircrafts  = new List<CBOoptions>();
            foreach (CraftProperties aircraft in Consts.CraftTypes) aircrafts.Add(new CBOoptions(aircraft.CraftType));
            cboSelectCraftType.DisplayMember = "Data";
            cboSelectCraftType.ValueMember = "ID";
            cboSelectCraftType.DataSource = aircrafts;

            
            //    FOR Combo Box Select Airport
            List<CBOoptions> emergencylevels = new List<CBOoptions>();
            emergencylevels.Add(new CBOoptions("No Emergency"));
            for (int i = 1; i <= Consts.Activities[cboSelectActivity.SelectedIndex].MaxEmergencyLevel; i++) emergencylevels.Add(new CBOoptions("Emergency Level "+i.ToString()));
            cboSelectEmerLevel.DisplayMember = "Data";
            cboSelectEmerLevel.ValueMember = "ID";
            cboSelectEmerLevel.DataSource = emergencylevels;
            
            //    FOR Combo Box Select Airport
            List<CBOoptions> RNDirection = new List<CBOoptions>();
            RNDirection.Add(new CBOoptions(Consts.RunawayDirections[0]));
            RNDirection.Add(new CBOoptions(Consts.RunawayDirections[1]));
            cboSelectRunawayDirection.DisplayMember = "Data";
            cboSelectRunawayDirection.ValueMember = "ID";
            cboSelectRunawayDirection.DataSource = RNDirection;
        }

        private void btnCancelAircraft_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            foreach(Airport port in MainForm.Airports) 
                if(port.Airport_Name==cboSelectAirport.Text)
                {
                    if (!port.AddAirCraft(new Aircraft(cboSelectRunawayDirection.SelectedIndex,cboSelectActivity.SelectedIndex, cboSelectCraftType.SelectedIndex, cboSelectEmerLevel.SelectedIndex)))
                        MessageBox.Show("Current Selected Holding Stack is Full !", "Stop", MessageBoxButtons.OK);
                    break;
                }

            if (MainForm.Airports[0].Holding_Stacks[0].AirPlanes.Count > 0)
                if (MainForm.Airports[0].Holding_Stacks[0].AirPlanes[0].Activity_Status != 1)
                {
                    MainForm.Airports[0].Holding_Stacks[0].AirPlanes[0].UpdateActivityStatus(1);
                    MainForm.HSD.UpdateDataTable();
                }

        }
    }
}
