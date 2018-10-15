using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homeify.Server.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Homeify.Server.Models
{
    public class Device
    {
        public string MacId { get; }

        public string Name { get; }
        
        public DateTime LastConnected { get; }

        public BluetoothStatus Status { get; }

        public Device(string macId, string name, DateTime lastConnected, BluetoothStatus status)
        {
            MacId = macId;
            Name = name;
            LastConnected = lastConnected;
            Status = status;
        }
    }
}
