using MyShop.Interfaces;
using MyShop.Services.BancoDados;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyShop.Services
{

	public class AcessoDB<t> : IDisposable, Interfaces.IAcessoDados<t> where t: class,IChave
	{
		private SQLiteConnection conexaoSQLite;
		public AcessoDB()
		{
			try
			{
				var config = DependencyService.Get<IConfig>();
				conexaoSQLite = new SQLiteConnection(config.Plataforma, Path.Combine(config.DiretorioSQLite, "Cadastro.db3"));
				conexaoSQLite.CreateTable<t>();

			}
			catch( Exception ex)
			{

			}
			
		}
		public void InserirCliente(t objeto)
		{
			conexaoSQLite.Insert(objeto);
		}
		public void AtualizarCliente(t objeto)
		{
			conexaoSQLite.Update(objeto);
		}
		public void DeletarCliente(t objeto)
		{
			conexaoSQLite.Delete(objeto);
		}
		public t GetObjeto(int codigo)
		{
			return conexaoSQLite.Table<t>().FirstOrDefault(c => c.IdRegistro == codigo);
		}
		public List<t> GetClientes()
		{
			return conexaoSQLite.Table<t>().ToList();
		}
		public void Dispose()
		{
			conexaoSQLite.Dispose();
		}
	}
}

