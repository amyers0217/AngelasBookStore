using AngelasBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngelasBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
