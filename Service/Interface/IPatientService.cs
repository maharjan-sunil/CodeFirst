using DataLayer.Models.ViewModel;
using System.Collections.Generic;

namespace Service.Interface
{
    interface IPatientService
    {
        List<Patient> GetALL();
    }
}
