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
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void pregunta01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta01());
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

        private void pregunta05ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta05());
        }

        private void pregunta06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta06());
        }

        private void pregunta07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmPregunta07());
        }
    }
}
