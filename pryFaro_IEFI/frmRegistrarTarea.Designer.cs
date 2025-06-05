namespace pryFaro_IEFI
{
    partial class frmRegistrarTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTarea));
            this.lblTarea = new System.Windows.Forms.Label();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkbxRecibo = new System.Windows.Forms.CheckBox();
            this.chkbxSalario = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkbxRetraso = new System.Windows.Forms.CheckBox();
            this.chkbxPermiso = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbxAusencia = new System.Windows.Forms.CheckBox();
            this.chkbxHsExtra = new System.Windows.Forms.CheckBox();
            this.chkbxPersonal = new System.Windows.Forms.CheckBox();
            this.chkbxMedica = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbxVacacion = new System.Windows.Forms.CheckBox();
            this.chkbxEstudio = new System.Windows.Forms.CheckBox();
            this.chkbxInsumo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(18, 32);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(54, 23);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea:";
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Items.AddRange(new object[] {
            "Auditoría",
            "Consultas",
            "Inspección",
            "Reclamos",
            "Visitas"});
            this.cmbTarea.Location = new System.Drawing.Point(78, 30);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(176, 29);
            this.cmbTarea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(350, 26);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lugar:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Items.AddRange(new object[] {
            "Empresa",
            "Servicio",
            "Oficina"});
            this.cmbLugar.Location = new System.Drawing.Point(78, 80);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(176, 29);
            this.cmbLugar.TabIndex = 5;
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLista.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLista.Location = new System.Drawing.Point(178, 442);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(215, 36);
            this.btnAgregarLista.TabIndex = 6;
            this.btnAgregarLista.Text = "Agregar Tarea a la Lista";
            this.btnAgregarLista.UseVisualStyleBackColor = false;
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Tarea,
            this.Lugar,
            this.Fecha});
            this.dgvTareas.Location = new System.Drawing.Point(11, 133);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(588, 194);
            this.dgvTareas.TabIndex = 8;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            this.Tarea.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarLista);
            this.groupBox1.Controls.Add(this.lblTarea);
            this.groupBox1.Controls.Add(this.dgvTareas);
            this.groupBox1.Controls.Add(this.cmbTarea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbLugar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 344);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar una tarea";
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.Location = new System.Drawing.Point(485, 93);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(107, 34);
            this.btnLimpiarLista.TabIndex = 7;
            this.btnLimpiarLista.Text = "Borrar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkbxRecibo);
            this.groupBox2.Controls.Add(this.chkbxSalario);
            this.groupBox2.Controls.Add(this.btnAgregarLista);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.txtComentario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkbxRetraso);
            this.groupBox2.Controls.Add(this.chkbxPermiso);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkbxAusencia);
            this.groupBox2.Controls.Add(this.chkbxHsExtra);
            this.groupBox2.Controls.Add(this.chkbxPersonal);
            this.groupBox2.Controls.Add(this.chkbxMedica);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkbxVacacion);
            this.groupBox2.Controls.Add(this.chkbxEstudio);
            this.groupBox2.Controls.Add(this.chkbxInsumo);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 490);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(18, 442);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(154, 36);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar casillas";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Reclamo:";
            // 
            // chkbxRecibo
            // 
            this.chkbxRecibo.AutoSize = true;
            this.chkbxRecibo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxRecibo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxRecibo.Location = new System.Drawing.Point(212, 75);
            this.chkbxRecibo.Name = "chkbxRecibo";
            this.chkbxRecibo.Size = new System.Drawing.Size(95, 26);
            this.chkbxRecibo.TabIndex = 9;
            this.chkbxRecibo.Text = "- Recibo:";
            this.chkbxRecibo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxRecibo.UseVisualStyleBackColor = true;
            // 
            // chkbxSalario
            // 
            this.chkbxSalario.AutoSize = true;
            this.chkbxSalario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxSalario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxSalario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxSalario.Location = new System.Drawing.Point(211, 48);
            this.chkbxSalario.Name = "chkbxSalario";
            this.chkbxSalario.Size = new System.Drawing.Size(96, 26);
            this.chkbxSalario.TabIndex = 8;
            this.chkbxSalario.Text = "- Salario:";
            this.chkbxSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxSalario.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(462, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 36);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Todo";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(23, 272);
            this.txtComentario.MaxLength = 400;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(569, 161);
            this.txtComentario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comentarios:";
            // 
            // chkbxRetraso
            // 
            this.chkbxRetraso.AutoSize = true;
            this.chkbxRetraso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxRetraso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxRetraso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxRetraso.Location = new System.Drawing.Point(244, 204);
            this.chkbxRetraso.Name = "chkbxRetraso";
            this.chkbxRetraso.Size = new System.Drawing.Size(101, 26);
            this.chkbxRetraso.TabIndex = 13;
            this.chkbxRetraso.Text = "- Retraso:";
            this.chkbxRetraso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxRetraso.UseVisualStyleBackColor = true;
            // 
            // chkbxPermiso
            // 
            this.chkbxPermiso.AutoSize = true;
            this.chkbxPermiso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxPermiso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxPermiso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxPermiso.Location = new System.Drawing.Point(174, 180);
            this.chkbxPermiso.Name = "chkbxPermiso";
            this.chkbxPermiso.Size = new System.Drawing.Size(171, 26);
            this.chkbxPermiso.TabIndex = 12;
            this.chkbxPermiso.Text = "- Permiso temporal:";
            this.chkbxPermiso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxPermiso.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Otros:";
            // 
            // chkbxAusencia
            // 
            this.chkbxAusencia.AutoSize = true;
            this.chkbxAusencia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxAusencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxAusencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxAusencia.Location = new System.Drawing.Point(161, 156);
            this.chkbxAusencia.Name = "chkbxAusencia";
            this.chkbxAusencia.Size = new System.Drawing.Size(184, 26);
            this.chkbxAusencia.TabIndex = 11;
            this.chkbxAusencia.Text = "- Ausencia justificada:";
            this.chkbxAusencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxAusencia.UseVisualStyleBackColor = true;
            // 
            // chkbxHsExtra
            // 
            this.chkbxHsExtra.AutoSize = true;
            this.chkbxHsExtra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxHsExtra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxHsExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxHsExtra.Location = new System.Drawing.Point(211, 131);
            this.chkbxHsExtra.Name = "chkbxHsExtra";
            this.chkbxHsExtra.Size = new System.Drawing.Size(134, 26);
            this.chkbxHsExtra.TabIndex = 10;
            this.chkbxHsExtra.Text = "- Horas extras:";
            this.chkbxHsExtra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxHsExtra.UseVisualStyleBackColor = true;
            // 
            // chkbxPersonal
            // 
            this.chkbxPersonal.AutoSize = true;
            this.chkbxPersonal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxPersonal.Location = new System.Drawing.Point(30, 216);
            this.chkbxPersonal.Name = "chkbxPersonal";
            this.chkbxPersonal.Size = new System.Drawing.Size(107, 26);
            this.chkbxPersonal.TabIndex = 7;
            this.chkbxPersonal.Text = "- Personal:";
            this.chkbxPersonal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxPersonal.UseVisualStyleBackColor = true;
            // 
            // chkbxMedica
            // 
            this.chkbxMedica.AutoSize = true;
            this.chkbxMedica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxMedica.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxMedica.Location = new System.Drawing.Point(40, 188);
            this.chkbxMedica.Name = "chkbxMedica";
            this.chkbxMedica.Size = new System.Drawing.Size(98, 26);
            this.chkbxMedica.TabIndex = 6;
            this.chkbxMedica.Text = "- Médica:";
            this.chkbxMedica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxMedica.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Uniforme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Licencia:";
            // 
            // chkbxVacacion
            // 
            this.chkbxVacacion.AutoSize = true;
            this.chkbxVacacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxVacacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxVacacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxVacacion.Location = new System.Drawing.Point(30, 160);
            this.chkbxVacacion.Name = "chkbxVacacion";
            this.chkbxVacacion.Size = new System.Drawing.Size(109, 26);
            this.chkbxVacacion.TabIndex = 3;
            this.chkbxVacacion.Text = "- Vacación:";
            this.chkbxVacacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxVacacion.UseVisualStyleBackColor = true;
            // 
            // chkbxEstudio
            // 
            this.chkbxEstudio.AutoSize = true;
            this.chkbxEstudio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxEstudio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxEstudio.Location = new System.Drawing.Point(40, 132);
            this.chkbxEstudio.Name = "chkbxEstudio";
            this.chkbxEstudio.Size = new System.Drawing.Size(99, 26);
            this.chkbxEstudio.TabIndex = 2;
            this.chkbxEstudio.Text = "- Estudio:";
            this.chkbxEstudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxEstudio.UseVisualStyleBackColor = true;
            // 
            // chkbxInsumo
            // 
            this.chkbxInsumo.AutoSize = true;
            this.chkbxInsumo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxInsumo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkbxInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxInsumo.Location = new System.Drawing.Point(49, 50);
            this.chkbxInsumo.Name = "chkbxInsumo";
            this.chkbxInsumo.Size = new System.Drawing.Size(90, 26);
            this.chkbxInsumo.TabIndex = 1;
            this.chkbxInsumo.Text = "Insumo:";
            this.chkbxInsumo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkbxInsumo.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 842);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkbxInsumo;
        private System.Windows.Forms.CheckBox chkbxEstudio;
        private System.Windows.Forms.CheckBox chkbxVacacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbxPersonal;
        private System.Windows.Forms.CheckBox chkbxMedica;
        private System.Windows.Forms.CheckBox chkbxRetraso;
        private System.Windows.Forms.CheckBox chkbxPermiso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbxAusencia;
        private System.Windows.Forms.CheckBox chkbxHsExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkbxRecibo;
        private System.Windows.Forms.CheckBox chkbxSalario;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}