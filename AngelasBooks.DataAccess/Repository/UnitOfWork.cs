using AngelasBooks.DataAccess.Repository.IRepository;
using AngelasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using AngelasBooks.Models;

namespace AngelasBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork        // Make the method public to access the class
    {
        private readonly ApplicationDbContext _db;      // The using statement
        public UnitOfWork(ApplicationDbContext db)      // Constructor to us DI and inject into the respoitory
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; set; }
        public ISP_Call SP_Call { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()          // All changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
