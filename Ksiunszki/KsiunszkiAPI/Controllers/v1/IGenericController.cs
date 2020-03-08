using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KsiunszkiAPI.Controllers.v1
{
    public interface IGenericController<Request, Response>
    {
        IActionResult Get([FromQuery] Request req);
        IActionResult Create([FromBody] Request req);
        IActionResult Update([FromRoute] int id, [FromBody] Request req);
    }
}
