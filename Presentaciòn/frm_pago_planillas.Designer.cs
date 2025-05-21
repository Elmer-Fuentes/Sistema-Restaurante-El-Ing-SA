namespace Presentaciòn
{
	partial class frm_pago_planillas
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label8 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dgvPagoPlanillas = new System.Windows.Forms.DataGridView();
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.btnSalir = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_codigo_pago_planilla = new System.Windows.Forms.TextBox();
			this.btnGuardar = new FontAwesome.Sharp.IconButton();
			this.btnEditar = new FontAwesome.Sharp.IconButton();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbox_estado = new System.Windows.Forms.ComboBox();
			this.lbl_bono = new System.Windows.Forms.Label();
			this.lbl_montototal = new System.Windows.Forms.Label();
			this.cbox_codigoempleado = new System.Windows.Forms.ComboBox();
			this.lbl_salario = new System.Windows.Forms.Label();
			this.DtpFechaPago = new System.Windows.Forms.DateTimePicker();
			this.txtHorasExtras = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPagoPlanillas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkOrange;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(1, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1031, 62);
			this.panel2.TabIndex = 84;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(447, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 26);
			this.label1.TabIndex = 64;
			this.label1.Text = "Pago Planillas";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(633, 78);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 17);
			this.label8.TabIndex = 78;
			this.label8.Text = "Fecha actual:";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(730, 78);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(100, 17);
			this.lblFecha.TabIndex = 79;
			this.lblFecha.Text = "Imprimir fecha:";
			// 
			// dgvPagoPlanillas
			// 
			this.dgvPagoPlanillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPagoPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPagoPlanillas.Location = new System.Drawing.Point(14, 267);
			this.dgvPagoPlanillas.Margin = new System.Windows.Forms.Padding(2);
			this.dgvPagoPlanillas.Name = "dgvPagoPlanillas";
			this.dgvPagoPlanillas.ReadOnly = true;
			this.dgvPagoPlanillas.RowHeadersWidth = 51;
			this.dgvPagoPlanillas.RowTemplate.Height = 24;
			this.dgvPagoPlanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPagoPlanillas.Size = new System.Drawing.Size(1004, 209);
			this.dgvPagoPlanillas.TabIndex = 81;
			this.dgvPagoPlanillas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagoPlanillas_CellClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
			this.btnEliminar.IconColor = System.Drawing.Color.Black;
			this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEliminar.IconSize = 25;
			this.btnEliminar.Location = new System.Drawing.Point(652, 501);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(129, 31);
			this.btnEliminar.TabIndex = 82;
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
			this.btnSalir.Location = new System.Drawing.Point(809, 501);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(129, 31);
			this.btnSalir.TabIndex = 83;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txtHorasExtras);
			this.groupBox1.Controls.Add(this.DtpFechaPago);
			this.groupBox1.Controls.Add(this.lbl_salario);
			this.groupBox1.Controls.Add(this.cbox_codigoempleado);
			this.groupBox1.Controls.Add(this.lbl_montototal);
			this.groupBox1.Controls.Add(this.lbl_bono);
			this.groupBox1.Controls.Add(this.cbox_estado);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnEditar);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.txt_codigo_pago_planilla);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(14, 102);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(1004, 161);
			this.groupBox1.TabIndex = 80;
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo Pago Planilla:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Codigo Empleado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 85);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de Pago:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(476, 18);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Bono:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(476, 49);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Horas Extras:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(476, 81);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Monto Total:";
			// 
			// txt_codigo_pago_planilla
			// 
			this.txt_codigo_pago_planilla.Enabled = false;
			this.txt_codigo_pago_planilla.Location = new System.Drawing.Point(240, 16);
			this.txt_codigo_pago_planilla.Name = "txt_codigo_pago_planilla";
			this.txt_codigo_pago_planilla.ReadOnly = true;
			this.txt_codigo_pago_planilla.Size = new System.Drawing.Size(165, 20);
			this.txt_codigo_pago_planilla.TabIndex = 14;
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
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
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
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(27, 114);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 17);
			this.label9.TabIndex = 53;
			this.label9.Text = "Salario:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(476, 114);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 17);
			this.label10.TabIndex = 54;
			this.label10.Text = "Estado:";
			// 
			// cbox_estado
			// 
			this.cbox_estado.FormattingEnabled = true;
			this.cbox_estado.Items.AddRange(new object[] {
            "Pendiente ",
            "Proceso ",
            "Pagado ",
            "Rechazado"});
			this.cbox_estado.Location = new System.Drawing.Point(617, 110);
			this.cbox_estado.Name = "cbox_estado";
			this.cbox_estado.Size = new System.Drawing.Size(164, 21);
			this.cbox_estado.TabIndex = 55;
			// 
			// lbl_bono
			// 
			this.lbl_bono.AutoSize = true;
			this.lbl_bono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_bono.Location = new System.Drawing.Point(614, 16);
			this.lbl_bono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_bono.Name = "lbl_bono";
			this.lbl_bono.Size = new System.Drawing.Size(98, 17);
			this.lbl_bono.TabIndex = 57;
			this.lbl_bono.Text = "Imprimir Bono:";
			// 
			// lbl_montototal
			// 
			this.lbl_montototal.AutoSize = true;
			this.lbl_montototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_montototal.Location = new System.Drawing.Point(614, 81);
			this.lbl_montototal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_montototal.Name = "lbl_montototal";
			this.lbl_montototal.Size = new System.Drawing.Size(140, 17);
			this.lbl_montototal.TabIndex = 59;
			this.lbl_montototal.Text = "Imprimir Monto Total:";
			// 
			// cbox_codigoempleado
			// 
			this.cbox_codigoempleado.FormattingEnabled = true;
			this.cbox_codigoempleado.Location = new System.Drawing.Point(241, 53);
			this.cbox_codigoempleado.Name = "cbox_codigoempleado";
			this.cbox_codigoempleado.Size = new System.Drawing.Size(164, 21);
			this.cbox_codigoempleado.TabIndex = 61;
			this.cbox_codigoempleado.SelectedIndexChanged += new System.EventHandler(this.cbox_codigoempleado_SelectedIndexChanged_1);
			// 
			// lbl_salario
			// 
			this.lbl_salario.AutoSize = true;
			this.lbl_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_salario.Location = new System.Drawing.Point(261, 114);
			this.lbl_salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_salario.Name = "lbl_salario";
			this.lbl_salario.Size = new System.Drawing.Size(109, 17);
			this.lbl_salario.TabIndex = 56;
			this.lbl_salario.Text = "Imprimir Salario:";
			this.lbl_salario.Click += new System.EventHandler(this.lbl_salario_Click);
			// 
			// DtpFechaPago
			// 
			this.DtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DtpFechaPago.Location = new System.Drawing.Point(240, 86);
			this.DtpFechaPago.Margin = new System.Windows.Forms.Padding(2);
			this.DtpFechaPago.Name = "DtpFechaPago";
			this.DtpFechaPago.Size = new System.Drawing.Size(165, 21);
			this.DtpFechaPago.TabIndex = 62;
			// 
			// txtHorasExtras
			// 
			this.txtHorasExtras.Location = new System.Drawing.Point(617, 53);
			this.txtHorasExtras.Name = "txtHorasExtras";
			this.txtHorasExtras.Size = new System.Drawing.Size(164, 20);
			this.txtHorasExtras.TabIndex = 63;
			this.txtHorasExtras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.btnSalir);
			this.groupBox2.Controls.Add(this.btnEliminar);
			this.groupBox2.Controls.Add(this.dgvPagoPlanillas);
			this.groupBox2.Controls.Add(this.lblFecha);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(1, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1031, 551);
			this.groupBox2.TabIndex = 85;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// frm_pago_planillas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1034, 549);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox2);
			this.Name = "frm_pago_planillas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_pago_planillas";
			this.Load += new System.EventHandler(this.frm_pago_planillas_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPagoPlanillas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DataGridView dgvPagoPlanillas;
		private FontAwesome.Sharp.IconButton btnEliminar;
		private FontAwesome.Sharp.IconButton btnSalir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtHorasExtras;
		private System.Windows.Forms.DateTimePicker DtpFechaPago;
		private System.Windows.Forms.Label lbl_salario;
		private System.Windows.Forms.ComboBox cbox_codigoempleado;
		private System.Windows.Forms.Label lbl_montototal;
		private System.Windows.Forms.Label lbl_bono;
		private System.Windows.Forms.ComboBox cbox_estado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnCancelar;
		private FontAwesome.Sharp.IconButton btnEditar;
		private FontAwesome.Sharp.IconButton btnGuardar;
		private System.Windows.Forms.TextBox txt_codigo_pago_planilla;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}