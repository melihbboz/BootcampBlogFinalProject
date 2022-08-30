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
    public class PostService : Service<Post>, IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IGenericRepository<Post> repository, IUnitOfWork unitOfWork, IMapper mapper, IPostRepository postRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<List<PostWithCategoryViewModel>> GetPostsWithCategory()
        {
            var posts = await _postRepository.GetPostsWithCategory();

            var postViewModel = _mapper.Map<List<PostWithCategoryViewModel>>(posts);
            return postViewModel;
        }
    }
}
