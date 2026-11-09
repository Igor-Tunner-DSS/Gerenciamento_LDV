namespace lojaDasVariedades
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            menuStrip1 = new MenuStrip();
            inícioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            carrinhoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            logo = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            destaques = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, toolStripMenuItem2, produtosToolStripMenuItem, sobreToolStripMenuItem, carrinhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1347, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inícioToolStripMenuItem.ForeColor = Color.White;
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.I;
            inícioToolStripMenuItem.Size = new Size(49, 22);
            inícioToolStripMenuItem.Text = "&Início";
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.ForeColor = Color.White;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Alt | Keys.C;
            toolStripMenuItem2.Size = new Size(65, 22);
            toolStripMenuItem2.Text = "&Carrinho";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.ForeColor = Color.White;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            produtosToolStripMenuItem.Size = new Size(67, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.ForeColor = Color.White;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            sobreToolStripMenuItem.Size = new Size(49, 22);
            sobreToolStripMenuItem.Text = "&Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // carrinhoToolStripMenuItem
            // 
            carrinhoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            carrinhoToolStripMenuItem.ForeColor = Color.White;
            carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            carrinhoToolStripMenuItem.Size = new Size(38, 22);
            carrinhoToolStripMenuItem.Text = "Sair";
            carrinhoToolStripMenuItem.Click += carrinhoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 20, 20);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(0, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1347, 49);
            label1.TabIndex = 3;
            label1.Text = "SHOPPING DAS VARIEDADES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.Center;
            logo.Dock = DockStyle.Top;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(451, 2);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(445, 319);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 4;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click;
            logo.MouseLeave += logo_MouseLeave;
            logo.MouseHover += logo_MouseHover;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.RoyalBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(logo, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 73);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(1347, 788);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox4, 1, 2);
            tableLayoutPanel2.Controls.Add(pictureBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(destaques, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Size = new Size(445, 784);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = CadastrarCliente.Properties.Resources.sementes;
            pictureBox4.Location = new Point(224, 432);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 245);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = CadastrarCliente.Properties.Resources.fitas;
            pictureBox3.Location = new Point(2, 432);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(218, 245);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = CadastrarCliente.Properties.Resources.puppies4;
            pictureBox2.Location = new Point(224, 80);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // destaques
            // 
            destaques.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(destaques, 2);
            destaques.Dock = DockStyle.Fill;
            destaques.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            destaques.ForeColor = Color.WhiteSmoke;
            destaques.Location = new Point(2, 0);
            destaques.Margin = new Padding(2, 0, 2, 0);
            destaques.Name = "destaques";
            destaques.Size = new Size(441, 78);
            destaques.TabIndex = 0;
            destaques.Text = "DESTAQUES";
            destaques.TextAlign = ContentAlignment.MiddleCenter;
            destaques.Click += destaques_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = CadastrarCliente.Properties.Resources.cadernos;
            pictureBox1.Location = new Point(2, 80);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.White;
            imageList1.Images.SetKeyName(0, "cadernos.png");
            imageList1.Images.SetKeyName(1, "canetas.png");
            imageList1.Images.SetKeyName(2, "fitas.png");
            imageList1.Images.SetKeyName(3, "sementes.png");
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1347, 861);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping das Variedades";
            FormClosed += inicio_FormClosed;
            Load += inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem carrinhoToolStripMenuItem;
        private Label label1;
        private PictureBox logo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label destaques;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
