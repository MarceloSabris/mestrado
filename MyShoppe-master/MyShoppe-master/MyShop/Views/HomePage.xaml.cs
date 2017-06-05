using MyShop.Views;
using MyShop.Views.Tablet;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace MyShop
{
	public partial class HomePage : ContentPage
	{
		ILocationService _locationProvider;

		public HomePage()
		{
			Geocoder geoCoder = new Geocoder();
			InitializeComponent();
			BindingContext = new HomeViewModel(this);
			_locationProvider = DependencyService.Get<ILocationService>();
			MessagingCenter.Subscribe<ILocationService, string>(this, Messaging.LocationUpdated, HandleLocationUpdate);

			ButtonFindStore.Clicked += async (sender, e) =>
			{
				if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
					await Navigation.PushAsync(new StoresTabletPage());
				else
					await Navigation.PushAsync(new VagasView());
			};

			//if (Device.Idiom == TargetIdiom.Tablet)
			//{va
			//	//HeroImage.Source = ImageSource.FromFile("herotablet.jpg");
			//}

			ButtonLeaveFeedback.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new MainVagas());
			};

			btnCadastro.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new Cadastro());
			};

			
			//CentralizarMapaAsync();
		}

		private void HandleLocationUpdate(ILocationService arg1, string location)
		{

			Device.BeginInvokeOnMainThread(() =>
			{
				string[] position = location.Split('#');

				var posicao = new Position(double.Parse(position[0]), double.Parse(position[1]));

				//	var latlongdegrees = 360 / (Math.Pow( float.Parse(position[0]), 16));
				//var longlogdegrees = 360 / (Math.Pow(float.Parse(position[1]), 16));
				//	MyMap.MoveToRegion(new MapSpan(MyMap.VisibleRegion.Center, double.Parse(position[0]), double.Parse(position[1])));

				MyMap.MoveToRegion(
                        MapSpan.FromCenterAndRadius(
						posicao, Distance.FromMiles(.2)));

				if ( MyMap.Pins.Count == 0 )
				{
					var pin = new Pin()
					{
						Type = PinType.Place,
						Position = new Position(double.Parse(position[0]), double.Parse(position[1])),
						Label = "local"
					};
					MyMap.Pins.Add(pin);
					//var pin1 = new Pin()
					//{
					//	Type = PinType.Place,
					//	Position = new Position(double.Parse(position[0]+0.1), double.Parse(position[1]+0.1)),
					//	Label = "estacion1"
					//};
					//MyMap.Pins.Add(pin1);
				}
				else
				{
					for(int i=0;i< MyMap.Pins.Count; i++)
					{

						if (MyMap.Pins[i].Label == "local")
						{
							MyMap.Pins[i].Position = new Position(double.Parse(position[0]), double.Parse(position[1]));
							break;
						}
					}
				}
				
				
			});

		}

		//		public async void CentralizarMapaAsync()
		//		{

		//			try
		//			{

		//				//var possibleAddresses = await geoCoder.GetAddressesForPositionAsync(fortMasonPosition);
		//				if ((CrossGeolocator.Current.IsGeolocationAvailable) == false)
		//				{
		//					await DisplayAlert("Notification", "Geolocation is Unavailable ", "Ok");
		//				}
		//				else
		//				{

		//					var locator = CrossGeolocator.Current;

		//					//locator.DesiredAccuracy = 50;               
		//					var position = await locator.GetPositionAsync(timeoutMilliseconds: 50000);

		//					Position pos = new Position(position.Latitude, position.Longitude);

		//					MyMap.MoveToRegion(new MapSpan(pos, position.Latitude, position.Longitude));
		//					locator.PositionChanged += (sender, e) =>
		//					{

		//						Position pos1 = new Position(e.Position.Latitude, e.Position.Longitude);
		//						MyMap.MoveToRegion(new MapSpan(pos1, e.Position.Latitude, e.Position.Longitude));

		//					};
		//				}


		//				} catch (Exception ex)
		//			{ 
		//}


		//		}



		protected override void OnAppearing()
		{
			base.OnAppearing();
			_locationProvider.Start();
		}

	}
}

