using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn
{
	public partial class frm_encabezado_ordenes : Form
	{
		public frm_encabezado_ordenes()
		{
			InitializeComponent();
		}

		private void frm_encabezado_ordenes_Load(object sender, EventArgs e)
		{
			style();
		}
		public void style()
		{
			this.ControlBox = false; // Oculta los botones de la barra de título
			this.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
		}

	}
}
