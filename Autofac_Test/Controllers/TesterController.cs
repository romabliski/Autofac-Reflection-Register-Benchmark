using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac_Test.Services;
using Microsoft.AspNetCore.Mvc;

namespace Autofac_Test.Controllers
{
    [Route("tester")]
    [ApiController]
    public class TesterController : ControllerBase
    {
        private readonly IClassA classA;
        private readonly IClassB classB;
        private readonly IClassC classC;
        private readonly IClassD classD;
        private readonly IClassE classE;
        private readonly IClassF classF;
        private readonly IClassG classG;
        private readonly IClassH classH;
        private readonly IClassI classI;
        private readonly IClassJ classJ;

        public TesterController(
            IClassA classA,
            IClassB classB,
            IClassC classC,
            IClassD classD,
            IClassE classE,
            IClassF classF,
            IClassG classG,
            IClassH classH,
            IClassI classI,
            IClassJ classJ
            )
        {
            this.classA = classA;
            this.classB = classB;
            this.classC = classC;
            this.classD = classD;
            this.classE = classE;
            this.classF = classF;
            this.classG = classG;
            this.classH = classH;
            this.classI = classI;
            this.classJ = classJ;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Get()
        {
            return new JsonResult(classA.Test());
        }
    }
}
