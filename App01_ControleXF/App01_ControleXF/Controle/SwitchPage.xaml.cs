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
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void Resultado(ToggledEventArgs args, object sender)
        {
            resultado.Text = DateTime.Now.ToString("HH:mm") + " - " + args.Value;
        }

    }
}