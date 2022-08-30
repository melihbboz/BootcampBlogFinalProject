using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.ViewModels
{
    public class PostFeatureViewModel
    {
        public int Id { get; set; }
        public string Color { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        public int PostId { get; set; }
    }
}
