using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SILogic.DataController;
using SILogic.Model;

namespace WebAPIService
{
    [Route("[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {

        //public string Calc([FromBody] string request)

        [HttpPost]
        public async Task<ActionResult<string>> Calc(List<WorkerTag> l)//[FromBody] string data)
        {

            //var l = WorkerTag.ListFromJson(data);
            var res = Calculator.Calculate(l);
            return res + "";
        }



    }
}
