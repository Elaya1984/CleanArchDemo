using ClearArchDomain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArchDomain.Interfaces
{
	public interface ICourseRepository
	{
		IEnumerable<Course> GetCourses();
	}
}
