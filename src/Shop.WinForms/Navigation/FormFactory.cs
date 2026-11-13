using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LDV.Shop.WinForms.Navigation
{
    public class FormFactory
    {
        private readonly IServiceProvider _provider;
        public FormFactory(IServiceProvider provider) => _provider = provider;

        public T Create<T>() where T : Form
        {
            var scope = _provider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<T>();
            form.FormClosed += (_, _) => scope.Dispose();
            return form;
        }
    }
}
