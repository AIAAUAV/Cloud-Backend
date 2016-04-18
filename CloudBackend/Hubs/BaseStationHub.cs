using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using CloudBackend.Models;

namespace CloudBackend.Hubs
{
    public class BaseStationHub : Hub
    {
        private readonly TelemetryTicker _ticker;

        public BaseStationHub() : this(TelemetryTicker.Instance) { }

        public BaseStationHub(TelemetryTicker ticker)
        {
            _ticker = ticker;
        }

        public TelemetryTicker GetTelemetry()
        {
            return _ticker;
        }

    }
}