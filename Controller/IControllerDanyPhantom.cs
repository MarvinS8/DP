using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Model;

namespace DP.Controller
{
    interface IControllerDanyPhantom
    {
        List<PhantomModel> ObtenerPersonajes();
        bool Insertar(PhantomModel personaje);
    }
}
