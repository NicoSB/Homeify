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
        public ActionResult<IEnumerable<Device>> Get()
        {
            return new[] {new Device("D3:19:C8:89:F9:42", "TestDevice", DateTime.Now, BluetoothStatus.Unknown)};
        }
    }
}
