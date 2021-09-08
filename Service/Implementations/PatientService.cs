using DataLayer.Models.ViewModel;
using Service.BaseService;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Service.Implementations
{
    public class PatientService : BaseServices, IPatientService
    {
        public List<Patient> GetALL()
        {
            var query = _unitOfWork.Patients.All();
            return query.ToList();
        }
    }
}
