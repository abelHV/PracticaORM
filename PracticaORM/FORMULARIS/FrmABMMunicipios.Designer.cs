namespace PracticaORM.FORMULARIS
{
    partial class FrmABMMunicipios
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
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbRegio = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbComarcas = new System.Windows.Forms.Label();
            this.cbComarques = new System.Windows.Forms.ComboBox();
            this.nupHabitants = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupHabitants)).BeginInit();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(332, 160);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 42);
            this.btNo.TabIndex = 23;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(176, 160);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 22;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbRegio.ForeColor = System.Drawing.Color.White;
            this.lbRegio.Location = new System.Drawing.Point(26, 95);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(100, 22);
            this.lbRegio.TabIndex = 21;
            this.lbRegio.Text = "NumHabitants";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(133, 64);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(418, 22);
            this.tbNom.TabIndex = 20;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(26, 64);
            this.lbNom.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(3);
            this.lbNom.Size = new System.Drawing.Size(100, 22);
            this.lbNom.TabIndex = 19;
            this.lbNom.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(133, 35);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbId.Size = new System.Drawing.Size(188, 22);
            this.tbId.TabIndex = 18;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(26, 35);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(100, 22);
            this.lbId.TabIndex = 17;
            this.lbId.Text = "Id.";
            // 
            // lbComarcas
            // 
            this.lbComarcas.AutoSize = true;
            this.lbComarcas.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbComarcas.ForeColor = System.Drawing.Color.White;
            this.lbComarcas.Location = new System.Drawing.Point(26, 123);
            this.lbComarcas.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbComarcas.Name = "lbComarcas";
            this.lbComarcas.Padding = new System.Windows.Forms.Padding(3);
            this.lbComarcas.Size = new System.Drawing.Size(100, 22);
            this.lbComarcas.TabIndex = 25;
            this.lbComarcas.Text = "Comarca";
            // 
            // cbComarques
            // 
            this.cbComarques.FormattingEnabled = true;
            this.cbComarques.Location = new System.Drawing.Point(132, 123);
            this.cbComarques.Name = "cbComarques";
            this.cbComarques.Size = new System.Drawing.Size(419, 24);
            this.cbComarques.TabIndex = 26;
            // 
            // nupHabitants
            // 
            this.nupHabitants.Location = new System.Drawing.Point(133, 95);
            this.nupHabitants.Name = "nupHabitants";
            this.nupHabitants.Size = new System.Drawing.Size(120, 22);
            this.nupHabitants.TabIndex = 27;
            // 
            // FrmABMMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 239);
            this.Controls.Add(this.nupHabitants);
            this.Controls.Add(this.cbComarques);
            this.Controls.Add(this.lbComarcas);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmABMMunicipios";
            this.Text = "FrmABMMunicipios";
            this.Load += new System.EventHandler(this.FrmABMMunicipios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupHabitants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbComarcas;
        private System.Windows.Forms.ComboBox cbComarques;
        private System.Windows.Forms.NumericUpDown nupHabitants;
    }
}