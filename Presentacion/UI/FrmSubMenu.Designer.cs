namespace Presentacion.UI
{
    partial class FrmSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubMenu));
            panel1 = new Panel();
            btnCerrar = new Button();
            panel5 = new Panel();
            panel2 = new Panel();
            PnlMenu = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            buttonNuevoCliente = new Button();
            panel6 = new Panel();
            panelDivSubMenu = new Panel();
            label1 = new Label();
            buttonDesplegar = new Button();
            Pnl_contenedor = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PnlMenu.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 34, 65);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(150, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 35);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.icons8_eliminar_22;
            btnCerrar.Location = new Point(655, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 34);
            btnCerrar.TabIndex = 1;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(98, 93, 159);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(679, 1);
            panel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 34, 65);
            panel2.Controls.Add(PnlMenu);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 535);
            panel2.TabIndex = 1;
            // 
            // PnlMenu
            // 
            PnlMenu.AutoScroll = true;
            PnlMenu.BackColor = Color.FromArgb(31, 34, 65);
            PnlMenu.Controls.Add(button4);
            PnlMenu.Controls.Add(button3);
            PnlMenu.Controls.Add(button2);
            PnlMenu.Controls.Add(buttonNuevoCliente);
            PnlMenu.Dock = DockStyle.Top;
            PnlMenu.Location = new Point(0, 35);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(150, 180);
            PnlMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateBlue;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 90);
            button4.Name = "button4";
            button4.Size = new Size(150, 30);
            button4.TabIndex = 3;
            button4.Text = "Inscripciones";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateBlue;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.WhiteSmoke;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 60);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 2;
            button3.Text = " Nueva Inscripción";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 30);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 1;
            button2.Text = " Listado Cliente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonNuevoCliente
            // 
            buttonNuevoCliente.BackColor = Color.DarkSlateBlue;
            buttonNuevoCliente.Dock = DockStyle.Top;
            buttonNuevoCliente.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            buttonNuevoCliente.FlatStyle = FlatStyle.Flat;
            buttonNuevoCliente.ForeColor = Color.WhiteSmoke;
            buttonNuevoCliente.Image = (Image)resources.GetObject("buttonNuevoCliente.Image");
            buttonNuevoCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNuevoCliente.Location = new Point(0, 0);
            buttonNuevoCliente.Name = "buttonNuevoCliente";
            buttonNuevoCliente.Size = new Size(150, 30);
            buttonNuevoCliente.TabIndex = 0;
            buttonNuevoCliente.Text = " Nuevo Cliente";
            buttonNuevoCliente.UseVisualStyleBackColor = false;
            buttonNuevoCliente.Click += buttonNuevoCliente_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(31, 34, 65);
            panel6.Controls.Add(panelDivSubMenu);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(buttonDesplegar);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 35);
            panel6.TabIndex = 1;
            // 
            // panelDivSubMenu
            // 
            panelDivSubMenu.BackColor = Color.FromArgb(98, 93, 159);
            panelDivSubMenu.Dock = DockStyle.Bottom;
            panelDivSubMenu.Location = new Point(35, 34);
            panelDivSubMenu.Name = "panelDivSubMenu";
            panelDivSubMenu.Size = new Size(115, 1);
            panelDivSubMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // buttonDesplegar
            // 
            buttonDesplegar.BackColor = Color.DarkSlateBlue;
            buttonDesplegar.Dock = DockStyle.Left;
            buttonDesplegar.FlatAppearance.BorderSize = 0;
            buttonDesplegar.FlatStyle = FlatStyle.Flat;
            buttonDesplegar.Image = (Image)resources.GetObject("buttonDesplegar.Image");
            buttonDesplegar.Location = new Point(0, 0);
            buttonDesplegar.Name = "buttonDesplegar";
            buttonDesplegar.Size = new Size(35, 35);
            buttonDesplegar.TabIndex = 2;
            buttonDesplegar.UseVisualStyleBackColor = false;
            buttonDesplegar.Click += buttonDesplegar_Click;
            // 
            // Pnl_contenedor
            // 
            Pnl_contenedor.BackColor = Color.FromArgb(43, 47, 90);
            Pnl_contenedor.Dock = DockStyle.Fill;
            Pnl_contenedor.Location = new Point(150, 35);
            Pnl_contenedor.Name = "Pnl_contenedor";
            Pnl_contenedor.Size = new Size(679, 500);
            Pnl_contenedor.TabIndex = 2;
            // 
            // FrmSubMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(56, 66, 78);
            ClientSize = new Size(829, 535);
            Controls.Add(Pnl_contenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSubMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSubMenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            PnlMenu.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel Pnl_contenedor;
        private Button btnCerrar;
        private Panel panel5;
        private Panel PnlMenu;
        private Panel panel6;
        private Label label1;
        private Button buttonDesplegar;
        private Button button2;
        private Button buttonNuevoCliente;
        private Button button3;
        private Button button4;
        private Panel panelDivSubMenu;
    }
}