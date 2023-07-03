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
	public class CarViewModel : ViewModelBase
	{
		private readonly IRepository<Car> carRepo;


		public static Car selectCar;

		public Car SelectCar
		{
			get { return selectCar; }
			set { Set(ref selectCar, value); }
		}

		public static ObservableCollection<Car> Cars { get; set; } = new();

		public CarViewModel(IRepository<Car> carRepo)
		{

			this.carRepo = carRepo;
			Cars = new ObservableCollection<Car>(this.carRepo.GetAll());
		}


		public RelayCommand CarAddCommand
		{
			get => new RelayCommand(() =>
			{
				Window window = new CarAddView();
				window.DataContext = new CarAddViewModel(window);
				window.Show();

			});
		}

		public RelayCommand CarEditCommand
		{
			get => new RelayCommand(() =>
			{
				Window window = new CarEditView();
				window.DataContext = new CarEditViewModel(window, SelectCar);
				window.Show();

			});
		}
	}
}
