using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace CadastrarCliente.PastaUtil
{
    internal class enviarEmail
    {
        public static class GeradorCodigos
        {
            private static Random random = new Random();

            public static int GerarCodigoValidacao()
            {
                return random.Next(100000, 1000000); // 100000 a 999999
            }
        }
        public static bool enviar(string email, int cod, out string mensagemErro)
        {
            mensagemErro = "";

            // Validação MÍNIMA - só o essencial
            if (string.IsNullOrWhiteSpace(email))
            {
                mensagemErro = "Email não pode estar vazio";
                return false;
            }

            SmtpClient smtp = null;
            MailMessage mail = null;

            try
            {
                // Configurações do SMTP Brevo
                string smtpHost = "smtp-relay.brevo.com";
                int smtpPort = 587;
                string smtpUser = "983bee001@smtp-brevo.com";
                string smtpPass = "Mktc8DOaQxCBnps9";

                // Configura o e-mail
                mail = new MailMessage();
                mail.From = new MailAddress("gabrieljacilanderse@gmail.com", "Gabriel");
                mail.To.Add(email.Trim());
                mail.Subject = "Teste de envio SMTP Brevo";
                mail.Body = "<h2>Olá!</h2> Este é um e-mail enviado via <b>SMTP</b> Brevo." + " Seu código: " + cod;
                mail.IsBodyHtml = true;

                // Configura o cliente SMTP
                smtp = new SmtpClient(smtpHost, smtpPort);
                smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
                smtp.EnableSsl = true;
                smtp.Timeout = 15000; // 15 segundos

                // Tenta enviar - se cair aqui sem internet, VAI FALHAR
                smtp.Send(mail);

                return true; // Só retorna true se passou por smtp.Send()
            }
            catch (Exception ex)
            {
                // AGORA: SEM MENTIRAS - se caiu aqui, NÃO enviou
                mensagemErro = ex.Message;
                return false;
            }
            finally
            {
                // Limpeza SILENCIOSA - se der erro aqui, não importa
                try
                {
                    mail?.Dispose();
                    smtp?.Dispose();
                }
                catch
                {
                    // Ignora erros de dispose - não afetam o envio
                }
            }
        }
    }
}