using System;

using Xamarin.Forms;

namespace MyShop
{
    public class HomeViewModel : ViewModelBase
    {
		ILocationService _locationProvider; 
        public HomeViewModel(Page page) : base(page)
        {
            Title = "My Shoppe";
		

		}




    }
}

