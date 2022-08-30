using BlogProject.Core;
using BlogProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Category> GetSingleCategoryByIdWithPostsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Posts).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }

    }
}
