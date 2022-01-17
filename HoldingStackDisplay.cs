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
    public partial class HoldingStackDisplay : Form
    {
        public DataTable Hold_stack = new DataTable("HOLDING STACK");

        public HoldingStackDisplay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HoldingStackDisplay_Load(object sender, EventArgs e)
        {
            if (Hold_stack.Columns.Count == 0) InitializeDataTable();
        }

        public void InitializeDataTable()
        {
            Hold_stack.Columns.Add("Air Craft", typeof(String));
            Hold_stack.Columns.Add("Craft Type", typeof(String));
            Hold_stack.Columns.Add("Emergency Level", typeof(String));
            Hold_stack.Columns.Add("Runaway Direction", typeof(String));
            Hold_stack.Columns.Add("Activity", typeof(String));
            Hold_stack.Columns.Add("Activity Status", typeof(String));

            dgvHoldStack.DataSource = Hold_stack;

            dgvHoldStack.DefaultCellStyle.Font = new Font("Tahoma", 10);
        }

        public void UpdateDataTable()
        {
            Hold_stack.Rows.Clear();
            foreach (Aircraft AC in MainForm.Airports[0].Holding_Stacks[0].AirPlanes)
            {
                Hold_stack.Rows.Add(AC.Craft_Name, AC.CraftType, "Emergency Level " + AC.GetEmergencyLevel(), Consts.RunawayDirections[AC.RunawayDir], AC.activity, Consts.ActivityStatuses[AC.Activity_Status]);
            }

            dgvHoldStack.DataSource = Hold_stack;

            foreach(DataGridViewRow row in dgvHoldStack.Rows)
            {
                switch(row.Cells[5].Value.ToString())
                {
                    case "SCHEDULED": row.DefaultCellStyle.ForeColor = Color.Red;
                    break;

                    case "IN PROGRESS": row.DefaultCellStyle.ForeColor = Color.Goldenrod;
                    break;

                    case "COMPLETED": row.DefaultCellStyle.ForeColor = Color.Green;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataTable();
        }
    }
}
