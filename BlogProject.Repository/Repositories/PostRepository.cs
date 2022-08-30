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
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Post>> GetPostsWithCategory()
        {
            return await _context.Posts.Include(x => x.Category).ToListAsync();
        }
    }
}
