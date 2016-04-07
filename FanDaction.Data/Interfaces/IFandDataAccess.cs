using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Data.Repositories;
using FanDaction.Data.Interfaces;

namespace FanDaction.Data
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        Task<int> SaveAsync();
    }
    public interface IFandDataAccess : IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        ISettingsRepository Settings { get;  }
        IAutoEmailRepository Emails { get;  }
    }
}
