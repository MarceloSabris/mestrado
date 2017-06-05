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
	public partial class VagasDisponiveis : ContentPage
	{
		public VagasDisponiveis()
		{
			InitializeComponent();

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			List<Vagas> lstVagas = new List<Vagas>();
			lstVagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,175 Vila Alice Diadema São Paulo ", Tipo = "Mensal" });
			lstVagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,181 Vila Alice Diadema São Paulo ", Tipo = "Diaria" });
			lstVagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,210 Vila Alice Diadema São Paulo ", Tipo = "Diaria - Mensal" });
			listView.ItemsSource = lstVagas;
		}

	}
}