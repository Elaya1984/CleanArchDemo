using CleanArchApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApp.Interfaces
{
	public interface ICourseService
	{
		CourseViewModel GetCourses();
	}
}
