using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyShop.Services.BancoDados;
using SQLite.Net.Interop;
using System.Runtime.CompilerServices;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(MyShop.Droid.BancoDados.ConfigBanco))]
namespace MyShop.Droid.BancoDados
{

	public class ConfigBanco : Java.Lang.Object, IConfig
	{
		private string _diretorioSQLite;
		private SQLite.Net.Interop.ISQLitePlatform _plataforma;
		public string DiretorioSQLite
		{
			get
			{
				if (string.IsNullOrEmpty(_diretorioSQLite))
				{
					_diretorioSQLite = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
				}
				return _diretorioSQLite;
			}
		}
		public ISQLitePlatform Plataforma
		{
			get
			{
				if (_plataforma == null)
				{
					_plataforma =  new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
				}
				return _plataforma;
			}
		}
	}
}