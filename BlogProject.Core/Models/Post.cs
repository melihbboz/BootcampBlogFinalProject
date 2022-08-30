using BlogProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core
{
    public class Post:BaseEntity
    {

        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public PostFeature PostFeature { get; set; }


    }
}
