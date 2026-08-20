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
    public partial class FrmComarques : Form
    {

        // Propiedad para el contexto de la base de datos
        private GestionResiduosEntities gestionResiduosContext { get; set; }

        // Variables globales para controlar el estado
        Boolean bFirst = true;
        FrmABMComarcas fABMComarcas = null;
        public FrmComarques(GestionResiduosEntities xContext)
        {
            InitializeComponent();
            gestionResiduosContext = xContext;
        }

        private void FrmComarques_Load(object sender, EventArgs e)
        {
            getDades();
            iniDgrid();
            bFirst = false;
        }

        private void FrmComarques_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ajusta esto según el nombre de tu formulario principal
            ((FrmMain)this.MdiParent).tancarForm(this);
        }

        private void getDades(string filtro = "")
        {
            var qryComarcas = from c in gestionResiduosContext.Comarcas
                              where c.Nombre.ToLower().Contains(filtro) // Filtramos por nombre
                              orderby c.Nombre
                              select new
                              {
                                  id = c.Id,
                                  nom = c.Nombre,
                                  capital = c.Capital
                              };

            dgDades.DataSource = qryComarcas.ToList();
        }

        // --- PERSONALIZACIÓN DEL GRID ---
        private void iniDgrid()
        {
            if (dgDades.Columns["id"] != null) dgDades.Columns["id"].HeaderText = "ID";
            if (dgDades.Columns["nom"] != null) dgDades.Columns["nom"].HeaderText = "Comarca";
            if (dgDades.Columns["capital"] != null) dgDades.Columns["capital"].HeaderText = "Capital";

            dgDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDades.AllowUserToAddRows = false;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            fABMComarcas = new FrmABMComarcas('A', gestionResiduosContext);
            fABMComarcas.ShowDialog();

            getDades(); // Refrescar

            if (!string.IsNullOrEmpty(fABMComarcas.id))
            {
                seleccionarFila(fABMComarcas.id);
            }
            fABMComarcas = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgDades.SelectedRows.Count > 0)
            {
                fABMComarcas = new FrmABMComarcas('B', gestionResiduosContext);

                // Pasamos los datos a las propiedades del formulario ABM
                fABMComarcas.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString();
                fABMComarcas.nom = dgDades.SelectedRows[0].Cells["nom"].Value.ToString();
                fABMComarcas.capital = dgDades.SelectedRows[0].Cells["capital"].Value.ToString();

                fABMComarcas.ShowDialog();
                getDades();
                fABMComarcas = null;
            }
            else
            {
                MessageBox.Show("Selecciona una comarca per eliminar.", "Avís", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDades.SelectedRows.Count > 0)
            {
                fABMComarcas = new FrmABMComarcas('M', gestionResiduosContext);

                fABMComarcas.id = dgDades.SelectedRows[0].Cells["id"].Value.ToString();
                fABMComarcas.nom = dgDades.SelectedRows[0].Cells["nom"].Value.ToString();
                fABMComarcas.capital = dgDades.SelectedRows[0].Cells["capital"].Value.ToString();

                fABMComarcas.ShowDialog();
                getDades();

                if (!string.IsNullOrEmpty(fABMComarcas.id))
                {
                    seleccionarFila(fABMComarcas.id);
                }
                fABMComarcas = null;
            }
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

        private void tbComarca_TextChanged(object sender, EventArgs e)
        {
            string filtro = tbComarca.Text.Trim().ToLower();
            getDades(filtro);
        }
    }
}
