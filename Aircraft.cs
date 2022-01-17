using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    public class Aircraft
    {
        static int CraftNames = 100;
        public String Craft_Name;
        public Double StartTime = 0;
        public String activity = "Arrival";
        public int RunawayDir;
        public int Activity_Status = 0;              // Status of activity(Landing/Take-off) as either -1(Scheduled), 0(Activity in progress), 1(Activity Completed)
        public String CraftType;
        Double AirportDist, Height;            // "Distance From Airport", "Height from the Ground"
        Double Fuel;                           // "Fuel Content"
        Double SpeedKMPH, FuelConsRate;        // "Speed in KMPH", "Fuel Consumption Rate"

        int EmergencyLevel;                    // Depicts the Level Of Emergency
        public int GetEmergencyLevel() { return EmergencyLevel; }

        public Aircraft(int Runawaydir = 0, int Activitytype = 1, int Crafttype = 0, int EmerLevel = 0, Double Airportdist = 0, Double height = 0, Double fuel = 300, Double SKMPH = 0, Double FCR = 0, String AircraftName = "Demo")
        {
            CraftType        =   Consts.CraftTypes[Crafttype].CraftType;
            Craft_Name       =   AircraftName == "Demo" ? "FL-" + CraftType.Substring(0,3).ToUpper() + "-IC-" + (++CraftNames).ToString() : AircraftName;
            AirportDist      =   Math.Min(Consts.Activities[Activitytype].MinAirportDistKM , Airportdist);        // Distance from Airport w.r.t. Activity Type
            Height           =   Math.Min(Consts.Activities[Activitytype].MinHeightFt, height);                   // Height from Ground w.r.t. Activity Type
            EmergencyLevel   =   Math.Min(Consts.Activities[Activitytype].MaxEmergencyLevel, EmerLevel);          // Emergency Level
            Fuel             =   fuel;                                                                            // Instataneous Fuel
            SpeedKMPH        =   Math.Max(Consts.CraftTypes[Crafttype].Min_Speed_KMPH, SKMPH);                    // Speed in KMPH
            FuelConsRate     =   Math.Max(Consts.CraftTypes[Crafttype].FCR_PerSec, FCR);                          // Fuel Cons Rate
            activity         =   Consts.Activities[Activitytype].ActivityType;
            RunawayDir = Runawaydir;
        }

        // public void UpdateProperties(Double APD = 0, Double H = 0) { AirportDist += APD; Height += H; Fuel -= FuelConsRate; }   // Method to Update AirCraft Properties
        public void UpdateActivityStatus(int activity = 0)
        {
            if (activity < 0 || activity > 2) return;
            Activity_Status = activity;
        }
    }
}
