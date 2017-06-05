using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyShop.Model
{
	public class VagasBuscaViewModel
	{
		public ObservableCollection<Vagas> vagas { get; private set; }

		public ICommand SearchCommand { get; private set; }

		public VagasBuscaViewModel()
		{
			SearchCommand = new Command<string>(async (text) => await AzureSearch(text));
			vagas = new ObservableCollection<Vagas>();
		}

		async Task AzureSearch(string text)
		{
			vagas.Clear();

			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,175 Vila Alice Diadema São Paulo ", Tipo = "Mensal", Foto="verde.jpg" });
			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,181 Vila Alice Diadema São Paulo ", Tipo = "Diaria", Foto = "verde.jpg" });
			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,210 Vila Alice Diadema São Paulo ", Tipo = "Diaria - Mensal",Foto="vermelho.jpg" });

		}
	}
}
