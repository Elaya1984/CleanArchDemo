using CleanArchApp.Interfaces;
using CleanArchApp.Services;
using CleanArchInfra.Data.Repositories;
using ClearArchDomain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Ioc
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			//App Layer
			services.AddScoped<ICourseService, CourseService>();

			//Data layer
			services.AddScoped<ICourseRepository, CourseRepository>();
		}
	}
}
