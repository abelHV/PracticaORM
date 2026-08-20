using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaORM.FORMULARIS
{
    public partial class FrmABMMunicipios : Form
    {
        private Char op { get; set; } = '\0';
        private GestionResiduosEntities gestionResiduosContext { get; set; }

        // Propiedades públicas para recibir datos del Grid
        public String id { get; set; } = "";
        public String nom { get; set; } = "";
        public int poblacio { get; set; }
        public int idComarcaRebuda { get; set; }

        public FrmABMMunicipios(Char xop, GestionResiduosEntities xcontext)
        {
            InitializeComponent();
            gestionResiduosContext = xcontext;
            op = xop;
        }

        private void FrmABMMunicipios_Load(object sender, EventArgs e)
        {
            omplirComboComarques();
            configurarNumericUpDown();

            switch (op)
            {
                case 'A':
                    this.Text = "Alta d'un nou municipi";
                    int nuevoId = 1;
                    if (gestionResiduosContext.Municipios.Any())
                    {
                        nuevoId = gestionResiduosContext.Municipios.Max(m => m.Id) + 1;
                    }
                    tbId.Text = nuevoId.ToString();
                    break;
                case 'B':
                    this.Text = "Eliminar municipi";
                    tbId.Text = id;
                    break;
                case 'M':
                    this.Text = "Modificar municipi";
                    tbId.Text = id;
                    break;
            }

            // Asignamos valores al resto de controles
            tbNom.Text = nom;
            nupHabitants.Value = (op == 'A') ? 0 : poblacio;
            cbComarques.SelectedValue = idComarcaRebuda;

            // Bloqueos: tbId SIEMPRE deshabilitado (ya que es automático o viene de la BD)
            tbId.Enabled = false;
            tbNom.Enabled = (op != 'B');
            nupHabitants.Enabled = (op != 'B');
            cbComarques.Enabled = (op != 'B');
        }

        private void configurarNumericUpDown()
        {
            nupHabitants.Minimum = 0;
            nupHabitants.Maximum = 10000000; // 10 millones por ejemplo
            nupHabitants.ThousandsSeparator = true;
        }

        private void omplirComboComarques()
        {
            var qry = from c in gestionResiduosContext.Comarcas
                      orderby c.Nombre
                      select c;

            cbComarques.DataSource = qry.ToList();
            cbComarques.DisplayMember = "Nombre"; // Lo que el usuario ve
            cbComarques.ValueMember = "Id";       // El ID real
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addMunicipi(); break;
                    case 'B': xb = delMunicipi(); break;
                    case 'M': xb = updMunicipi(); break;
                }
                if (xb) this.Close();
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            id = ""; // Reset para que el form principal sepa que se canceló
            this.Close();
        }

        private Boolean vDades()
        {
            if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbNom.Text))
            {
                MessageBox.Show("El codi i el nom del municipi són obligatoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbComarques.SelectedValue == null)
            {
                MessageBox.Show("Has de seleccionar una comarca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private Boolean addMunicipi()
        {
            try
            {
                Municipios m = new Municipios();
                m.Id = int.Parse(tbId.Text); // Usamos el ID autogenerado que hay en el TextBox
                m.Nombre = tbNom.Text.Trim();
                m.NumHabitants = (int)nupHabitants.Value;
                m.ComarcaId = (int)cbComarques.SelectedValue;

                gestionResiduosContext.Municipios.Add(m);
                if (ferCanvis())
                {
                    id = m.Id.ToString(); // Asignamos a la propiedad pública para que el grid pueda seleccionar la fila
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al processar l'alta: " + ex.Message, "ERROR");
            }
            return false;
        }

        private Boolean delMunicipi()
        {
            int idB = int.Parse(tbId.Text);
            var m = gestionResiduosContext.Municipios.Find(idB);
            if (m != null)
            {
                gestionResiduosContext.Municipios.Remove(m);
                return ferCanvis();
            }
            return false;
        }

        private Boolean updMunicipi()
        {
            int idB = int.Parse(tbId.Text);
            var m = gestionResiduosContext.Municipios.Find(idB);
            if (m != null)
            {
                m.Nombre = tbNom.Text.Trim();
                m.NumHabitants = (int)nupHabitants.Value;
                m.ComarcaId = (int)cbComarques.SelectedValue;
                return ferCanvis();
            }
            return false;
        }

        private Boolean ferCanvis()
        {
            try
            {
                gestionResiduosContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Error al guardar: " + errorMsg, "ERROR BD", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiar el tracker para que no intente aplicar el cambio erróneo otra vez
                foreach (var entry in gestionResiduosContext.ChangeTracker.Entries())
                    entry.State = EntityState.Detached;

                return false;
            }
        }
    }
}
