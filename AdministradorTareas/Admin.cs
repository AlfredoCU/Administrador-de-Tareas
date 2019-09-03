using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdministradorTareas
{
    public partial class Admin : Form
    {
        // Instancia de la lista de procesos.
        ListaProcesos lp = new ListaProcesos();
        Validar v = new Validar();

        // Constructor.
        public Admin()
        {
            InitializeComponent();
        }

        // Form.
        private void Admin_Load(object sender, EventArgs e)
        {
            // Inicializar lista.
            lp.IniciaLista();

            // Se actualiza las tablas y el total de procesos.
            ActualizarDatos();

            // Cargar datos a los ComboBox.
            this.cbUsuario.Items.Add("Alfredo");
            this.cbUsuario.Items.Add("Miguel");
            this.cbUsuario.Items.Add("Sergio");
            this.cbUsuario.Items.Add("SYSTEM");
            this.cbUsuario.Items.Add("SERVICIO LOCAL");

            // Mensajes de ayuda.
            this.ttMensajeAyuda.ToolTipTitle = "Complete los campos";
            this.ttMensajeAyuda.ToolTipIcon = ToolTipIcon.Info;
            this.ttMensajeAyuda.SetToolTip(this.txtNombre, "Ingrese letras: A, B, C...");
            this.ttMensajeAyuda.SetToolTip(this.txtPidId, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtCpu, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtMemoria, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtDisco, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.cbUsuario, "Elija un usuario para el proceso.");
            this.ttMensajeAyuda.SetToolTip(this.txtDescripcion, "Ingrese letras: A, B, C...");
            this.ttMensajeAyuda.SetToolTip(this.txtTiempo, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtPID, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtPID2, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtCPUTope, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtMemoriaTope, "Ingrese números: 1, 2, 3, 4, 5...");
            this.ttMensajeAyuda.SetToolTip(this.txtDiscoTope, "Ingrese números: 1, 2, 3, 4, 5...");

            // Texbox de la vista Equipo desactivados.
            this.txtCPUTope.Enabled = false;
            this.txtMemoriaTope.Enabled = false;
            this.txtDiscoTope.Enabled = false;

            // Gráfica y tablas.
            cGrafica1.Titles.Add("Rendimiento");
            cGrafica1.Series[0].Points.AddXY("", 1024);
            cGrafica1.Series[0].Points.AddXY("", 1404);
            cGrafica1.Series[1].Points.AddXY("", 150);
            tTiempo.Start();
        }

        // Se actualiza las tablas y el total de procesos.
        public void ActualizarDatos()
        {
            // Mostrar lista en la vista Nuevo proceso.
            dgvProIngresado.DataSource = null;
            dgvProIngresado.DataSource = lp.MostrarLista();
            // Mostrar lista en la vista Procesos.
            dgvProcesos.DataSource = null;
            dgvProcesos.DataSource = lp.MostrarLista();
            // Total de procesos.
            lblTotal.Text = "Total de procesos: " + lp.Total();
        }

        // Limpiar todos los Textbox y ComboBox.
        public void LimpiarTxt()
        {
            this.txtNombre.Clear();
            this.txtPidId.Clear();
            this.txtCpu.Clear();
            this.txtMemoria.Clear();
            this.txtDisco.Clear();
            this.cbUsuario.SelectedIndex = -1;
            this.txtDescripcion.Clear();
            this.txtPID.Clear();
            this.txtPID2.Clear();
            this.txtTiempo.Clear();
        }

        // Activar o desactivar Texbox de la vista Equipo.
        public void ActivarDesactivar()
        {
            if (ckbActivar.Checked)
            {
                this.txtCPUTope.Enabled = true;
                this.txtMemoriaTope.Enabled = true;
                this.txtDiscoTope.Enabled = true;
            }
            else
            {
                this.txtCPUTope.Enabled = false;
                this.txtMemoriaTope.Enabled = false;
                this.txtDiscoTope.Enabled = false;
            }
        }

        // Validar TextBox.
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtPidId_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtCpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtMemoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtDisco_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtPID1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtPID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtCPUTope_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtMemoriaTope_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtDiscoTope_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        // Botón de Ingresar.
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Trim().Length == 0 || this.txtPidId.Text.Trim().Length == 0 || !(this.cbUsuario.SelectedIndex > -1) || 
                this.txtCpu.Text.Trim().Length == 0 || this.txtMemoria.Text.Trim().Length == 0 || this.txtDisco.Text.Trim().Length == 0 || 
                this.txtDescripcion.Text.Trim().Length == 0 || this.txtTiempo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los campos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Procesos dt = new Procesos(this.txtNombre.Text, Int32.Parse(this.txtPidId.Text), "Ejecutando", 
                    this.cbUsuario.Text, Int32.Parse(this.txtCpu.Text), Int32.Parse(this.txtMemoria.Text), 
                    Int32.Parse(this.txtDisco.Text), this.txtDescripcion.Text, Int32.Parse(this.txtTiempo.Text));
                // Validar la busqueda.
                if(!(lp.BuscarLista(Int32.Parse(this.txtPidId.Text))))
                {
                    lp.InsertarLista(dt);
                    ActualizarDatos();
                    LimpiarTxt();
                    MessageBox.Show("Proceso almacenado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo alamacenar (PID ya existe).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botón de Eliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.txtPID2.Text.Trim().Length == 0)
            {
                MessageBox.Show("No ha agregado un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lp.EliminarDatoLista(Int32.Parse(txtPID2.Text));
                ActualizarDatos();
                LimpiarTxt();
                MessageBox.Show("Proceso eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Botón de Finalizar.
        private void btnFinalizarProceso_Click(object sender, EventArgs e)
        {
            if (this.txtPID.Text.Trim().Length == 0)
            {
                MessageBox.Show("No ha agregado un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lp.EliminarDatoLista(Int32.Parse(txtPID.Text));
                ActualizarDatos();
                LimpiarTxt();
                MessageBox.Show("Proceso finalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Activar o desactivar los TextBox de la vista Equipo.
        private void ckbActivar_CheckedChanged(object sender, EventArgs e)
        {
            ActivarDesactivar();
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

        // Opción Actualizar.
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se actualiza las tablas y el total de procesos.
            lp.ReiniciarLista();
            lp.IniciaLista();
            ActualizarDatos();
            MessageBox.Show("Procesos actualizados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Gráficas y tablas.
        private void tTiempo_Tick(object sender, EventArgs e)
        {
            cGrafica1.Series[0].Points.AddXY("", 1024);
            cGrafica1.Series[0].Points.AddXY("", 1404);
            cGrafica1.Series[1].Points.AddXY("", 150);

            lp.ReiniciarLista();
            lp.IniciaLista();
            ActualizarDatos();
        }
    }
}
