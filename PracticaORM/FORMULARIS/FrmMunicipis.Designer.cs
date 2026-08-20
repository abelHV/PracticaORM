namespace PracticaORM.FORMULARIS
{
    partial class FrmMunicipis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCercar = new System.Windows.Forms.TextBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.chkTotes = new System.Windows.Forms.CheckBox();
            this.cbComarcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCercar
            // 
            this.tbCercar.Location = new System.Drawing.Point(32, 85);
            this.tbCercar.Multiline = true;
            this.tbCercar.Name = "tbCercar";
            this.tbCercar.Size = new System.Drawing.Size(249, 24);
            this.tbCercar.TabIndex = 20;
            this.tbCercar.TextChanged += new System.EventHandler(this.tbMunicipis_TextChanged);
            // 
            // pbDel
            // 
            this.pbDel.Image = global::PracticaORM.Properties.Resources.cancel50;
            this.pbDel.Location = new System.Drawing.Point(359, 591);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(50, 50);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDel.TabIndex = 19;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::PracticaORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(237, 591);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(50, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 18;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(32, 125);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(584, 447);
            this.dgDades.TabIndex = 16;
            this.dgDades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDades_CellDoubleClick);
            // 
            // chkTotes
            // 
            this.chkTotes.AutoSize = true;
            this.chkTotes.Checked = true;
            this.chkTotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.chkTotes.Location = new System.Drawing.Point(480, 87);
            this.chkTotes.Name = "chkTotes";
            this.chkTotes.Size = new System.Drawing.Size(136, 20);
            this.chkTotes.TabIndex = 22;
            this.chkTotes.Text = "Tots els municipis";
            this.chkTotes.UseVisualStyleBackColor = true;
            this.chkTotes.CheckedChanged += new System.EventHandler(this.chkTotes_CheckedChanged);
            // 
            // cbComarcas
            // 
            this.cbComarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComarcas.Enabled = false;
            this.cbComarcas.FormattingEnabled = true;
            this.cbComarcas.Location = new System.Drawing.Point(300, 85);
            this.cbComarcas.Name = "cbComarcas";
            this.cbComarcas.Size = new System.Drawing.Size(157, 24);
            this.cbComarcas.TabIndex = 21;
            this.cbComarcas.SelectedIndexChanged += new System.EventHandler(this.cbMunicipis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(255, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "MUNICIPIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::PracticaORM.Properties.Resources._158241d2079a635fb0cae49accb56da5_icono_de_lupa;
            this.pictureBox1.Location = new System.Drawing.Point(259, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMunicipis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(660, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTotes);
            this.Controls.Add(this.cbComarcas);
            this.Controls.Add(this.tbCercar);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgDades);
            this.Name = "FrmMunicipis";
            this.Text = "FrmMunicipis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMunicipis_FormClosing);
            this.Load += new System.EventHandler(this.FrmMunicipis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCercar;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.CheckBox chkTotes;
        private System.Windows.Forms.ComboBox cbComarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}