using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVistaCalificacionEstudiante : Form
    {
        public FrmVistaCalificacionEstudiante()
        {
            InitializeComponent();
        }

        //Metodo ocultar columnas
        private void Ocultar()
        {
            this.dtListado.Columns[0].Visible = false;
            this.dtListado.Columns[1].Visible = false;
            this.dtListado.Columns[4].Visible = false;
            this.dtListado.Columns[5].Visible = false;
            this.dtListado.Columns[6].Visible = false;
            this.dtListado.Columns[7].Visible = false;
            this.dtListado.Columns[8].Visible = false;
            this.dtListado.Columns[9].Visible = false;
            this.dtListado.Columns[10].Visible = false;
            this.dtListado.Columns[11].Visible = false;
            this.dtListado.Columns[12].Visible = false;
            this.dtListado.Columns[13].Visible = false;
            this.dtListado.Columns[15].Visible = false;
            this.dtListado.Columns[16].Visible = false;
            this.dtListado.Columns[17].Visible = false;
            this.dtListado.Columns[18].Visible = false;
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dtListado.DataSource = NegocioEstudiante.Mostrar();
            this.Ocultar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Metodo Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioCalificacion.BuscarNombreEstudiante(this.txtBuscar.Text);
            this.Ocultar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        private void FrmVistaCalificacionEstudiante_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBuscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
            this.txtBuscar.Text = string.Empty;
        }

        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            FrmCalificacion F = FrmCalificacion.GetInstancia();
            string parametro1, parametro2, parametro3;
            parametro1 = Convert.ToString(this.dtListado.CurrentRow.Cells["IdEstudiante"].Value);
            parametro2 = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre"].Value);
            parametro3 = Convert.ToString(this.dtListado.CurrentRow.Cells["AñoEscolar"].Value);
            F.EnviarEstudiante(parametro1, parametro2, parametro3);
            this.Hide();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
