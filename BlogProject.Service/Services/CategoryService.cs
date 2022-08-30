using AutoMapper;
using BlogProject.Core;
using BlogProject.Core.Repositories;
using BlogProject.Core.Services;
using BlogProject.Core.UnitOfWorks;
using BlogProject.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<CategoryWithPostsViewModel> GetSingleCategoryByIdWithPostsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetSingleCategoryByIdWithPostsAsync(categoryId);

            var categoryViewModel = _mapper.Map<CategoryWithPostsViewModel>(category);

            return categoryViewModel;
        }
    }
}
