using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GerirUtilizadores : Form
    {
        public GerirUtilizadores()
        {
            InitializeComponent();
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void GerirUtilizadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Utilizadores' table. You can move, or remove it, as needed.
            this.utilizadoresTableAdapter.Fill(this.dataSet1.Utilizadores);

        }
    }
}
