using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.ControlBox = false; //Quitar los bordes del formulario.
            this.DoubleBuffered = true; //Reducir el parpadeo en los gráficos del formulario.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Para que no oculte la barra de tareas.
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15)); //Bordes del formulario
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnCambiar.Image = (System.Drawing.Image)(Properties.Resources.maximize);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15)); //Le agregamos los bordes al formulario
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnCambiar.Image = (System.Drawing.Image)(Properties.Resources.restore);
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0)); //Le quitamos los bordes al formulario
            }
        }

        private void PnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (WindowState == FormWindowState.Normal)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15)); //Le agregamos los bordes al formulario
                btnCambiar.Image = (System.Drawing.Image)(Properties.Resources.maximize);
            }
        }


        #region MDI_parent
        private void AbrirFormulario<AbreForm>() where AbreForm : Form, new()
        {
            Form NuevoForm;
            NuevoForm = Pnl_contenedor.Controls.OfType<AbreForm>().FirstOrDefault(); //Buscar en la colección de formularios
            if (NuevoForm == null)
            {
                NuevoForm = new AbreForm();
                NuevoForm.TopLevel = false;
                NuevoForm.FormBorderStyle = FormBorderStyle.None;
                NuevoForm.Dock = DockStyle.Fill;
                Pnl_contenedor.Controls.Add(NuevoForm);
                Pnl_contenedor.Tag = NuevoForm;
                NuevoForm.Show();
                NuevoForm.BringToFront();
                //  NuevoForm.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            } //Si el formulario existe lo traemos al frente
            else
                NuevoForm.BringToFront();
        }
        #endregion
        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["UI.FrmSubMenu"] == null)
                buttonTemporal.BackColor = Color.FromArgb(148, 137, 241);
        }
        private void buttonTemporal_Click(object sender, EventArgs e)
        {
            buttonTemporal.BackColor = Color.FromArgb(54, 56, 112);
            AbrirFormulario<UI.FrmSubMenu>();
        }

        private void buttonPagos_Click(object sender, EventArgs e)
        {
            buttonPagos.BackColor = Color.FromArgb(54, 56, 112);
            AbrirFormulario<UI.FrmSubMenu>();
        }
    }
}
