namespace Presentaciòn
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
			this.dtp_fechaorden = new System.Windows.Forms.DateTimePicker();
			this.lbl_horasextras = new System.Windows.Forms.Label();
			this.cbox_estado = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_codigocliente = new System.Windows.Forms.TextBox();
			this.txt_codigoorden = new System.Windows.Forms.TextBox();
			this.dgvEncabezadoOrdenes = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.btnEditar = new FontAwesome.Sharp.IconButton();
			this.btnGuardar = new FontAwesome.Sharp.IconButton();
			this.btnSalir = new FontAwesome.Sharp.IconButton();
			this.txt_codigomesa = new System.Windows.Forms.TextBox();
			this.txt_codigoempleado = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadoOrdenes)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtp_fechaorden
			// 
			this.dtp_fechaorden.Location = new System.Drawing.Point(617, 12);
			this.dtp_fechaorden.Name = "dtp_fechaorden";
			this.dtp_fechaorden.Size = new System.Drawing.Size(160, 20);
			this.dtp_fechaorden.TabIndex = 60;
			// 
			// lbl_horasextras
			// 
			this.lbl_horasextras.AutoSize = true;
			this.lbl_horasextras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_horasextras.Location = new System.Drawing.Point(614, 47);
			this.lbl_horasextras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_horasextras.Name = "lbl_horasextras";
			this.lbl_horasextras.Size = new System.Drawing.Size(146, 34);
			this.lbl_horasextras.TabIndex = 58;
			this.lbl_horasextras.Text = "Imprimir Horas Extras:\r\n\r\n";
			// 
			// cbox_estado
			// 
			this.cbox_estado.FormattingEnabled = true;
			this.cbox_estado.Items.AddRange(new object[] {
            "Pendiente ",
            "Proceso ",
            "Pagado ",
            "Rechazado"});
			this.cbox_estado.Location = new System.Drawing.Point(617, 80);
			this.cbox_estado.Name = "cbox_estado";
			this.cbox_estado.Size = new System.Drawing.Size(164, 21);
			this.cbox_estado.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(476, 84);
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
			// txt_codigocliente
			// 
			this.txt_codigocliente.Location = new System.Drawing.Point(240, 53);
			this.txt_codigocliente.Name = "txt_codigocliente";
			this.txt_codigocliente.Size = new System.Drawing.Size(165, 20);
			this.txt_codigocliente.TabIndex = 15;
			// 
			// txt_codigoorden
			// 
			this.txt_codigoorden.Enabled = false;
			this.txt_codigoorden.Location = new System.Drawing.Point(240, 16);
			this.txt_codigoorden.Name = "txt_codigoorden";
			this.txt_codigoorden.ReadOnly = true;
			this.txt_codigoorden.Size = new System.Drawing.Size(165, 20);
			this.txt_codigoorden.TabIndex = 14;
			// 
			// dgvEncabezadoOrdenes
			// 
			this.dgvEncabezadoOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEncabezadoOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEncabezadoOrdenes.Location = new System.Drawing.Point(15, 241);
			this.dgvEncabezadoOrdenes.Margin = new System.Windows.Forms.Padding(2);
			this.dgvEncabezadoOrdenes.Name = "dgvEncabezadoOrdenes";
			this.dgvEncabezadoOrdenes.ReadOnly = true;
			this.dgvEncabezadoOrdenes.RowHeadersWidth = 51;
			this.dgvEncabezadoOrdenes.RowTemplate.Height = 24;
			this.dgvEncabezadoOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEncabezadoOrdenes.Size = new System.Drawing.Size(1004, 228);
			this.dgvEncabezadoOrdenes.TabIndex = 63;
			// 
			// groupBox1
			// 
			this.groupBox1.CausesValidation = false;
			this.groupBox1.Controls.Add(this.txt_codigoempleado);
			this.groupBox1.Controls.Add(this.txt_codigomesa);
			this.groupBox1.Controls.Add(this.dtp_fechaorden);
			this.groupBox1.Controls.Add(this.lbl_horasextras);
			this.groupBox1.Controls.Add(this.cbox_estado);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnEditar);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.txt_codigocliente);
			this.groupBox1.Controls.Add(this.txt_codigoorden);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(15, 70);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(1004, 167);
			this.groupBox1.TabIndex = 62;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(476, 49);
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
			this.label5.Location = new System.Drawing.Point(476, 18);
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
			this.label2.Size = new System.Drawing.Size(104, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo Orden: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(412, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 26);
			this.label1.TabIndex = 59;
			this.label1.Text = "Encabezado Ordenes";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(735, 51);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(100, 17);
			this.lblFecha.TabIndex = 61;
			this.lblFecha.Text = "Imprimir fecha:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(629, 51);
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
			this.btnEliminar.Location = new System.Drawing.Point(653, 494);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(129, 31);
			this.btnEliminar.TabIndex = 64;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
			this.btnCancelar.IconColor = System.Drawing.Color.Black;
			this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCancelar.IconSize = 25;
			this.btnCancelar.Location = new System.Drawing.Point(842, 84);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(129, 31);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
			this.btnEditar.IconColor = System.Drawing.Color.Black;
			this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEditar.IconSize = 25;
			this.btnEditar.Location = new System.Drawing.Point(842, 47);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(129, 31);
			this.btnEditar.TabIndex = 21;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
			this.btnGuardar.IconColor = System.Drawing.Color.Black;
			this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnGuardar.IconSize = 25;
			this.btnGuardar.Location = new System.Drawing.Point(842, 12);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(129, 31);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
			this.btnSalir.IconColor = System.Drawing.Color.Black;
			this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSalir.IconSize = 25;
			this.btnSalir.Location = new System.Drawing.Point(810, 494);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(129, 31);
			this.btnSalir.TabIndex = 65;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// txt_codigomesa
			// 
			this.txt_codigomesa.Enabled = false;
			this.txt_codigomesa.Location = new System.Drawing.Point(240, 84);
			this.txt_codigomesa.Name = "txt_codigomesa";
			this.txt_codigomesa.Size = new System.Drawing.Size(165, 20);
			this.txt_codigomesa.TabIndex = 61;
			// 
			// txt_codigoempleado
			// 
			this.txt_codigoempleado.Enabled = false;
			this.txt_codigoempleado.Location = new System.Drawing.Point(240, 114);
			this.txt_codigoempleado.Name = "txt_codigoempleado";
			this.txt_codigoempleado.Size = new System.Drawing.Size(165, 20);
			this.txt_codigoempleado.TabIndex = 62;
			// 
			// frm_encabezado_ordenes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 549);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvEncabezadoOrdenes);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label8);
			this.Name = "frm_encabezado_ordenes";
			this.Text = "frm_encabezado_ordenes";
			((System.ComponentModel.ISupportInitialize)(this.dgvEncabezadoOrdenes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnEliminar;
		private System.Windows.Forms.DateTimePicker dtp_fechaorden;
		private System.Windows.Forms.Label lbl_horasextras;
		private System.Windows.Forms.ComboBox cbox_estado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnCancelar;
		private FontAwesome.Sharp.IconButton btnEditar;
		private FontAwesome.Sharp.IconButton btnGuardar;
		private System.Windows.Forms.TextBox txt_codigocliente;
		private System.Windows.Forms.TextBox txt_codigoorden;
		private System.Windows.Forms.DataGridView dgvEncabezadoOrdenes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_codigoempleado;
		private System.Windows.Forms.TextBox txt_codigomesa;
	}
}