using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBus.Presentation.Views;
using SchoolBusModels.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
	public class DriverViewModel : ViewModelBase
	{
		private readonly IRepository<Driver> driverRepo;
		private readonly IRepository<Car> carRepo = new Repository<Car>();


		public static Driver selectDriver;

		public Driver SelectDriver
		{
			get { return selectDriver; }
			set { Set(ref selectDriver, value); }
		}

		public static ObservableCollection<Driver> Drivers { get; set; } = new();
		public static ObservableCollection<Car> Cars { get; set; } = new();

		public DriverViewModel(IRepository<Driver> driverRepo)
		{

			this.driverRepo = driverRepo;
			Drivers = new ObservableCollection<Driver>(this.driverRepo.GetAll());
		}

		public RelayCommand DriverAddCommand
		{
			get => new RelayCommand(() =>
			{
				Window window = new DriverAddView();
				window.DataContext = new DriverAddViewModel(window);
				window.Show();

			});
		}

		public RelayCommand DriverEditCommand
		{
			get => new RelayCommand(() =>
			{
				Window window = new DriverEditView();
				window.DataContext = new DriverEditViewModel(window, selectDriver);
				window.Show();

			});
		}
	}
}
