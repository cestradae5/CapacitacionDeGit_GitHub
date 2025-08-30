using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaControlador;

namespace CapaVista
{
    public partial class ConsultasVista : Form
    {
        //instanciar la variable controlador para acceder a las funciones
        Controlador cn = new Controlador();
        string tabla = "empleados";//nombre de la tabla que se cosuta

        public ConsultasVista()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dgv_consulta.DataSource = dt;
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
