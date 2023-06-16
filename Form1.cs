namespace PROGRAMACION_3_TP_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProyect_Click(object sender, EventArgs e)
        {
            Frm.frmProyect frmProyect = new Frm.frmProyect();

            frmProyect.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Frm.frmEmployee frmEmployee = new Frm.frmEmployee();

            frmEmployee.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Frm.frmOwner frmOwner = new Frm.frmOwner();

            frmOwner.Show();
        }
    }
}