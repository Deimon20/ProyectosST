using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autenticacion
{
    public partial class Form2 : Form
    {
        Registro rt = new Registro();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string user = cbox_asignado.Text; //USUARIO DEBE ESTAR REGISTRADO EN LA TABLA USUARIOS
            string tiporeq = cbox_req.Text;
            string desc = tbox_descReq.Text;
            string prio = cbox_prioridad.Text;

            if (user == "Seleccionar..." || tiporeq == "Seleccionar..." || prio == "Seleccionar...")
            {
                MessageBox.Show("Faltan casillas por completar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (prio == "Alta")
            {
               MessageBox.Show(rt.insertarAlta(user, tiporeq, desc, prio), "Insercion Prioridad: Alta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cbox_asignado.Text = "Seleccionar...";
                cbox_req.Text = "Seleccionar...";
                cbox_prioridad.Text = "Seleccionar...";
                tbox_descReq.Text = String.Empty;
            }
        }
    }
}
