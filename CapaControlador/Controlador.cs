using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//llamar a capa modelo
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class Controlador
    {
        //Todas las funciones y metodos que conectan con la capa vista y la capa modelo
        Consultas cn = new Consultas();

        // LLenar una tabla CAPA CONTROLADOR
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = cn.llenarTbl(tabla);
            DataTable table = new DataTable();//se carga con los datos que se pidieron para mostrar en el datagridview
            dt.Fill(table);
            return table;
        }
    }
}
