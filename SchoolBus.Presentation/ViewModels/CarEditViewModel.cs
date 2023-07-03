using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBus.Data.Repos;
using SchoolBusModels.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SchoolBus.Presentation.ViewModels
{
	public class CarEditViewModel : ViewModelBase
	{
		readonly IRepository<Car>? carRepo = new Repository<Car>();

		private Car editCar = new();

		public Car EditCar
		{
			get { return editCar; }
			set { Set(ref editCar, value); }
		}



		private Window dataContext;

		public Window DataContext
		{
			get { return dataContext; }
			set { Set(ref dataContext, value); }
		}

		public CarEditViewModel(Window window, Car SelectCar)
		{
			dataContext = window;
			editCar = SelectCar;
		}



		public RelayCommand CarEditCommand
		{
			get => new RelayCommand(() =>
			{
				try
				{
					if (editCar.Name is null || editCar.CarNumber is null || editCar.SeatCount <= 0)
					{
						MessageBox.Show("dsfa", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
					}
					else
					{
						foreach (var item in CarViewModel.Cars)
						{
							if (item.Id == editCar.Id)
							{
								item.Name = editCar.Name;
								item.CarNumber = editCar.CarNumber;
								item.SeatCount = editCar.SeatCount;
								break;
							}
						}
						carRepo.Update(editCar);
						carRepo.SaveChanges();
						dataContext.Close();
						MessageBox.Show("Car elave olundu", "", MessageBoxButton.OK);
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
