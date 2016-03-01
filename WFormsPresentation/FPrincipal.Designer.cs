namespace WindowsForms
{
    partial class FPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTeléfonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPresupuestoAClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vehículosToolStripMenuItem,
            this.presupuestosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.actualizarTeléfonoToolStripMenuItem,
            this.obtenerClienteToolStripMenuItem,
            this.añadirPresupuestoAClienteToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // actualizarTeléfonoToolStripMenuItem
            // 
            this.actualizarTeléfonoToolStripMenuItem.Name = "actualizarTeléfonoToolStripMenuItem";
            this.actualizarTeléfonoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.actualizarTeléfonoToolStripMenuItem.Text = "Actualizar teléfono";
            // 
            // obtenerClienteToolStripMenuItem
            // 
            this.obtenerClienteToolStripMenuItem.Name = "obtenerClienteToolStripMenuItem";
            this.obtenerClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.obtenerClienteToolStripMenuItem.Text = "Obtener cliente";
            // 
            // añadirPresupuestoAClienteToolStripMenuItem
            // 
            this.añadirPresupuestoAClienteToolStripMenuItem.Name = "añadirPresupuestoAClienteToolStripMenuItem";
            this.añadirPresupuestoAClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.añadirPresupuestoAClienteToolStripMenuItem.Text = "Añadir presupuesto a cliente";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.Text = "Aplicación de gestión de presupuestos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTeléfonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPresupuestoAClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
    }
}

