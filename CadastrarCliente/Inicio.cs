using CadastrarCliente;
using CadastrarCliente.Properties;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.util;
using CadastrarCliente.PastaUtil;

namespace lojaDasVariedades
{
    public partial class inicio : Form
    {
        private System.Windows.Forms.Timer fadeTimer;
        private float opacity = 1f;
        private bool fadingOut = false;
        private Image fromImage;
        private Image toImage;
        private Bitmap lastGeneratedBmp = null;
        private const float step = 0.08f;

        public inicio()
        {
            InitializeComponent();



            //fadeTimer = new System.Windows.Forms.Timer();
            //fadeTimer.Interval = 40;
            //fadeTimer.Tick += FadeTimer_Tick;

            //// liga eventos
            //logo.MouseHover += logo_MouseHover;
            //logo.MouseLeave += logo_MouseLeave;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente.PastaUtil.Util.CreateForm(new sobre());
            this.Hide();
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

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarCliente.PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente.PastaUtil.Util.CreateForm(new Produtos());
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarCliente.PastaUtil.Util.CreateForm(new Carrinho());
            this.Hide();
        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logo_MouseHover(object sender, EventArgs e)
        {
            //StartFade(Resources.shopping_logo);
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
            //StartFade(Resources.logo);
        }

        private void StartFade(Image newImg)
        {
            if (logo.Image == newImg) return;
            fromImage = logo.Image ?? newImg;
            toImage = newImg;
            fadingOut = true;
            opacity = 1f;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadingOut)
            {
                opacity -= step;
                if (opacity <= 0f)
                {
                    logo.Image = toImage;
                    fromImage = toImage;
                    fadingOut = false;
                    opacity = 0f;
                }
            }
            else
            {
                opacity += step;
                if (opacity >= 1f)
                {
                    opacity = 1f;
                    fadeTimer.Stop();
                    logo.Image = toImage;
                    return;
                }
            }

            if (logo.Width <= 0 || logo.Height <= 0) return;

            Bitmap bmp = new Bitmap(logo.Width, logo.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                DrawImageWithOpacity(g, fromImage, opacity, new Rectangle(0, 0, bmp.Width, bmp.Height));
                DrawImageWithOpacity(g, toImage, 1f - opacity, new Rectangle(0, 0, bmp.Width, bmp.Height));
            }

            if (lastGeneratedBmp != null && !object.ReferenceEquals(lastGeneratedBmp, fromImage) && !object.ReferenceEquals(lastGeneratedBmp, toImage))
            {
                lastGeneratedBmp.Dispose();
            }
            lastGeneratedBmp = bmp;
            logo.Image = bmp;
        }

        private void DrawImageWithOpacity(Graphics g, Image img, float alpha, Rectangle destRect)
        {
            if (img == null || alpha <= 0f) return;

            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = Math.Max(0f, Math.Min(1f, alpha));
            using (ImageAttributes attr = new ImageAttributes())
            {
                attr.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(img, destRect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attr);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void destaques_Click(object sender, EventArgs e)
        {

        }

        // REMOVA completamente o método Dispose daqui - ele já existe no Inicio.Designer.cs
        // O método Dispose fica APENAS no arquivo gerado automaticamente
    }
}