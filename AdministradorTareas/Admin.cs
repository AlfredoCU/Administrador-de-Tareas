using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorTareas
{
    public partial class Admin : Form
    {
        // Instancia de la lista de procesos.
        ListaProcesos lp = new ListaProcesos();

        // Constructor.
        public Admin()
        {
            InitializeComponent();
        }

        // Form.
        private void Admin_Load(object sender, EventArgs e)
        {
            lp.IniciaLista();
            dgvProcesos.DataSource = null;
            dgvProcesos.DataSource = lp.MostrarLista();
            lblTotal.Text = "Total de procesos: " + lp.Total();
        }

        // Boton de Actualizar.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lp.ReiniciarLista();
            lp.IniciaLista();
            dgvProcesos.DataSource = null;
            dgvProcesos.DataSource = lp.MostrarLista();
            lblTotal.Text = "Total de procesos: " + lp.Total();
        }

        // Validar el Textbox para que funcione sólo con números.
        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Boton de Finalizar.
        private void btnFinalizarProceso_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "")
            {
                MessageBox.Show("No ha agregado un valor o el valor es erróneo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lp.EliminarDatoLista(Int32.Parse(txtPID.Text));
                dgvProcesos.DataSource = null;
                dgvProcesos.DataSource = lp.MostrarLista();
                lblTotal.Text = "Total de procesos: " + lp.Total();
                txtPID.Clear();
            }
        }

        // Opción Información.
        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Este sistema esta creado por Alción Computer.\nPrograma: Administrador de tareas.\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Opción Ayuda.
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si necesita ayuda con la aplicación contacte con el Administrador.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // Opción Actializar.
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lp.ReiniciarLista();
            lp.IniciaLista();
            dgvProcesos.DataSource = null;
            dgvProcesos.DataSource = lp.MostrarLista();
            lblTotal.Text = "Total de procesos: " + lp.Total();
        }

        // Opción Salir.
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
