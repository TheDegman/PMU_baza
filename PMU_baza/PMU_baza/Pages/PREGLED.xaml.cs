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
    public partial class PREGLED : ContentPage
    {
        public PREGLED()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView1.ItemsSource = await App.Database.GetPeopleAsync();

        }
    }
}