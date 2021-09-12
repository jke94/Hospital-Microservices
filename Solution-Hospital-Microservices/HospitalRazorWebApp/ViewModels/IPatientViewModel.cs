namespace HospitalRazorWebApp.ViewModels
{
    using HospitalRazorWebApp.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPatientViewModel
    {
        public List<Doctor> TestMethod();

        public Task<List<Doctor>> TestMethodAsync();
    }
}
