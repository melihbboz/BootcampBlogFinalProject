using BlogProject.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.Services
{
    public interface ICategoryService: IService<Category>
    {
        public Task<CategoryWithPostsViewModel> GetSingleCategoryByIdWithPostsAsync(int categoryId);
    }
}
