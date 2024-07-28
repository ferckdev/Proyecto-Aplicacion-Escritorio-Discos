using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace trabajo_practico_con_Discos_db
{
  
    public partial class frmDisco : Form
    {
        private List<Disco> listaDisco;
        public frmDisco()
        {
            InitializeComponent();
        }

        private void frmDisco_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.listar();
            dgvDisco.DataSource = listaDisco;
            dgvDisco.Columns["UrlImagentapa"].Visible= false;
            cargarImagen(listaDisco[0].UrlimagenTapa);
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
           Disco selecionado = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            cargarImagen(selecionado.UrlimagenTapa);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);

            }
            catch (Exception)
            {

                pbxDisco.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
        }
    }
}
