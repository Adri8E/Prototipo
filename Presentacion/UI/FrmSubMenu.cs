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

namespace Presentacion.UI
{
    public partial class FrmSubMenu : Form
    {
        public FrmSubMenu()
        {
            InitializeComponent();
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15)); //Bordes del formulario
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

        private void buttonDesplegar_Click(object sender, EventArgs e)
        {

            if (PnlMenu.Visible == true)
            {
                PnlMenu.Visible = false;
                buttonDesplegar.BackColor = Color.FromArgb(31, 34, 65);
                panelDivSubMenu.SendToBack();

            }
            else
            {
                PnlMenu.Visible = true;
                buttonDesplegar.BackColor = Color.DarkSlateBlue;
                panelDivSubMenu.BringToFront();
            }
        }
        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmCliente"] == null)
                buttonNuevoCliente.BackColor = Color.FromArgb(148, 137, 241);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {


            this.Close();
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
        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            buttonNuevoCliente.BackColor = Color.FromArgb(43, 47, 90);
            AbrirFormulario<UI.Inscripcion.FrmCliente>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<UI.Inscripcion.FrmListadoCliente>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<UI.Inscripcion.FrmInscripcion>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<UI.Inscripcion.FrmListadoInscripcion>();
        }
    }
}
