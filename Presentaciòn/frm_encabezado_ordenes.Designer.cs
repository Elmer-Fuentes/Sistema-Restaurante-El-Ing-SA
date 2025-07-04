﻿namespace Presentaciòn
{
	partial class frm_encabezado_ordenes
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
			this.lbl_MontoTotal = new System.Windows.Forms.Label();
			this.cbox_estado = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dgvEncabezadoOrdenes = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbox_CodigoOrdenEnc = new System.Windows.Forms.ComboBox();
			this.cbox_CodigoEmpleado = new System.Windows.Forms.ComboBox();
			this.cbox_CodigoMesa = new System.Windows.Forms.ComboBox();
			this.cbox_CodigoCliente = new System.Windows.Forms.ComboBox();
			this.DtpFechaOrden = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.btnEditar = new FontAwesome.Sharp.IconButton();
			this.btnGuardar = new FontAwesome.Sharp.IconButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.btnSalir = new FontAwesome.Sharp.IconButton();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadoOrdenes)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_MontoTotal
			// 
			this.lbl_MontoTotal.AutoSize = true;
			this.lbl_MontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_MontoTotal.Location = new System.Drawing.Point(708, 48);
			this.lbl_MontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_MontoTotal.Name = "lbl_MontoTotal";
			this.lbl_MontoTotal.Size = new System.Drawing.Size(36, 17);
			this.lbl_MontoTotal.TabIndex = 58;
			this.lbl_MontoTotal.Text = "0.00";
			// 
			// cbox_estado
			// 
			this.cbox_estado.FormattingEnabled = true;
			this.cbox_estado.Items.AddRange(new object[] {
            "Creado",
            "Preparacion",
            "Entregado",
            "Finalizado",
            "Cancelado"});
			this.cbox_estado.Location = new System.Drawing.Point(702, 91);
			this.cbox_estado.Name = "cbox_estado";
			this.cbox_estado.Size = new System.Drawing.Size(164, 21);
			this.cbox_estado.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(561, 85);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 17);
			this.label10.TabIndex = 54;
			this.label10.Text = "Estado:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(27, 114);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 17);
			this.label9.TabIndex = 53;
			this.label9.Text = "Codigo Empleado:";
			// 
			// dgvEncabezadoOrdenes
			// 
			this.dgvEncabezadoOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEncabezadoOrdenes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvEncabezadoOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEncabezadoOrdenes.Location = new System.Drawing.Point(14, 263);
			this.dgvEncabezadoOrdenes.Margin = new System.Windows.Forms.Padding(2);
			this.dgvEncabezadoOrdenes.Name = "dgvEncabezadoOrdenes";
			this.dgvEncabezadoOrdenes.ReadOnly = true;
			this.dgvEncabezadoOrdenes.RowHeadersWidth = 51;
			this.dgvEncabezadoOrdenes.RowTemplate.Height = 24;
			this.dgvEncabezadoOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEncabezadoOrdenes.Size = new System.Drawing.Size(1109, 206);
			this.dgvEncabezadoOrdenes.TabIndex = 63;
			this.dgvEncabezadoOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncabezadoOrdenes_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox1.CausesValidation = false;
			this.groupBox1.Controls.Add(this.cbox_CodigoOrdenEnc);
			this.groupBox1.Controls.Add(this.cbox_CodigoEmpleado);
			this.groupBox1.Controls.Add(this.cbox_CodigoMesa);
			this.groupBox1.Controls.Add(this.cbox_CodigoCliente);
			this.groupBox1.Controls.Add(this.DtpFechaOrden);
			this.groupBox1.Controls.Add(this.lbl_MontoTotal);
			this.groupBox1.Controls.Add(this.cbox_estado);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnEditar);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(14, 92);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(1109, 167);
			this.groupBox1.TabIndex = 62;
			this.groupBox1.TabStop = false;
			// 
			// cbox_CodigoOrdenEnc
			// 
			this.cbox_CodigoOrdenEnc.FormattingEnabled = true;
			this.cbox_CodigoOrdenEnc.Location = new System.Drawing.Point(241, 11);
			this.cbox_CodigoOrdenEnc.Name = "cbox_CodigoOrdenEnc";
			this.cbox_CodigoOrdenEnc.Size = new System.Drawing.Size(164, 21);
			this.cbox_CodigoOrdenEnc.TabIndex = 68;
			this.cbox_CodigoOrdenEnc.SelectedIndexChanged += new System.EventHandler(this.cbox_CodigoOrdenEnc_SelectedIndexChanged);
			// 
			// cbox_CodigoEmpleado
			// 
			this.cbox_CodigoEmpleado.FormattingEnabled = true;
			this.cbox_CodigoEmpleado.Location = new System.Drawing.Point(240, 110);
			this.cbox_CodigoEmpleado.Name = "cbox_CodigoEmpleado";
			this.cbox_CodigoEmpleado.Size = new System.Drawing.Size(164, 21);
			this.cbox_CodigoEmpleado.TabIndex = 67;
			// 
			// cbox_CodigoMesa
			// 
			this.cbox_CodigoMesa.FormattingEnabled = true;
			this.cbox_CodigoMesa.Location = new System.Drawing.Point(241, 81);
			this.cbox_CodigoMesa.Name = "cbox_CodigoMesa";
			this.cbox_CodigoMesa.Size = new System.Drawing.Size(164, 21);
			this.cbox_CodigoMesa.TabIndex = 66;
			// 
			// cbox_CodigoCliente
			// 
			this.cbox_CodigoCliente.FormattingEnabled = true;
			this.cbox_CodigoCliente.Location = new System.Drawing.Point(241, 46);
			this.cbox_CodigoCliente.Name = "cbox_CodigoCliente";
			this.cbox_CodigoCliente.Size = new System.Drawing.Size(164, 21);
			this.cbox_CodigoCliente.TabIndex = 65;
			// 
			// DtpFechaOrden
			// 
			this.DtpFechaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DtpFechaOrden.Location = new System.Drawing.Point(701, 13);
			this.DtpFechaOrden.Margin = new System.Windows.Forms.Padding(2);
			this.DtpFechaOrden.Name = "DtpFechaOrden";
			this.DtpFechaOrden.Size = new System.Drawing.Size(165, 21);
			this.DtpFechaOrden.TabIndex = 64;
			// 
			// btnCancelar
			// 
			this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
			this.btnCancelar.IconColor = System.Drawing.Color.Black;
			this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancelar.IconSize = 25;
			this.btnCancelar.Location = new System.Drawing.Point(927, 85);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(129, 31);
			this.btnCancelar.TabIndex = 22;
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
			this.btnEditar.Location = new System.Drawing.Point(927, 48);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(129, 31);
			this.btnEditar.TabIndex = 21;
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
			this.btnGuardar.Location = new System.Drawing.Point(927, 13);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(129, 31);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(561, 50);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Monto Total Orden:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(561, 19);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Fecha Orden: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 85);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Codigo Mesa:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Codigo Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo Orden Enc: ";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(737, 73);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(100, 17);
			this.lblFecha.TabIndex = 61;
			this.lblFecha.Text = "Imprimir fecha:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(628, 73);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 17);
			this.label8.TabIndex = 60;
			this.label8.Text = "Fecha actual:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnEliminar.IconColor = System.Drawing.Color.Black;
			this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEliminar.IconSize = 25;
			this.btnEliminar.Location = new System.Drawing.Point(767, 481);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(129, 31);
			this.btnEliminar.TabIndex = 64;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
			this.btnSalir.IconColor = System.Drawing.Color.Black;
			this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSalir.IconSize = 25;
			this.btnSalir.Location = new System.Drawing.Point(924, 481);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(129, 31);
			this.btnSalir.TabIndex = 65;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(419, 18);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(240, 26);
			this.label11.TabIndex = 64;
			this.label11.Text = "Encabezado Ordenes";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkOrange;
			this.panel2.Controls.Add(this.label11);
			this.panel2.Location = new System.Drawing.Point(-5, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1141, 62);
			this.panel2.TabIndex = 86;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnEliminar);
			this.groupBox2.Controls.Add(this.dgvEncabezadoOrdenes);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.btnSalir);
			this.groupBox2.Controls.Add(this.lblFecha);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(-2, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1138, 546);
			this.groupBox2.TabIndex = 87;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// frm_encabezado_ordenes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1132, 523);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox2);
			this.Name = "frm_encabezado_ordenes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_encabezado_ordenes";
			this.Load += new System.EventHandler(this.frm_encabezado_ordenes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadoOrdenes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnEliminar;
		private System.Windows.Forms.Label lbl_MontoTotal;
		private System.Windows.Forms.ComboBox cbox_estado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnCancelar;
		private FontAwesome.Sharp.IconButton btnEditar;
		private FontAwesome.Sharp.IconButton btnGuardar;
		private System.Windows.Forms.DataGridView dgvEncabezadoOrdenes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnSalir;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker DtpFechaOrden;
		private System.Windows.Forms.ComboBox cbox_CodigoEmpleado;
		private System.Windows.Forms.ComboBox cbox_CodigoMesa;
		private System.Windows.Forms.ComboBox cbox_CodigoCliente;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbox_CodigoOrdenEnc;
	}
}