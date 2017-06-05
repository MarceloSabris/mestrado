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
	public partial class VagasView : ContentPage
	{
		private VagasViewModel viewModel;
		private bool blAlterar;

		public VagasView()
		{
			blAlterar = true;
			InitializeComponent();
			this.Title = "Cadastro de vagas";
			BindingContext = viewModel = new VagasViewModel(this);
			chkDiario.PropertyChanged += ChkDiario_PropertyChanged;
			chkPeriodo.PropertyChanged += ChkPeriodo_PropertyChanged;
			chkMensal.PropertyChanged += ChkMensal_PropertyChanged;
			btnSalvar.Clicked += BtnSalvar_Clicked;
			chkArea.PropertyChanged += ChkArea_PropertyChanged;
			chkVaga.PropertyChanged += ChkVaga_PropertyChanged;
		}

		private void ChkVaga_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if(blAlterar)
			{
				blAlterar = false;
				chkArea.Checked = false;
				blAlterar = true;
			}
			
		}

		private void ChkArea_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (blAlterar)
			{
				blAlterar = false;
				chkVaga.Checked = false;
				blAlterar = true;
			}
			
		}

		private void BtnSalvar_Clicked(object sender, EventArgs e)
		{
			this.viewModel.vaga.ValorHora = Double.Parse(ValorHora.Text);
			this.viewModel.vaga.HoraInicialDisponivel = HoraInicial.Text;
			this.viewModel.vaga.HoraFinalDisponivel = HoraFinal.Text;
			this.viewModel.vaga.DisponivelPerido = this.chkPeriodo.Checked;
			this.viewModel.vaga.ValorMensal = Double.Parse(ValorMensal.Text);
			this.viewModel.vaga.DisponivelMensal = this.chkMensal.Checked;
			this.viewModel.vaga.ValorDiaria = Double.Parse(ValorMensal.Text);
			this.viewModel.vaga.DisponivelDiario = this.chkMensal.Checked;
			this.viewModel.vaga.Endereco = this.Endereço.Text;
			viewModel.SalvarAsync();

		}

		private void ChkMensal_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			grpMensal.IsVisible = chkPeriodo.Checked;
		}

		private void ChkPeriodo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{

			grupvalorhora.IsVisible = chkPeriodo.Checked;
			grphorafinal.IsVisible = chkPeriodo.Checked;
			grphorainicial.IsVisible = chkPeriodo.Checked;

		}

		private void ChkDiario_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			
			grpValorDiario.IsVisible = chkDiario.Checked;

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

		}

	}
}