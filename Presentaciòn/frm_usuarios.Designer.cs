namespace Presentaciòn
{
    partial class frm_usuarios
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar_usuario = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalir_frm_usuarios = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.cbx_rol = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_asignar_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.txt_codigo_empleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelarBus_Usuario = new FontAwesome.Sharp.IconButton();
            this.btn_Bus_emple_sin_name = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dvg_empleados_sin_Usuarios = new System.Windows.Forms.DataGridView();
            this.txt_buscar_empleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl_Usuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Usuarios
            // 
            this.tabControl_Usuarios.Controls.Add(this.tabPage1);
            this.tabControl_Usuarios.Controls.Add(this.tabPage2);
            this.tabControl_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Usuarios.Location = new System.Drawing.Point(3, 2);
            this.tabControl_Usuarios.Name = "tabControl_Usuarios";
            this.tabControl_Usuarios.SelectedIndex = 0;
            this.tabControl_Usuarios.Size = new System.Drawing.Size(1046, 614);
            this.tabControl_Usuarios.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Usuarios.TabIndex = 0;
            this.tabControl_Usuarios.SelectedIndexChanged += new System.EventHandler(this.tabControl_Usuarios_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnEliminar_usuario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvUsuarios);
            this.tabPage1.Controls.Add(this.btnSalir_frm_usuarios);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Usuarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 62);
            this.panel2.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 26);
            this.label8.TabIndex = 63;
            this.label8.Text = "Creaciòn de Usuarios";
            // 
            // btnEliminar_usuario
            // 
            this.btnEliminar_usuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar_usuario.IconColor = System.Drawing.Color.Black;
            this.btnEliminar_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar_usuario.IconSize = 25;
            this.btnEliminar_usuario.Location = new System.Drawing.Point(655, 524);
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
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(31, 276);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(956, 228);
            this.dgvUsuarios.TabIndex = 66;
            this.dgvUsuarios.Click += new System.EventHandler(this.dgvUsuarios_Click);
            // 
            // btnSalir_frm_usuarios
            // 
            this.btnSalir_frm_usuarios.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir_frm_usuarios.IconColor = System.Drawing.Color.Black;
            this.btnSalir_frm_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir_frm_usuarios.IconSize = 25;
            this.btnSalir_frm_usuarios.Location = new System.Drawing.Point(812, 524);
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
            this.lblFecha.Location = new System.Drawing.Point(855, 69);
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
            this.label9.Location = new System.Drawing.Point(758, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fecha actual:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_estado);
            this.groupBox1.Controls.Add(this.cbx_rol);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_contrasena);
            this.groupBox1.Controls.Add(this.txt_asignar_nombre_usuario);
            this.groupBox1.Controls.Add(this.txt_nombre_empleado);
            this.groupBox1.Controls.Add(this.txt_codigo_empleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1004, 152);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // cbx_estado
            // 
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.ItemHeight = 16;
            this.cbx_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_estado.Location = new System.Drawing.Point(612, 90);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(165, 24);
            this.cbx_estado.TabIndex = 19;
            // 
            // cbx_rol
            // 
            this.cbx_rol.FormattingEnabled = true;
            this.cbx_rol.ItemHeight = 16;
            this.cbx_rol.Items.AddRange(new object[] {
            "Admin",
            "Cocina",
            "Mesa",
            "Caja",
            "Bodega"});
            this.cbx_rol.Location = new System.Drawing.Point(612, 59);
            this.cbx_rol.Name = "cbx_rol";
            this.cbx_rol.Size = new System.Drawing.Size(165, 24);
            this.cbx_rol.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(860, 93);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(860, 56);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 31);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.Location = new System.Drawing.Point(860, 21);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 31);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(612, 23);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(165, 22);
            this.txt_contrasena.TabIndex = 4;
            // 
            // txt_asignar_nombre_usuario
            // 
            this.txt_asignar_nombre_usuario.Location = new System.Drawing.Point(258, 95);
            this.txt_asignar_nombre_usuario.Name = "txt_asignar_nombre_usuario";
            this.txt_asignar_nombre_usuario.Size = new System.Drawing.Size(165, 22);
            this.txt_asignar_nombre_usuario.TabIndex = 3;
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Enabled = false;
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(258, 62);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(165, 20);
            this.txt_nombre_empleado.TabIndex = 2;
            // 
            // txt_codigo_empleado
            // 
            this.txt_codigo_empleado.Enabled = false;
            this.txt_codigo_empleado.Location = new System.Drawing.Point(258, 25);
            this.txt_codigo_empleado.Name = "txt_codigo_empleado";
            this.txt_codigo_empleado.Size = new System.Drawing.Size(165, 22);
            this.txt_codigo_empleado.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Còdigo Empleado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelarBus_Usuario);
            this.tabPage2.Controls.Add(this.btn_Bus_emple_sin_name);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dvg_empleados_sin_Usuarios);
            this.tabPage2.Controls.Add(this.txt_buscar_empleado);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btn_cancelarBus_Usuario.Click += new System.EventHandler(this.btn_cancelarBus_Usuario_Click);
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
            this.btn_Bus_emple_sin_name.Click += new System.EventHandler(this.btn_Bus_emple_sin_name_Click);
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
            this.dvg_empleados_sin_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_empleados_sin_Usuarios_CellClick);
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
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 598);
            this.Controls.Add(this.tabControl_Usuarios);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_usuarios";
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            this.tabControl_Usuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_empleados_sin_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Usuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private FontAwesome.Sharp.IconButton btnEliminar_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconButton btnSalir_frm_usuarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.ComboBox cbx_rol;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_asignar_nombre_usuario;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.TextBox txt_codigo_empleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_buscar_empleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dvg_empleados_sin_Usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btn_Bus_emple_sin_name;
        private FontAwesome.Sharp.IconButton btn_cancelarBus_Usuario;
    }
}