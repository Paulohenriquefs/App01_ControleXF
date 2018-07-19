using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraPesquisa : ContentPage
    {
        private List<string> EmpresasTI;

        public BarraPesquisa()
        {
            InitializeComponent();

            EmpresasTI = new List<string>();
            EmpresasTI.Add("Microsoft");
            EmpresasTI.Add("Google");
            EmpresasTI.Add("Facebook");
            EmpresasTI.Add("Apple");
            EmpresasTI.Add("Oracle");
            Preencher(EmpresasTI);
        }

        private void pesquisarButton(object sender, EventArgs args)
        {
            var resultado = EmpresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = EmpresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<String>();
            Preencher(resultado);
        }

        private void Preencher(List<string> empresasTI)
        {
            ListResult.Children.Clear();
            foreach(var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }
	}
}