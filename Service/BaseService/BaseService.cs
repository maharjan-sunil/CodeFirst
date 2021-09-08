using DataBase;
using Repository.Interface;
using Repository.UnitOfWork;

namespace Service.BaseService
{
    public abstract class BaseServices
    {
        protected IUnitOfWork<DbEntityModelContext> _unitOfWork;

        public BaseServices(IUnitOfWork<DbEntityModelContext> unitOfWork = null)
        {
            _unitOfWork = unitOfWork ?? new UnitOfWork<DbEntityModelContext>();
        }

    }
}
