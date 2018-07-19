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
            Detail = new Controle.ActivityIndicatorPage();
        }

        private void Progress(object sender, EventArgs args)
        {
            Detail = new Controle.ProgressBarPage();
        }

        private void BoxView(object sender, EventArgs args)
        {
            Detail = new Controle.BoxViewPage();
        }

        private void Enter(object sender, EventArgs args)
        {
            Detail = new Controle.Enter();
        }

        private void DatePicker(EventArgs args, object sender)
        {
            Detail = new Controle.DatePickerPage();
        }

        private void TimePiker(object sender, EventArgs args)
        {
            Detail = new Controle.TimePickerPage();
        }

        private void Picker(object sender, EventArgs args)
        {
            Detail = new Controle.PickerPage();
        }

        private void Pesquisa(object sender, EventArgs args)
        {
            Detail = new Controle.BarraPesquisa();
        }

        private void Slider(object sender, EventArgs args)
        {
            Detail = new Controle.SlidderStapperPage();
        }

        private void switchaction(object sender, EventArgs args)
        {
            Detail = new Controle.SwitchPage();
        }

        private void ViewPage(object sender, EventArgs args)
        {
            Detail = new Controle.ListViewPage();
        }

        private void TablePage(object sender, EventArgs args)
        {
            Detail = new Controle.TableViewPage();
        }      
    }
}