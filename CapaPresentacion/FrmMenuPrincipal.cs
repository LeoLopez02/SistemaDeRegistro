using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region Funcionalidades del Formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "¡Información Importante!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Capturar posicion del formulario
        int LX, LY, SW, SH;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Metodo Abrir Formulario Dentro de Panel
        private void AbrirFormularioEnPanel<MyForm>()where MyForm: Form, new()
        {
            Form Frm;
            Frm = panelFormularios.Controls.OfType<MyForm>().FirstOrDefault();

            if (Frm == null)
            {
                Frm = new MyForm();
                Frm.TopLevel = false;
                Frm.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(Frm);
                panelFormularios.Tag = Frm;
                Frm.Show();
                Frm.BringToFront();
                Frm.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            }
            else
            {
                Frm.BringToFront();
            }
        }

        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmAdministrativo"] == null)
                btnAdministrativo.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmArea"] == null)
                btnAreas.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmCursos"] == null)
                btnCursos.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmCalificacion"] == null)
                btnCalificacion.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmEstudiante"] == null)
                btnEstudiantes.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmProfesor"] == null)
                btnProfesores.BackColor = Color.FromArgb(120, 40, 31);
            if (Application.OpenForms["FrmAsignatura"] == null)
                btnAsignaturas.BackColor = Color.FromArgb(120, 40, 31);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "¡Información Importante!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmAdministrativo>();
            btnAdministrativo.BackColor = Color.DodgerBlue;
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmProfesor>();
            btnProfesores.BackColor = Color.DodgerBlue;
        }

        private void btnPersonalApoyo_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel<FrmAdministrativo>();
            //btnAdministrativo.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstudiante>();
            btnEstudiantes.BackColor = Color.DodgerBlue;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmCursos>();
            btnCursos.BackColor = Color.DodgerBlue;
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmArea>();
            btnAreas.BackColor = Color.DodgerBlue;
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmAsignatura>();
            btnAsignaturas.BackColor = Color.DodgerBlue;
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmCalificacion>();
            btnCalificacion.BackColor = Color.DodgerBlue;
        }

        private void btnSoporteTec_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel<FrmAdministrativo>();
            //btnCursos.BackColor = Color.DodgerBlue;
        }

        private void btnSuplidor_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel<FrmAdministrativo>();
            //btnCursos.BackColor = Color.DodgerBlue;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel<FrmAdministrativo>();
            //btnCursos.BackColor = Color.DodgerBlue;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel<FrmAdministrativo>();
            //btnCursos.BackColor = Color.DodgerBlue;
        }

        private void btnMenuAnimado_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 260)
            {
                this.tmOcultarMenu.Start();
            }
            else if (panelMenu.Width == 65)
            {
                this.tmMostrarMenu.Start();
            }
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 260)
                this.tmMostrarMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 65)
                this.tmOcultarMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }
    }
}
