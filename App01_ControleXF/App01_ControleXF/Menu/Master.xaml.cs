using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Activity(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void Progress(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.ProgressBarPage());
            IsPresented = false;
        }

        private void BoxView(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.BoxViewPage());
            IsPresented = false;
        }

        private void Enter(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.Enter());
            IsPresented = false;
        }

        private void DatePicker(EventArgs args, object sender)
        {
            Detail = new NavigationPage(new Controle.DatePickerPage());
            IsPresented = false;
        }

        private void TimePiker(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.TimePickerPage());
            IsPresented = false;
        }

        private void Picker(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.PickerPage());
            IsPresented = false;
        }

        private void Pesquisa(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.BarraPesquisa());
            IsPresented = false;
        }

        private void Slider(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.SlidderStapperPage());
            IsPresented = false;
        }

        private void switchaction(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.SwitchPage());
            IsPresented = false;
        }

        private void ViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.ListViewPage());
            IsPresented = false;
        }

        private void TablePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.TableViewPage());
            IsPresented = false;
        }      

        private void WebViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Controle.WebViewPage());
            IsPresented = false;
        }
    }
}