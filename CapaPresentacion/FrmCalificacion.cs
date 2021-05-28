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
    public partial class FrmCalificacion : Form
    {
        private bool EsNuevo = false;
        private bool EsEditar = false;

        private static FrmCalificacion _instancia;
        public static FrmCalificacion GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmCalificacion();
            }
            return _instancia;
        }

        //Enviar datos estudiantes
        public void EnviarEstudiante(string idestudiante, string nombre, string añoescolar) 
        {
            this.txtIdEstudiante.Text = idestudiante;
            this.txtNombreEstudiante.Text = nombre;
            this.txtAñoEscolar.Text = añoescolar;
        }

        public FrmCalificacion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtPrimerPeriodo, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtSegundoPeriodo, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtTercerPeriodo, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtCuartoPeriodo, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtCalificaionFinal, "**Campo obligatorio.**");
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
            this.txtId.Text = string.Empty; //Agregar 
            this.txtPrimerPeriodo.Text = string.Empty;
            this.txtSegundoPeriodo.Text = string.Empty;
            this.txtTercerPeriodo.Text = string.Empty;
            this.txtCuartoPeriodo.Text = string.Empty;
            this.txtCalificaionFinal.Text = string.Empty;
        }

        //Habilitar Textboxs
        private void Habilitar(bool Valor)
        {
            this.txtId.ReadOnly = !Valor; //Agregar
            this.txtPrimerPeriodo.ReadOnly = !Valor;
            this.txtSegundoPeriodo.ReadOnly = !Valor;
            this.txtTercerPeriodo.ReadOnly = !Valor;
            this.txtCuartoPeriodo.ReadOnly = !Valor;
            this.txtCalificaionFinal.ReadOnly = !Valor;
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
        }

        //Mostrar
        private void Mostrar()
        {
            this.dtListado.DataSource = NegocioCalificacion.Mostrar();
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioCalificacion.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        private void FrmCalificacion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
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
                            RepuestaEliminar = NegocioCalificacion.Eliminar(Convert.ToInt32(Codigo));

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
            this.txtId.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdCalificacion"].Value);
            this.txtIdEstudiante.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdEstudainte"].Value);
            this.txtNombreEstudiante.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre_Estudiante"].Value);
            this.txtIdAsignatura.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdAsignatura"].Value);
            this.txtNombreAsignatura.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre_Asignatura"].Value);
            this.txtPrimerPeriodo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["PrimerPeriodo"].Value);
            this.txtSegundoPeriodo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["SegundoPeriodo"].Value);
            this.txtTercerPeriodo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["TercerPeriodo"].Value);
            this.txtCuartoPeriodo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["CuartoPeriodo"].Value);
            //this.txtCalificaionFinal.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Calificacion_Final"].Value);
            this.txtAñoEscolar.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["AñoEscolar"].Value);
            this.tabCalificacion.SelectedIndex = 1;
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
                if (this.txtPrimerPeriodo.Text == string.Empty || this.txtSegundoPeriodo.Text == string.Empty || this.txtTercerPeriodo.Text == string.Empty || this.txtCuartoPeriodo.Text == string.Empty || this.txtCalificaionFinal.Text == string.Empty)
                {
                    MensajeError("Campos obligatorios vacíos, favor completar.");
                    errorIcono.SetError(txtPrimerPeriodo, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtSegundoPeriodo, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtTercerPeriodo, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtCuartoPeriodo, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtCalificaionFinal, "Ingresar datos requeridos.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        Respuesta = NegocioCalificacion.Insertar(Convert.ToDecimal(this.txtPrimerPeriodo.Text.Trim()), Convert.ToDecimal(this.txtSegundoPeriodo.Text.Trim()), Convert.ToDecimal(this.txtTercerPeriodo.Text.Trim()), Convert.ToDecimal(this.txtCuartoPeriodo.Text.Trim()), Convert.ToInt32(this.txtIdAsignatura.Text.Trim()), Convert.ToInt32(this.txtIdEstudiante.Text.Trim()), this.txtAñoEscolar.Text.Trim());
                    }
                    else
                    {
                        Respuesta = NegocioCalificacion.Editar(Convert.ToInt32(this.txtId.Text), Convert.ToDecimal(this.txtPrimerPeriodo.Text.Trim()), Convert.ToDecimal(this.txtSegundoPeriodo.Text.Trim()), Convert.ToDecimal(this.txtTercerPeriodo.Text.Trim()), Convert.ToDecimal(this.txtCuartoPeriodo.Text.Trim()), Convert.ToInt32(this.txtIdAsignatura.Text.Trim()), Convert.ToInt32(this.txtIdEstudiante.Text.Trim()), this.txtAñoEscolar.Text.Trim());
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
                    this.tabCalificacion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + " Botón Insertar Calificacion.");
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

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            FrmVistaCalificacionEstudiante Frm = new FrmVistaCalificacionEstudiante();
            Frm.Show();
        }

        private void FrmCalificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }
    }
}
