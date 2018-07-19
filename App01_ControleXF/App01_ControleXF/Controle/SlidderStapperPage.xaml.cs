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
	public partial class SlidderStapperPage : ContentPage
	{
		public SlidderStapperPage ()
		{
			InitializeComponent ();
		}

        private void ActionValorMudou(object sender, ValueChangedEventArgs args)
        {
            reult.Text = args.NewValue.ToString();
        }

        private void ActionValorMudouStepper(object sender, ValueChangedEventArgs args)
        {
            stepperResult.Text = args.NewValue.ToString();
        }

        

    }
}