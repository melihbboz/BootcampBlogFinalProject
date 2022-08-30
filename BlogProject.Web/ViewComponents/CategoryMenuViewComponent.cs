using AutoMapper;
using BlogProject.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        private readonly ICategoryService _categoryServices;
        private readonly IMapper _mapper;
        public CategoryMenuViewComponent( ICategoryService categoryService, IMapper mapper)
        {
            
            _categoryServices = categoryService;
            _mapper = mapper;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryServices.GetAllAsync());
        }
    }
}
