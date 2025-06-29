﻿namespace Presentaciòn
{
    partial class frm_inventario
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_buscar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_realizabusqueda = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_fechafin = new System.Windows.Forms.DateTimePicker();
            this.dtp_buscarporfechaentrada = new System.Windows.Forms.DateTimePicker();
            this.dgv_buscarclientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvDatosPlanilla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cbox_categorias = new System.Windows.Forms.ComboBox();
            this.cbox_codigomenu = new System.Windows.Forms.ComboBox();
            this.dtm_fechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtm_fechaentrada = new System.Windows.Forms.DateTimePicker();
            this.txt_codigoInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscarclientes)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPlanilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_buscar.IconColor = System.Drawing.Color.Black;
            this.btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar.IconSize = 25;
            this.btn_buscar.Location = new System.Drawing.Point(930, 133);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(55, 31);
            this.btn_buscar.TabIndex = 62;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Del";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 26);
            this.label9.TabIndex = 58;
            this.label9.Text = "Buscar Inventario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(3, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 62);
            this.panel2.TabIndex = 70;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.lbl_realizabusqueda);
            this.tabPage2.Controls.Add(this.pb_foto);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dtp_fechafin);
            this.tabPage2.Controls.Add(this.dtp_buscarporfechaentrada);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgv_buscarclientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1124, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Inventario";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbl_realizabusqueda
            // 
            this.lbl_realizabusqueda.AutoSize = true;
            this.lbl_realizabusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_realizabusqueda.Location = new System.Drawing.Point(524, 215);
            this.lbl_realizabusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_realizabusqueda.Name = "lbl_realizabusqueda";
            this.lbl_realizabusqueda.Size = new System.Drawing.Size(167, 17);
            this.lbl_realizabusqueda.TabIndex = 75;
            this.lbl_realizabusqueda.Text = "Realizar una busqueda...";
            // 
            // pb_foto
            // 
            this.pb_foto.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_foto.Image = global::Presentaciòn.Properties.Resources.restaurantes;
            this.pb_foto.Location = new System.Drawing.Point(374, 235);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(431, 257);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 74;
            this.pb_foto.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(646, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "Hasta";
            // 
            // dtp_fechafin
            // 
            this.dtp_fechafin.Location = new System.Drawing.Point(717, 107);
            this.dtp_fechafin.Name = "dtp_fechafin";
            this.dtp_fechafin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechafin.TabIndex = 72;
            this.dtp_fechafin.ValueChanged += new System.EventHandler(this.dtp_fechafin_ValueChanged);
            // 
            // dtp_buscarporfechaentrada
            // 
            this.dtp_buscarporfechaentrada.Location = new System.Drawing.Point(420, 104);
            this.dtp_buscarporfechaentrada.Name = "dtp_buscarporfechaentrada";
            this.dtp_buscarporfechaentrada.Size = new System.Drawing.Size(200, 20);
            this.dtp_buscarporfechaentrada.TabIndex = 71;
            this.dtp_buscarporfechaentrada.ValueChanged += new System.EventHandler(this.dtp_buscarporfechaentrada_ValueChanged);
            // 
            // dgv_buscarclientes
            // 
            this.dgv_buscarclientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_buscarclientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_buscarclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscarclientes.Location = new System.Drawing.Point(55, 235);
            this.dgv_buscarclientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_buscarclientes.Name = "dgv_buscarclientes";
            this.dgv_buscarclientes.ReadOnly = true;
            this.dgv_buscarclientes.RowHeadersWidth = 51;
            this.dgv_buscarclientes.RowTemplate.Height = 24;
            this.dgv_buscarclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buscarclientes.Size = new System.Drawing.Size(1118, 262);
            this.dgv_buscarclientes.TabIndex = 55;
            this.dgv_buscarclientes.Visible = false;
            this.dgv_buscarclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscarclientes_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(923, 88);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 31);
            this.btnCancelar.TabIndex = 26;
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
            this.btnEditar.Location = new System.Drawing.Point(923, 51);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 31);
            this.btnEditar.TabIndex = 25;
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
            this.btnGuardar.Location = new System.Drawing.Point(923, 16);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 31);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1132, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.dgvDatosPlanilla);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1124, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 62);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Inventario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(738, 448);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 31);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(976, 70);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 17);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Text = "Imprimir fecha:";
            // 
            // dgvDatosPlanilla
            // 
            this.dgvDatosPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosPlanilla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDatosPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPlanilla.Location = new System.Drawing.Point(2, 242);
            this.dgvDatosPlanilla.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosPlanilla.Name = "dgvDatosPlanilla";
            this.dgvDatosPlanilla.ReadOnly = true;
            this.dgvDatosPlanilla.RowHeadersWidth = 51;
            this.dgvDatosPlanilla.RowTemplate.Height = 24;
            this.dgvDatosPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosPlanilla.Size = new System.Drawing.Size(1099, 188);
            this.dgvDatosPlanilla.TabIndex = 54;
            this.dgvDatosPlanilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosPlanilla_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(895, 448);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 31);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_Cantidad);
            this.groupBox1.Controls.Add(this.cbox_categorias);
            this.groupBox1.Controls.Add(this.cbox_codigomenu);
            this.groupBox1.Controls.Add(this.dtm_fechavencimiento);
            this.groupBox1.Controls.Add(this.dtm_fechaentrada);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_codigoInventario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1089, 135);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(685, 18);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(39, 20);
            this.nud_Cantidad.TabIndex = 31;
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            // 
            // cbox_categorias
            // 
            this.cbox_categorias.FormattingEnabled = true;
            this.cbox_categorias.Location = new System.Drawing.Point(214, 102);
            this.cbox_categorias.Name = "cbox_categorias";
            this.cbox_categorias.Size = new System.Drawing.Size(165, 21);
            this.cbox_categorias.TabIndex = 30;
            this.cbox_categorias.SelectedIndexChanged += new System.EventHandler(this.cbox_categorias_SelectedIndexChanged);
            // 
            // cbox_codigomenu
            // 
            this.cbox_codigomenu.FormattingEnabled = true;
            this.cbox_codigomenu.Location = new System.Drawing.Point(214, 54);
            this.cbox_codigomenu.Name = "cbox_codigomenu";
            this.cbox_codigomenu.Size = new System.Drawing.Size(165, 21);
            this.cbox_codigomenu.TabIndex = 29;
            this.cbox_codigomenu.SelectedIndexChanged += new System.EventHandler(this.cbox_codigomenu_SelectedIndexChanged);
            // 
            // dtm_fechavencimiento
            // 
            this.dtm_fechavencimiento.Location = new System.Drawing.Point(685, 82);
            this.dtm_fechavencimiento.Name = "dtm_fechavencimiento";
            this.dtm_fechavencimiento.Size = new System.Drawing.Size(198, 20);
            this.dtm_fechavencimiento.TabIndex = 28;
            // 
            // dtm_fechaentrada
            // 
            this.dtm_fechaentrada.Location = new System.Drawing.Point(685, 51);
            this.dtm_fechaentrada.Name = "dtm_fechaentrada";
            this.dtm_fechaentrada.Size = new System.Drawing.Size(198, 20);
            this.dtm_fechaentrada.TabIndex = 27;
            // 
            // txt_codigoInventario
            // 
            this.txt_codigoInventario.Enabled = false;
            this.txt_codigoInventario.Location = new System.Drawing.Point(214, 15);
            this.txt_codigoInventario.Name = "txt_codigoInventario";
            this.txt_codigoInventario.Size = new System.Drawing.Size(165, 20);
            this.txt_codigoInventario.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Inventario:";
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1132, 523);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_inventario";
            this.Text = "frm_inventario";
            this.Load += new System.EventHandler(this.frm_inventario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscarclientes)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPlanilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_buscarclientes;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvDatosPlanilla;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_codigoInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_fechavencimiento;
        private System.Windows.Forms.DateTimePicker dtm_fechaentrada;
        private System.Windows.Forms.ComboBox cbox_codigomenu;
        private System.Windows.Forms.ComboBox cbox_categorias;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.DateTimePicker dtp_buscarporfechaentrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_fechafin;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label lbl_realizabusqueda;
    }
}