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
	public class DriverEditViewModel : ViewModelBase
	{
		readonly IRepository<Car>? carRepo = new Repository<Car>();
		readonly IRepository<Driver>? driverRepo = new Repository<Driver>();

		private Driver editDriver = new();

		public Driver EditDriver
		{
			get { return editDriver; }
			set { Set(ref editDriver, value); }
		}

		private Driver _selectCar = new();

		public Driver _SelectCar
		{
			get { return _selectCar; }
			set { Set(ref _selectCar, value); }
		}


		private Window dataContext;

		public Window DataContext
		{
			get { return dataContext; }
			set { Set(ref dataContext, value); }
		}

		public DriverEditViewModel(Window window, Driver SelectDriver)
		{
			dataContext = window;
			editDriver = SelectDriver;
			Cars = new ObservableCollection<Car>(carRepo.GetAll());
		}


		public ObservableCollection<Car> Cars { get; set; } = new();

		public RelayCommand CarEditCommand
		{
			get => new RelayCommand(() =>
			{
				try
				{
					if (editDriver.FirstName is null || editDriver.LastName is null || editDriver.PhoneNumber is null || editDriver.Adress is null || editDriver.CarId is null)
					{
						MessageBox.Show("Wrong", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
					}
					else
					{
						foreach (var item in DriverViewModel.Drivers)
						{
							if (item.Id == editDriver.Id)
							{
								item.FirstName = editDriver.FirstName;
								item.LastName = editDriver.LastName;
								item.Adress = editDriver.Adress;
								item.PhoneNumber = editDriver.PhoneNumber;
								item.CarId = editDriver.CarId;
								break;
							}
						}
						driverRepo.Update(editDriver);
						driverRepo.SaveChanges();
						dataContext.Close();
						MessageBox.Show("Driver Edit olundu", "", MessageBoxButton.OK);
						//dataContext.Close();
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
