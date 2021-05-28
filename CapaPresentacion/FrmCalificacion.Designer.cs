namespace CapaPresentacion
{
    partial class FrmCalificacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            this.txtIdAsignatura = new System.Windows.Forms.TextBox();
            this.btnBuscarAsignatura = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtAñoEscolar = new System.Windows.Forms.MaskedTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCalificaionFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuartoPeriodo = new System.Windows.Forms.TextBox();
            this.txtTercerPeriodo = new System.Windows.Forms.TextBox();
            this.txtSegundoPeriodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimerPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabCalificacion = new System.Windows.Forms.TabControl();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboBuscar = new System.Windows.Forms.ComboBox();
            this.checkBoxEliminar = new System.Windows.Forms.CheckBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabCalificacion.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Formulario Calificación";
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.FlatAppearance.BorderSize = 0;
            this.btnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCerrarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCerrarForm.Location = new System.Drawing.Point(20, 20);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(36, 34);
            this.btnCerrarForm.TabIndex = 16;
            this.btnCerrarForm.Text = "X";
            this.btnCerrarForm.UseVisualStyleBackColor = true;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(540, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 35);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(395, 354);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 35);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertar.Location = new System.Drawing.Point(249, 354);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(106, 35);
            this.btnInsertar.TabIndex = 50;
            this.btnInsertar.Text = "&Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNombreAsignatura);
            this.groupBox1.Controls.Add(this.txtIdAsignatura);
            this.groupBox1.Controls.Add(this.btnBuscarAsignatura);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreEstudiante);
            this.groupBox1.Controls.Add(this.txtIdEstudiante);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Controls.Add(this.txtAñoEscolar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtCalificaionFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCuartoPeriodo);
            this.groupBox1.Controls.Add(this.txtTercerPeriodo);
            this.groupBox1.Controls.Add(this.txtSegundoPeriodo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrimerPeriodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "*Asignatura:";
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreAsignatura.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAsignatura.Location = new System.Drawing.Point(497, 284);
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(150, 22);
            this.txtNombreAsignatura.TabIndex = 61;
            this.txtNombreAsignatura.TabStop = false;
            // 
            // txtIdAsignatura
            // 
            this.txtIdAsignatura.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdAsignatura.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAsignatura.Location = new System.Drawing.Point(497, 241);
            this.txtIdAsignatura.Name = "txtIdAsignatura";
            this.txtIdAsignatura.ReadOnly = true;
            this.txtIdAsignatura.Size = new System.Drawing.Size(75, 22);
            this.txtIdAsignatura.TabIndex = 60;
            this.txtIdAsignatura.TabStop = false;
            this.txtIdAsignatura.Visible = false;
            // 
            // btnBuscarAsignatura
            // 
            this.btnBuscarAsignatura.FlatAppearance.BorderSize = 0;
            this.btnBuscarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAsignatura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscarAsignatura.Location = new System.Drawing.Point(607, 231);
            this.btnBuscarAsignatura.Name = "btnBuscarAsignatura";
            this.btnBuscarAsignatura.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarAsignatura.TabIndex = 59;
            this.btnBuscarAsignatura.Text = "X";
            this.btnBuscarAsignatura.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "*Estudiante:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(497, 137);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(150, 22);
            this.txtNombreEstudiante.TabIndex = 57;
            this.txtNombreEstudiante.TabStop = false;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIdEstudiante.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstudiante.Location = new System.Drawing.Point(497, 94);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.ReadOnly = true;
            this.txtIdEstudiante.Size = new System.Drawing.Size(75, 22);
            this.txtIdEstudiante.TabIndex = 56;
            this.txtIdEstudiante.TabStop = false;
            this.txtIdEstudiante.Visible = false;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstudiante.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(607, 84);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarEstudiante.TabIndex = 17;
            this.btnBuscarEstudiante.Text = "X";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtAñoEscolar
            // 
            this.txtAñoEscolar.Location = new System.Drawing.Point(123, 276);
            this.txtAñoEscolar.Mask = "0000 - 0000";
            this.txtAñoEscolar.Name = "txtAñoEscolar";
            this.txtAñoEscolar.Size = new System.Drawing.Size(150, 20);
            this.txtAñoEscolar.TabIndex = 55;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(101, 354);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 35);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCalificaionFinal
            // 
            this.txtCalificaionFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalificaionFinal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificaionFinal.Location = new System.Drawing.Point(157, 232);
            this.txtCalificaionFinal.Name = "txtCalificaionFinal";
            this.txtCalificaionFinal.Size = new System.Drawing.Size(116, 22);
            this.txtCalificaionFinal.TabIndex = 40;
            this.txtCalificaionFinal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Año Escolar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Calificacion Final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "4to Periodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "3er Periodo:";
            // 
            // txtCuartoPeriodo
            // 
            this.txtCuartoPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuartoPeriodo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuartoPeriodo.Location = new System.Drawing.Point(122, 189);
            this.txtCuartoPeriodo.Name = "txtCuartoPeriodo";
            this.txtCuartoPeriodo.Size = new System.Drawing.Size(150, 22);
            this.txtCuartoPeriodo.TabIndex = 36;
            this.txtCuartoPeriodo.TabStop = false;
            // 
            // txtTercerPeriodo
            // 
            this.txtTercerPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTercerPeriodo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTercerPeriodo.Location = new System.Drawing.Point(123, 148);
            this.txtTercerPeriodo.Name = "txtTercerPeriodo";
            this.txtTercerPeriodo.Size = new System.Drawing.Size(150, 22);
            this.txtTercerPeriodo.TabIndex = 36;
            this.txtTercerPeriodo.TabStop = false;
            // 
            // txtSegundoPeriodo
            // 
            this.txtSegundoPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoPeriodo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoPeriodo.Location = new System.Drawing.Point(123, 107);
            this.txtSegundoPeriodo.Name = "txtSegundoPeriodo";
            this.txtSegundoPeriodo.Size = new System.Drawing.Size(150, 22);
            this.txtSegundoPeriodo.TabIndex = 36;
            this.txtSegundoPeriodo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "2do Periodo:";
            // 
            // txtPrimerPeriodo
            // 
            this.txtPrimerPeriodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerPeriodo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerPeriodo.Location = new System.Drawing.Point(123, 65);
            this.txtPrimerPeriodo.Name = "txtPrimerPeriodo";
            this.txtPrimerPeriodo.Size = new System.Drawing.Size(150, 22);
            this.txtPrimerPeriodo.TabIndex = 35;
            this.txtPrimerPeriodo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "1er Periodo:";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(62, 26);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 22);
            this.txtId.TabIndex = 30;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Id:";
            this.label3.Visible = false;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabMantenimiento.Controls.Add(this.groupBox1);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(790, 418);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 64;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // tabCalificacion
            // 
            this.tabCalificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCalificacion.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCalificacion.Controls.Add(this.tabListado);
            this.tabCalificacion.Controls.Add(this.tabMantenimiento);
            this.tabCalificacion.Location = new System.Drawing.Point(80, 125);
            this.tabCalificacion.Name = "tabCalificacion";
            this.tabCalificacion.SelectedIndex = 0;
            this.tabCalificacion.Size = new System.Drawing.Size(798, 447);
            this.tabCalificacion.TabIndex = 15;
            // 
            // tabListado
            // 
            this.tabListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabListado.Controls.Add(this.lblTotal);
            this.tabListado.Controls.Add(this.btnActualizar);
            this.tabListado.Controls.Add(this.btnEliminar);
            this.tabListado.Controls.Add(this.btnImprimir);
            this.tabListado.Controls.Add(this.btnBuscar);
            this.tabListado.Controls.Add(this.txtBuscar);
            this.tabListado.Controls.Add(this.comboBuscar);
            this.tabListado.Controls.Add(this.checkBoxEliminar);
            this.tabListado.Controls.Add(this.dtListado);
            this.tabListado.Location = new System.Drawing.Point(4, 25);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(790, 418);
            this.tabListado.TabIndex = 0;
            this.tabListado.Text = "Listado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(439, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 17);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "label2";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(676, 68);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 35);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(676, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(676, 135);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 35);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(402, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 35);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Location = new System.Drawing.Point(107, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(265, 20);
            this.txtBuscar.TabIndex = 24;
            // 
            // comboBuscar
            // 
            this.comboBuscar.FormattingEnabled = true;
            this.comboBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Cedula"});
            this.comboBuscar.Location = new System.Drawing.Point(6, 10);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Size = new System.Drawing.Size(84, 21);
            this.comboBuscar.TabIndex = 23;
            this.comboBuscar.Text = "Nombre";
            // 
            // checkBoxEliminar
            // 
            this.checkBoxEliminar.AutoSize = true;
            this.checkBoxEliminar.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEliminar.ForeColor = System.Drawing.Color.White;
            this.checkBoxEliminar.Location = new System.Drawing.Point(6, 40);
            this.checkBoxEliminar.Name = "checkBoxEliminar";
            this.checkBoxEliminar.Size = new System.Drawing.Size(92, 21);
            this.checkBoxEliminar.TabIndex = 22;
            this.checkBoxEliminar.Text = "Eliminar";
            this.checkBoxEliminar.UseVisualStyleBackColor = true;
            this.checkBoxEliminar.CheckedChanged += new System.EventHandler(this.checkBoxEliminar_CheckedChanged);
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AllowUserToOrderColumns = true;
            this.dtListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListado.ColumnHeadersHeight = 30;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(6, 68);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtListado.RowHeadersVisible = false;
            this.dtListado.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(646, 344);
            this.dtListado.TabIndex = 21;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
            this.dtListado.DoubleClick += new System.EventHandler(this.dtListado_DoubleClick);
            // 
            // FrmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarForm);
            this.Controls.Add(this.tabCalificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalificacion";
            this.Text = "FrmCalificacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalificacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabCalificacion.ResumeLayout(false);
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCalificaionFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuartoPeriodo;
        private System.Windows.Forms.TextBox txtTercerPeriodo;
        private System.Windows.Forms.TextBox txtSegundoPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimerPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabCalificacion;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox comboBuscar;
        private System.Windows.Forms.CheckBox checkBoxEliminar;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.MaskedTextBox txtAñoEscolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
        private System.Windows.Forms.TextBox txtIdAsignatura;
        private System.Windows.Forms.Button btnBuscarAsignatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
    }
}