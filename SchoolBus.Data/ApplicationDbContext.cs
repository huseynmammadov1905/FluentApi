using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus.Data
{
	public class ApplicationDbContext :DbContext

	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseSqlServer("Data Source=DESKTOP-N6OLO15;Initial Catalog=FluentAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;MultiSubnetFailover=False");
			//optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{





		

			modelBuilder.Entity<Car>()
						 .HasOne(c => c.Driver)
						 .WithOne(d => d.Car)
						 .HasForeignKey<Driver>(d => d.CarId);

			modelBuilder.Entity<Driver>()
				.HasOne(d => d.Car)
			   .WithOne(c => c.Driver)
			   .HasForeignKey<Driver>(d => d.CarId);

		





		}
	}
}
