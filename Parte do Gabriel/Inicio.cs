namespace lojaDasVariedades
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sobre sobre = new sobre();
            sobre.Show();
        }
    }
}
