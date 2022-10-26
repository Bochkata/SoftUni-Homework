using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Tasks;
using Task = TaskBoardApp.Data.Entities.Task;

namespace TaskBoardApp.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskBoardAppDbContext _taskBoardAppDbContext; 
        public TasksController(TaskBoardAppDbContext taskBoardAppDbContext)
        {
            _taskBoardAppDbContext = taskBoardAppDbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            TaskFormModel taskModel = new TaskFormModel()
            {
                Boards = GetBoards(),
            };
            return View(taskModel);
        }

        [HttpPost]
        public IActionResult Create(TaskFormModel taskFormModel)
        {
            if(!GetBoards().Any(b=>b.Id == taskFormModel.BoardId))
            {
                ModelState.AddModelError(nameof(taskFormModel.BoardId), "Board does not exist");
            }
            string currentUserId = GetUserId();
            Task task = new Task()
            {
                Title = taskFormModel.Title,
                Description = taskFormModel.Description,
                CreatedOn = DateTime.Now,
                BoardId = taskFormModel.BoardId,
                OwnerId = currentUserId
            };
            _taskBoardAppDbContext.Tasks.Add(task);
            _taskBoardAppDbContext.SaveChanges();

            var boards = _taskBoardAppDbContext.Boards;

            return RedirectToAction("All","Boards");  

        }
        private IEnumerable<TaskBoardModel> GetBoards()
        {
            return _taskBoardAppDbContext.Boards.Select(b => new TaskBoardModel
            {
                Id = b.Id,
                Name = b.Name,
            });
        }
        /// <summary>
        /// The ClaimTypes.NameIdentifier returns the user id when requested. 
        /// </summary>
        /// <returns></returns>
        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);  
        }

        public IActionResult Details(int id)
        {
            TaskDetailsViewModel task = _taskBoardAppDbContext.Tasks.Where(t => t.Id == id)
                .Select(t => new TaskDetailsViewModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    Owner = t.Owner.UserName,
                    Board = t.Board.Name,
                    CreatedOn = t.CreatedOn.ToString("dd/MM/yyyy HH:mm")
                })
                .FirstOrDefault();

            if(task == null)
            {
                return BadRequest();  
            }
            return View(task);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Task task = _taskBoardAppDbContext.Tasks.Find(id);

            if(task == null)
            {
                //When task with this id doesn't exist
                return BadRequest();
            }

            string currentUserId = GetUserId(); 
            if(currentUserId != task.OwnerId)
            {
                //When current user is not an owner
                return Unauthorized();
            }
            
            TaskFormModel taskFormModel = new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                Boards = GetBoards()
            };

            return View(taskFormModel);
        }

        [HttpPost]

        public IActionResult Edit(int id, TaskFormModel taskFormModel)
        {
            Task task = _taskBoardAppDbContext.Tasks.Find(id);

            if (task == null)
            {
                return BadRequest();
            }

            if (task.OwnerId != GetUserId())
            {
                //Not an owner -> return "Unauthorized"
                return Unauthorized();  
            }
            if (!GetBoards().Any(b=>b.Id == taskFormModel.BoardId))
            {
                ModelState.AddModelError(nameof(taskFormModel.BoardId), "Board does not exist");
            }

            task.Title = taskFormModel.Title;
            task.Description = taskFormModel.Description;
            task.BoardId = taskFormModel.BoardId;

            _taskBoardAppDbContext.SaveChanges();

            return RedirectToAction("All", "Boards");
          
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Task task = _taskBoardAppDbContext.Tasks.Find(id);
            if (task == null)
            {
                //When task with this id doesn't exist
                return BadRequest();
            }
            if (GetUserId() != task.OwnerId)
            {
                //When current user is not an owner
                return Unauthorized();
            }
                       
            TaskViewModel taskViewModel = new TaskViewModel()
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description
            };
            return View(taskViewModel); 
        }

        [HttpPost]

        public IActionResult Delete(TaskViewModel taskViewModel)
        {
            Task task = _taskBoardAppDbContext.Tasks.Find(taskViewModel.Id);

            if(task == null)
            {
                return BadRequest();
            }

            if (GetUserId() != task.OwnerId)
            {
                //Not an owner -> return "Unauthorized"
                return Unauthorized();
            }

            _taskBoardAppDbContext.Tasks.Remove(task);
            _taskBoardAppDbContext.SaveChanges();

            return RedirectToAction("All", "Boards");
        }

    }
}
