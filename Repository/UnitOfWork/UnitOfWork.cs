using DataLayer.Models.ViewModel;
using Repository.Interface;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Repository.Implementations;

namespace Repository.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext, new()
    {
        private T _context = null;
        public UnitOfWork()
        {
            _context = new T();
        }

        public UnitOfWork(T dbContext)
        {
            _context = dbContext;
        }

        public T Context { get { return _context; } }

        public IRepository<Patient> _Patient;
        public IRepository<Patient> Patients 
        {
            get { return _Patient ?? (_Patient = new RepositoryBase<Patient, T>(_context)); }
        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
