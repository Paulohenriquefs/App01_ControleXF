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
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        public void GoPage(object sender, EventArgs args)
        {
            navegador.Source = EnderecoSite.Text;
        }

        public void GoProximo(object sender, EventArgs args)
        {
            if (navegador.CanGoForward)
            {
                navegador.GoForward();
            }
        }

        public void GoVoltar(object sender, EventArgs args)
        {
            if (navegador.CanGoBack)
            {
                navegador.GoBack();
            }
        }

        public void Carregando(object sender, EventArgs args)
        {
            lblStatus.Text = "Carregando...";
        }

        public void Carregado(object sender, EventArgs args)
        {
            lblStatus.Text = "Finalizado";
        }
    }
}