namespace Presentaciòn
{
    partial class frm_pago_ordens
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
            this.tabControl_Usuarios = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar_usuario = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPagoOrdenes = new System.Windows.Forms.DataGridView();
            this.btnSalir_frm_usuarios = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_calendario = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_mtd_pago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.cbx_monto_orden = new System.Windows.Forms.ComboBox();
            this.cbx_Orden_encabezados = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_impuesto = new System.Windows.Forms.TextBox();
            this.txt_codigo_pago_orden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Reporte = new FontAwesome.Sharp.IconButton();
            this.btn_cancelarBus_Usuario = new FontAwesome.Sharp.IconButton();
            this.btn_Bus_emple_sin_name = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dvg_empleados_sin_Usuarios = new System.Windows.Forms.DataGridView();
            this.txt_buscar_empleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl_detall_ordenes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_propina = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.tabControl_Usuarios.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).BeginInit();
            this.tabControl_detall_ordenes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Usuarios
            // 
            this.tabControl_Usuarios.Controls.Add(this.tabPage4);
            this.tabControl_Usuarios.Controls.Add(this.tabPage3);
            this.tabControl_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Usuarios.Location = new System.Drawing.Point(2, -65);
            this.tabControl_Usuarios.Name = "tabControl_Usuarios";
            this.tabControl_Usuarios.SelectedIndex = 0;
            this.tabControl_Usuarios.Size = new System.Drawing.Size(1129, 635);
            this.tabControl_Usuarios.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Usuarios.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.btnEliminar_usuario);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dgvPagoOrdenes);
            this.tabPage4.Controls.Add(this.btnSalir_frm_usuarios);
            this.tabPage4.Controls.Add(this.lblFecha);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1121, 606);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Crear Usuarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(2, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 62);
            this.panel2.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 26);
            this.label8.TabIndex = 63;
            this.label8.Text = "Pago Ordenes";
            // 
            // btnEliminar_usuario
            // 
            this.btnEliminar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar_usuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar_usuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminar_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar_usuario.IconSize = 25;
            this.btnEliminar_usuario.Location = new System.Drawing.Point(741, 499);
            this.btnEliminar_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar_usuario.Name = "btnEliminar_usuario";
            this.btnEliminar_usuario.Size = new System.Drawing.Size(129, 31);
            this.btnEliminar_usuario.TabIndex = 61;
            this.btnEliminar_usuario.Text = "Eliminar";
            this.btnEliminar_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar_usuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 59;
            // 
            // dgvPagoOrdenes
            // 
            this.dgvPagoOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagoOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagoOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPagoOrdenes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPagoOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagoOrdenes.Location = new System.Drawing.Point(27, 321);
            this.dgvPagoOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPagoOrdenes.Name = "dgvPagoOrdenes";
            this.dgvPagoOrdenes.ReadOnly = true;
            this.dgvPagoOrdenes.RowHeadersWidth = 51;
            this.dgvPagoOrdenes.RowTemplate.Height = 24;
            this.dgvPagoOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagoOrdenes.Size = new System.Drawing.Size(1083, 174);
            this.dgvPagoOrdenes.TabIndex = 66;
            this.dgvPagoOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagoOrdenes_CellClick);
            // 
            // btnSalir_frm_usuarios
            // 
            this.btnSalir_frm_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir_frm_usuarios.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir_frm_usuarios.IconColor = System.Drawing.Color.Black;
            this.btnSalir_frm_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir_frm_usuarios.IconSize = 25;
            this.btnSalir_frm_usuarios.Location = new System.Drawing.Point(898, 499);
            this.btnSalir_frm_usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir_frm_usuarios.Name = "btnSalir_frm_usuarios";
            this.btnSalir_frm_usuarios.Size = new System.Drawing.Size(129, 31);
            this.btnSalir_frm_usuarios.TabIndex = 60;
            this.btnSalir_frm_usuarios.Text = "Salir";
            this.btnSalir_frm_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir_frm_usuarios.UseVisualStyleBackColor = true;
            this.btnSalir_frm_usuarios.Click += new System.EventHandler(this.btnSalir_frm_usuarios_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(882, 109);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 17);
            this.lblFecha.TabIndex = 64;
            this.lblFecha.Text = "Imprimir fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(785, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fecha actual:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_descuento);
            this.groupBox1.Controls.Add(this.txt_propina);
            this.groupBox1.Controls.Add(this.dtp_calendario);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbx_estado);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbx_mtd_pago);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.cbx_monto_orden);
            this.groupBox1.Controls.Add(this.cbx_Orden_encabezados);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_impuesto);
            this.groupBox1.Controls.Add(this.txt_codigo_pago_orden);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(27, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1087, 183);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // dtp_calendario
            // 
            this.dtp_calendario.Location = new System.Drawing.Point(689, 146);
            this.dtp_calendario.Name = "dtp_calendario";
            this.dtp_calendario.Size = new System.Drawing.Size(161, 22);
            this.dtp_calendario.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(568, 150);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha Pago";
            // 
            // cbx_estado
            // 
            this.cbx_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.ItemHeight = 16;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(686, 113);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(165, 24);
            this.cbx_estado.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(568, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Estado";
            // 
            // cbx_mtd_pago
            // 
            this.cbx_mtd_pago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_mtd_pago.FormattingEnabled = true;
            this.cbx_mtd_pago.ItemHeight = 16;
            this.cbx_mtd_pago.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_mtd_pago.Location = new System.Drawing.Point(686, 80);
            this.cbx_mtd_pago.Name = "cbx_mtd_pago";
            this.cbx_mtd_pago.Size = new System.Drawing.Size(165, 24);
            this.cbx_mtd_pago.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(568, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Metodo Pago";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Propina";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_total.Location = new System.Drawing.Point(686, 47);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(165, 22);
            this.txt_total.TabIndex = 23;
            // 
            // cbx_monto_orden
            // 
            this.cbx_monto_orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_monto_orden.FormattingEnabled = true;
            this.cbx_monto_orden.ItemHeight = 16;
            this.cbx_monto_orden.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_monto_orden.Location = new System.Drawing.Point(258, 79);
            this.cbx_monto_orden.Name = "cbx_monto_orden";
            this.cbx_monto_orden.Size = new System.Drawing.Size(165, 24);
            this.cbx_monto_orden.TabIndex = 21;
            // 
            // cbx_Orden_encabezados
            // 
            this.cbx_Orden_encabezados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Orden_encabezados.FormattingEnabled = true;
            this.cbx_Orden_encabezados.ItemHeight = 16;
            this.cbx_Orden_encabezados.Location = new System.Drawing.Point(258, 48);
            this.cbx_Orden_encabezados.Name = "cbx_Orden_encabezados";
            this.cbx_Orden_encabezados.Size = new System.Drawing.Size(165, 24);
            this.cbx_Orden_encabezados.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(919, 129);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(919, 76);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.Location = new System.Drawing.Point(919, 31);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_impuesto.Location = new System.Drawing.Point(258, 150);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(165, 22);
            this.txt_impuesto.TabIndex = 4;
            // 
            // txt_codigo_pago_orden
            // 
            this.txt_codigo_pago_orden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_codigo_pago_orden.Enabled = false;
            this.txt_codigo_pago_orden.Location = new System.Drawing.Point(258, 14);
            this.txt_codigo_pago_orden.Name = "txt_codigo_pago_orden";
            this.txt_codigo_pago_orden.Size = new System.Drawing.Size(165, 22);
            this.txt_codigo_pago_orden.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Pago";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Orden";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Orden Encabezados";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Pago";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Reporte);
            this.tabPage3.Controls.Add(this.btn_cancelarBus_Usuario);
            this.tabPage3.Controls.Add(this.btn_Bus_emple_sin_name);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dvg_empleados_sin_Usuarios);
            this.tabPage3.Controls.Add(this.txt_buscar_empleado);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1121, 606);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Buscar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btn_Reporte.IconColor = System.Drawing.Color.Black;
            this.btn_Reporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Reporte.IconSize = 25;
            this.btn_Reporte.Location = new System.Drawing.Point(842, 456);
            this.btn_Reporte.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(129, 31);
            this.btn_Reporte.TabIndex = 71;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarBus_Usuario
            // 
            this.btn_cancelarBus_Usuario.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btn_cancelarBus_Usuario.IconColor = System.Drawing.Color.Black;
            this.btn_cancelarBus_Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelarBus_Usuario.IconSize = 25;
            this.btn_cancelarBus_Usuario.Location = new System.Drawing.Point(833, 136);
            this.btn_cancelarBus_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelarBus_Usuario.Name = "btn_cancelarBus_Usuario";
            this.btn_cancelarBus_Usuario.Size = new System.Drawing.Size(129, 31);
            this.btn_cancelarBus_Usuario.TabIndex = 70;
            this.btn_cancelarBus_Usuario.Text = "Limpiar";
            this.btn_cancelarBus_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelarBus_Usuario.UseVisualStyleBackColor = true;
            // 
            // btn_Bus_emple_sin_name
            // 
            this.btn_Bus_emple_sin_name.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_Bus_emple_sin_name.IconColor = System.Drawing.Color.Black;
            this.btn_Bus_emple_sin_name.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Bus_emple_sin_name.IconSize = 25;
            this.btn_Bus_emple_sin_name.Location = new System.Drawing.Point(833, 96);
            this.btn_Bus_emple_sin_name.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Bus_emple_sin_name.Name = "btn_Bus_emple_sin_name";
            this.btn_Bus_emple_sin_name.Size = new System.Drawing.Size(129, 31);
            this.btn_Bus_emple_sin_name.TabIndex = 69;
            this.btn_Bus_emple_sin_name.Text = "Buscar";
            this.btn_Bus_emple_sin_name.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Bus_emple_sin_name.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 62);
            this.panel1.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(386, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Datos Empleados";
            // 
            // dvg_empleados_sin_Usuarios
            // 
            this.dvg_empleados_sin_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvg_empleados_sin_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_empleados_sin_Usuarios.Location = new System.Drawing.Point(46, 180);
            this.dvg_empleados_sin_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dvg_empleados_sin_Usuarios.Name = "dvg_empleados_sin_Usuarios";
            this.dvg_empleados_sin_Usuarios.ReadOnly = true;
            this.dvg_empleados_sin_Usuarios.RowHeadersWidth = 51;
            this.dvg_empleados_sin_Usuarios.RowTemplate.Height = 24;
            this.dvg_empleados_sin_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_empleados_sin_Usuarios.Size = new System.Drawing.Size(946, 228);
            this.dvg_empleados_sin_Usuarios.TabIndex = 67;
            // 
            // txt_buscar_empleado
            // 
            this.txt_buscar_empleado.Location = new System.Drawing.Point(225, 110);
            this.txt_buscar_empleado.Name = "txt_buscar_empleado";
            this.txt_buscar_empleado.Size = new System.Drawing.Size(563, 22);
            this.txt_buscar_empleado.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nombre del Empleado";
            // 
            // tabControl_detall_ordenes
            // 
            this.tabControl_detall_ordenes.Controls.Add(this.tabPage1);
            this.tabControl_detall_ordenes.Controls.Add(this.tabPage2);
            this.tabControl_detall_ordenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_detall_ordenes.Location = new System.Drawing.Point(0, 0);
            this.tabControl_detall_ordenes.Name = "tabControl_detall_ordenes";
            this.tabControl_detall_ordenes.SelectedIndex = 0;
            this.tabControl_detall_ordenes.Size = new System.Drawing.Size(1132, 523);
            this.tabControl_detall_ordenes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage1.Controls.Add(this.tabControl_Usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1124, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1124, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // txt_propina
            // 
            this.txt_propina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_propina.Location = new System.Drawing.Point(258, 119);
            this.txt_propina.Name = "txt_propina";
            this.txt_propina.Size = new System.Drawing.Size(165, 22);
            this.txt_propina.TabIndex = 33;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_descuento.Location = new System.Drawing.Point(685, 16);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(165, 22);
            this.txt_descuento.TabIndex = 34;
            // 
            // frm_pago_ordens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1132, 523);
            this.Controls.Add(this.tabControl_detall_ordenes);
            this.Name = "frm_pago_ordens";
            this.Text = "frm_pago_ordens";
            this.Load += new System.EventHandler(this.frm_pago_ordens_Load);
            this.tabControl_Usuarios.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).EndInit();
            this.tabControl_detall_ordenes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Usuarios;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPagoOrdenes;
        private FontAwesome.Sharp.IconButton btnSalir_frm_usuarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cbx_monto_orden;
        private System.Windows.Forms.ComboBox cbx_Orden_encabezados;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txt_impuesto;
        private System.Windows.Forms.TextBox txt_codigo_pago_orden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private FontAwesome.Sharp.IconButton btn_Reporte;
        private FontAwesome.Sharp.IconButton btn_cancelarBus_Usuario;
        private FontAwesome.Sharp.IconButton btn_Bus_emple_sin_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dvg_empleados_sin_Usuarios;
        private System.Windows.Forms.TextBox txt_buscar_empleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl_detall_ordenes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbx_mtd_pago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_calendario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_propina;
        private System.Windows.Forms.TextBox txt_descuento;
    }
}