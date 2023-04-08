using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLINQ
{
    public class Datos
    {
        public static IList<Producto> Productos = new List<Producto>
        {
            new Producto {Codigo=1,Nombre="Harina",Precio=7,Stock=56},
            new Producto {Codigo=2,Nombre="Leche",Precio=42,Stock=68},
            new Producto {Codigo=3,Nombre="Azúcar",Precio=1,Stock=29},
            new Producto {Codigo=1,Nombre="Sal",Precio=2,Stock=516}
        };

    }
}
