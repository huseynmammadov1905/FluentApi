using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
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
	public class CarAddViewModel : ViewModelBase
	{
		readonly IRepository<Car>? carRepo = new Repository<Car>();
		private Car addCar = new();

		public Car AddCar
		{
			get { return addCar; }
			set { Set(ref addCar, value); }
		}

		private Window dataContext;

		public Window DataContext
		{
			get { return dataContext; }
			set { Set(ref dataContext, value); }
		}
		public ObservableCollection<Car> Cars { get; set; }


		public CarAddViewModel(Window window)
		{
			DataContext = window;

		}

		public RelayCommand CarCreateCommand
		{
			get => new RelayCommand(() =>
			{
				try
				{
					if (addCar.Name is null || addCar.CarNumber is null || addCar.SeatCount <= 0)
					{
						MessageBox.Show("Wrong", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
					}
					else
					{
						CarViewModel.Cars.Add(addCar);
						carRepo.Add(addCar);
						carRepo.SaveChanges();
						dataContext.Close();
						MessageBox.Show("Car elave olundu", "", MessageBoxButton.OK);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

				}


			});
		}
	}
}
