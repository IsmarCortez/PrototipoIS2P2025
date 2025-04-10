using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_RRHH
{
    public partial class Frm_Mante_Examen : Form
    {
        public Frm_Mante_Examen()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();


            // Utilizando navegador
            string[] alias = { "Id Empresa", "NIT", "Nombre", "Direccion", "Telefono", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.Green/*ColorTranslator.FromHtml("#B4D2F0")*/);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("empresa");
            navegador1.ObtenerIdAplicacion("18001");
            navegador1.ObtenerIdUsuario(idUsuario);
            // navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento Examen Ismar Cortez IS");

            // Modulo 18,000
            //Aplicacion 18,001


            //navegador1.AsignarComboConTabla("tbl_puestos_trabajo", "pk_id_puestos", "puestos_nombre_puesto", 1);
            //navegador1.AsignarComboConTabla("Tbl_nivel_educativo", "Pk_id_nivel", "nivel", 1);
            //navegador1.AsignarComboConTabla("Tbl_disponibilidad", "Pk_id_disponibilidad", "disponibilidad", 1);

            //navegador1.AsignarForaneas("tbl_puestos_trabajo", "puestos_nombre_puesto", "Fk_puesto_aplica_postulante", "pk_id_puestos");
            //navegador1.AsignarForaneas("Tbl_nivel_educativo", "nivel", "Fk_nivel_educativo", "Pk_id_nivel");
            //navegador1.AsignarForaneas("Tbl_disponibilidad", "disponibilidad", "Fk_disponibilidad", "Pk_id_disponibilidad");

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
