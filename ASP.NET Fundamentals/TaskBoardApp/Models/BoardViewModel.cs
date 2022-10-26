﻿using TaskBoardApp.Models.Tasks;

namespace TaskBoardApp.Models
{
    public class BoardViewModel
    {
        public BoardViewModel()
        {
            Tasks = new List<TaskViewModel>();   
        }
        public int Id { get; init; }  

        public string Name { get; init; }    

        public IEnumerable<TaskViewModel> Tasks { get; set; }   
    }
}
