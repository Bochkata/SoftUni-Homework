using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskBoardAppDbContext _dbContext;

        public HomeController(TaskBoardAppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public IActionResult Index()
        {
            IQueryable<string> boardsNames = _dbContext.Boards.Select(b => b.Name).Distinct();

           List<HomeBoardModel> boardTasksAndCounts = new List<HomeBoardModel>();

            foreach(string boardName in boardsNames)
            {
                int tasksCountInBoard = _dbContext.Tasks.Where(t=>t.Board.Name == boardName).Count();    HomeBoardModel boardAndTaskCount = new HomeBoardModel()
                {
                    BoardName = boardName,
                    TasksCount = tasksCountInBoard
                };
                boardTasksAndCounts.Add(boardAndTaskCount);

            }

            int userTasksCount = 0;

            if (User.Identity.IsAuthenticated)
            {
                string currentUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                userTasksCount = _dbContext.Tasks.Where(t => t.OwnerId == currentUserId).Count();
            }
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                AllTasksCount = _dbContext.Tasks.Count(),
                BoardsWithTasksCount = boardTasksAndCounts,
                UserTasksCount = userTasksCount
            };

            return View(homeViewModel);
        }


       
    }
}