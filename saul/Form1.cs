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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void algebraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.algebraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basesdatos1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basesdatos1DataSet.algebra' Puede moverla o quitarla según sea necesario.
            this.algebraTableAdapter.Fill(this.basesdatos1DataSet.algebra);

        }
    }
}
