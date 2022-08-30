﻿using BlogProject.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.Services
{
    public interface IPostService: IService<Post>
    {
        Task<List<PostWithCategoryViewModel>>GetPostsWithCategory();
    }
}
