using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyShop.Model;

namespace MyShop.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VagasDetalhe : ContentPage
	{

		public VagasDetalhe()
		{
			InitializeComponent();
			//BindingContext = new VagasDetalheViewModel();
		
		}
		public VagasDetalhe(Vagas vaga)
		{
			InitializeComponent();
			BindingContext = vaga;
			if (vaga.DisponivelMensal) grupomensal.IsVisible = true;
			if (vaga.DisponivelDiario) grupodiario.IsVisible = true;
			if (vaga.DisponivelPerido) grupohora.IsVisible = true;


		}
	}
}