using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.ViewModels
{
    public class PostWithCategoryViewModel: PostViewModel
    {
        public CategoryViewModel Category { get; set; }
    }
}
