using Blog.web.Models.ViewModels;
using Blog.web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blog.web.Controllers
{
    public class AdminBlogPostsController : Controller
    {
        private readonly ITagRepository tagRepository;

        public AdminBlogPostsController(ITagRepository tagRepository) 
        {
            this.tagRepository = tagRepository;
        }
        [HttpGet]
        public async Task <IActionResult> Add()
        {
            //get Tags from repository
            var tags = await tagRepository.GetAllAsync();
                var  model = new AddBlogPostRequest
                {
                    Tags = tags.Select(x => new SelectListItem { Text = x.DisplayName, Value = x.Id.ToString() })
                };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddBlogPostRequest addBlogPostRequest)
        {
            return RedirectToAction("Add");
        }
    }
}
