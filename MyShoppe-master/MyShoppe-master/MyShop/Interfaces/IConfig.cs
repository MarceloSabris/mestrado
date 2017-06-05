﻿using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Services.BancoDados
{
	public interface IConfig
	{
		string DiretorioSQLite { get; }
		 ISQLitePlatform Plataforma { get; }
	}
}
