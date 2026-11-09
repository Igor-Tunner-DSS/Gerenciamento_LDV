namespace CadastrarCliente.PastaUtil
{
    public static class pegarEmail
    {
        public static string EmailSalvo { get; set; }
        public static int CodigoSalvo { get; set; }

        public static void SalvarEmail(string email)
        {
            EmailSalvo = email;
        }

        public static string PegarEmail()
        {
            return EmailSalvo;
        }

        public static void SalvarCodigo(int codigo)
        {
            CodigoSalvo = codigo;
        }

        public static int PegarCodigo()
        {
            return CodigoSalvo;
        }
    }
}