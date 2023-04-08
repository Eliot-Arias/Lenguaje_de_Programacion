using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLINQ
{
    public partial class frmQueries : Form
    {
        public frmQueries()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Datos.Productos;
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            // Ordenar la coleccion por nombre del producto
            var coleccion = from prducto in Datos.Productos
                            orderby prducto.Nombre
                            select prducto;
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            //Ordenar la coleccion por nombre del producto
            //decendente por nombre, listar los campos Codigo y Nombre Producto
            var coleccion = from producto in Datos.Productos
                            orderby producto.Nombre descending
                            select new
                            {
                                Codigo = producto.Codigo,
                                NombreProducto = producto.Nombre
                            };
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            //Ordenar la coleccion por precio del producto decendente
            //Listar los campos por nombre y precio
            var coleccion = from producto in Datos.Productos
                          orderby producto.Precio descending
                          select new Producto
                          {
                              Nombre = producto.Nombre,
                              Precio = producto.Precio
                          };
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            //Listar los contrloes, nombre de control y texto desde la coleccion de controles de formulario
            var coleccion = from Control ctl in this.Controls
                            select new
                            {
                                Control = ctl.Name,
                                Text = ctl.Text,
                            };
            grvResultados.DataSource= coleccion.ToList();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            //Listar productos con precio >1 y con stock <100
            var coleccion = from producto in Datos.Productos
                            where producto.Precio > 1 && producto.Stock < 100
                            select producto;
            grvResultados.DataSource = coleccion.ToList();
        }
    }
}
