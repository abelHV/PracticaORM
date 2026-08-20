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
    public partial class FrmResidusAnys : Form
    {
        private GestionResiduosEntities gestionResiduosContext { get; set; }
        Boolean bFirst = true;
        public FrmResidusAnys(GestionResiduosEntities xContext)
        {
            InitializeComponent();
            gestionResiduosContext = xContext;
        }

        private void FrmResidusAnys_Load(object sender, EventArgs e)
        {
            omplirComboComarques();
            omplirFiltreAnys(); // Cargamos los años reales de la BD
            getDades();         // Primero cargamos los datos
            iniDgrid();         // Segundo aplicamos el formato con los "if" de seguridad
            bFirst = false;
        }

        private void omplirFiltreAnys()
        {
            // Extrae los años que existen en la tabla Residuos ordenados de más nuevo a más antiguo
            var anys = (from r in gestionResiduosContext.Residus
                        where r.Anyo != null
                        select r.Anyo).Distinct().OrderByDescending(a => a).ToList();

            clbAnys.Items.Clear();
            foreach (var any in anys)
            {
                clbAnys.Items.Add(any);
            }

            // Al hacer un solo clic sobre el año, se marcará el checkbox automáticamente
            clbAnys.CheckOnClick = true;
        }

        private void clbAnys_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() => getDades()));
        }

        private void tbMunicipi_TextChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private void cbComarques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst) getDades();
        }

        private void chkTotes_CheckedChanged(object sender, EventArgs e)
        {
            cbComarcas.Enabled = !chkTotes.Checked;
            getDades();
        }

        // --- CONSULTA LINQ: AHORA INCLUYE EL AÑO EN EL GRID ---
        private void getDades()
        {
            List<int> anysSeleccionats = new List<int>();
            foreach (var item in clbAnys.CheckedItems)
            {
                anysSeleccionats.Add((int)item);
            }

            // Cambiamos la lógica: seleccionamos los residuos directamente 
            // para poder extraer el año fila por fila junto al municipio
            var qry = from r in gestionResiduosContext.Residus
                      join m in gestionResiduosContext.Municipios on r.MunicipioId equals m.Id
                      join c in gestionResiduosContext.Comarcas on m.ComarcaId equals c.Id
                      where (!anysSeleccionats.Any() || anysSeleccionats.Contains((int)r.Anyo))
                      select new
                      {
                          id = m.Id,              // ID Municipio (Lo mantendremos oculto)
                          idComarca = m.ComarcaId,// ID Comarca (Lo mantendremos oculto)
                          nom = m.Nombre,
                          nomComarca = c.Nombre,
                          anyo = r.Anyo,          // ¡Añadimos el Año aquí!
                          totalResidus = (double?)(r.Vidre ?? 0) +
                                         (double?)(r.PodaJardineria ?? 0) +
                                         (double?)(r.PaperCartro ?? 0)
                      };

            // Filtro por Comarca
            if (!chkTotes.Checked && cbComarcas.SelectedValue != null)
            {
                int idC = (int)cbComarcas.SelectedValue;
                qry = qry.Where(x => x.idComarca == idC);
            }

            // Filtro por búsqueda de texto del municipio
            string textoBusqueda = tbMunicipi.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                qry = qry.Where(x => x.nom.ToLower().Contains(textoBusqueda));
            }

            // Mostramos los datos ordenados por Municipio y luego por Año de forma descendente
            dgDades.DataSource = qry.OrderBy(x => x.nom).ThenByDescending(x => x.anyo).ToList();

            iniDgrid();
        }

        // --- FORMATO DEL GRID CON EL CÓDIGO OCULTO ---
        private void iniDgrid()
        {
            if (dgDades.Columns.Count > 0)
            {
                // TAPAR LOS CÓDIGOS (Ocultamos las columnas ID para que no se vean)
                if (dgDades.Columns["id"] != null) dgDades.Columns["id"].Visible = false;
                if (dgDades.Columns["idComarca"] != null) dgDades.Columns["idComarca"].Visible = false;

                // Columnas visibles y textos bonitos
                if (dgDades.Columns["nom"] != null) dgDades.Columns["nom"].HeaderText = "Municipi";
                if (dgDades.Columns["nomComarca"] != null) dgDades.Columns["nomComarca"].HeaderText = "Comarca";

                if (dgDades.Columns["anyo"] != null)
                {
                    dgDades.Columns["anyo"].HeaderText = "Any";
                    dgDades.Columns["anyo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgDades.Columns["totalResidus"] != null)
                {
                    dgDades.Columns["totalResidus"].HeaderText = "Total Residus (Tones)";
                    dgDades.Columns["totalResidus"].DefaultCellStyle.Format = "N2";
                    dgDades.Columns["totalResidus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dgDades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDades.AllowUserToAddRows = false;
            dgDades.ReadOnly = true;
        }

        private void omplirComboComarques()
        {
            var qry = from c in gestionResiduosContext.Comarcas
                      orderby c.Nombre
                      select c;

            cbComarcas.DataSource = qry.ToList();
            cbComarcas.DisplayMember = "Nombre";
            cbComarcas.ValueMember = "Id";
        }

        private void FrmResidusAnys_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FrmMain)this.MdiParent).tancarForm(this);
        }
    }
}
