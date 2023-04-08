using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInstalador
{
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
        }

        private void Acercade_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion.ToString();
            LblFecha.Text = "Fecha: " + System.IO.File.GetLastWriteTime(Application.ExecutablePath).ToString();
        }
    }
}
