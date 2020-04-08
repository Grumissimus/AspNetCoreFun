using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public interface IController<T>
    {
        public IActionResult Read([FromRoute] int id);
        public IActionResult Create([FromBody]T newEntity);
        public IActionResult Update([FromRoute] int id, [FromBody]T newEntity);
        public IActionResult Delete([FromRoute] int id);
    }
}
