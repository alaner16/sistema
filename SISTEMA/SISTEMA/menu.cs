using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void aLUMNOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_alumno m = new Agregar_alumno();
            m.Show();
        }
    }
}
