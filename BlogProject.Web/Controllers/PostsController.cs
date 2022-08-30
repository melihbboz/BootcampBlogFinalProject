using AutoMapper;
using BlogProject.Core;
using BlogProject.Core.Services;
using BlogProject.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogProject.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostService _services;
        private readonly ICategoryService _categoryServices;
        private readonly IMapper _mapper;
        public PostsController(IPostService service, ICategoryService categoryService, IMapper mapper)
        {
            _services = service;
            _categoryServices = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _services.GetPostsWithCategory());
        }

        public async Task<IActionResult> Save()
        {
            var categories= await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(PostViewModel postViewModel)
        {
            

            if (ModelState.IsValid)
            {
                await _services.AddAsync(_mapper.Map<Post>(postViewModel));
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name");
            return View();
        }
        [ServiceFilter(typeof(NotFoundFilter<Post>))]
        public async Task<IActionResult> Update(int id)
        {
            var post = await _services.GetByIdAsync(id);
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name", post.CategoryId);
            return View(_mapper.Map<PostViewModel>(post));
        }

        [HttpPost]
        public async Task<IActionResult> Update(PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                await _services.UpdateAsync(_mapper.Map<Post>(postViewModel));
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name", postViewModel.CategoryId);
            return View(postViewModel);
        }

        public async Task<IActionResult> Remove(int id)
        {
            var post = await _services.GetByIdAsync(id);

            await _services.RemoveAsync(post);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
