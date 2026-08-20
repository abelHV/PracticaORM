namespace PracticaORM.FORMULARIS
{
    partial class FrmImportacio
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
            this.cbImportar = new System.Windows.Forms.ComboBox();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btArchiu = new System.Windows.Forms.Button();
            this.lbEstat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRegistres = new System.Windows.Forms.ListBox();
            this.btAturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbImportar
            // 
            this.cbImportar.ForeColor = System.Drawing.Color.Black;
            this.cbImportar.FormattingEnabled = true;
            this.cbImportar.Items.AddRange(new object[] {
            "Comarcas",
            "Municipis",
            "Residus"});
            this.cbImportar.Location = new System.Drawing.Point(111, 120);
            this.cbImportar.Name = "cbImportar";
            this.cbImportar.Size = new System.Drawing.Size(127, 24);
            this.cbImportar.TabIndex = 0;
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btSeleccionar.Location = new System.Drawing.Point(101, 170);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(145, 33);
            this.btSeleccionar.TabIndex = 1;
            this.btSeleccionar.Text = "Seleccionar arxiu";
            this.btSeleccionar.UseVisualStyleBackColor = false;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // btArchiu
            // 
            this.btArchiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btArchiu.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArchiu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btArchiu.Location = new System.Drawing.Point(87, 245);
            this.btArchiu.Name = "btArchiu";
            this.btArchiu.Size = new System.Drawing.Size(172, 64);
            this.btArchiu.TabIndex = 2;
            this.btArchiu.Text = "Importar";
            this.btArchiu.UseVisualStyleBackColor = false;
            this.btArchiu.Click += new System.EventHandler(this.btArchiu_Click);
            // 
            // lbEstat
            // 
            this.lbEstat.BackColor = System.Drawing.Color.White;
            this.lbEstat.ForeColor = System.Drawing.Color.Black;
            this.lbEstat.Location = new System.Drawing.Point(42, 348);
            this.lbEstat.Name = "lbEstat";
            this.lbEstat.Size = new System.Drawing.Size(263, 53);
            this.lbEstat.TabIndex = 3;
            this.lbEstat.Text = "Cap arxiu seleccionat";
            this.lbEstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMPORTACIO DE DADES";
            // 
            // lbRegistres
            // 
            this.lbRegistres.ForeColor = System.Drawing.Color.Black;
            this.lbRegistres.FormattingEnabled = true;
            this.lbRegistres.ItemHeight = 16;
            this.lbRegistres.Location = new System.Drawing.Point(362, 51);
            this.lbRegistres.Name = "lbRegistres";
            this.lbRegistres.Size = new System.Drawing.Size(351, 308);
            this.lbRegistres.TabIndex = 5;
            // 
            // btAturar
            // 
            this.btAturar.BackColor = System.Drawing.Color.Red;
            this.btAturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btAturar.Location = new System.Drawing.Point(503, 375);
            this.btAturar.Name = "btAturar";
            this.btAturar.Size = new System.Drawing.Size(75, 37);
            this.btAturar.TabIndex = 6;
            this.btAturar.Text = "Aturar";
            this.btAturar.UseVisualStyleBackColor = false;
            this.btAturar.Click += new System.EventHandler(this.btAturar_Click);
            // 
            // FrmImportacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.btAturar);
            this.Controls.Add(this.lbEstat);
            this.Controls.Add(this.lbRegistres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btArchiu);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.cbImportar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Name = "FrmImportacio";
            this.Text = "FrmImportacio";
            this.Load += new System.EventHandler(this.FrmImportacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbImportar;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.Button btArchiu;
        private System.Windows.Forms.Label lbEstat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRegistres;
        private System.Windows.Forms.Button btAturar;
    }
}