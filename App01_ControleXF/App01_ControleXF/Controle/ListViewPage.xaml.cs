using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_ControleXF.Controle;
using App01_ControleXF.Modelo;

namespace App01_ControleXF.Controle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "Paulo Santos", Idade = "20 anos" });
            lista.Add(new Pessoa { Nome = "Henrique Santos", Idade = "20 anos" });
            lista.Add(new Pessoa { Nome = "Ferraz Santos", Idade = "20 anos" });
            lista.Add(new Pessoa { Nome = "Santos Santos", Idade = "20 anos" });

            ListaPessoas.ItemsSource = lista;

        }
	}
}