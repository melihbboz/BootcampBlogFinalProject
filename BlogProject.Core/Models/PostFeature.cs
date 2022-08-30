using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core
{
    public class PostFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
