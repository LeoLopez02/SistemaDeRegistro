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
    public partial class FrmAdministrativo : Form
    {

        private bool EsNuevo = false;
        private bool EsEditar = false;

        private static FrmAdministrativo _instancia;
        public static FrmAdministrativo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmAdministrativo();
            }
            return _instancia;
        }

        public FrmAdministrativo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtApellido, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.maskedCedula, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtCorreoElectronico, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.dtFechaNacimiento, "**Campo obligatorio.**");
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
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.maskedTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.maskedCedula.Text = string.Empty;
            this.comboGenero.Text = "Otro...";
            this.txtCondicionMedica.Text = string.Empty;
            this.dtFechaNacimiento.Text = string.Empty;
            this.dtFechaIngreso.Text = string.Empty;
            this.txtCorreoElectronico.Text = string.Empty;
            this.txtNacionalidad.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.comboEstatus.Text = "Elegir Estatus...";
            this.txtFuncion.Text = string.Empty;
        }

        //Habilitar Textboxs
        private void Habilitar(bool Valor)
        {
            this.txtId.ReadOnly = !Valor; //Agregar
            this.txtNombre.ReadOnly = !Valor;
            this.txtApellido.ReadOnly = !Valor;
            this.maskedTelefono.ReadOnly = !Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.maskedCedula.ReadOnly = !Valor;
            this.txtCondicionMedica.ReadOnly = !Valor;
            this.txtCorreoElectronico.ReadOnly = !Valor;
            this.txtNacionalidad.ReadOnly = !Valor;
            this.txtTitulo.ReadOnly = !Valor;
            this.txtFuncion.ReadOnly = !Valor;
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
            this.dtListado.DataSource = NegocioAdministrativo.Mostrar();
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Cedula
        private void BuscarCedula()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarCedula(this.txtBuscar.Text);
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        private void FrmAdministrativo1_Load(object sender, EventArgs e)
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
            else if (comboBuscar.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
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
                            RepuestaEliminar = NegocioAdministrativo.Eliminar(Convert.ToInt32(Codigo));

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
            this.txtId.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdAdministrativo"].Value);
            this.txtNombre.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre"].Value);
            this.txtApellido.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Apellido"].Value);
            this.maskedTelefono.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Telefono"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Direccion"].Value);
            this.maskedCedula.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Cedula"].Value);
            this.comboGenero.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Genero"].Value);
            this.txtCondicionMedica.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Condicion_Medica"].Value);
            this.dtFechaNacimiento.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Fecha_Nacimiento"].Value);
            this.dtFechaIngreso.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Fecha_Ingreso"].Value);
            this.txtCorreoElectronico.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Correo_Electronico"].Value);
            this.txtNacionalidad.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nacionalidad"].Value);
            this.txtTitulo.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Titulo"].Value);
            this.comboEstatus.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Estatus"].Value);
            this.txtFuncion.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Funcion"].Value);
            this.tabAdministrativo.SelectedIndex = 1;
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
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty || this.maskedCedula.Text == string.Empty || this.comboGenero.Text == string.Empty || this.txtNacionalidad.Text == string.Empty || this.comboEstatus.Text == string.Empty || this.txtFuncion.Text == string.Empty)
                {
                    MensajeError("Campos obligatorios vacíos, favor completar.");
                    errorIcono.SetError(txtNombre, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtApellido, "Ingresar datos requeridos.");
                    errorIcono.SetError(maskedCedula, "Ingresar datos requeridos.");
                    errorIcono.SetError(comboGenero, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtNacionalidad, "Ingresar datos requeridos.");
                    errorIcono.SetError(comboEstatus, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtFuncion, "Ingresar datos requeridos.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        Respuesta = NegocioAdministrativo.Insertar(this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.maskedTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.maskedCedula.Text.Trim(), this.comboGenero.Text.Trim(), this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
                    }
                    else
                    {
                        Respuesta = NegocioAdministrativo.Editar(Convert.ToInt32(this.txtId.Text), this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.maskedTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.maskedCedula.Text.Trim(), this.comboGenero.Text.Trim(), this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
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
                    this.tabAdministrativo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + " Botón Insertar Administrativo.");
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
