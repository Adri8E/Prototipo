namespace Presentacion.UI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panel1 = new Panel();
            Pnl_contenedor = new Panel();
            PnlSuperior = new Panel();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            btnCambiar = new Button();
            panel3 = new Panel();
            buttonTemporal = new Button();
            buttonPagos = new Button();
            panel1.SuspendLayout();
            PnlSuperior.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Pnl_contenedor);
            panel1.Controls.Add(PnlSuperior);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 570);
            panel1.TabIndex = 1;
            // 
            // Pnl_contenedor
            // 
            Pnl_contenedor.BackColor = Color.FromArgb(54, 56, 112);
            Pnl_contenedor.Dock = DockStyle.Fill;
            Pnl_contenedor.Location = new Point(172, 35);
            Pnl_contenedor.Name = "Pnl_contenedor";
            Pnl_contenedor.Padding = new Padding(8);
            Pnl_contenedor.Size = new Size(857, 535);
            Pnl_contenedor.TabIndex = 2;
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = Color.FromArgb(54, 56, 112);
            PnlSuperior.Controls.Add(btnMinimizar);
            PnlSuperior.Controls.Add(btnCerrar);
            PnlSuperior.Controls.Add(btnCambiar);
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(172, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(857, 35);
            PnlSuperior.TabIndex = 0;
            PnlSuperior.MouseDown += PnlSuperior_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = Properties.Resources.icons8_menos_22;
            btnMinimizar.Location = new Point(761, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.icons8_eliminar_22;
            btnCerrar.Location = new Point(833, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 35);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCambiar
            // 
            btnCambiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCambiar.FlatAppearance.BorderSize = 0;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Image = Properties.Resources.restore;
            btnCambiar.Location = new Point(797, 2);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(30, 30);
            btnCambiar.TabIndex = 1;
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(148, 137, 241);
            panel3.Controls.Add(buttonPagos);
            panel3.Controls.Add(buttonTemporal);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 570);
            panel3.TabIndex = 1;
            // 
            // buttonTemporal
            // 
            buttonTemporal.Dock = DockStyle.Top;
            buttonTemporal.FlatAppearance.BorderSize = 0;
            buttonTemporal.FlatStyle = FlatStyle.Flat;
            buttonTemporal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTemporal.ForeColor = Color.White;
            buttonTemporal.Image = (Image)resources.GetObject("buttonTemporal.Image");
            buttonTemporal.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTemporal.Location = new Point(0, 0);
            buttonTemporal.Name = "buttonTemporal";
            buttonTemporal.Size = new Size(172, 35);
            buttonTemporal.TabIndex = 0;
            buttonTemporal.Text = "Inscripciones";
            buttonTemporal.UseVisualStyleBackColor = true;
            buttonTemporal.Click += buttonTemporal_Click;
            // 
            // buttonPagos
            // 
            buttonPagos.Dock = DockStyle.Top;
            buttonPagos.FlatAppearance.BorderSize = 0;
            buttonPagos.FlatStyle = FlatStyle.Flat;
            buttonPagos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagos.ForeColor = Color.White;
            buttonPagos.Image = (Image)resources.GetObject("buttonPagos.Image");
            buttonPagos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPagos.Location = new Point(0, 35);
            buttonPagos.Name = "buttonPagos";
            buttonPagos.Size = new Size(172, 35);
            buttonPagos.TabIndex = 1;
            buttonPagos.Text = "Pagos";
            buttonPagos.UseVisualStyleBackColor = true;
            buttonPagos.Click += buttonPagos_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 66, 78);
            ClientSize = new Size(1029, 570);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmMenu";
            Text = "FrmMenu";
            panel1.ResumeLayout(false);
            PnlSuperior.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Pnl_contenedor;
        private Panel panel3;
        private Panel PnlSuperior;
        private Button btnMinimizar;
        private Button btnCambiar;
        private Button btnCerrar;
        private Button buttonTemporal;
        private Button buttonPagos;
    }
}