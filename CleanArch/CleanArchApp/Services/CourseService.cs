using CleanArchApp.Interfaces;
using CleanArchApp.ViewModels;
using ClearArchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApp.Services
{
	public class CourseService : ICourseService
	{
		private ICourseRepository _courseRepository;

		public CourseService(ICourseRepository courseRepository)
		{
			_courseRepository = courseRepository;
		} 
		public CourseViewModel GetCourses()
		{
			return new CourseViewModel()
			{
				Courses = _courseRepository.GetCourses()
			};
		}
	}
}
