using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaORM.FORMULARIS
{
    public partial class FrmResidusMunicipis : Form
    {
        private GestionResiduosEntities gestionResiduosContext { get; set; }
        Boolean bFirst = true;
        public FrmResidusMunicipis(GestionResiduosEntities xContext)
        {
            InitializeComponent();
            gestionResiduosContext = xContext;
        }

        private void FrmResidusMunicipis_Load(object sender, EventArgs e)
        {
            omplirComboComarques();
            getDades(); // Carga inicial de datos
            iniDgrid(); // Aplicamos formato al Grid
            bFirst = false;
        }

        private void cbComarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst) getDades();
        }

        private void chkTotes_CheckedChanged(object sender, EventArgs e)
        {
            cbComarques.Enabled = !chkTotes.Checked;
            getDades();
        }

        private void tbCercar_TextChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private void getDades()
        {
            // 1. Hacemos el Group Join o Join tradicional para agrupar las toneladas de los residuos
            // Agrupamos por Municipio y Comarca para obtener el total histórico de todos los años
            var qry = from m in gestionResiduosContext.Municipios
                      join c in gestionResiduosContext.Comarcas on m.ComarcaId equals c.Id
                      // Asumo que tu tabla de datos se llama 'Residuos' y se relaciona con el municipio
                      join r in gestionResiduosContext.Residus on m.Id equals r.MunicipioId into residuosGrupo
                      select new
                      {
                          idMunicipi = m.Id,
                          nomMunicipi = m.Nombre,
                          nomComarca = c.Nombre,
                          idComarca = m.ComarcaId,
                          // Sumamos los kilos/toneladas de todos los registros de ese municipio
                          totalResidus = residuosGrupo.Sum(x =>
                                                                (double?)(x.Vidre ?? 0) +
                                                                (double?)(x.PodaJardineria ?? 0) +
                                                                (double?)(x.PaperCartro ?? 0)
                                                            ) ?? 0
                      };

            // 2. Filtro de Comarca (si el check de 'Totes' no está marcado)
            if (!chkTotes.Checked && cbComarques.SelectedValue != null)
            {
                int idC = (int)cbComarques.SelectedValue;
                qry = qry.Where(x => x.idComarca == idC);
            }

            // 3. Filtro por texto del nombre del Municipio
            string textoBusqueda = tbMunicipi.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                qry = qry.Where(x => x.nomMunicipi.ToLower().Contains(textoBusqueda));
            }

            // 4. Asignamos al Grid ordenando por nombre de municipio
            dgDades.DataSource = qry.OrderBy(x => x.nomMunicipi).ToList();

            // Refrescamos el formato de las columnas por si cambia el DataSource
            iniDgrid();
        }

        private void omplirComboComarques()
        {
            var qry = from c in gestionResiduosContext.Comarcas
                      orderby c.Nombre
                      select c;

            cbComarques.DataSource = qry.ToList();
            cbComarques.DisplayMember = "Nombre";
            cbComarques.ValueMember = "Id";
        }

        // --- CONFIGURACIÓN DE LA INTERFAZ (DISEÑO) ---

        private void iniDgrid()
        {
            if (dgDades.Columns.Count > 0)
            {
                if (dgDades.Columns["idMunicipi"] != null) dgDades.Columns["idMunicipi"].HeaderText = "Codi";
                if (dgDades.Columns["nomMunicipi"] != null) dgDades.Columns["nomMunicipi"].HeaderText = "Municipi";
                if (dgDades.Columns["nomComarca"] != null) dgDades.Columns["nomComarca"].HeaderText = "Comarca";
                if (dgDades.Columns["idComarca"] != null) dgDades.Columns["idComarca"].Visible = false;

                if (dgDades.Columns["totalResidus"] != null)
                {
                    dgDades.Columns["totalResidus"].HeaderText = "Total Residus (Tones)";
                    // Formato numérico con separador de miles y 2 decimales
                    dgDades.Columns["totalResidus"].DefaultCellStyle.Format = "N2";
                    dgDades.Columns["totalResidus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDades.AllowUserToAddRows = false;
            dgDades.ReadOnly = true; // Al ser consulta, bloqueamos la edición directa en el Grid
        }

        private void FrmResidusMunicipis_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FrmMain)this.MdiParent).tancarForm(this);
        }
    }
}
