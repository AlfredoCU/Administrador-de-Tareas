﻿namespace AdministradorTareas
{
    partial class Admin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcProcesos = new System.Windows.Forms.TabControl();
            this.tpNuevoProcesos = new System.Windows.Forms.TabPage();
            this.gbProcesos = new System.Windows.Forms.GroupBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDisco = new System.Windows.Forms.Label();
            this.txtDisco = new System.Windows.Forms.TextBox();
            this.lblCpu = new System.Windows.Forms.Label();
            this.txtPidId = new System.Windows.Forms.TextBox();
            this.lblPidId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tpProcesos = new System.Windows.Forms.TabPage();
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.tpRendimiento = new System.Windows.Forms.TabPage();
            this.tpEquipo = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnFinalizarProceso = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.dgvProIngresado = new System.Windows.Forms.DataGridView();
            this.txtPID2 = new System.Windows.Forms.TextBox();
            this.lblPID2 = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbMaquina = new System.Windows.Forms.GroupBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMemoriaTope = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPUTope = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscoTope = new System.Windows.Forms.TextBox();
            this.lblCpuTope = new System.Windows.Forms.Label();
            this.ckbActivar = new System.Windows.Forms.CheckBox();
            this.msPrincipal.SuspendLayout();
            this.tcProcesos.SuspendLayout();
            this.tpNuevoProcesos.SuspendLayout();
            this.gbProcesos.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            this.tpProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            this.tpEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProIngresado)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(1070, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informaciónToolStripMenuItem.Image")));
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem});
            this.vistaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistaToolStripMenuItem.Image")));
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarToolStripMenuItem.Image")));
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // tcProcesos
            // 
            this.tcProcesos.Controls.Add(this.tpNuevoProcesos);
            this.tcProcesos.Controls.Add(this.tpProcesos);
            this.tcProcesos.Controls.Add(this.tpRendimiento);
            this.tcProcesos.Controls.Add(this.tpEquipo);
            this.tcProcesos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProcesos.Location = new System.Drawing.Point(12, 27);
            this.tcProcesos.Name = "tcProcesos";
            this.tcProcesos.SelectedIndex = 0;
            this.tcProcesos.Size = new System.Drawing.Size(1042, 492);
            this.tcProcesos.TabIndex = 1;
            // 
            // tpNuevoProcesos
            // 
            this.tpNuevoProcesos.Controls.Add(this.gbProcesos);
            this.tpNuevoProcesos.Controls.Add(this.gbControl);
            this.tpNuevoProcesos.Controls.Add(this.gbIngresar);
            this.tpNuevoProcesos.Location = new System.Drawing.Point(4, 26);
            this.tpNuevoProcesos.Name = "tpNuevoProcesos";
            this.tpNuevoProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevoProcesos.Size = new System.Drawing.Size(1034, 462);
            this.tpNuevoProcesos.TabIndex = 0;
            this.tpNuevoProcesos.Text = "Nuevo procesos";
            this.tpNuevoProcesos.UseVisualStyleBackColor = true;
            // 
            // gbProcesos
            // 
            this.gbProcesos.Controls.Add(this.dgvProIngresado);
            this.gbProcesos.Location = new System.Drawing.Point(43, 223);
            this.gbProcesos.Name = "gbProcesos";
            this.gbProcesos.Size = new System.Drawing.Size(940, 233);
            this.gbProcesos.TabIndex = 75;
            this.gbProcesos.TabStop = false;
            this.gbProcesos.Text = "Procesos";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lblPID2);
            this.gbControl.Controls.Add(this.txtPID2);
            this.gbControl.Controls.Add(this.btnEliminar);
            this.gbControl.Controls.Add(this.btnIngresar);
            this.gbControl.Location = new System.Drawing.Point(679, 11);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(304, 206);
            this.gbControl.TabIndex = 74;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(18, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(269, 39);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(18, 35);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(269, 39);
            this.btnIngresar.TabIndex = 71;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.lblUsuario);
            this.gbIngresar.Controls.Add(this.cbUsuario);
            this.gbIngresar.Controls.Add(this.txtMemoria);
            this.gbIngresar.Controls.Add(this.txtDescripcion);
            this.gbIngresar.Controls.Add(this.lblEstado);
            this.gbIngresar.Controls.Add(this.lblMemoria);
            this.gbIngresar.Controls.Add(this.cbEstado);
            this.gbIngresar.Controls.Add(this.txtCpu);
            this.gbIngresar.Controls.Add(this.lblDescripcion);
            this.gbIngresar.Controls.Add(this.lblDisco);
            this.gbIngresar.Controls.Add(this.txtDisco);
            this.gbIngresar.Controls.Add(this.lblCpu);
            this.gbIngresar.Controls.Add(this.txtPidId);
            this.gbIngresar.Controls.Add(this.lblPidId);
            this.gbIngresar.Controls.Add(this.txtNombre);
            this.gbIngresar.Controls.Add(this.lblNombre);
            this.gbIngresar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresar.Location = new System.Drawing.Point(43, 11);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(630, 206);
            this.gbIngresar.TabIndex = 0;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "Ingresar un nuevo proceso";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(29, 144);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(97, 141);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(154, 25);
            this.cbUsuario.TabIndex = 12;
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(103, 92);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(102, 25);
            this.txtMemoria.TabIndex = 7;
            this.txtMemoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemoria_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(364, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(232, 25);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(387, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 17);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(29, 95);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(68, 17);
            this.lblMemoria.TabIndex = 6;
            this.lblMemoria.Text = "Memoria:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(451, 92);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 25);
            this.cbEstado.TabIndex = 10;
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(526, 43);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(70, 25);
            this.txtCpu.TabIndex = 5;
            this.txtCpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpu_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(268, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 17);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(224, 95);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(50, 17);
            this.lblDisco.TabIndex = 8;
            this.lblDisco.Text = "Disco:";
            // 
            // txtDisco
            // 
            this.txtDisco.Location = new System.Drawing.Point(280, 92);
            this.txtDisco.Name = "txtDisco";
            this.txtDisco.Size = new System.Drawing.Size(88, 25);
            this.txtDisco.TabIndex = 9;
            this.txtDisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisco_KeyPress);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(477, 46);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(43, 17);
            this.lblCpu.TabIndex = 4;
            this.lblCpu.Text = "CPU:";
            // 
            // txtPidId
            // 
            this.txtPidId.Location = new System.Drawing.Point(390, 43);
            this.txtPidId.Name = "txtPidId";
            this.txtPidId.Size = new System.Drawing.Size(72, 25);
            this.txtPidId.TabIndex = 3;
            this.txtPidId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPidId_KeyPress);
            // 
            // lblPidId
            // 
            this.lblPidId.AutoSize = true;
            this.lblPidId.Location = new System.Drawing.Point(348, 46);
            this.lblPidId.Name = "lblPidId";
            this.lblPidId.Size = new System.Drawing.Size(36, 17);
            this.lblPidId.TabIndex = 2;
            this.lblPidId.Text = "PID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tpProcesos
            // 
            this.tpProcesos.Controls.Add(this.dgvProcesos);
            this.tpProcesos.Location = new System.Drawing.Point(4, 26);
            this.tpProcesos.Name = "tpProcesos";
            this.tpProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcesos.Size = new System.Drawing.Size(1034, 462);
            this.tpProcesos.TabIndex = 1;
            this.tpProcesos.Text = "Procesos";
            this.tpProcesos.UseVisualStyleBackColor = true;
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AllowUserToAddRows = false;
            this.dgvProcesos.AllowUserToOrderColumns = true;
            this.dgvProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcesos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcesos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProcesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcesos.Location = new System.Drawing.Point(3, 3);
            this.dgvProcesos.MultiSelect = false;
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProcesos.RowHeadersWidth = 25;
            this.dgvProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcesos.Size = new System.Drawing.Size(1028, 456);
            this.dgvProcesos.TabIndex = 67;
            // 
            // tpRendimiento
            // 
            this.tpRendimiento.Location = new System.Drawing.Point(4, 26);
            this.tpRendimiento.Name = "tpRendimiento";
            this.tpRendimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRendimiento.Size = new System.Drawing.Size(1034, 462);
            this.tpRendimiento.TabIndex = 2;
            this.tpRendimiento.Text = "Rendimiento";
            this.tpRendimiento.UseVisualStyleBackColor = true;
            // 
            // tpEquipo
            // 
            this.tpEquipo.Controls.Add(this.gbMaquina);
            this.tpEquipo.Controls.Add(this.gbInfo);
            this.tpEquipo.Location = new System.Drawing.Point(4, 26);
            this.tpEquipo.Name = "tpEquipo";
            this.tpEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEquipo.Size = new System.Drawing.Size(1034, 462);
            this.tpEquipo.TabIndex = 3;
            this.tpEquipo.Text = "Equipo";
            this.tpEquipo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(466, 525);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 39);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnFinalizarProceso
            // 
            this.btnFinalizarProceso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarProceso.ForeColor = System.Drawing.Color.Red;
            this.btnFinalizarProceso.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarProceso.Image")));
            this.btnFinalizarProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarProceso.Location = new System.Drawing.Point(874, 525);
            this.btnFinalizarProceso.Name = "btnFinalizarProceso";
            this.btnFinalizarProceso.Size = new System.Drawing.Size(180, 39);
            this.btnFinalizarProceso.TabIndex = 67;
            this.btnFinalizarProceso.Text = "Finalizar";
            this.btnFinalizarProceso.UseVisualStyleBackColor = true;
            this.btnFinalizarProceso.Click += new System.EventHandler(this.btnFinalizarProceso_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.Location = new System.Drawing.Point(8, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 19);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "Total de procesos: ";
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(765, 532);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(87, 26);
            this.txtPID.TabIndex = 69;
            this.txtPID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPID_KeyPress);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPID.Location = new System.Drawing.Point(666, 535);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(93, 18);
            this.lblPID.TabIndex = 70;
            this.lblPID.Text = "Ingrese PID:";
            // 
            // dgvProIngresado
            // 
            this.dgvProIngresado.AllowUserToAddRows = false;
            this.dgvProIngresado.AllowUserToOrderColumns = true;
            this.dgvProIngresado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProIngresado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProIngresado.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProIngresado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProIngresado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProIngresado.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProIngresado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProIngresado.Location = new System.Drawing.Point(3, 21);
            this.dgvProIngresado.MultiSelect = false;
            this.dgvProIngresado.Name = "dgvProIngresado";
            this.dgvProIngresado.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProIngresado.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProIngresado.RowHeadersWidth = 25;
            this.dgvProIngresado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProIngresado.Size = new System.Drawing.Size(934, 209);
            this.dgvProIngresado.TabIndex = 68;
            // 
            // txtPID2
            // 
            this.txtPID2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID2.Location = new System.Drawing.Point(181, 96);
            this.txtPID2.Name = "txtPID2";
            this.txtPID2.Size = new System.Drawing.Size(106, 26);
            this.txtPID2.TabIndex = 75;
            this.txtPID2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPID2_KeyPress);
            // 
            // lblPID2
            // 
            this.lblPID2.AutoSize = true;
            this.lblPID2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPID2.Location = new System.Drawing.Point(15, 99);
            this.lblPID2.Name = "lblPID2";
            this.lblPID2.Size = new System.Drawing.Size(160, 18);
            this.lblPID2.TabIndex = 77;
            this.lblPID2.Text = "Eliminar proceso PID:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblInfo);
            this.gbInfo.Location = new System.Drawing.Point(24, 6);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(486, 450);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Información del equipo";
            // 
            // gbMaquina
            // 
            this.gbMaquina.Controls.Add(this.ckbActivar);
            this.gbMaquina.Controls.Add(this.txtCPUTope);
            this.gbMaquina.Controls.Add(this.label3);
            this.gbMaquina.Controls.Add(this.txtDiscoTope);
            this.gbMaquina.Controls.Add(this.lblCpuTope);
            this.gbMaquina.Controls.Add(this.txtMemoriaTope);
            this.gbMaquina.Controls.Add(this.label2);
            this.gbMaquina.Controls.Add(this.pbImg);
            this.gbMaquina.Location = new System.Drawing.Point(555, 22);
            this.gbMaquina.Name = "gbMaquina";
            this.gbMaquina.Size = new System.Drawing.Size(443, 418);
            this.gbMaquina.TabIndex = 2;
            this.gbMaquina.TabStop = false;
            this.gbMaquina.Text = "Maquina";
            // 
            // pbImg
            // 
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(0, 24);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(443, 265);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(17, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(453, 391);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // txtMemoriaTope
            // 
            this.txtMemoriaTope.Location = new System.Drawing.Point(303, 332);
            this.txtMemoriaTope.Name = "txtMemoriaTope";
            this.txtMemoriaTope.Size = new System.Drawing.Size(97, 25);
            this.txtMemoriaTope.TabIndex = 9;
            this.txtMemoriaTope.Text = "12000";
            this.txtMemoriaTope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemoriaTope_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Memoria:";
            // 
            // txtCPUTope
            // 
            this.txtCPUTope.Location = new System.Drawing.Point(109, 332);
            this.txtCPUTope.Name = "txtCPUTope";
            this.txtCPUTope.Size = new System.Drawing.Size(87, 25);
            this.txtCPUTope.TabIndex = 11;
            this.txtCPUTope.Text = "4";
            this.txtCPUTope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPUTope_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Disco:";
            // 
            // txtDiscoTope
            // 
            this.txtDiscoTope.Location = new System.Drawing.Point(212, 381);
            this.txtDiscoTope.Name = "txtDiscoTope";
            this.txtDiscoTope.Size = new System.Drawing.Size(88, 25);
            this.txtDiscoTope.TabIndex = 13;
            this.txtDiscoTope.Text = "500000";
            this.txtDiscoTope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscoTope_KeyPress);
            // 
            // lblCpuTope
            // 
            this.lblCpuTope.AutoSize = true;
            this.lblCpuTope.Location = new System.Drawing.Point(60, 335);
            this.lblCpuTope.Name = "lblCpuTope";
            this.lblCpuTope.Size = new System.Drawing.Size(43, 17);
            this.lblCpuTope.TabIndex = 10;
            this.lblCpuTope.Text = "CPU:";
            // 
            // ckbActivar
            // 
            this.ckbActivar.AutoSize = true;
            this.ckbActivar.Location = new System.Drawing.Point(163, 295);
            this.ckbActivar.Name = "ckbActivar";
            this.ckbActivar.Size = new System.Drawing.Size(137, 21);
            this.ckbActivar.TabIndex = 14;
            this.ckbActivar.Text = "Modificar Valores";
            this.ckbActivar.UseVisualStyleBackColor = true;
            this.ckbActivar.CheckedChanged += new System.EventHandler(this.ckbActivar_CheckedChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1070, 576);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinalizarProceso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tcProcesos);
            this.Controls.Add(this.msPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de tareas";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tcProcesos.ResumeLayout(false);
            this.tpNuevoProcesos.ResumeLayout(false);
            this.gbProcesos.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            this.tpProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            this.tpEquipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProIngresado)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMaquina.ResumeLayout(false);
            this.gbMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.TabControl tcProcesos;
        private System.Windows.Forms.TabPage tpNuevoProcesos;
        private System.Windows.Forms.TabPage tpProcesos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnFinalizarProceso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TabPage tpRendimiento;
        private System.Windows.Forms.DataGridView dgvProcesos;
        private System.Windows.Forms.TabPage tpEquipo;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.TextBox txtPidId;
        private System.Windows.Forms.Label lblPidId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.TextBox txtDisco;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gbProcesos;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.DataGridView dgvProIngresado;
        private System.Windows.Forms.Label lblPID2;
        private System.Windows.Forms.TextBox txtPID2;
        private System.Windows.Forms.GroupBox gbMaquina;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMemoriaTope;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPUTope;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscoTope;
        private System.Windows.Forms.Label lblCpuTope;
        private System.Windows.Forms.CheckBox ckbActivar;
    }
}

