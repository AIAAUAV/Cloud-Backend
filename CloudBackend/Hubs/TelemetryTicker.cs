using CloudBackend.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace CloudBackend.Hubs
{
    public class TelemetryTicker
    {
        // Singleton instance
        private readonly static Lazy<TelemetryTicker> _instance = new Lazy<TelemetryTicker>(
            () => new TelemetryTicker(GlobalHost.ConnectionManager.GetHubContext<BaseStationHub>().Clients)
        );

        // Telemetry Object
        private readonly Telemetry _telemetry;


        // Threading Variables
        private readonly object _updateTelemetryLock = new object();
        private volatile bool _updatingTelemetry = false;


        // Timing Variables
        private readonly Timer _timer;
        private readonly TimeSpan _updateInterval = TimeSpan.FromMilliseconds(250);

        private TelemetryTicker(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;

            _telemetry = null;

            _timer = new Timer(UpdateTelemetry, null, _updateInterval, _updateInterval);

        }

        public static TelemetryTicker Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }

        public Telemetry GetTelemetry()
        {
            return _telemetry;
        }

        private void UpdateTelemetry(object state)
        {
            lock (_updateTelemetryLock)
            {
                if (!_updatingTelemetry)
                {
                    _updatingTelemetry = true;
                    
                    // if new telemetry from UAV has been recieved
                    //{
                        BroadcastTelemetry();
                    //}
                    _updatingTelemetry = false;
                }
            }
        }

        private void BroadcastTelemetry()
        {
            Clients.All.updateTelemetry(_telemetry);
        }
    }

}