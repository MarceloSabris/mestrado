using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Interfaces
{
	public interface IAcessoDados<t>
	{
		 void InserirCliente(t objeto);

		void AtualizarCliente(t objeto);

		void DeletarCliente(t objeto);

		t GetObjeto(int codigo);

		List<t> GetClientes();
		
	}
}
