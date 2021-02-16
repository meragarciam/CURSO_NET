
namespace Cesar_8
{
    partial class Form1
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
            this.numHabitacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numHabita = new System.Windows.Forms.Label();
            this.nomCliente = new System.Windows.Forms.Label();
            this.nomTrabajador = new System.Windows.Forms.Label();
            this.tipoReserva = new System.Windows.Forms.Label();
            this.fechaReserva = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.Label();
            this.fechaSalida = new System.Windows.Forms.Label();
            this.costoAloj = new System.Windows.Forms.Label();
            this.textobservacion = new System.Windows.Forms.Label();
            this.textBoxHabitacion = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxTrabajador = new System.Windows.Forms.TextBox();
            this.comboBoxReserva = new System.Windows.Forms.ComboBox();
            this.dateTimeReserva = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSalida = new System.Windows.Forms.DateTimePicker();
            this.textBoxCosta = new System.Windows.Forms.TextBox();
            this.TextBoxObservacion = new System.Windows.Forms.RichTextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.NomHabita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTrabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoAlojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFichero = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numHabitacion
            // 
            this.numHabitacion.AutoSize = true;
            this.numHabitacion.Location = new System.Drawing.Point(13, 68);
            this.numHabitacion.Name = "numHabitacion";
            this.numHabitacion.Size = new System.Drawing.Size(0, 17);
            this.numHabitacion.TabIndex = 0;
            this.numHabitacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonGuardar);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Controls.Add(this.TextBoxObservacion);
            this.groupBox1.Controls.Add(this.textBoxCosta);
            this.groupBox1.Controls.Add(this.dateTimeSalida);
            this.groupBox1.Controls.Add(this.dateTimeIngreso);
            this.groupBox1.Controls.Add(this.dateTimeReserva);
            this.groupBox1.Controls.Add(this.comboBoxReserva);
            this.groupBox1.Controls.Add(this.textBoxTrabajador);
            this.groupBox1.Controls.Add(this.textBoxCliente);
            this.groupBox1.Controls.Add(this.textBoxHabitacion);
            this.groupBox1.Controls.Add(this.textobservacion);
            this.groupBox1.Controls.Add(this.costoAloj);
            this.groupBox1.Controls.Add(this.fechaSalida);
            this.groupBox1.Controls.Add(this.fechaIngreso);
            this.groupBox1.Controls.Add(this.fechaReserva);
            this.groupBox1.Controls.Add(this.tipoReserva);
            this.groupBox1.Controls.Add(this.nomTrabajador);
            this.groupBox1.Controls.Add(this.nomCliente);
            this.groupBox1.Controls.Add(this.numHabita);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 502);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualización Consumo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numHabita
            // 
            this.numHabita.AutoSize = true;
            this.numHabita.Location = new System.Drawing.Point(6, 41);
            this.numHabita.Name = "numHabita";
            this.numHabita.Size = new System.Drawing.Size(75, 17);
            this.numHabita.TabIndex = 0;
            this.numHabita.Text = "Habitacion";
            // 
            // nomCliente
            // 
            this.nomCliente.AutoSize = true;
            this.nomCliente.Location = new System.Drawing.Point(6, 76);
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.Size = new System.Drawing.Size(51, 17);
            this.nomCliente.TabIndex = 1;
            this.nomCliente.Text = "Cliente";
            // 
            // nomTrabajador
            // 
            this.nomTrabajador.AutoSize = true;
            this.nomTrabajador.Location = new System.Drawing.Point(6, 111);
            this.nomTrabajador.Name = "nomTrabajador";
            this.nomTrabajador.Size = new System.Drawing.Size(78, 17);
            this.nomTrabajador.TabIndex = 2;
            this.nomTrabajador.Text = "Trabajador";
            // 
            // tipoReserva
            // 
            this.tipoReserva.AutoSize = true;
            this.tipoReserva.Location = new System.Drawing.Point(7, 148);
            this.tipoReserva.Name = "tipoReserva";
            this.tipoReserva.Size = new System.Drawing.Size(93, 17);
            this.tipoReserva.TabIndex = 3;
            this.tipoReserva.Text = "Tipo Reserva";
            // 
            // fechaReserva
            // 
            this.fechaReserva.AutoSize = true;
            this.fechaReserva.Location = new System.Drawing.Point(6, 182);
            this.fechaReserva.Name = "fechaReserva";
            this.fechaReserva.Size = new System.Drawing.Size(104, 17);
            this.fechaReserva.TabIndex = 4;
            this.fechaReserva.Text = "Fecha Reserva";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSize = true;
            this.fechaIngreso.Location = new System.Drawing.Point(7, 217);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(98, 17);
            this.fechaIngreso.TabIndex = 5;
            this.fechaIngreso.Text = "Fecha Ingreso";
            // 
            // fechaSalida
            // 
            this.fechaSalida.AutoSize = true;
            this.fechaSalida.Location = new System.Drawing.Point(7, 250);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(90, 17);
            this.fechaSalida.TabIndex = 6;
            this.fechaSalida.Text = "Fecha Salida";
            // 
            // costoAloj
            // 
            this.costoAloj.AutoSize = true;
            this.costoAloj.Location = new System.Drawing.Point(6, 281);
            this.costoAloj.Name = "costoAloj";
            this.costoAloj.Size = new System.Drawing.Size(121, 17);
            this.costoAloj.TabIndex = 7;
            this.costoAloj.Text = "Costo Alojamiento";
            // 
            // textobservacion
            // 
            this.textobservacion.AutoSize = true;
            this.textobservacion.Location = new System.Drawing.Point(6, 311);
            this.textobservacion.Name = "textobservacion";
            this.textobservacion.Size = new System.Drawing.Size(88, 17);
            this.textobservacion.TabIndex = 8;
            this.textobservacion.Text = "Observacion";
            // 
            // textBoxHabitacion
            // 
            this.textBoxHabitacion.Location = new System.Drawing.Point(140, 38);
            this.textBoxHabitacion.Name = "textBoxHabitacion";
            this.textBoxHabitacion.Size = new System.Drawing.Size(100, 22);
            this.textBoxHabitacion.TabIndex = 9;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(140, 76);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(96, 22);
            this.textBoxCliente.TabIndex = 10;
            // 
            // textBoxTrabajador
            // 
            this.textBoxTrabajador.Location = new System.Drawing.Point(140, 108);
            this.textBoxTrabajador.Name = "textBoxTrabajador";
            this.textBoxTrabajador.Size = new System.Drawing.Size(96, 22);
            this.textBoxTrabajador.TabIndex = 11;
            // 
            // comboBoxReserva
            // 
            this.comboBoxReserva.FormattingEnabled = true;
            this.comboBoxReserva.Location = new System.Drawing.Point(140, 148);
            this.comboBoxReserva.Name = "comboBoxReserva";
            this.comboBoxReserva.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReserva.TabIndex = 12;
            // 
            // dateTimeReserva
            // 
            this.dateTimeReserva.Location = new System.Drawing.Point(140, 182);
            this.dateTimeReserva.Name = "dateTimeReserva";
            this.dateTimeReserva.Size = new System.Drawing.Size(146, 22);
            this.dateTimeReserva.TabIndex = 13;
            // 
            // dateTimeIngreso
            // 
            this.dateTimeIngreso.Location = new System.Drawing.Point(140, 217);
            this.dateTimeIngreso.Name = "dateTimeIngreso";
            this.dateTimeIngreso.Size = new System.Drawing.Size(146, 22);
            this.dateTimeIngreso.TabIndex = 14;
            // 
            // dateTimeSalida
            // 
            this.dateTimeSalida.Location = new System.Drawing.Point(140, 245);
            this.dateTimeSalida.Name = "dateTimeSalida";
            this.dateTimeSalida.Size = new System.Drawing.Size(146, 22);
            this.dateTimeSalida.TabIndex = 15;
            // 
            // textBoxCosta
            // 
            this.textBoxCosta.Location = new System.Drawing.Point(140, 281);
            this.textBoxCosta.Name = "textBoxCosta";
            this.textBoxCosta.Size = new System.Drawing.Size(100, 22);
            this.textBoxCosta.TabIndex = 16;
            // 
            // TextBoxObservacion
            // 
            this.TextBoxObservacion.Location = new System.Drawing.Point(140, 311);
            this.TextBoxObservacion.Name = "TextBoxObservacion";
            this.TextBoxObservacion.Size = new System.Drawing.Size(151, 60);
            this.TextBoxObservacion.TabIndex = 17;
            this.TextBoxObservacion.Text = "";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(13, 387);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(52, 17);
            this.Estado.TabIndex = 18;
            this.Estado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(140, 383);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEstado.TabIndex = 19;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(19, 460);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(91, 26);
            this.buttonNuevo.TabIndex = 20;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(159, 460);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(81, 26);
            this.buttonGuardar.TabIndex = 21;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(289, 460);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(81, 26);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(443, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(525, 422);
            this.tabControl.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomHabita,
            this.nomClient,
            this.nomTrabaja,
            this.tipoReserv,
            this.fechaReserv,
            this.fechaIngre,
            this.fechaSalid,
            this.costoAlojamiento,
            this.observacion,
            this.tipoEstado});
            this.dataGridView1.Location = new System.Drawing.Point(3, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(448, 472);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(91, 26);
            this.buttonEliminar.TabIndex = 21;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(764, 472);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(91, 26);
            this.buttonImprimir.TabIndex = 22;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(874, 472);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(91, 26);
            this.buttonSalir.TabIndex = 23;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // NomHabita
            // 
            this.NomHabita.HeaderText = "HABITACION";
            this.NomHabita.MinimumWidth = 6;
            this.NomHabita.Name = "NomHabita";
            this.NomHabita.Width = 125;
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "CLIENTE";
            this.nomClient.MinimumWidth = 6;
            this.nomClient.Name = "nomClient";
            this.nomClient.Width = 125;
            // 
            // nomTrabaja
            // 
            this.nomTrabaja.HeaderText = "TRABAJADOR";
            this.nomTrabaja.MinimumWidth = 6;
            this.nomTrabaja.Name = "nomTrabaja";
            this.nomTrabaja.Width = 125;
            // 
            // tipoReserv
            // 
            this.tipoReserv.HeaderText = "TIPO RESERVA";
            this.tipoReserv.MinimumWidth = 6;
            this.tipoReserv.Name = "tipoReserv";
            this.tipoReserv.Width = 125;
            // 
            // fechaReserv
            // 
            this.fechaReserv.HeaderText = "FECHA RESERVA";
            this.fechaReserv.MinimumWidth = 6;
            this.fechaReserv.Name = "fechaReserv";
            this.fechaReserv.Width = 125;
            // 
            // fechaIngre
            // 
            this.fechaIngre.HeaderText = "FECHA INGRESO";
            this.fechaIngre.MinimumWidth = 6;
            this.fechaIngre.Name = "fechaIngre";
            this.fechaIngre.Width = 125;
            // 
            // fechaSalid
            // 
            this.fechaSalid.HeaderText = "FECHA SALIDA";
            this.fechaSalid.MinimumWidth = 6;
            this.fechaSalid.Name = "fechaSalid";
            this.fechaSalid.Width = 125;
            // 
            // costoAlojamiento
            // 
            this.costoAlojamiento.HeaderText = "COSTO ALOJAMIENTO";
            this.costoAlojamiento.MinimumWidth = 6;
            this.costoAlojamiento.Name = "costoAlojamiento";
            this.costoAlojamiento.Width = 125;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "OBSERVACIONES";
            this.observacion.MinimumWidth = 6;
            this.observacion.Name = "observacion";
            this.observacion.Width = 125;
            // 
            // tipoEstado
            // 
            this.tipoEstado.HeaderText = "ESTADO";
            this.tipoEstado.MinimumWidth = 6;
            this.tipoEstado.Name = "tipoEstado";
            this.tipoEstado.Width = 125;
            // 
            // buttonFichero
            // 
            this.buttonFichero.Location = new System.Drawing.Point(560, 472);
            this.buttonFichero.Name = "buttonFichero";
            this.buttonFichero.Size = new System.Drawing.Size(185, 26);
            this.buttonFichero.TabIndex = 24;
            this.buttonFichero.Text = "Guardar en fichero TXT";
            this.buttonFichero.UseVisualStyleBackColor = true;
            this.buttonFichero.Click += new System.EventHandler(this.buttonFichero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 526);
            this.Controls.Add(this.buttonFichero);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numHabitacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numHabitacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fechaReserva;
        private System.Windows.Forms.Label tipoReserva;
        private System.Windows.Forms.Label nomTrabajador;
        private System.Windows.Forms.Label nomCliente;
        private System.Windows.Forms.Label numHabita;
        private System.Windows.Forms.Label textobservacion;
        private System.Windows.Forms.Label costoAloj;
        private System.Windows.Forms.Label fechaSalida;
        private System.Windows.Forms.Label fechaIngreso;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.RichTextBox TextBoxObservacion;
        private System.Windows.Forms.TextBox textBoxCosta;
        private System.Windows.Forms.DateTimePicker dateTimeSalida;
        private System.Windows.Forms.DateTimePicker dateTimeIngreso;
        private System.Windows.Forms.DateTimePicker dateTimeReserva;
        private System.Windows.Forms.ComboBox comboBoxReserva;
        private System.Windows.Forms.TextBox textBoxTrabajador;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxHabitacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomHabita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTrabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoAlojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEstado;
        private System.Windows.Forms.Button buttonFichero;
    }
}

