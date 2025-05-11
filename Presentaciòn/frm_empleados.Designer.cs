namespace Presentaciòn
{
	partial class frm_empleados
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
			this.btnEliminar = new FontAwesome.Sharp.IconButton();
			this.lbl_salario = new System.Windows.Forms.Label();
			this.cbox_estado = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnCancelar = new FontAwesome.Sharp.IconButton();
			this.btnEditar = new FontAwesome.Sharp.IconButton();
			this.btnGuardar = new FontAwesome.Sharp.IconButton();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.txt_codigo_empleado = new System.Windows.Forms.TextBox();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalir = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dtp_contratacion = new System.Windows.Forms.DateTimePicker();
			this.cboxcargo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			// lbl_salario
			// 
			this.lbl_salario.AutoSize = true;
			this.lbl_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_salario.Location = new System.Drawing.Point(614, 18);
			this.lbl_salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_salario.Name = "lbl_salario";
			this.lbl_salario.Size = new System.Drawing.Size(109, 17);
			this.lbl_salario.TabIndex = 56;
			this.lbl_salario.Text = "Imprimir Salario:";
			// 
			// cbox_estado
			// 
			this.cbox_estado.FormattingEnabled = true;
			this.cbox_estado.Items.AddRange(new object[] {
            "Pendiente ",
            "Proceso ",
            "Pagado ",
            "Rechazado"});
			this.cbox_estado.Location = new System.Drawing.Point(617, 87);
			this.cbox_estado.Name = "cbox_estado";
			this.cbox_estado.Size = new System.Drawing.Size(164, 21);
			this.cbox_estado.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(476, 87);
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
			this.label9.Location = new System.Drawing.Point(476, 19);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 17);
			this.label9.TabIndex = 53;
			this.label9.Text = "Salario:";
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
			// txt_Nombre
			// 
			this.txt_Nombre.Location = new System.Drawing.Point(240, 53);
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(165, 20);
			this.txt_Nombre.TabIndex = 15;
			// 
			// txt_codigo_empleado
			// 
			this.txt_codigo_empleado.Enabled = false;
			this.txt_codigo_empleado.Location = new System.Drawing.Point(240, 16);
			this.txt_codigo_empleado.Name = "txt_codigo_empleado";
			this.txt_codigo_empleado.Size = new System.Drawing.Size(165, 20);
			this.txt_codigo_empleado.TabIndex = 14;
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Location = new System.Drawing.Point(15, 241);
			this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.ReadOnly = true;
			this.dgvEmpleados.RowHeadersWidth = 51;
			this.dgvEmpleados.RowTemplate.Height = 24;
			this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmpleados.Size = new System.Drawing.Size(1004, 228);
			this.dgvEmpleados.TabIndex = 63;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboxcargo);
			this.groupBox1.Controls.Add(this.dtp_contratacion);
			this.groupBox1.Controls.Add(this.lbl_salario);
			this.groupBox1.Controls.Add(this.cbox_estado);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnEditar);
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.txt_Nombre);
			this.groupBox1.Controls.Add(this.txt_codigo_empleado);
			this.groupBox1.Controls.Add(this.label7);
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(476, 81);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 17);
			this.label7.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(476, 49);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 17);
			this.label6.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(475, 56);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Fecha Contratacion:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 85);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Cargo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 15);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo Empleado:";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(412, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 26);
			this.label1.TabIndex = 59;
			this.label1.Text = "Empleados";
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
			// dtp_contratacion
			// 
			this.dtp_contratacion.Location = new System.Drawing.Point(615, 53);
			this.dtp_contratacion.Name = "dtp_contratacion";
			this.dtp_contratacion.Size = new System.Drawing.Size(160, 20);
			this.dtp_contratacion.TabIndex = 61;
			// 
			// cboxcargo
			// 
			this.cboxcargo.FormattingEnabled = true;
			this.cboxcargo.Items.AddRange(new object[] {
            "Pendiente ",
            "Proceso ",
            "Pagado ",
            "Rechazado"});
			this.cboxcargo.Location = new System.Drawing.Point(240, 84);
			this.cboxcargo.Name = "cboxcargo";
			this.cboxcargo.Size = new System.Drawing.Size(164, 21);
			this.cboxcargo.TabIndex = 62;
			// 
			// frm_empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 549);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvEmpleados);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label8);
			this.Name = "frm_empleados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_empleados";
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnEliminar;
		private System.Windows.Forms.Label lbl_salario;
		private System.Windows.Forms.ComboBox cbox_estado;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private FontAwesome.Sharp.IconButton btnCancelar;
		private FontAwesome.Sharp.IconButton btnEditar;
		private FontAwesome.Sharp.IconButton btnGuardar;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.TextBox txt_codigo_empleado;
		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private FontAwesome.Sharp.IconButton btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboxcargo;
		private System.Windows.Forms.DateTimePicker dtp_contratacion;
	}
}