using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMU_baza
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IZBOR : ContentPage
    {
        public IZBOR()
        {
            InitializeComponent();
        }

        private async void Unos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UNOS());
        }

        private async void Pregled_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PREGLED());

        }
    }
}