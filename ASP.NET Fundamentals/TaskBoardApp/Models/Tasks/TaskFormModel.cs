using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Data;
using static TaskBoardApp.Data.DataConstants.Task;

namespace TaskBoardApp.Models.Tasks
{
	public class TaskFormModel
	{
       
        [Required]
        [StringLength(MaxTaskTitle, MinimumLength = MinTaskTitle, ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxTaskDescription,MinimumLength = MinTaskDescription, ErrorMessage = "Description should be at least {2} characters long")]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Board")]
        public int BoardId { get; set; } 

        public IEnumerable<TaskBoardModel> Boards { get; set; }

    }
}
