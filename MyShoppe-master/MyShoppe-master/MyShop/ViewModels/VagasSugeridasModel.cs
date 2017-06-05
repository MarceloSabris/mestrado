using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model
{
 public 	class VagasSugeridasModel
	{
		public ObservableCollection<Vagas> vagas { get; private set; }

		public VagasSugeridasModel()
		{
			vagas = new ObservableCollection<Vagas>();

			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,175 Vila Alice Diadema São Paulo ", Tipo = "Mensal", DisponivelMensal= true, DescricaoDisponiveMensal="Vaga Mensal", ValorMensal=10.55, Foto = "verde.jpg" });
			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,181 Vila Alice Diadema São Paulo ", Tipo = "Diaria", DisponivelDiario = true, DescricaoDisponivelDiario = "Vaga Diaria", ValorDiaria=2.00, Foto = "verde.jpg" });
			vagas.Add(new Vagas() { Endereco = "Rua princesa Isabel,210 Vila Alice Diadema São Paulo ", Tipo = "Diaria - Mensal", DisponivelDiario = true, DescricaoDisponivelDiario = "Vaga Diaria", ValorMensal = 10.55, ValorDiaria = 2.00, DisponivelMensal = true,DescricaoDisponiveMensal="Vaga Mensal", Foto = "vermelho.jpg" });
		}
	}
}
