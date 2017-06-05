using MyShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyShop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VagasBusca : ContentPage
	{
		public VagasBusca()
		{
			InitializeComponent();
			BindingContext = new VagasBuscaViewModel();
		}
		void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
		{
			((ListView)sender).SelectedItem = null;
		}

		async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var vaga = ((ListView)sender).SelectedItem as Vagas;
			if (vaga != null)
			{
				//var page = new MonkeyDetailsPage();
				//page.BindingContext = monkey;
				//await Navigation.PushAsync(page);
			}
		}
	}
}