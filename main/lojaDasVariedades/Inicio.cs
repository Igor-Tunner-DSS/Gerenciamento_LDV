namespace lojaDasVariedades
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();

            Dictionary<string, string[]> images = new Dictionary<string, string[]>();
            images.Add("canetas", [@"./Resources/canetas.png"]);

            pictureBox2.ImageLocation = images["canetas"][0];

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sobre sobre = new sobre();
            sobre.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Image[] getFeaturedImages()
        {
            Image[] images = new Image[4];
            images[0] = imageList1.Images[0];
            images[1] = imageList1.Images[1];
            images[2] = imageList1.Images[2];
            images[3] = imageList1.Images[3];
            

            return images;
        }
    }
}
