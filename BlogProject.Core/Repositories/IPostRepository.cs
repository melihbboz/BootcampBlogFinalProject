using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.Repositories
{
    public interface IPostRepository: IGenericRepository<Post>
    {
        Task<List<Post>> GetPostsWithCategory();
    }
}
