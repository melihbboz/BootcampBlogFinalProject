using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
