namespace PracticaORM
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBaseDeDadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportacio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestio = new System.Windows.Forms.ToolStripMenuItem();
            this.comarquesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.municipisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.residusPerMunicipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residusPerMunicipiYAnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.menuImportacio,
            this.menuGestio,
            this.menuConsulta});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1297, 28);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testBaseDeDadesToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // testBaseDeDadesToolStripMenuItem
            // 
            this.testBaseDeDadesToolStripMenuItem.Name = "testBaseDeDadesToolStripMenuItem";
            this.testBaseDeDadesToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.testBaseDeDadesToolStripMenuItem.Text = "&Test base de dades";
            this.testBaseDeDadesToolStripMenuItem.Click += new System.EventHandler(this.testBaseDeDadesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sortirToolStripMenuItem.Text = "&Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // menuImportacio
            // 
            this.menuImportacio.Enabled = false;
            this.menuImportacio.Name = "menuImportacio";
            this.menuImportacio.Size = new System.Drawing.Size(96, 24);
            this.menuImportacio.Text = "Importació";
            this.menuImportacio.Click += new System.EventHandler(this.menuImportacio_Click);
            // 
            // menuGestio
            // 
            this.menuGestio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comarquesToolStripMenuItem1,
            this.municipisToolStripMenuItem1});
            this.menuGestio.Enabled = false;
            this.menuGestio.Name = "menuGestio";
            this.menuGestio.Size = new System.Drawing.Size(65, 24);
            this.menuGestio.Text = "Gestió";
            // 
            // comarquesToolStripMenuItem1
            // 
            this.comarquesToolStripMenuItem1.Name = "comarquesToolStripMenuItem1";
            this.comarquesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.comarquesToolStripMenuItem1.Text = "comarques";
            this.comarquesToolStripMenuItem1.Click += new System.EventHandler(this.comarquesToolStripMenuItem1_Click);
            // 
            // municipisToolStripMenuItem1
            // 
            this.municipisToolStripMenuItem1.Name = "municipisToolStripMenuItem1";
            this.municipisToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.municipisToolStripMenuItem1.Text = "Municipis";
            this.municipisToolStripMenuItem1.Click += new System.EventHandler(this.municipisToolStripMenuItem1_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residusPerMunicipiToolStripMenuItem,
            this.residusPerMunicipiYAnyToolStripMenuItem});
            this.menuConsulta.Enabled = false;
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(80, 24);
            this.menuConsulta.Text = "Consulta";
            // 
            // residusPerMunicipiToolStripMenuItem
            // 
            this.residusPerMunicipiToolStripMenuItem.Name = "residusPerMunicipiToolStripMenuItem";
            this.residusPerMunicipiToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.residusPerMunicipiToolStripMenuItem.Text = "Residus per municipi";
            this.residusPerMunicipiToolStripMenuItem.Click += new System.EventHandler(this.residusPerMunicipiToolStripMenuItem_Click);
            // 
            // residusPerMunicipiYAnyToolStripMenuItem
            // 
            this.residusPerMunicipiYAnyToolStripMenuItem.Name = "residusPerMunicipiYAnyToolStripMenuItem";
            this.residusPerMunicipiYAnyToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.residusPerMunicipiYAnyToolStripMenuItem.Text = "Residus per municipi y any";
            this.residusPerMunicipiYAnyToolStripMenuItem.Click += new System.EventHandler(this.residusPerMunicipiYAnyToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 680);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Residus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testBaseDeDadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImportacio;
        private System.Windows.Forms.ToolStripMenuItem menuGestio;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem comarquesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem municipisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem residusPerMunicipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem residusPerMunicipiYAnyToolStripMenuItem;
    }
}

