using CleanArchInfra.Data.Context;
using ClearArchDomain.Interfaces;
using ClearArchDomain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchInfra.Data.Repositories
{
	public class CourseRepository : ICourseRepository
	{
		private UniversityDbContext _ctx;

		public CourseRepository(UniversityDbContext ctx)
		{
			_ctx = ctx;
		}
		public IEnumerable<Course> GetCourses()
		{
			return _ctx.Courses;
		}
	}
}
