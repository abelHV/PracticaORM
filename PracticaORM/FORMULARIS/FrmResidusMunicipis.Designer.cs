namespace PracticaORM.FORMULARIS
{
    partial class FrmResidusMunicipis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkTotes = new System.Windows.Forms.CheckBox();
            this.cbComarques = new System.Windows.Forms.ComboBox();
            this.tbMunicipi = new System.Windows.Forms.TextBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTotes
            // 
            this.chkTotes.AutoSize = true;
            this.chkTotes.Checked = true;
            this.chkTotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.chkTotes.Location = new System.Drawing.Point(436, 89);
            this.chkTotes.Name = "chkTotes";
            this.chkTotes.Size = new System.Drawing.Size(136, 20);
            this.chkTotes.TabIndex = 29;
            this.chkTotes.Text = "Tots els municipis";
            this.chkTotes.UseVisualStyleBackColor = true;
            this.chkTotes.CheckedChanged += new System.EventHandler(this.chkTotes_CheckedChanged);
            // 
            // cbComarques
            // 
            this.cbComarques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComarques.Enabled = false;
            this.cbComarques.FormattingEnabled = true;
            this.cbComarques.Location = new System.Drawing.Point(135, 85);
            this.cbComarques.Name = "cbComarques";
            this.cbComarques.Size = new System.Drawing.Size(277, 24);
            this.cbComarques.TabIndex = 28;
            this.cbComarques.SelectedIndexChanged += new System.EventHandler(this.cbComarcas_SelectedIndexChanged);
            // 
            // tbMunicipi
            // 
            this.tbMunicipi.Location = new System.Drawing.Point(40, 128);
            this.tbMunicipi.Multiline = true;
            this.tbMunicipi.Name = "tbMunicipi";
            this.tbMunicipi.Size = new System.Drawing.Size(584, 24);
            this.tbMunicipi.TabIndex = 27;
            this.tbMunicipi.TextChanged += new System.EventHandler(this.tbCercar_TextChanged);
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(40, 176);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(584, 447);
            this.dgDades.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(190, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "RESIDUS PER MUNICIPI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::PracticaORM.Properties.Resources._158241d2079a635fb0cae49accb56da5_icono_de_lupa;
            this.pictureBox1.Location = new System.Drawing.Point(602, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmResidusMunicipis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(663, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTotes);
            this.Controls.Add(this.cbComarques);
            this.Controls.Add(this.tbMunicipi);
            this.Controls.Add(this.dgDades);
            this.Name = "FrmResidusMunicipis";
            this.Text = "FrmResidusMunicipis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResidusMunicipis_FormClosing);
            this.Load += new System.EventHandler(this.FrmResidusMunicipis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTotes;
        private System.Windows.Forms.ComboBox cbComarques;
        private System.Windows.Forms.TextBox tbMunicipi;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}