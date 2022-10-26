namespace TaskBoardApp.Models
{
	public class HomeBoardModel
	{
		public string BoardName { get; init; }

		public int TasksCount { get; init; }
	}

	public class HomeViewModel
	{
		public int AllTasksCount { get; init; }	

		public List<HomeBoardModel> BoardsWithTasksCount { get; init; }	

		public int UserTasksCount { get; set; }		
	}


}
