using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saul
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basesdatos1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basesdatos1DataSet.calculo' Puede moverla o quitarla según sea necesario.
            this.calculoTableAdapter.Fill(this.basesdatos1DataSet.calculo);

        }
    }
}
