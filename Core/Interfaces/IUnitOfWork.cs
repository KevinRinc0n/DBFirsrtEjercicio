using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IDriverRepository Drivers {get;}
        ITeamRepository Teams {get;}
        Task<int> SaveAsync();
    }
}