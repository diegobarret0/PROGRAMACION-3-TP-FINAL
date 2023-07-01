using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_3_TP_FINAL.Frm
{
    public partial class frmProyect : Form
    {
        public frmProyect()
        {
            InitializeComponent();
        }
        private void Propietario_Click(object sender, EventArgs e)
        {
            Frm.frmOwner frmOwner = new frmOwner();

            frmOwner.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm.frmTask frmTask = new frmTask();

            frmTask.Show();
        }
    }
}
