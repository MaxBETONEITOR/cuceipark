using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_gráfica
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void estacionamientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estacionamientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBIMDataSet);

        }

        private void Control_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBIMDataSet.Estacionamiento' Puede moverla o quitarla según sea necesario.
            this.estacionamientoTableAdapter.Fill(this.dBIMDataSet.Estacionamiento);

        }
    }
}
