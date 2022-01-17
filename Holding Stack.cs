using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC
{
    public class Holding_Stack
    {
        static int HSNames = 100000;
        public String HS_Name;

        public List<Aircraft> AirPlanes = new List<Aircraft>();

        public int HoldCapacity = Consts.MaxHoldStackCapacity, DynamicCount = 0;                 // Depicts Max Holding Capacity of Stack and Counter Variable

        public Holding_Stack(String HSname = "Demo")
        {
            HS_Name = HSname == "Demo" ? "HS-" + (++HSNames).ToString() : HSname;
        }

        
        public bool EnQueue(Aircraft Plane)
        {
            if (DynamicCount >= HoldCapacity) return false;

            if (DynamicCount++ < 2) AirPlanes.Add(Plane);

            else if (DynamicCount < HoldCapacity)
            {
                int i;
                for (i = 1; i < AirPlanes.Count; i++) if (AirPlanes[i].Activity_Status == 2 || AirPlanes[i].GetEmergencyLevel() < Plane.GetEmergencyLevel()) break;
                AirPlanes.Insert(i, Plane);
            }

            return true;
        }


        public bool DeQueue()
        {
            if (DynamicCount == 0) return false;
            
            //AirPlanes.RemoveAt(0);
            DynamicCount--;
            return true;
        }

        public int IsEmpty_Full() { return DynamicCount == 0 ? -1 : (DynamicCount == HoldCapacity ? 1 : 0 ); }
    }
}
