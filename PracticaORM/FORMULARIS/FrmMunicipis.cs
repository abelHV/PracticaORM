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
    public partial class FrmMunicipis : Form
    {
        private GestionResiduosEntities gestionResiduosContext { get; set; }
        Boolean bFirst = true;
        FrmABMMunicipios fABMMunicipios = null;
        public FrmMunicipis(GestionResiduosEntities xContext)
        {
            InitializeComponent();
            gestionResiduosContext = xContext;
        }

        private void FrmMunicipis_Load(object sender, EventArgs e)
        {
            omplirComboComarcas();
            getDades(); // Carga inicial
            iniDgrid();
            
            bFirst = false;
        }

        private void cbMunicipis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst) getDades();
        }

        private void chkTotes_CheckedChanged(object sender, EventArgs e)
        {
            cbComarcas.Enabled = !chkTotes.Checked;
            getDades();
        }

        private void tbMunicipis_TextChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private void getDades()
        {
            // Hacemos un JOIN entre Municipios y Comarcas
            var qry = from m in gestionResiduosContext.Municipios
                      join c in gestionResiduosContext.Comarcas on m.ComarcaId equals c.Id
                      select new
                      {
                          id = m.Id,
                          nom = m.Nombre,
                          poblacio = m.NumHabitants,
                          idComarca = m.ComarcaId, // Lo mantenemos oculto para lógica interna
                          nomComarca = c.Nombre    // Este es el que el usuario verá
                      };

            // Aplicar filtros (Check y TextBox)
            if (!chkTotes.Checked && cbComarcas.SelectedValue != null)
            {
                int idC = (int)cbComarcas.SelectedValue;
                qry = qry.Where(m => m.idComarca == idC);
            }

            string textoBusqueda = tbCercar.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                qry = qry.Where(m => m.nom.ToLower().Contains(textoBusqueda));
            }

            dgDades.DataSource = qry.OrderBy(m => m.nom).ToList();

            // Ajustamos las columnas para que el ID de la comarca no se vea
            if (dgDades.Columns["idComarca"] != null) dgDades.Columns["idComarca"].Visible = false;
            if (dgDades.Columns["nomComarca"] != null) dgDades.Columns["nomComarca"].HeaderText = "Comarca";
        }

        private void omplirComboComarcas()
        {
            var qry = from c in gestionResiduosContext.Comarcas
                      orderby c.Nombre
                      select c;

            cbComarcas.DataSource = qry.ToList();
            cbComarcas.DisplayMember = "Nombre";
            cbComarcas.ValueMember = "Id"; // Asegúrate que el ID de comarca es int
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fABMMunicipios = new FrmABMMunicipios('A', gestionResiduosContext);

            // Si tenemos una comarca seleccionada en el combo, se la pasamos por defecto
            if (!chkTotes.Checked && cbComarcas.SelectedValue != null)
            {
                fABMMunicipios.idComarcaRebuda = (int)cbComarcas.SelectedValue;
            }

            fABMMunicipios.ShowDialog();
            getDades();

            if (fABMMunicipios.id != "") seleccionarFila(fABMMunicipios.id);
            fABMMunicipios = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgDades.SelectedRows.Count > 0)
            {
                fABMMunicipios = new FrmABMMunicipios('B', gestionResiduosContext);
                MapearFilaAForm(fABMMunicipios);
                fABMMunicipios.ShowDialog();
                getDades();
                fABMMunicipios = null;
            }
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDades.SelectedRows.Count > 0)
            {
                fABMMunicipios = new FrmABMMunicipios('M', gestionResiduosContext);
                MapearFilaAForm(fABMMunicipios);
                fABMMunicipios.ShowDialog();
                getDades();
                if (fABMMunicipios.id != "") seleccionarFila(fABMMunicipios.id);
                fABMMunicipios = null;
            }
        }

        private void MapearFilaAForm(FrmABMMunicipios form)
        {
            form.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString();
            form.nom = dgDades.SelectedRows[0].Cells["nom"].Value.ToString();
            form.poblacio = (int)dgDades.SelectedRows[0].Cells["poblacio"].Value;
            form.idComarcaRebuda = (int)dgDades.SelectedRows[0].Cells["idComarca"].Value;
        }

        private void iniDgrid()
        {
            dgDades.Columns["id"].HeaderText = "Codi";
            dgDades.Columns["nom"].HeaderText = "Municipi";
            dgDades.Columns["poblacio"].HeaderText = "Població";
            dgDades.Columns["idComarca"].Visible = false;
            dgDades.Columns["nomComarca"].HeaderText = "Comarca";

            dgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDades.AllowUserToAddRows = false;
        }

        private void seleccionarFila(string id)
        {
            foreach (DataGridViewRow row in dgDades.Rows)
            {
                if (row.Cells["id"].Value.ToString() == id)
                {
                    dgDades.ClearSelection();
                    row.Selected = true;
                    dgDades.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void FrmMunicipis_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FrmMain)this.MdiParent).tancarForm(this);
        }
    }
}
