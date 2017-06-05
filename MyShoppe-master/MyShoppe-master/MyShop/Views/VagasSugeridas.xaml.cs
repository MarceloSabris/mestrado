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
	public partial class VagasSugeridas : ContentPage
	{
		public VagasSugeridas()
		{
			InitializeComponent();
			BindingContext = new VagasSugeridasModel();
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
				var page = new VagasDetalhe(vaga);
				//page.BindingContext = vaga;
				await Navigation.PushAsync(page);
			}
		}
	}
}