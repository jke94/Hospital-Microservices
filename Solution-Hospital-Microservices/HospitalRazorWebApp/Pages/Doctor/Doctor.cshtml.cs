namespace HospitalRazorWebApp.Pages.Doctor
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    using HospitalRazorWebApp.ViewModels;

    public class DoctorModel : PageModel
    {
        private readonly ILogger<DoctorModel> _logger;

        private IPatientViewModel _patientViewModel;

        public DoctorModel(ILogger<DoctorModel> logger, IPatientViewModel patientViewModel)
        {
            _logger = logger;
            _patientViewModel = patientViewModel;
        }

        public void OnGet()
        {
        }
    }
}
