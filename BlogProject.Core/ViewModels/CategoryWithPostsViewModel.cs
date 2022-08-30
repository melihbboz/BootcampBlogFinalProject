using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.ViewModels
{
    public class CategoryWithPostsViewModel: CategoryViewModel
    {
        public List<PostViewModel> Posts { get; set; }
    }
}
