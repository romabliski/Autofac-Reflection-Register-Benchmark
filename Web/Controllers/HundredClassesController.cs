using HundredClasses;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("hundred")]
    [ApiController]
    public class HundredClassesController : ControllerBase
    {
        private readonly IClass1 class1;
        private readonly IClass2 class2;
        private readonly IClass3 class3;
        private readonly IClass4 class4;
        private readonly IClass5 class5;
        private readonly IClass6 class6;
        private readonly IClass7 class7;
        private readonly IClass8 class8;
        private readonly IClass9 class9;
        private readonly IClass10 class10;
        private readonly IClass11 class11;
        private readonly IClass12 class12;
        private readonly IClass13 class13;
        private readonly IClass14 class14;
        private readonly IClass15 class15;
        private readonly IClass16 class16;
        private readonly IClass17 class17;
        private readonly IClass18 class18;
        private readonly IClass19 class19;
        private readonly IClass20 class20;
        private readonly IClass21 class21;
        private readonly IClass22 class22;
        private readonly IClass23 class23;
        private readonly IClass24 class24;
        private readonly IClass25 class25;
        private readonly IClass26 class26;
        private readonly IClass27 class27;
        private readonly IClass28 class28;
        private readonly IClass29 class29;
        private readonly IClass30 class30;
        private readonly IClass31 class31;
        private readonly IClass32 class32;
        private readonly IClass33 class33;
        private readonly IClass34 class34;
        private readonly IClass35 class35;
        private readonly IClass36 class36;
        private readonly IClass37 class37;
        private readonly IClass38 class38;
        private readonly IClass39 class39;
        private readonly IClass40 class40;
        private readonly IClass41 class41;
        private readonly IClass42 class42;
        private readonly IClass43 class43;
        private readonly IClass44 class44;
        private readonly IClass45 class45;
        private readonly IClass46 class46;
        private readonly IClass47 class47;
        private readonly IClass48 class48;
        private readonly IClass49 class49;
        private readonly IClass50 class50;
        private readonly IClass51 class51;
        private readonly IClass52 class52;
        private readonly IClass53 class53;
        private readonly IClass54 class54;
        private readonly IClass55 class55;
        private readonly IClass56 class56;
        private readonly IClass57 class57;
        private readonly IClass58 class58;
        private readonly IClass59 class59;
        private readonly IClass60 class60;
        private readonly IClass61 class61;
        private readonly IClass62 class62;
        private readonly IClass63 class63;
        private readonly IClass64 class64;
        private readonly IClass65 class65;
        private readonly IClass66 class66;
        private readonly IClass67 class67;
        private readonly IClass68 class68;
        private readonly IClass69 class69;
        private readonly IClass70 class70;
        private readonly IClass71 class71;
        private readonly IClass72 class72;
        private readonly IClass73 class73;
        private readonly IClass74 class74;
        private readonly IClass75 class75;
        private readonly IClass76 class76;
        private readonly IClass77 class77;
        private readonly IClass78 class78;
        private readonly IClass79 class79;
        private readonly IClass80 class80;
        private readonly IClass81 class81;
        private readonly IClass82 class82;
        private readonly IClass83 class83;
        private readonly IClass84 class84;
        private readonly IClass85 class85;
        private readonly IClass86 class86;
        private readonly IClass87 class87;
        private readonly IClass88 class88;
        private readonly IClass89 class89;
        private readonly IClass90 class90;
        private readonly IClass91 class91;
        private readonly IClass92 class92;
        private readonly IClass93 class93;
        private readonly IClass94 class94;
        private readonly IClass95 class95;
        private readonly IClass96 class96;
        private readonly IClass97 class97;
        private readonly IClass98 class98;
        private readonly IClass99 class99;
        private readonly IClass100 class100;

        public HundredClassesController(
        IClass1 class1,
        IClass2 class2,
        IClass3 class3,
        IClass4 class4,
        IClass5 class5,
        IClass6 class6,
        IClass7 class7,
        IClass8 class8,
        IClass9 class9,
        IClass10 class10,
        IClass11 class11,
        IClass12 class12,
        IClass13 class13,
        IClass14 class14,
        IClass15 class15,
        IClass16 class16,
        IClass17 class17,
        IClass18 class18,
        IClass19 class19,
        IClass20 class20,
        IClass21 class21,
        IClass22 class22,
        IClass23 class23,
        IClass24 class24,
        IClass25 class25,
        IClass26 class26,
        IClass27 class27,
        IClass28 class28,
        IClass29 class29,
        IClass30 class30,
        IClass31 class31,
        IClass32 class32,
        IClass33 class33,
        IClass34 class34,
        IClass35 class35,
        IClass36 class36,
        IClass37 class37,
        IClass38 class38,
        IClass39 class39,
        IClass40 class40,
        IClass41 class41,
        IClass42 class42,
        IClass43 class43,
        IClass44 class44,
        IClass45 class45,
        IClass46 class46,
        IClass47 class47,
        IClass48 class48,
        IClass49 class49,
        IClass50 class50,
        IClass51 class51,
        IClass52 class52,
        IClass53 class53,
        IClass54 class54,
        IClass55 class55,
        IClass56 class56,
        IClass57 class57,
        IClass58 class58,
        IClass59 class59,
        IClass60 class60,
        IClass61 class61,
        IClass62 class62,
        IClass63 class63,
        IClass64 class64,
        IClass65 class65,
        IClass66 class66,
        IClass67 class67,
        IClass68 class68,
        IClass69 class69,
        IClass70 class70,
        IClass71 class71,
        IClass72 class72,
        IClass73 class73,
        IClass74 class74,
        IClass75 class75,
        IClass76 class76,
        IClass77 class77,
        IClass78 class78,
        IClass79 class79,
        IClass80 class80,
        IClass81 class81,
        IClass82 class82,
        IClass83 class83,
        IClass84 class84,
        IClass85 class85,
        IClass86 class86,
        IClass87 class87,
        IClass88 class88,
        IClass89 class89,
        IClass90 class90,
        IClass91 class91,
        IClass92 class92,
        IClass93 class93,
        IClass94 class94,
        IClass95 class95,
        IClass96 class96,
        IClass97 class97,
        IClass98 class98,
        IClass99 class99,
        IClass100 class100
            )
        {
            this.class1  = class1;
            this.class2  = class2; 
            this.class3  = class3; 
            this.class4  = class4; 
            this.class5  = class5; 
            this.class6  = class6; 
            this.class7  = class7; 
            this.class8  = class8;
            this.class9 = class9; 
            this.class10 = class10;
            this.class11 = class11;
            this.class12 = class12;
            this.class13 = class13;
            this.class14 = class14;
            this.class15 = class15;
            this.class16 = class16;
            this.class17 = class17;
            this.class18 = class18;
            this.class19 = class19;
            this.class20 = class20;
            this.class21 = class21;
            this.class22 = class22;
            this.class23 = class23;
            this.class24 = class24;
            this.class25 = class25;
            this.class26 = class26;
            this.class27 = class27;
            this.class28 = class28;
            this.class29 = class29;
            this.class30 = class30;
            this.class31 = class31;
            this.class32 = class32;
            this.class33 = class33;
            this.class34 = class34;
            this.class35 = class35;
            this.class36 = class36;
            this.class37 = class37;
            this.class38 = class38;
            this.class39 = class39;
            this.class40 = class40;
            this.class41 = class41;
            this.class42 = class42;
            this.class43 = class43;
            this.class44 = class44;
            this.class45 = class45;
            this.class46 = class46;
            this.class47 = class47;
            this.class48 = class48;
            this.class49 = class49;
            this.class50 = class50;
            this.class51 = class51;
            this.class52 = class52;
            this.class53 = class53;
            this.class54 = class54;
            this.class55 = class55;
            this.class56 = class56;
            this.class57 = class57;
            this.class58 = class58;
            this.class59 = class59;
            this.class60 = class60;
            this.class61 = class61;
            this.class62 = class62;
            this.class63 = class63;
            this.class64 = class64;
            this.class65 = class65;
            this.class66 = class66;
            this.class67 = class67;
            this.class68 = class68;
            this.class69 = class69;
            this.class70 = class70;
            this.class71 = class71;
            this.class72 = class72;
            this.class73 = class73;
            this.class74 = class74;
            this.class75 = class75;
            this.class76 = class76;
            this.class77 = class77;
            this.class78 = class78;
            this.class79 = class79;
            this.class80 = class80;
            this.class81 = class81;
            this.class82 = class82;
            this.class83 = class83;
            this.class84 = class84;
            this.class85 = class85;
            this.class86 = class86;
            this.class87 = class87;
            this.class88 = class88;
            this.class89 = class89;
            this.class90 = class90;
            this.class91 = class91;
            this.class92 = class92;
            this.class93 = class93;
            this.class94 = class94;
            this.class95 = class95;
            this.class96 = class96;
            this.class97 = class97;
            this.class98 = class98;
            this.class99 = class99; 
            this.class100 = class100;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Get()
        {
            return new JsonResult(class100.MethodA());
        }
    }
}
