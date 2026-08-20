namespace PracticaORM.FORMULARIS
{
    partial class FrmABMComarcas
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
            this.lbDescripcio = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(335, 176);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 42);
            this.btNo.TabIndex = 15;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(172, 176);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbRegio.ForeColor = System.Drawing.Color.White;
            this.lbRegio.Location = new System.Drawing.Point(21, 141);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(100, 22);
            this.lbRegio.TabIndex = 12;
            this.lbRegio.Text = "Capital";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(128, 110);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(418, 22);
            this.tbNom.TabIndex = 11;
            // 
            // lbDescripcio
            // 
            this.lbDescripcio.AutoSize = true;
            this.lbDescripcio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbDescripcio.ForeColor = System.Drawing.Color.White;
            this.lbDescripcio.Location = new System.Drawing.Point(21, 110);
            this.lbDescripcio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDescripcio.Name = "lbDescripcio";
            this.lbDescripcio.Padding = new System.Windows.Forms.Padding(3);
            this.lbDescripcio.Size = new System.Drawing.Size(100, 22);
            this.lbDescripcio.TabIndex = 10;
            this.lbDescripcio.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(128, 81);
            this.tbId.MaxLength = 20;
            this.tbId.Name = "tbId";
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbId.Size = new System.Drawing.Size(188, 22);
            this.tbId.TabIndex = 9;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(21, 81);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(3);
            this.lbId.Size = new System.Drawing.Size(100, 22);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "Id.";
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(128, 141);
            this.tbCapital.MaxLength = 50;
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(418, 22);
            this.tbCapital.TabIndex = 16;
            // 
            // FrmABMComarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 298);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbDescripcio);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmABMComarcas";
            this.Text = "FrmABMComarcas";
            this.Load += new System.EventHandler(this.FrmABMComarcas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbDescripcio;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbCapital;
    }
}