using AngelasBooks.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngelasBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
