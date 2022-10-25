using ForumApp.Data;
using ForumApp.Data.Entities;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext _context;    
        public PostsController(ForumAppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult All()
        {
            List<PostViewModel> posts = _context.Posts
                .Where(p=>p.IsDeleted == false)
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToList();
            return View(posts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(PostFormModel formModel)
        {
            Post post = new Post()
            {
                Title = formModel.Title,
                Content = formModel.Content

            };
            
            _context.Posts.Add(post);   
            _context.SaveChanges();

            return RedirectToAction(nameof(All));               
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Post post = _context.Posts.Find(id);               

            return View(new PostFormModel
            {
                Title = post.Title,
                Content = post.Content  
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PostFormModel postFormModel)
        {
            Post post = _context.Posts.Find(id);

            post.Title = postFormModel.Title;
            post.Content = postFormModel.Content;

            _context.SaveChanges();

            return RedirectToAction(nameof(All));  
        }

        [HttpPost]

        public IActionResult Delete(int id)
        {
            Post post = _context.Posts.Find(id);
            post.IsDeleted = true;
            //_context.Posts.Remove(post);
            _context.SaveChanges();

            return RedirectToAction(nameof(All));
        }
    }
}
