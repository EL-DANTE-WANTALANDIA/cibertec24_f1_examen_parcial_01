namespace slnExamenParcial_DanteQuispe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MostrarForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregunta01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta1());
        }

        private void pregunta02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta02());
        }

        private void pregunta03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta03());
        }

        private void pregunta04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta04());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pregunta05ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta05());
        }
    }
}
