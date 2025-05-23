namespace Presentaciòn
{
    partial class frm_detalle_ordenes
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvg_empleados_sin_Usuarios = new System.Windows.Forms.DataGridView();
            this.txt_buscar_empleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Reporte = new FontAwesome.Sharp.IconButton();
            this.btn_cancelarBus_Usuario = new FontAwesome.Sharp.IconButton();
            this.btn_Bus_emple_sin_name = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_precioMenu_unitario = new System.Windows.Forms.ComboBox();
            this.txt_precio_total = new System.Windows.Forms.TextBox();
            this.cbx_codigo_menu = new System.Windows.Forms.ComboBox();
            this.cbx_Orden_encabezados = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar_usuario = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdetalleOrdenes = new System.Windows.Forms.DataGridView();
            this.btnSalir_frm_usuarios = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_codgo_orden_detalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_detall_ordenes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl_Usuarios = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleOrdenes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl_detall_ordenes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl_Usuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1124, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
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
            // cbx_precioMenu_unitario
            // 
            this.cbx_precioMenu_unitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_precioMenu_unitario.FormattingEnabled = true;
            this.cbx_precioMenu_unitario.ItemHeight = 16;
            this.cbx_precioMenu_unitario.Location = new System.Drawing.Point(689, 56);
            this.cbx_precioMenu_unitario.Name = "cbx_precioMenu_unitario";
            this.cbx_precioMenu_unitario.Size = new System.Drawing.Size(165, 24);
            this.cbx_precioMenu_unitario.TabIndex = 24;
            // 
            // txt_precio_total
            // 
            this.txt_precio_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_precio_total.Location = new System.Drawing.Point(689, 89);
            this.txt_precio_total.Name = "txt_precio_total";
            this.txt_precio_total.Size = new System.Drawing.Size(165, 22);
            this.txt_precio_total.TabIndex = 23;
            // 
            // cbx_codigo_menu
            // 
            this.cbx_codigo_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_codigo_menu.FormattingEnabled = true;
            this.cbx_codigo_menu.ItemHeight = 16;
            this.cbx_codigo_menu.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_codigo_menu.Location = new System.Drawing.Point(258, 90);
            this.cbx_codigo_menu.Name = "cbx_codigo_menu";
            this.cbx_codigo_menu.Size = new System.Drawing.Size(165, 24);
            this.cbx_codigo_menu.TabIndex = 21;
            this.cbx_codigo_menu.SelectedIndexChanged += new System.EventHandler(this.cbx_codigo_menu_SelectedIndexChanged);
            // 
            // cbx_Orden_encabezados
            // 
            this.cbx_Orden_encabezados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_Orden_encabezados.FormattingEnabled = true;
            this.cbx_Orden_encabezados.ItemHeight = 16;
            this.cbx_Orden_encabezados.Location = new System.Drawing.Point(258, 59);
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
            this.btnCancelar.Location = new System.Drawing.Point(943, 84);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(943, 47);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.btnEliminar_usuario);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.dgvdetalleOrdenes);
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
            this.label8.Size = new System.Drawing.Size(184, 26);
            this.label8.TabIndex = 63;
            this.label8.Text = "Detalle Ordenes";
            // 
            // btnEliminar_usuario
            // 
            this.btnEliminar_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar_usuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar_usuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminar_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar_usuario.IconSize = 25;
            this.btnEliminar_usuario.Location = new System.Drawing.Point(741, 486);
            this.btnEliminar_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar_usuario.Name = "btnEliminar_usuario";
            this.btnEliminar_usuario.Size = new System.Drawing.Size(129, 31);
            this.btnEliminar_usuario.TabIndex = 61;
            this.btnEliminar_usuario.Text = "Eliminar";
            this.btnEliminar_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar_usuario.UseVisualStyleBackColor = true;
            this.btnEliminar_usuario.Click += new System.EventHandler(this.btnEliminar_usuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 59;
            // 
            // dgvdetalleOrdenes
            // 
            this.dgvdetalleOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalleOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdetalleOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdetalleOrdenes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvdetalleOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleOrdenes.Location = new System.Drawing.Point(31, 264);
            this.dgvdetalleOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdetalleOrdenes.Name = "dgvdetalleOrdenes";
            this.dgvdetalleOrdenes.ReadOnly = true;
            this.dgvdetalleOrdenes.RowHeadersWidth = 51;
            this.dgvdetalleOrdenes.RowTemplate.Height = 24;
            this.dgvdetalleOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalleOrdenes.Size = new System.Drawing.Size(1083, 208);
            this.dgvdetalleOrdenes.TabIndex = 66;
            this.dgvdetalleOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalleOrdenes_CellClick);
            // 
            // btnSalir_frm_usuarios
            // 
            this.btnSalir_frm_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir_frm_usuarios.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir_frm_usuarios.IconColor = System.Drawing.Color.Black;
            this.btnSalir_frm_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir_frm_usuarios.IconSize = 25;
            this.btnSalir_frm_usuarios.Location = new System.Drawing.Point(898, 486);
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
            this.groupBox1.Controls.Add(this.cbx_precioMenu_unitario);
            this.groupBox1.Controls.Add(this.txt_precio_total);
            this.groupBox1.Controls.Add(this.cbx_codigo_menu);
            this.groupBox1.Controls.Add(this.cbx_Orden_encabezados);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.txt_codgo_orden_detalle);
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
            this.groupBox1.Size = new System.Drawing.Size(1087, 126);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.Location = new System.Drawing.Point(943, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_cantidad.Location = new System.Drawing.Point(689, 23);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(165, 22);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // txt_codgo_orden_detalle
            // 
            this.txt_codgo_orden_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_codgo_orden_detalle.Enabled = false;
            this.txt_codgo_orden_detalle.Location = new System.Drawing.Point(258, 25);
            this.txt_codgo_orden_detalle.Name = "txt_codgo_orden_detalle";
            this.txt_codgo_orden_detalle.Size = new System.Drawing.Size(165, 22);
            this.txt_codgo_orden_detalle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio Total";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Códio Menu";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 59);
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
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Orden Detalle";
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
            this.tabControl_detall_ordenes.TabIndex = 1;
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
            // frm_detalle_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1132, 523);
            this.Controls.Add(this.tabControl_detall_ordenes);
            this.Name = "frm_detalle_ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_detalle_ordenes";
            this.Load += new System.EventHandler(this.frm_detalle_ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleOrdenes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_detall_ordenes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl_Usuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvg_empleados_sin_Usuarios;
        private System.Windows.Forms.TextBox txt_buscar_empleado;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btn_Reporte;
        private FontAwesome.Sharp.IconButton btn_cancelarBus_Usuario;
        private FontAwesome.Sharp.IconButton btn_Bus_emple_sin_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_precioMenu_unitario;
        private System.Windows.Forms.TextBox txt_precio_total;
        private System.Windows.Forms.ComboBox cbx_codigo_menu;
        private System.Windows.Forms.ComboBox cbx_Orden_encabezados;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdetalleOrdenes;
        private FontAwesome.Sharp.IconButton btnSalir_frm_usuarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_codgo_orden_detalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl_detall_ordenes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl_Usuarios;
    }
}