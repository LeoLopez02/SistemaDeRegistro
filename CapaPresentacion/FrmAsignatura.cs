﻿using System;
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
    public partial class FrmAsignatura : Form
    {
        private bool EsNuevo = false;
        private bool EsEditar = false;

        private static FrmAsignatura _instancia;
        public static FrmAsignatura GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmAsignatura();
            }
            return _instancia;
        }

        public FrmAsignatura()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "**Campo obligatorio.**");
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
            this.txtDescripcion.Text = string.Empty;
            this.txtCantidadHora.Text = string.Empty;
            this.txtIdProfesor.Text = string.Empty;
            this.comboProfesor.Text = "Elegir Profesor...";
            this.txtIdCurso.Text = string.Empty;
            this.comboCurso.Text = "Elegir Curso...";
        }

        //Habilitar Textboxs
        private void Habilitar(bool Valor)
        {
            this.txtId.ReadOnly = !Valor;
            this.txtNombre.ReadOnly = !Valor;
            this.txtDescripcion.ReadOnly = !Valor;
            this.txtCantidadHora.ReadOnly = !Valor;
            this.txtIdCurso.ReadOnly = !Valor;
            this.txtIdProfesor.ReadOnly = !Valor;
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
            this.dtListado.DataSource = NegocioAsignatura.Mostrar();
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioAsignatura.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumna();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Llenar ComboBox
        private void LlenarComboBoxCurso()
        {
            comboCurso.DataSource = NegocioCursos.Mostrar();
            comboCurso.ValueMember = "IdCurso";
            comboCurso.DisplayMember = "Nombre";
        }

        private void LlenarComboBoxProfesor()
        {
            comboProfesor.DataSource = NegocioProfesor.Mostrar();
            comboProfesor.ValueMember = "IdProfesor";
            comboProfesor.DisplayMember = "Nombre";
        }

        private void FrmAsignatura_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.LlenarComboBoxCurso();
            this.LlenarComboBoxProfesor();
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
                            RepuestaEliminar = NegocioAsignatura.Eliminar(Convert.ToInt32(Codigo));

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
            this.txtId.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["IdAsignatura"].Value);
            this.txtNombre.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Descripcion"].Value);
            this.txtCantidadHora.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["CantidadHoras"].Value);
            this.txtIdProfesor.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre_Profesor"].Value);
            this.txtIdCurso.Text = Convert.ToString(this.dtListado.CurrentRow.Cells["Nombre_Curso"].Value);
            this.tabAsignatura.SelectedIndex = 1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.Habilitar(true);
            this.Limpiar();
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtDescripcion.Text == string.Empty || this.txtCantidadHora.Text == string.Empty)
                {
                    MensajeError("Campos obligatorios vacíos, favor completar.");
                    errorIcono.SetError(txtNombre, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtDescripcion, "Ingresar datos requeridos.");
                    errorIcono.SetError(txtCantidadHora, "Ingresar datos requeridos.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        Respuesta = NegocioAsignatura.Insertar(this.txtNombre.Text.Trim(), this.txtDescripcion.Text.Trim(), Convert.ToInt32(this.txtCantidadHora.Text), Convert.ToInt32(this.txtIdProfesor.Text), Convert.ToInt32(this.txtIdCurso.Text));
                    }
                    else
                    {
                        Respuesta = NegocioAsignatura.Editar(Convert.ToInt32(this.txtId.Text), this.txtNombre.Text.Trim(), this.txtDescripcion.Text.Trim(), Convert.ToInt32(this.txtCantidadHora.Text), Convert.ToInt32(this.txtIdProfesor.Text), Convert.ToInt32(this.txtIdCurso.Text));
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
                    this.tabAsignatura.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + " Botón Insertar Asignatura.");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignatura_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtIdCurso.Text = comboCurso.SelectedValue.ToString();
        }

        private void comboProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtIdProfesor.Text = comboProfesor.SelectedValue.ToString();
        }
    }
}