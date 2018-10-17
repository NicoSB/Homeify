using System;
using System.Collections.Generic;
using Homeify.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homeify.Server.Controllers
{
    [Route("api/devices")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        // GET api/devices
        [HttpGet]
        public ActionResult<IEnumerable<Device>> ListDevices()
        {
            var bluetoothInterop = new BluetoothlibInterop();
            bluetoothInterop.ListDevices();
            return new[] {new Device("D3:19:C8:89:F9:42", "TestDevice", DateTime.Now, BluetoothStatus.Unknown)};
        }

        // PUT api/devices/{macAddress}
        [HttpPut("{macAddress}")]
        public ActionResult<Device> UpdateDevice(string macAddress, [FromBody] Device device)
        {
            return NoContent();
        }
    }
}
