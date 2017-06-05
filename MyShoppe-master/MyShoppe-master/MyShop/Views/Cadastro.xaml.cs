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
	public partial class Cadastro : ContentPage
	{
		public Cadastro()
		{
			InitializeComponent();
			btnSalvar.Clicked += BtnSalvar_ClickedAsync;
		}

		private async void BtnSalvar_ClickedAsync(object sender, EventArgs e)
		{
			await this.DisplayAlert("Vagas", "Vaga inserida com sucesso", "OK");
		}
	}
}