using AutoMapper;
using BlogProject.Core;
using BlogProject.Core.Repositories;
using BlogProject.Core.Services;
using BlogProject.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IPostService _postServices;
        private readonly ICategoryService _categoryServices;
        private readonly IMapper _mapper;
        public CategoryController(IPostService service, ICategoryService categoryService, IMapper mapper)
        {
            _postServices = service;
            _categoryServices = categoryService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            return View(await _categoryServices.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                await _categoryServices.AddAsync(_mapper.Map<Category>(categoryViewModel));
                return RedirectToAction(nameof(List));
            }
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name");
            return View();
        }
        [ServiceFilter(typeof(NotFoundFilter<Category>))]
        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryServices.GetByIdAsync(id);
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name", category.Id);
            return View(_mapper.Map<CategoryViewModel>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                await _categoryServices.UpdateAsync(_mapper.Map<Category>(categoryViewModel));
                return RedirectToAction(nameof(List));
            }
            var categories = await _categoryServices.GetAllAsync();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories.ToList());
            ViewBag.categories = new SelectList(categoriesViewModel, "Id", "Name", categoryViewModel.Id);
            return View(categoryViewModel);
        }
        public async Task<IActionResult> Remove(int id)
        {
            var post = await _categoryServices.GetByIdAsync(id);

            await _categoryServices.RemoveAsync(post);
            return RedirectToAction(nameof(List));
        }
    }
}
