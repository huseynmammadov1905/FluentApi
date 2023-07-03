using GalaSoft.MvvmLight.Messaging;
using SchoolBus.Data.Repos;
using SchoolBus.Presentation.Services;
using SchoolBus.Presentation.ViewModels;
using SchoolBus.Presentation.Views;
using SchoolBusModels.Concretes;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBus.Presentation
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static Container Container { get; set; }


		protected override void OnStartup(StartupEventArgs e)
		{
			Register();
			Window window = new MainView();
			var viewModel = Container.GetInstance<MainViewModel>();
			window.DataContext = viewModel;
			window.ShowDialog();
			window.Close();
			base.OnStartup(e);
		}

		private void Register()
		{
			Container = new Container();
			Container.RegisterSingleton<IMyNavigationService, MyNavigationService>();
			Container.RegisterSingleton<IMessenger, Messenger>();
			Container.RegisterSingleton<IRepository<Car>, Repository<Car>>();
			Container.RegisterSingleton<IRepository<Driver>, Repository<Driver>>();


			Container.Register<MainView>();
			Container.Register<MainViewModel>();

			Container.Register<CarView>();
			Container.Register<CarViewModel>();

			Container.Register<DriverView>();
			Container.Register<DriverViewModel>();

		}
	}
}
