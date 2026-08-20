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
    public partial class FrmABMComarcas : Form
    {

        Char op { get; set; } = '\0';
        private GestionResiduosEntities gestionResiduosContext { get; set; }

        // Propietats públiques per rebre dades del formulari principal
        public String id { get; set; } = "";
        public String nom { get; set; } = "";
        public String capital { get; set; } = "";
        public FrmABMComarcas(Char xop, GestionResiduosEntities xcontext)
        {
            InitializeComponent();
            gestionResiduosContext = xcontext;
            op = xop;
        }

        private void FrmABMComarcas_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'A': this.Text = "Alta d'una nova comarca"; break;
                case 'B': this.Text = "Eliminar comarca"; break;
                case 'M': this.Text = "Modificar comarca"; break;
            }

            // Omplir els camps de text amb les dades rebudes
            tbId.Text = id;
            tbNom.Text = nom;
            tbCapital.Text = capital;

            // Bloquejar o desbloquejar controls segons l'operació
            // L'ID normalment és autoincremental o no es toca en modificacions
            tbId.Enabled = false;
            tbNom.Enabled = (op != 'B');
            tbCapital.Enabled = (op != 'B');
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addComarca(); break;
                    case 'B': xb = delComarca(); break;
                    case 'M': xb = updComarca(); break;
                }

                if (xb) this.Close();
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            id = ""; // Indiquem que no s'ha fet res
            this.Close();
        }

        private Boolean vDades()
        {
            if (string.IsNullOrWhiteSpace(tbNom.Text))
            {
                MessageBox.Show("El nom de la comarca és obligatori", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Boolean addComarca()
        {
            Comarcas c = new Comarcas();
            c.Nombre = tbNom.Text.Trim();
            c.Capital = tbCapital.Text.Trim();

            gestionResiduosContext.Comarcas.Add(c);

            if (ferCanvis())
            {
                this.id = c.Id.ToString(); // Guardem l'ID generat
                return true;
            }
            return false;
        }

        private Boolean delComarca()
        {
            int idBuscat = int.Parse(tbId.Text);
            var c = gestionResiduosContext.Comarcas.Find(idBuscat);

            if (c != null)
            {
                // Alerta: Entity Framework fallarà si la comarca té municipis assignats (clau aliena)
                gestionResiduosContext.Comarcas.Remove(c);
                return ferCanvis();
            }
            return false;
        }

        private Boolean updComarca()
        {
            int idBuscat = int.Parse(tbId.Text);
            var c = gestionResiduosContext.Comarcas.Find(idBuscat);

            if (c != null)
            {
                c.Nombre = tbNom.Text.Trim();
                c.Capital = tbCapital.Text.Trim();
                return ferCanvis();
            }
            return false;
        }

        // Mètode genèric per guardar canvis i gestionar errors/neteja de cua
        private Boolean ferCanvis()
        {
            try
            {
                gestionResiduosContext.SaveChanges();
                return true;
            }
            catch (Exception excp)
            {
                // Mostrem l'error (InnerException sol ser més descriptiu en SQL)
                string msg = excp.InnerException != null ? excp.InnerException.Message : excp.Message;
                MessageBox.Show(msg, "ERROR en base de dades", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Netegem el rastrejador de canvis per evitar errors en cascada
                foreach (var accio in gestionResiduosContext.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }
                return false;
            }
        }




    }
}
