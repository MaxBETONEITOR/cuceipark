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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBIMDataSet);

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBIMDataSet.Estacionamiento' Puede moverla o quitarla según sea necesario.
            this.estacionamientoTableAdapter.Fill(this.dBIMDataSet.Estacionamiento);
            // TODO: esta línea de código carga datos en la tabla 'dBIMDataSet.Registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.dBIMDataSet.Registro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control popsC = new Control();


            popsC.Show();
            this.Show();
        }
    }
}
