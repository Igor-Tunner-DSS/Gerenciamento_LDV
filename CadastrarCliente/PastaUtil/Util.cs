using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente.PastaUtil
{
    public class Util
    {
        public static UserSession userSession = new UserSession();
        public static string conexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=loja;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static void CreateForm(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        public static void CreateForm(Form form, bool maximized)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Show();

            if (maximized) 
                form.WindowState = FormWindowState.Maximized;
        }

        public static void CreateDialog(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
        public static void CreateDialog(Form form, Point position)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
            form.Location = position;
        }
        public static void CreateDialog(Form form, Form parentForm)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog(parentForm);
        }
    }

    public class UserSession {
        public string Email = "";
        public string Senha = "";
    }


    

}
