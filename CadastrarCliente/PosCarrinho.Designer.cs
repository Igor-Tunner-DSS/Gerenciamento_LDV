namespace CadastrarCliente
{
    partial class PosCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosCarrinho));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            userName = new Label();
            userAddress = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 670);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 4;
            label1.Text = "Total da compra: ";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(637, 138);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(511, 613);
            dataGridView1.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(446, 670);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(183, 63);
            button5.TabIndex = 6;
            button5.Text = "Voltar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nubank", "PicPay", "Pix", "Mercado Pago" });
            comboBox1.Location = new Point(20, 140);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(410, 33);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Método de pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(49, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 36);
            label2.TabIndex = 8;
            label2.Text = "Endereço de entrega";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 15);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // userName
            // 
            userName.AutoEllipsis = true;
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userName.ForeColor = Color.Tomato;
            userName.Location = new Point(564, 17);
            userName.Margin = new Padding(4, 0, 4, 0);
            userName.MaximumSize = new Size(571, 35);
            userName.MinimumSize = new Size(571, 35);
            userName.Name = "userName";
            userName.Size = new Size(571, 35);
            userName.TabIndex = 10;
            userName.Text = "exemplo nome muito longo";
            userName.TextAlign = ContentAlignment.TopRight;
            // 
            // userAddress
            // 
            userAddress.AutoEllipsis = true;
            userAddress.AutoSize = true;
            userAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userAddress.ForeColor = SystemColors.Control;
            userAddress.Location = new Point(20, 65);
            userAddress.Margin = new Padding(4, 0, 4, 0);
            userAddress.MaximumSize = new Size(1143, 70);
            userAddress.Name = "userAddress";
            userAddress.Size = new Size(1131, 64);
            userAddress.TabIndex = 11;
            userAddress.Text = "Rua domingos edes faralhe, 56, casa de esquina, Residencial Jardim dos Ipês, Nova Odessa, São Paulo, 13386201";
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(userAddress);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 752);
            panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(316, 23);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 25);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Mudar";
            linkLabel1.VisitedLinkColor = Color.FromArgb(0, 192, 192);
            // 
            // PosCarrinho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1149, 752);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "PosCarrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check-in";
            FormClosed += PosCarrinho_FormClosed;
            Load += PosCarrinho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private Button button5;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label userName;
        private Label userAddress;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}