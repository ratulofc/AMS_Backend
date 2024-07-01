using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Interfaces.Repositories
{
    public interface IRepositoryWrapper
    {
        IParentRepository ParentRepository { get; set; }
        Task<int> SaveAsync();
    }
}
