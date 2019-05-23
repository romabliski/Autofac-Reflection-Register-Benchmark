using TenClasses;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("ten")]
    [ApiController]
    public class TenClassesController : ControllerBase
    {
        private readonly IClass1 classA;
        private readonly IClass2 classB;
        private readonly IClass3 classC;
        private readonly IClass4 classD;
        private readonly IClass5 classE;
        private readonly IClass6 classF;
        private readonly IClass7 classG;
        private readonly IClass8 classH;
        private readonly IClass9 classI;
        private readonly IClass10 classJ;

        public TenClassesController(
            IClass1 classA,
            IClass2 classB,
            IClass3 classC,
            IClass4 classD,
            IClass5 classE,
            IClass6 classF,
            IClass7 classG,
            IClass8 classH,
            IClass9 classI,
            IClass10 classJ
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
            return new JsonResult(classA.MethodA());
        }
    }
}
