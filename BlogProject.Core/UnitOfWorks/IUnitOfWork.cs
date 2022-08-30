using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void commit();
    }
}
