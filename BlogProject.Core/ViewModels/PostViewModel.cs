using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.ViewModels
{
    public class PostViewModel: BaseViewModel
    {
        public string Title { get; set; }

        public string Body { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
    }
}
