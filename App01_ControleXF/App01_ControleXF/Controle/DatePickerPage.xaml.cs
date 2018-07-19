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
	public partial class DatePickerPage : ContentPage
	{
		public DatePickerPage ()
		{
			InitializeComponent ();
		}

        public void ActionDateSelected(object sender, DateChangedEventArgs args)
        {
            lblResult.Text = args.OldDate.ToString("dd/MM/yyyy") + "  Alterado para ->  " + args.NewDate.ToString("dd/MM/yyyy");
        }

    }
}