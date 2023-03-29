using System.Collections.Generic;
using Homework_2__Backend_.Models;

namespace Homework_2__Backend_.ViewModels
{
	public class StudentViewModel
	{
		public List<Student> Students { get; set; }
		public List<Group> Groups { get; set; }
	}
}
