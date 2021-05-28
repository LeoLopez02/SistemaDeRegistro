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
    public partial class FrmArea : Form
    {

        private bool EsNuevo = false;
        private bool EsEditar = false;

        public FrmArea()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "**Campo obligatorio.**");
            this.LlenarComboBoxCurso();
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo Limpiar
        public void Limpiar()
        {
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.comboCurso.Text = string.Empty;
        }

        //Habilitar Textboxs
        private void Habilitar(bool Valor)
        {
            this.txtId.ReadOnly = !Valor;
            this.txtNombre.ReadOnly = !Valor;
            this.comboCurso.Enabled = Valor;
        }

        //Habilitar Botones
        private void Botones()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnInsertar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnInsertar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Ocultar Columnas
        private void OcultarColumna()
        {
            this.dtListado.Columns[0].Visible = false;
            this.dtListado.Columns[1].Visible = false;
            this.dtListado.Columns[3].Visible = false;
        }

        //Mostrar
        private void Mostrar()
        {
            this.dtListado.DataSource = NegocioArea.Mostrar();
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioArea.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Llenar ComboBox
        private void LlenarComboBoxCurso()
        {
            comboCurso.DataSource = NegocioCursos.Mostrar();
            comboCurso.ValueMember = "IdCurso";
            comboCurso.DisplayMember = "Nombre_Curso";
        }

        private void FrmAreas_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(true);
            this.Botones();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Sistema de Registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string RepuestaEliminar = "";

                    foreach (DataGridViewRow row in dtListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            RepuestaEliminar = NegocioArea.Eliminar(Convert.ToInt32(Codigo));

                            if (RepuestaEliminar.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(RepuestaEliminar);
                            }
                        }
                    }
                    this.Mostrar();
                    this.checkBoxEliminar.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace + " Verificar Boton Eliminar");
            }
        }

        private void checkBoxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEliminar.Checked)
            {
                this.dtListado.Columns[0].Visible = true;
            }
            else
            {
                this.dtListado.Columns[0].Visible = false;
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell checkBoxEliminar = (DataGridViewCheckBoxCell)dtListado.Rows[e.RowIndex].Cells["Eliminar"];
                checkBoxEliminar.Value = !Convert.ToBoolean(checkBoxEliminar.Value);
            }
        }

        private void dtListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdAreas"].Value);
            this.txtNombre.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre_Area"].Value);
            this.comboCurso.SelectedValue = Convert.ToString(this.dtListado.CurrentRow.Cells["IdCurso"].Value);
            this.tabAreas.SelectedIndex = 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.Habilitar(true);
            this.Limpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Campos obligatorios vacíos, favor completar.");
                    errorIcono.SetError(txtNombre, "Ingresar datos requeridos.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        Respuesta = NegocioArea.Insertar(this.txtNombre.Text.Trim(), Convert.ToInt32(this.comboCurso.SelectedValue));
                    }
                    else
                    {
                        Respuesta = NegocioArea.Editar(Convert.ToInt32(this.txtId.Text.Trim()), this.txtNombre.Text.Trim(), Convert.ToInt32(this.comboCurso.SelectedValue));
                    }

                    if (Respuesta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro.");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro.");
                        }
                    }
                    else
                    {
                        this.MensajeError(Respuesta);
                    }
                    this.EsNuevo = false;
                    this.EsEditar = false;
                    this.Botones();
                    this.Mostrar();
                    this.Limpiar();
                    this.tabAreas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + " Botón Insertar Area.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtId.Text.Equals(""))
            {
                this.EsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debes seleccionar el registro a modificar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.EsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
