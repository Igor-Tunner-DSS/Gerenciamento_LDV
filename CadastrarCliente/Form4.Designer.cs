namespace CadastrarCliente
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Complemento = new TextBox();
            label9 = new Label();
            Cidade = new TextBox();
            label8 = new Label();
            Bairro = new TextBox();
            label7 = new Label();
            Rua = new TextBox();
            label6 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Senha = new TextBox();
            label3 = new Label();
            CPF = new TextBox();
            label2 = new Label();
            Nome = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            delete = new Button();
            update = new Button();
            gerarTable = new Button();
            fazer = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Complemento
            // 
            Complemento.Location = new Point(117, 401);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(95, 23);
            Complemento.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 383);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 14;
            label9.Text = "Estado";
            // 
            // Cidade
            // 
            Cidade.Location = new Point(117, 347);
            Cidade.Name = "Cidade";
            Cidade.Size = new Size(95, 23);
            Cidade.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(117, 329);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 12;
            label8.Text = "Cidade";
            // 
            // Bairro
            // 
            Bairro.Location = new Point(117, 294);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(95, 23);
            Bairro.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 276);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 10;
            label7.Text = "Bairro";
            // 
            // Rua
            // 
            Rua.Location = new Point(117, 241);
            Rua.Name = "Rua";
            Rua.Size = new Size(95, 23);
            Rua.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 223);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 8;
            label6.Text = "Rua";
            // 
            // Email
            // 
            Email.Location = new Point(117, 186);
            Email.Name = "Email";
            Email.Size = new Size(95, 23);
            Email.TabIndex = 9;
            Email.TextChanged += Nota_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 168);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "E-mail";
            // 
            // Senha
            // 
            Senha.Location = new Point(117, 132);
            Senha.Name = "Senha";
            Senha.Size = new Size(95, 23);
            Senha.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 114);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // CPF
            // 
            CPF.Location = new Point(117, 80);
            CPF.Name = "CPF";
            CPF.Size = new Size(95, 23);
            CPF.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 62);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // Nome
            // 
            Nome.Location = new Point(117, 26);
            Nome.Name = "Nome";
            Nome.Size = new Size(95, 23);
            Nome.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 8);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(240, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1107, 630);
            dataGridView1.TabIndex = 16;
            // 
            // delete
            // 
            delete.Location = new Point(17, 91);
            delete.Margin = new Padding(2);
            delete.Name = "delete";
            delete.Size = new Size(81, 34);
            delete.TabIndex = 3;
            delete.Text = "EXCLUIR";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // update
            // 
            update.Location = new Point(16, 51);
            update.Margin = new Padding(2);
            update.Name = "update";
            update.Size = new Size(82, 37);
            update.TabIndex = 2;
            update.Text = "ATUALIZAR";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // gerarTable
            // 
            gerarTable.BackColor = SystemColors.Control;
            gerarTable.Location = new Point(16, 165);
            gerarTable.Margin = new Padding(2);
            gerarTable.Name = "gerarTable";
            gerarTable.Size = new Size(82, 33);
            gerarTable.TabIndex = 5;
            gerarTable.Text = "MOSTRAR";
            gerarTable.UseVisualStyleBackColor = true;
            gerarTable.Click += gerarTable_Click_1;
            // 
            // fazer
            // 
            fazer.Location = new Point(16, 128);
            fazer.Margin = new Padding(2);
            fazer.Name = "fazer";
            fazer.Size = new Size(82, 33);
            fazer.TabIndex = 4;
            fazer.Text = "CRIAR";
            fazer.UseVisualStyleBackColor = true;
            fazer.Click += fazer_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(16, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 449);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(240, 630);
            splitter1.TabIndex = 18;
            splitter1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 630);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(gerarTable);
            Controls.Add(fazer);
            Controls.Add(Rua);
            Controls.Add(label6);
            Controls.Add(Bairro);
            Controls.Add(label7);
            Controls.Add(Cidade);
            Controls.Add(label8);
            Controls.Add(Complemento);
            Controls.Add(label9);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(Senha);
            Controls.Add(label3);
            Controls.Add(CPF);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(splitter1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso ADM";
            FormClosed += Form4_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Complemento;
        private Label label9;
        private TextBox Cidade;
        private Label label8;
        private TextBox Bairro;
        private Label label7;
        private TextBox Rua;
        private Label label6;
        private TextBox Email;
        private Label label4;
        private TextBox Senha;
        private Label label3;
        private TextBox CPF;
        private Label label2;
        private TextBox Nome;
        private Label label1;
        private DataGridView dataGridView1;
        private Button delete;
        private Button update;
        private Button gerarTable;
        private Button fazer;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Splitter splitter1;
    }
}