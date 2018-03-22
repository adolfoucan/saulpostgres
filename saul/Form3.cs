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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void fisicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fisicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basesdatos1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basesdatos1DataSet.fisica' Puede moverla o quitarla según sea necesario.
            this.fisicaTableAdapter.Fill(this.basesdatos1DataSet.fisica);

        }
    }
}
