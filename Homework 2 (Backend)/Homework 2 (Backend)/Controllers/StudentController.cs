using System.Collections.Generic;
using Homework_2__Backend_.Models;
using Homework_2__Backend_.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework_2__Backend_.Controllers
{
	public class StudentController : Controller
	{
		List<Student> _students;
		List<Group> _groups;
		public StudentController()
		{
			_students = new List<Student>()
			{
				new Student {Id=1,FullName="Vuqar Memmedov",Point=100},
				new Student {Id=2,FullName="Orxan Eliyev",Point=87},
				new Student {Id=3,FullName="Resad Hesenov",Point=38},
				new Student {Id=4,FullName="Vusal Suleymanov",Point=45},
				new Student {Id=5,FullName="Niyazi Qurbanli",Point=75}
			};

			_groups = new List<Group>()
			{
				new Group {Id=1,Name="P232"},
				new Group {Id=2,Name="D276"},
				new Group {Id=3,Name="S134"},
				new Group {Id=4,Name="P214"},
				new Group {Id=5,Name="D248"}
			};
		}
		public IActionResult Index()
		{
			StudentViewModel studentWM = new StudentViewModel
			{
				Students = _students,
				Groups = _groups,
			};
			return View(studentWM);
		}
		public IActionResult Detail(int id)
		{
			Student std = _students.Find(x => x.Id == id);
			if (std == null)
				return View("Error");
			return View(std);
		}
	}
}
