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
            menuStrip1 = new MenuStrip();
            inícioToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            carrinhoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, produtosToolStripMenuItem, sobreToolStripMenuItem, toolStripMenuItem1, carrinhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.ForeColor = Color.White;
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Size = new Size(70, 29);
            inícioToolStripMenuItem.Text = "&Início";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.ForeColor = Color.White;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(101, 29);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            sobreToolStripMenuItem.ForeColor = Color.White;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(75, 29);
            sobreToolStripMenuItem.Text = "&Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(139, 29);
            toolStripMenuItem1.Text = "&Faça seu login";
            // 
            // carrinhoToolStripMenuItem
            // 
            carrinhoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            carrinhoToolStripMenuItem.ForeColor = Color.White;
            carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            carrinhoToolStripMenuItem.Size = new Size(95, 29);
            carrinhoToolStripMenuItem.Text = "&Carrinho";
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            Name = "inicio";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem carrinhoToolStripMenuItem;
    }
}
