using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    public class Airport
    {
        static int AirportNames = 100000;
        public String Airport_Name;

        public List<Holding_Stack> Holding_Stacks = new List<Holding_Stack>();              // Dynamic List of all the Holding Stacks

        List<Runaways> Runaway;                                 // List of Runaways an Airport will Own
        int NORunaways, Instan_Capacity;                                                         // Total Number of Runaways  and  Instantaneous Capacity 


        public Airport(int NoRunaways = 1, String PortName = "Demo", List<Holding_Stack> holding_Stack = null)
        {
            Airport_Name = PortName == "Demo" ? "AirPort-" + (++AirportNames).ToString() : PortName;
            NORunaways = Instan_Capacity = NoRunaways == 0 ? Consts.NORunaways : NoRunaways;     // Initialize variables with Std Consts Value if No argument is Recieved 
            Runaway = new List<Runaways>();
            Runaway.Add(new Runaways());

            if (holding_Stack == null) Holding_Stacks.Add(new Holding_Stack());
        }

        public void AddRunaway() { }

        public bool AddAirCraft(Aircraft aircraft, int HoldStack_Index = 0)
        {
            return Holding_Stacks[HoldStack_Index].EnQueue(aircraft);
        }
    }


    struct Runaways
    {
        static int RunawayNames = 100000;
        String Runaway_Name;
        Double Length;
        bool Available { get; set; }

        public Runaways(String RAName = "Demo",Double length = 0, bool available = true)
        {
            Length = length == 0 ? Consts.RunawayLengthKM : length;
            Available = available;
            Runaway_Name = RAName == "Demo"? "RN-" + (++RunawayNames).ToString() : RAName;
        }
    }
} 
