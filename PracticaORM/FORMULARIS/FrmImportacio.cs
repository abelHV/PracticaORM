using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PracticaORM.FORMULARIS
{
    public partial class FrmImportacio : Form
    {

        private string rutaArchivo = string.Empty;
        private GestionResiduosEntities gestionResiduosContext { get; set; }
        private bool aturarImportacio = false; // Control per al botó Aturar


        public FrmImportacio(GestionResiduosEntities xGestionResiduos)
        {
            InitializeComponent();
            gestionResiduosContext = xGestionResiduos;
        }

        private void FrmImportacio_Load(object sender, EventArgs e)
        {

        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arxius XML (*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    lbEstat.Text = "Arxiu preparat: " + Path.GetFileName(rutaArchivo);
                    lbEstat.ForeColor = Color.Blue;
                    lbRegistres.Items.Clear();
                    LogMensaje($"[SISTEMA] Arxiu seleccionat: {Path.GetFileName(rutaArchivo)}");
                }
            }
        }

        private void btArchiu_Click(object sender, EventArgs e)
        {
            if (!ValidarRequisits()) return;

            string opcion = cbImportar.SelectedItem.ToString();

            // --- VALIDACIÓ DE JERARQUIA ---
            if (opcion == "Municipis" && !gestionResiduosContext.Comarcas.Any())
            {
                MessageBox.Show("Error: No pots importar Municipis si no hi ha Comarques a la base de dades.", "Error de jerarquia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (opcion == "Residus" && !gestionResiduosContext.Municipios.Any())
            {
                MessageBox.Show("Error: No pots importar Residus si no hi ha Municipis a la base de dades.", "Error de jerarquia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            aturarImportacio = false;
            PrepararInterfaz(opcion);

            try
            {

                gestionResiduosContext.Configuration.AutoDetectChangesEnabled = false;
                XDocument doc = XDocument.Load(rutaArchivo);
                var rows = doc.Descendants("row").Where(r => r.Element("municipi") != null);

                HashSet<string> cacheProcesados = new HashSet<string>();
                string ultimoMunicipioLog = "";
                int totalAnalizados = 0;

                foreach (var row in rows)
                {
                    if (aturarImportacio) break;

                    string xmlComarca = (string)row.Element("comarca");
                    string xmlMunicipi = (string)row.Element("municipi");

                    switch (opcion)
                    {
                        case "Comarcas":
                            ImportarComarca(xmlComarca, cacheProcesados);
                            break;
                        case "Municipis":
                            ImportarMunicipio(row, xmlMunicipi, xmlComarca, cacheProcesados);
                            break;
                        case "Residus":
                            ImportarResiduo(row, xmlMunicipi, ref ultimoMunicipioLog);
                            break;
                    }

                    totalAnalizados++;

                    // Contador visual 1 a 1
                    lbEstat.Text = $"Analitzant registre: {totalAnalizados}...";

                    if (totalAnalizados % 10 == 0) Application.DoEvents();

                    // SaveChanges por lotes para velocidad
                    if (totalAnalizados % 100 == 0)
                    {
                        gestionResiduosContext.SaveChanges();
                    }
                }

                gestionResiduosContext.SaveChanges();
                FinalizarInterfaz(totalAnalizados);
            }
            catch (Exception ex)
            {
                lbEstat.Text = "Error en el procés.";
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // --- FUNCIONES DE LÓGICA (MÁS LIMPIO) ---

        private void ImportarComarca(string nombre, HashSet<string> cache)
        {
            if (cache.Contains(nombre)) return;

            var comarca = gestionResiduosContext.Comarcas.FirstOrDefault(c => c.Nombre == nombre);

            if (comarca == null)
            {
                gestionResiduosContext.Comarcas.Add(new Comarcas { Nombre = nombre, Capital = "Desconeguda" });
                LogMensaje($"[NOVA COMARCA] {nombre}");
            }
            else
            {
                // Ahora el log avisa si ya existía y se ha procesado
                LogMensaje($"[ACTUALITZADA] Comarca: {nombre}");
            }
            cache.Add(nombre);
        }

        private void ImportarMunicipio(XElement row, string nomMuni, string nomComa, HashSet<string> cache)
        {
            if (cache.Contains(nomMuni)) return;
            var comarca = gestionResiduosContext.Comarcas.FirstOrDefault(c => c.Nombre == nomComa);
            if (comarca != null)
            {
                int habs = (int?)row.Element("poblaci") ?? 0;
                var muni = gestionResiduosContext.Municipios.FirstOrDefault(m => m.Nombre == nomMuni);
                if (muni == null)
                {
                    gestionResiduosContext.Municipios.Add(new Municipios { Nombre = nomMuni, ComarcaId = comarca.Id, NumHabitants = habs });
                    LogMensaje($"[NOU MUNICIPI] {nomMuni}");
                }
                else
                {
                    muni.NumHabitants = habs;
                    LogMensaje($"[ACTUALITZAT] {nomMuni}");
                }
                cache.Add(nomMuni);
            }
        }

        private void ImportarResiduo(XElement row, string nomMuni, ref string ultimoMuni)
        {
            var muni = gestionResiduosContext.Municipios.FirstOrDefault(m => m.Nombre == nomMuni);
            if (muni != null)
            {
                int anyo = (int?)row.Element("any") ?? 0;
                var res = gestionResiduosContext.Residus.FirstOrDefault(r => r.Anyo == anyo && r.MunicipioId == muni.Id);

                double org = (double?)row.Element("mat_ria_org_nica") ?? 0;
                double pod = (double?)row.Element("poda_i_jardineria") ?? 0;
                double pap = (double?)row.Element("paper_i_cartr") ?? 0;
                double vid = (double?)row.Element("vidre") ?? 0;

                string etiquetaEstado = "";

                if (res == null)
                {
                    gestionResiduosContext.Residus.Add(new Residus
                    {
                        Anyo = anyo,
                        MunicipioId = muni.Id,
                        MateriaOrganica = org,
                        PodaJardineria = pod,
                        PaperCartro = pap,
                        Vidre = vid
                    });
                    etiquetaEstado = "NOU REGISTRE";
                }
                else
                {
                    res.MateriaOrganica = org;
                    res.PodaJardineria = pod;
                    res.PaperCartro = pap;
                    res.Vidre = vid;
                    etiquetaEstado = "ACTUALITZAT";
                }

                // Log: Solo escribe cuando cambia el municipio para no colapsar el ListBox, 
                // pero ahora incluye el estado (Nuevo/Actualizado) y el año.
                if (nomMuni != ultimoMuni)
                {
                    LogMensaje($"[{etiquetaEstado}] {nomMuni} - Any {anyo}");
                    ultimoMuni = nomMuni;
                }
            }
        }

        // --- UTILIDADES DE INTERFAZ ---

        private void LogMensaje(string msg)
        {
            lbRegistres.Items.Add($"{DateTime.Now.ToString("HH:mm:ss")} - {msg}");
            lbRegistres.TopIndex = lbRegistres.Items.Count - 1;
        }

        private bool ValidarRequisits()
        {
            if (string.IsNullOrEmpty(rutaArchivo)) { lbEstat.Text = "Selecciona un arxiu."; return false; }
            if (cbImportar.SelectedItem == null) { lbEstat.Text = "Selecciona categoria."; return false; }
            return true;
        }

        private void PrepararInterfaz(string opc)
        {
            lbRegistres.Items.Add($"--- INICIANT IMPORTACIÓ: {opc.ToUpper()} ---");
            lbEstat.ForeColor = Color.DarkBlue;
            btArchiu.Enabled = false;
        }

        private void FinalizarInterfaz(int n)
        {
            btArchiu.Enabled = true;
            if (aturarImportacio)
            {
                lbEstat.Text = "Importació cancel·lada.";
                lbEstat.ForeColor = Color.Red;
            }
            else
            {
                lbEstat.Text = $"Finalitzat! {n} registres analitzats. Pots carregar més.";
                lbEstat.ForeColor = Color.Green;
                LogMensaje(">>> PROCÉS COMPLETAT.");
            }
        }

        private void btAturar_Click(object sender, EventArgs e)
        {
            aturarImportacio = true;
            lbEstat.Text = "Aturant importació...";
            lbEstat.ForeColor = Color.Orange;
        }
    }
}
