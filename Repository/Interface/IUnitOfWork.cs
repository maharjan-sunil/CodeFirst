using DataLayer.Models.ViewModel;
using System.Data.Entity;

namespace Repository.Interface
{
    public interface IUnitOfWork<T> where T :DbContext
    {
        IRepository<Patient> Patients { get; }
    }
}
