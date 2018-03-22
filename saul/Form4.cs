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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void quimicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quimicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basesdatos1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basesdatos1DataSet.quimica' Puede moverla o quitarla según sea necesario.
            this.quimicaTableAdapter.Fill(this.basesdatos1DataSet.quimica);

        }
    }
}
