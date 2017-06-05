using MyShop.Interfaces;
using MyShop.Model;
using MyShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyShop
{
	public class VagasViewModel : ViewModelBase, INotifyPropertyChanged
	{
		public  Vagas vaga;
		public double teste { get;
		set;}
		private IAcessoDados<Vagas> acessoDados;

		public VagasViewModel(Page page) : base(page)
		{
			try
			{
				vaga = new Vagas();
				acessoDados = new AcessoDB<Vagas>();
			}catch(Exception ex)
			{

			}
			



		}

	

		public event PropertyChangedEventHandler PropertyChanged;
		public async Task SalvarAsync()
		{
			try
			{
				acessoDados.InserirCliente(vaga);
				await page.DisplayAlert("Vagas","Vaga inserida com sucesso","OK");
				await page.Navigation.PopAsync(true);

			}
			catch (Exception ex)
			{
				await page.DisplayAlert("Uh Oh :(", $"Erro ao inserir a vaga tente novamente erro: {ex.Message}", "OK");
			}

		}
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
