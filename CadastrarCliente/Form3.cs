using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static CadastrarCliente.Form3;
using static CadastrarCliente.Rules.Validacao;
using System.util;
using System.Collections;
using CadastrarCliente.PastaUtil;
using static CadastrarCliente.PastaUtil.enviarEmail;
using CadastrarCliente.PastaUtil.DAO;

namespace CadastrarCliente
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            bool isValidEmail = emailIsValid(textBox2.Text);
            bool isValidCPF = cpfValidation(textBox9.Text);
            bool exists = emailExists(textBox2.Text);

            // Verifica se o resultado é maior que 0 (ou seja, nome encontrado)


            Usuario user = GetUserValues();

            string senha = textBox3.Text;
            string email = textBox2.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o seu nome");
                textBox1.Focus();

                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Preencha o seu email");

                textBox2.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Preencha a sua rua");
                textBox5.Focus();

                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Preencha o bairro");
                textBox6.Focus();

                return;
            }

            if (textBox9.Text == "")
            {
                MessageBox.Show("Preencha o seu CPF");
                textBox9.Focus();

                return;
            }
            if (!isValidCPF)
            {
                MessageBox.Show("Insira um CPF válido");
                textBox9.Focus();

                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Preencha a cidade");
                textBox8.Focus();

                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Preencha o estado");
                textBox7.Focus();

                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Preencha a senha");
                textBox3.Focus();

                return;
            }
            if (textBox4.Text != textBox3.Text)
            {
                MessageBox.Show("Repita a senha corretamente");
                textBox4.Focus();

                return;
            }
            if (!user.IsValid())
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            else if (!isValidEmail)
            {
                textBox2.BackColor = Color.IndianRed;

                textBox2.Focus();

                MessageBox.Show("Email inserido não é válido (exemplo@email.com)");
            }

            else if (exists)
            {
                textBox2.BackColor = Color.IndianRed;

                textBox2.Focus();

                MessageBox.Show("Já existe um usuário com esse email");
            }
            else
            {
                
                int codVal = GeradorCodigos.GerarCodigoValidacao();
                pegarEmail.SalvarCodigo(codVal);

                PastaUtil.Util.userSession.Email = email;
                PastaUtil.Util.userSession.Senha = senha;

                textBox2.BackColor = Color.SpringGreen;

                string mensagemErro;
                bool emailEnviado = PastaUtil.enviarEmail.enviar(textBox2.Text, codVal, out mensagemErro);

                if (emailEnviado)
                {
                    PastaUtil.DAO.ClienteDAO.insertCliente(
                        user,
                        codVal,
                        DateTime.Now.ToString("dd/MM/yyyy"),
                        "pendente"
                    );

                    pegarEmail.SalvarEmail(textBox2.Text);

                    MessageBox.Show("Email enviado com sucesso! Verifique sua caixa postal.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (validacao newForm = new())
                    {
                        this.Visible = false;
                        this.Owner.Visible = false;
                        newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                        newForm.StartPosition = FormStartPosition.Manual;
                        newForm.Location = new Point(screenWidth - 200 - newForm.Width, screenHeight / 2 - newForm.Height / 2);
                        if (newForm.ShowDialog() == DialogResult.OK)
                        {
                            this.Owner.Visible = true;
                            this.Hide();
                        }
                        else
                        {
                            int userID = ClienteDAO.getUserID();
                            ClienteDAO.removeCliente(userID);
                            this.Visible = true;
                            this.Owner.Visible = true;
                        }
                    }
                }
                else
                {

                    MessageBox.Show($"Falha ao enviar email: {mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                    textBox2.BackColor = Color.LightCoral;
                }

            }
        }

        private bool CheckForEmptyValues(List<TextBox> elements)
        {
            foreach (TextBox element in elements)
            {
                if (element.Text == null || element.Text == "") return true;
            }
            return false;
        }

        private Usuario GetUserValues()
        {
            var user = new Usuario();

            if (CheckForEmptyValues(new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 }))
            {
                return user;
            }

            string valorNome = textBox1.Text;
            string valorEmail = textBox2.Text;
            string valorSenha = textBox3.Text;
            string valorSenha2 = textBox4.Text;
            string valorRua = textBox5.Text;
            string valorBairro = textBox6.Text;
            string valorCidade = textBox8.Text;
            string valorEstado = textBox7.Text;
            string valorCPF = textBox9.Text;

            user.Nome = valorNome;
            user.email = valorEmail;
            user.senha = valorSenha;
            user.senha2 = valorSenha2;
            user.rua = valorRua;
            user.bairro = valorBairro;
            user.cidade = valorCidade;
            user.estado = valorEstado;
            user.CPF = valorCPF;

            return user;
        }

        private void button1_MouseHover(object objeto, EventArgs evento)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }






        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox10.Text))
            {
                var endereco = await ConsultarCep.BuscarEnderecoPorCep(textBox10.Text);
                if (endereco != null)
                {
                    textBox5.Text = endereco.Logradouro;
                    textBox6.Text = endereco.Bairro;
                    textBox7.Text = endereco.Uf;
                    textBox8.Text = endereco.Localidade;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;

                    textBox5.BackColor = Color.SpringGreen;
                    textBox6.BackColor = Color.SpringGreen;
                    textBox7.BackColor = Color.SpringGreen;
                    textBox8.BackColor = Color.SpringGreen;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado ou inválido.");
                    textBox10.BackColor = Color.LightCoral;
                }
            }
            else
            {
                MessageBox.Show("Preencha o CEP");
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox10.Focus();
            }
        }



        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            // button1.Size = new System.Drawing.Size(200, 50);
            // button1.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.Size = new System.Drawing.Size(104, 27);
            //button1.Font = new Font("Segoe", 9, GraphicsUnit.Point);
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            //button3.Size = new System.Drawing.Size(200, 50);
            //button3.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            //button3.Size = new System.Drawing.Size(104, 27);
            //button3.Font = new Font("Arial", 9, GraphicsUnit.Point);
        }


        private void textBox10_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }
        private void textBox5_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void textBox6_MouseMove(object sender, MouseEventArgs e)
        {

        }
        // TEXTBOX1 : //

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { textBox1.BackColor = Color.LightCoral; }
            else
            { textBox1.BackColor = Color.SpringGreen; }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { textBox1.BackColor = Color.LightCoral; }
            else
            { textBox1.BackColor = Color.SpringGreen; }
        }

        // TEXTBOX2 : //

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { textBox2.BackColor = Color.LightCoral; }
            else
            { textBox2.BackColor = Color.SpringGreen; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { textBox2.BackColor = Color.LightCoral; }
            else
            { textBox2.BackColor = Color.SpringGreen; }
        }

        // TEXTBOX5 : //
        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }


        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            { textBox5.BackColor = Color.LightCoral; }
            else
            { textBox5.BackColor = Color.SpringGreen; }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            { textBox5.BackColor = Color.LightCoral; }
            else
            { textBox5.BackColor = Color.SpringGreen; }
        }

        // TEXTBOX6 : //
        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            { textBox6.BackColor = Color.LightCoral; }
            else
            { textBox6.BackColor = Color.SpringGreen; }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            { textBox6.BackColor = Color.LightCoral; }
            else
            { textBox6.BackColor = Color.SpringGreen; }
        }


        // TEXTBOX9 : //
        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.White;
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            { textBox9.BackColor = Color.LightCoral; }
            else
            { textBox9.BackColor = Color.SpringGreen; }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            { textBox9.BackColor = Color.LightCoral; }
            else
            { textBox9.BackColor = Color.SpringGreen; }
        }


        // TEXTBOX8 : //

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            { textBox8.BackColor = Color.LightCoral; }
            else
            { textBox8.BackColor = Color.SpringGreen; }
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.White;
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            { textBox8.BackColor = Color.LightCoral; }
            else
            { textBox8.BackColor = Color.SpringGreen; }
        }

        // TEXTBOX7 : //
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            { textBox7.BackColor = Color.LightCoral; }
            else
            { textBox7.BackColor = Color.SpringGreen; }
        }
        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            { textBox7.BackColor = Color.LightCoral; }
            else
            { textBox7.BackColor = Color.SpringGreen; }
        }



        // TEXTBOX3 : //
        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            { textBox3.BackColor = Color.LightCoral; }
            else
            { textBox3.BackColor = Color.SpringGreen; }

        }



        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            { textBox3.BackColor = Color.LightCoral; }
            else
            { textBox3.BackColor = Color.SpringGreen; }

            if (textBox4.Text != textBox3.Text)
            {
                textBox4.BackColor = Color.LightCoral;
            }
            else
            { textBox4.BackColor = Color.SpringGreen; }
        }
        // TEXTBOX4 : //
        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox3.Text || textBox4.Text == "")
            { textBox4.BackColor = Color.LightCoral; }
            else
            { textBox4.BackColor = Color.SpringGreen; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != textBox3.Text || textBox4.Text == "")
            { textBox4.BackColor = Color.LightCoral; }
            else
            { textBox4.BackColor = Color.SpringGreen; }
        }
        // TEXTBOX10 : //

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            //textBox10.BackColor = Color.White;
        }

        private void textBox10_MouseLeave(object sender, EventArgs e)
        {
            //if (textBox10.Text == "")
            //{ textBox10.BackColor = Color.LightCoral; }
            //else
            //{ textBox10.BackColor = Color.SpringGreen; }
        }



        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //if (textBox10.Text == "")
            //{ textBox10.BackColor = Color.LightCoral; }
            //else
            //{ textBox10.BackColor = Color.SpringGreen; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }



}
