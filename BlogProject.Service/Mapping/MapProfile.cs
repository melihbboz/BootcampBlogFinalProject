using AutoMapper;
using BlogProject.Core;
using BlogProject.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<PostFeature, PostFeatureViewModel>().ReverseMap();
            CreateMap<PostUpdateViewModel, Post>();
            CreateMap<Post, PostWithCategoryViewModel>();
            CreateMap<Category, CategoryWithPostsViewModel>();
        }
    }
}
