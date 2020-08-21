using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseVR.Negocio;
using HouseVR.Servicios;

namespace HouseVR.Controllers
{
    public class Class1
    {
        Negocio.Class1 c1;
        Servicios.Class1 c2;
        public  Class1()
        {
            c1 = new Negocio.Class1();
            c2 = new Servicios.Class1();
        }
    }
}
