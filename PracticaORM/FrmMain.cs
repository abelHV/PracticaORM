using PracticaORM.FORMULARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaORM
{
    public partial class FrmMain : Form
    {
        private GestionResiduosEntities gestionResiduosContext { get; set; } = new GestionResiduosEntities();       // necessitem una instància del Context

        FrmImportacio fImportacio = null;

        FrmComarques fComarques = null;

        FrmMunicipis fMunicipis = null;

        FrmResidusMunicipis fResidusMunicipis = null;

        FrmResidusAnys fResidusAnys = null;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void testBaseDeDadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verificarConnexio();

        }

        private Boolean ja_esta_obert(String xnom)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom);
                x1++;
            }
            return (xb);
        }

        private void verificarConnexio()
        {
            Boolean xb = testConnexio();

            menuImportacio.Enabled = xb;
            menuGestio.Enabled = xb;
            menuConsulta.Enabled = xb;
            
        }

        private Boolean testConnexio()
        {
            Boolean xb = false;

            Cursor = Cursors.WaitCursor;
            try
            {
                xb = (gestionResiduosContext.Database.Connection.State == ConnectionState.Open);
                if (!xb)
                {
                    gestionResiduosContext.Database.Connection.Open();
                    xb = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            return xb;
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verificarConnexio();
        }

        private void menuImportacio_Click(object sender, EventArgs e)
        {
            String xnom = "Importacio";

            if (!(ja_esta_obert(xnom)))
            {
                fImportacio = new FrmImportacio(gestionResiduosContext); // fem un nou formulari i l'afegim a la llista de formularis
                fImportacio.Name = xnom;
                fImportacio.MdiParent = this;
                fImportacio.Show();
            }
            fImportacio.Activate();
        }

       

        public void tancarForm(Form xform)
        {
            xform = null;
        }

        private void comarquesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String xnom = "Comarques";

            if (!(ja_esta_obert(xnom)))
            {
                fComarques = new FrmComarques(gestionResiduosContext); // fem un nou formulari i l'afegim a la llista de formularis
                fComarques.Name = xnom;
                fComarques.MdiParent = this;
                fComarques.Show();
            }
            fComarques.Activate();
        }

        private void municipisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String xnom = "Municipis";

            if (!(ja_esta_obert(xnom)))
            {
                fMunicipis = new FrmMunicipis(gestionResiduosContext); // fem un nou formulari i l'afegim a la llista de formularis
                fMunicipis.Name = xnom;
                fMunicipis.MdiParent = this;
                fMunicipis.Show();
            }
            fMunicipis.Activate();
        }

        private void residusPerMunicipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "ResidusMunicipis";

            if (!(ja_esta_obert(xnom)))
            {
                fResidusMunicipis = new FrmResidusMunicipis(gestionResiduosContext); // fem un nou formulari i l'afegim a la llista de formularis
                fResidusMunicipis.Name = xnom;
                fResidusMunicipis.MdiParent = this;
                fResidusMunicipis.Show();
            }
            fResidusMunicipis.Activate();
        }

        private void residusPerMunicipiYAnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "ResidusAnys";

            if (!(ja_esta_obert(xnom)))
            {
                fResidusAnys = new FrmResidusAnys(gestionResiduosContext); // fem un nou formulari i l'afegim a la llista de formularis
                fResidusAnys.Name = xnom;
                fResidusAnys.MdiParent = this;
                fResidusAnys.Show();
            }
            fResidusAnys.Activate();
        }
    }
}
