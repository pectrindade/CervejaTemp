namespace CervejaTemp.Forms
{
    partial class Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCadIngredientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCIMalte = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCILupulo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCIFermento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCIAdjuntos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnCadEquipamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnFCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.MnFerramentas,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(905, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCadIngredientes,
            this.MnCadEquipamentos,
            this.toolStripSeparator3,
            this.MnSair});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(61, 20);
            this.fileMenu.Text = "&Estoque";
            // 
            // MnCadIngredientes
            // 
            this.MnCadIngredientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCIMalte,
            this.MnCILupulo,
            this.MnCIFermento,
            this.MnCIAdjuntos});
            this.MnCadIngredientes.Image = ((System.Drawing.Image)(resources.GetObject("MnCadIngredientes.Image")));
            this.MnCadIngredientes.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnCadIngredientes.Name = "MnCadIngredientes";
            this.MnCadIngredientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.MnCadIngredientes.Size = new System.Drawing.Size(243, 22);
            this.MnCadIngredientes.Text = "Cadastrar &Ingredientes";
            // 
            // MnCIMalte
            // 
            this.MnCIMalte.Name = "MnCIMalte";
            this.MnCIMalte.Size = new System.Drawing.Size(125, 22);
            this.MnCIMalte.Text = "&Malte";
            this.MnCIMalte.Click += new System.EventHandler(this.MnCIMalte_Click);
            // 
            // MnCILupulo
            // 
            this.MnCILupulo.Name = "MnCILupulo";
            this.MnCILupulo.Size = new System.Drawing.Size(125, 22);
            this.MnCILupulo.Text = "&Lúpulo";
            this.MnCILupulo.Click += new System.EventHandler(this.MnCILupulo_Click);
            // 
            // MnCIFermento
            // 
            this.MnCIFermento.Name = "MnCIFermento";
            this.MnCIFermento.Size = new System.Drawing.Size(125, 22);
            this.MnCIFermento.Text = "&Fermento";
            this.MnCIFermento.Click += new System.EventHandler(this.MnCIFermento_Click);
            // 
            // MnCIAdjuntos
            // 
            this.MnCIAdjuntos.Name = "MnCIAdjuntos";
            this.MnCIAdjuntos.Size = new System.Drawing.Size(125, 22);
            this.MnCIAdjuntos.Text = "&Adjuntos";
            this.MnCIAdjuntos.Click += new System.EventHandler(this.MnCIAdjuntos_Click);
            // 
            // MnCadEquipamentos
            // 
            this.MnCadEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("MnCadEquipamentos.Image")));
            this.MnCadEquipamentos.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnCadEquipamentos.Name = "MnCadEquipamentos";
            this.MnCadEquipamentos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MnCadEquipamentos.Size = new System.Drawing.Size(243, 22);
            this.MnCadEquipamentos.Text = "Cadastrar &Equipamentos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // MnSair
            // 
            this.MnSair.Name = "MnSair";
            this.MnSair.Size = new System.Drawing.Size(243, 22);
            this.MnSair.Text = "Sai&r";
            this.MnSair.Click += new System.EventHandler(this.MnSair_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(62, 20);
            this.editMenu.Text = "&Receitas";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(76, 20);
            this.viewMenu.Text = "&Brassagem";
            // 
            // MnFerramentas
            // 
            this.MnFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnFCadUsuario});
            this.MnFerramentas.Name = "MnFerramentas";
            this.MnFerramentas.Size = new System.Drawing.Size(84, 20);
            this.MnFerramentas.Text = "&Ferramentas";
            // 
            // MnFCadUsuario
            // 
            this.MnFCadUsuario.Name = "MnFCadUsuario";
            this.MnFCadUsuario.Size = new System.Drawing.Size(180, 22);
            this.MnFCadUsuario.Text = "Cadastro de Usuário";
            this.MnFCadUsuario.Click += new System.EventHandler(this.MnFCadUsuario_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(56, 20);
            this.windowsMenu.Text = "&Janelas";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(50, 20);
            this.helpMenu.Text = "&Ajuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(905, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem MnCadIngredientes;
        private System.Windows.Forms.ToolStripMenuItem MnCadEquipamentos;
        private System.Windows.Forms.ToolStripMenuItem MnSair;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem MnFerramentas;
        private System.Windows.Forms.ToolStripMenuItem MnFCadUsuario;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnCIMalte;
        private System.Windows.Forms.ToolStripMenuItem MnCILupulo;
        private System.Windows.Forms.ToolStripMenuItem MnCIFermento;
        private System.Windows.Forms.ToolStripMenuItem MnCIAdjuntos;
    }
}



