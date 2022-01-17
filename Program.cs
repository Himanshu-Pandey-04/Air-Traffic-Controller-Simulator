using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public struct CraftProperties                                                                                        // Stores Various AirCraft Properties
    {
        public String CraftType;                                                                                         // AirCraft Type
        public int FCR_PerSec;                                                                                           // Fuel Consumption Rate Per Seconds
        public int Min_Speed_KMPH;                                                                                       // Various Planes Average Speed In KMPH 
        public CraftProperties(String CT, int FCR, int ASK) { CraftType = CT; FCR_PerSec = FCR; Min_Speed_KMPH = ASK; }  // CraftProperties Ctor
    }

    public struct Activity                                                                                               // Types of Activities
    {
        public String ActivityType;                                                                                             // Stores Activity Info
        public int MaxEmergencyLevel;                                                                                           // Stores Max Emergency Level Info
        public Double MinAirportDistKM, MinHeightFt;
        public Activity(String AT, int MEL, int MADK, int MHF)
        { ActivityType = AT; MaxEmergencyLevel = MEL; MinAirportDistKM = MADK; MinHeightFt = MHF; }                      // Activity Ctor
    }
    /*
    public struct ActivityStatus
    {
        public int ID;
        public String Description;
        public ActivityStatus(int id, String desc) { ID = id; Description = desc; }
    }*/


    public static class Consts                          // Class of Constants
    {                                                         

        public static List<CraftProperties> CraftTypes = new List<CraftProperties>                                       // List of Valid AirCrafts
        { new CraftProperties("Passenger", 2, 700), new CraftProperties("Fighter", 4, 900), new CraftProperties("Cargo", 3, 750), new CraftProperties("Private", 1, 600) };

        public static List<Activity> Activities = new List<Activity>                                                     // Current Max Emergency Levels For Resp. Fields
        { new Activity("Departure", 3, 0, 0), new Activity("Arrival", 3, 5, 1000) };

        public static List<String> ActivityStatuses = new List<String>()
        { "SCHEDULED", "IN PROGRESS", "COMPLETED"};

        public static List<String> RunawayDirections = new List<String>() { "Runaway-15", "Runaway-33" };

        public static int NORunaways = 1, RunawayLengthKM = 2;                                                           // No. of Runaways per Airport and Runaway Lengths

        public static int MaxHoldStackCapacity = 15;
        
        public static void ChangeConstants()                                                                             // Access Privilege to only Administrators
        {
            //MENU
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch(Exception E)
            {

            }
        }
    }



    public class CBOoptions                                                                    // To Handle Options in a Combo Box
    {
        public int AutoID = 0;
        public int ID { get; set; }
        public String Data { get; set; }
        public CBOoptions(String data) { ID = AutoID++; Data = data; }
    }
}
