using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudBackend.Models
{
    public class Telemetry
    {
        public DateTime TimeStamp { get; set; }
        public bool UAVConnected { get; set; }

        public float BatteryPercentage { get; set; }
        public float Altitude { get; set; }
        public float Speed { get; set; }
    }
}