namespace CadastrarCliente
{
    partial class Carrinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            menuStrip2 = new MenuStrip();
            inícioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(222, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 375);
            dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(12, 329);
            button3.Name = "button3";
            button3.Size = new Size(171, 47);
            button3.TabIndex = 3;
            button3.Text = "Remover Produto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 391);
            button4.Name = "button4";
            button4.Size = new Size(171, 47);
            button4.TabIndex = 4;
            button4.Text = "Finalizar Carrinho";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Navy;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, sobreToolStripMenuItem, toolStripMenuItem4 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(4, 1, 0, 1);
            menuStrip2.Size = new Size(804, 24);
            menuStrip2.TabIndex = 42;
            menuStrip2.Text = "menuStrip2";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Font = new Font("Segoe UI", 9F);
            inícioToolStripMenuItem.ForeColor = Color.White;
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Size = new Size(48, 22);
            inícioToolStripMenuItem.Text = "&Início";
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripMenuItem2.ForeColor = Color.White;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(66, 22);
            toolStripMenuItem2.Text = "&Carrinho";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(67, 22);
            toolStripMenuItem1.Text = "&Produtos";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.ForeColor = Color.White;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 22);
            sobreToolStripMenuItem.Text = "&Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem4.ForeColor = Color.White;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(38, 22);
            toolStripMenuItem4.Text = "Sair";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(218, 411);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 43;
            label1.Text = "Valor do carrinho:";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(763, 411);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Carrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(804, 451);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Carrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping das Variedades - Carrinho";
            Load += Carrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private Label label1;
        private PictureBox pictureBox2;
    }
}