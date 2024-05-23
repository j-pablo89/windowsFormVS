using Pav.Ut3.Tp5.Modelo;
using Pav.Ut3.Tp5.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Ut3.Tp5.Vistas
{
    public partial class AgregarAnimalView : Form
    {
        public AgregarAnimalView()
        {
            InitializeComponent();
            especieBindingSource.DataSource = Repositorio.Instance.Especies;
            paisBindingSource.DataSource = Repositorio.Instance.Paises;
        }

        private void AgregarAnimalView_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecie.SelectedItem == null) return;
            var especie = cbEspecie.SelectedItem as Especie;
            lbSectores.Items.Clear();
            lbSectores.Items.AddRange(
                Repositorio.Instance.Sectores
                .Where(s => s.TipoAlimentacion == especie!.TipoAlimentacion)
                .Select(e=> e.ToString())
                .ToArray());
        }
    }
}
