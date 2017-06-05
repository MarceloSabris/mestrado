using MyShop.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
	public  partial  class Vagas : IChave
	{
		
		
		[MaxLength(50)]
		public string Endereco { get; set;}

	
		public Boolean DisponivelDiario { get; set; }

		public string DescricaoDisponivelDiario { get; set; }

		public Boolean DisponivelPerido { get; set; }
		public string DescricaoDisponivelPeriodo { get; set; }

		public Boolean DisponivelMensal { get; set; }
		public string DescricaoDisponiveMensal { get; set; }

		public double ValorHora {
			get;
			set; }
		public double ValorDiaria { get; set; }
		public double ValorMensal { get; set; }

		public string HoraInicialDisponivel { get; set; }

		public string HoraFinalDisponivel { get; set; }

		public bool Disponivel { get; set; }
		public double Latitude { get; set; } = 0;
		public double Longitude { get; set; } = 0;
		[PrimaryKey, AutoIncrement]
		public int IdRegistro { get; set; }
		public String Tipo { get; set; }

		public string Foto { get; set; }
	}
}
