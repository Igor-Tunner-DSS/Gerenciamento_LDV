using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.util;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using iTextSharp.text.pdf;
using CadastrarCliente.PastaUtil;
using lojaDasVariedades;
using CadastrarCliente.PastaUtil.DAO;

namespace CadastrarCliente
{
    public partial class Carrinho : Form
    {

        ProdutosLista PRODUTOS = new ProdutosLista();


        public Carrinho()
        {
            InitializeComponent();
            mostrarCarrinho();
            AtualizarTotalCarrinho();
        }
        private void AtualizarTotalCarrinho()
        {
            decimal total = CalcularTotalCarrinho();
            label1.Text = $"Total do Carrinho: R$ {total.ToString()}";


        }
        private decimal CalcularTotalCarrinho()
        {
            decimal total = 0;
            var produtos = GetCarrinhoUsuario();

            foreach (var produto in produtos)
            {
                try
                {
                    // Remove R$, espaços e converte vírgula para ponto
                    string valorLimpo = produto.Valor.Replace("R$", "")
                                                  .Replace(" ", "")
                                                  .Replace(",", ".")
                                                  .Trim();

                    if (decimal.TryParse(valorLimpo, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal valorUnitario))
                    {
                        total += valorUnitario;
                    }
                    else
                    {
                        MessageBox.Show($"Valor inválido: {produto.Valor} do produto: {produto.Nome}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro no produto: {produto.Nome}\nErro: {ex.Message}");
                }
            }

            return total;
        }
        private void mostrarCarrinho()
        {
            string query = @"SELECT Carrinho.Id, Clientes.Nome AS Usuario, Carrinho.Nome AS Produto, Quantidade, Valor FROM Carrinho INNER JOIN Clientes ON Clientes.ID = Carrinho.IdUsuario WHERE Carrinho.IdUsuario = @ID_U";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID_U", ClienteDAO.getUserID());

                using (SqlDataAdapter da = new SqlDataAdapter(command)) // Use the command here
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarCarrinho();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Carrinho WHERE Id = @ID";

            if (dataGridView1.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
                {
                    connection.Open();

                    int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }
                }

                mostrarCarrinho();
            }

            AtualizarTotalCarrinho();
        }

        private List<PastaUtil.produto> GetCarrinhoUsuario()
        {
            var produtos = new List<PastaUtil.produto>();
            int userId = ClienteDAO.getUserID();
            if (userId == -1) return produtos;

            string query = @"SELECT Id, IdUsuario, Nome, Quantidade, Valor FROM Carrinho WHERE IdUsuario = @ID_U";
            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_U", userId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(new produto()
                        {
                            ID = reader.GetInt32(0),
                            // IdUsuario não faz parte do objeto produto, então pode ser ignorado
                            Nome = reader.GetString(2),
                            Valor = reader.GetString(4),
                            Quantidade = reader.GetInt32(3)

                        });
                    }
                }
            }
            return produtos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        // MÉTODO AUXILIAR PARA ADICIONAR CÉLULAS
        private void AddTableCell(iTextSharp.text.pdf.PdfPTable table, string text, iTextSharp.text.Font font,
                                 iTextSharp.text.BaseColor backgroundColor, iTextSharp.text.BaseColor borderColor)
        {
            iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(text, font));
            cell.BackgroundColor = backgroundColor;
            cell.BorderColor = borderColor;
            cell.BorderWidth = 1f;
            cell.Padding = 8;
            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
            cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
            table.AddCell(cell);
        }

        // CLASSE PARA EVENTOS DE PÁGINA (não esqueça de adicionar esta classe)
        public class PdfPageEventHelper : iTextSharp.text.pdf.PdfPageEventHelper
        {
            public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, iTextSharp.text.Document document)
            {
                base.OnEndPage(writer, document);

                iTextSharp.text.pdf.PdfContentByte canvas = writer.DirectContent;
                canvas.SetColorStroke(new iTextSharp.text.BaseColor(100, 200, 200));
                canvas.SetLineWidth(2f);

                // Borda da página
                canvas.Rectangle(document.Left - 10, document.Bottom - 10,
                                document.PageSize.Width - document.LeftMargin - document.RightMargin + 20,
                                document.PageSize.Height - document.TopMargin - document.BottomMargin + 20);
                canvas.Stroke();

                // Número da página
                iTextSharp.text.pdf.BaseFont baseFont = iTextSharp.text.pdf.BaseFont.CreateFont(
                    iTextSharp.text.pdf.BaseFont.HELVETICA,
                    iTextSharp.text.pdf.BaseFont.WINANSI,
                    iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                canvas.BeginText();
                canvas.SetFontAndSize(baseFont, 10);
                canvas.SetColorFill(iTextSharp.text.BaseColor.GRAY);
                canvas.ShowTextAligned(iTextSharp.text.pdf.PdfContentByte.ALIGN_CENTER,
                                     $"Página {writer.PageNumber}",
                                     document.PageSize.Width / 2,
                                     document.Bottom - 30, 0);
                canvas.EndText();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new PosCarrinho());
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Produtos());
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }


        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new inicio());
            this.Hide();
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new sobre());
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Produtos());
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = "Carrinho.pdf",
                Filter = "Arquivo PDF|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    var produtos = GetCarrinhoUsuario();
                    var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 40, 40, 60, 60);
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, stream);

                    writer.PageEvent = new PdfPageEventHelper();
                    doc.Open();

                    // ======= PALETA DE CORES =======
                    iTextSharp.text.BaseColor corFundo = new iTextSharp.text.BaseColor(255, 255, 255); // Branco
                    iTextSharp.text.BaseColor corCabecalho = new iTextSharp.text.BaseColor(173, 216, 230); // Azul claro
                    iTextSharp.text.BaseColor corBorda = new iTextSharp.text.BaseColor(0, 70, 140); // Azul marinho
                    iTextSharp.text.BaseColor corTitulo = new iTextSharp.text.BaseColor(178, 34, 34); // Vermelho escuro
                    iTextSharp.text.BaseColor corAssinatura = new iTextSharp.text.BaseColor(220, 20, 60); // Vermelho médio
                    iTextSharp.text.BaseColor corTotal = new iTextSharp.text.BaseColor(0, 0, 139); // Azul escuro
                    iTextSharp.text.BaseColor corTotalFundo = new iTextSharp.text.BaseColor(255, 240, 240); // Rosado leve

                    // ======= FUNDO =======
                    iTextSharp.text.pdf.PdfContentByte canvas = writer.DirectContentUnder;
                    canvas.SetColorFill(corFundo);
                    canvas.Rectangle(doc.Left, doc.Bottom, doc.PageSize.Width - doc.LeftMargin - doc.RightMargin,
                                   doc.PageSize.Height - doc.TopMargin - doc.BottomMargin);
                    canvas.Fill();

                    // ======= FONTES =======
                    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    iTextSharp.text.pdf.BaseFont baseFont = iTextSharp.text.pdf.BaseFont.CreateFont(
                        fontPath,
                        iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                        iTextSharp.text.pdf.BaseFont.EMBEDDED);

                    iTextSharp.text.Font fonteTitulo = new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD, corTitulo);
                    iTextSharp.text.Font fonteCabecalho = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD, corBorda);
                    iTextSharp.text.Font fonteNormal = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font fonteAssinatura = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLDITALIC, corAssinatura);
                    iTextSharp.text.Font fonteTotal = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLD, corTotal);

                    // ======= TÍTULO =======
                    iTextSharp.text.Paragraph titulo = new iTextSharp.text.Paragraph("🛒 CARRINHO DE COMPRAS", fonteTitulo);
                    titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 20;
                    doc.Add(titulo);

                    // ======= TABELA =======
                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(3);
                    table.WidthPercentage = 95;
                    table.SpacingBefore = 15;
                    table.SpacingAfter = 30;

                    float[] columnWidths = new float[] { 3f, 2f, 2f };
                    table.SetWidths(columnWidths);

                    // Cabeçalho
                    AddTableCell(table, "NOME DO PRODUTO", fonteCabecalho, corCabecalho, corBorda);
                    AddTableCell(table, "QUANTIDADE", fonteCabecalho, corCabecalho, corBorda);
                    AddTableCell(table, "VALOR TOTAL", fonteCabecalho, corCabecalho, corBorda);

                    // Dados
                    decimal totalGeral = 0;
                    foreach (var produto in produtos)
                    {
                        AddTableCell(table, produto.Nome, fonteNormal, iTextSharp.text.BaseColor.WHITE, corBorda);
                        AddTableCell(table, produto.Quantidade.ToString(), fonteNormal, iTextSharp.text.BaseColor.WHITE, corBorda);

                        decimal valorUnitario = decimal.Parse(produto.Valor.Replace("R$", "").Trim(),
                                     System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                        decimal valorTotal = valorUnitario;
                        totalGeral += valorTotal;

                        AddTableCell(table, valorTotal.ToString("C"), fonteNormal, iTextSharp.text.BaseColor.WHITE, corBorda);
                    }

                    // Total Geral
                    AddTableCell(table, "TOTAL GERAL", fonteTotal, corTotalFundo, corBorda);
                    AddTableCell(table, "", fonteNormal, corTotalFundo, corBorda);
                    AddTableCell(table, totalGeral.ToString("C"), fonteTotal, corTotalFundo, corBorda);

                    doc.Add(table);

                    // ======= ASSINATURA =======
                    iTextSharp.text.Paragraph assinaturas = new iTextSharp.text.Paragraph();
                    assinaturas.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    assinaturas.SpacingBefore = 40;

                    // Linha decorativa
                    iTextSharp.text.Paragraph linha = new iTextSharp.text.Paragraph(
                        new iTextSharp.text.Chunk(
                            new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, corBorda, iTextSharp.text.Element.ALIGN_CENTER, 5f)));
                    linha.SpacingAfter = 20;
                    doc.Add(linha);

                    assinaturas.Add(new iTextSharp.text.Chunk("Desenvolvido por:\n",
                        new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GRAY)));
                    assinaturas.Add(new iTextSharp.text.Chunk("Igor & Gabriel\n", fonteAssinatura));
                    assinaturas.Add(new iTextSharp.text.Chunk(DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.GRAY)));

                    doc.Add(assinaturas);

                    doc.Close();
                    MessageBox.Show("PDF do carrinho criado com sucesso! 🎉");
                }
            }
        }
    }
}
