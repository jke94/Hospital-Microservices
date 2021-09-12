namespace HospitalRazorWebApp.ViewModels
{
    using Newtonsoft.Json;
    using HospitalRazorWebApp.Models;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class PatientViewModel : IPatientViewModel
    {
        private IHttpClientFactory _httpClientFactory;

        public PatientViewModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Doctor>> TestMethodAsync()
        {

            var list = new List<Doctor>();

            var client = _httpClientFactory.CreateClient("DoctorsService");
            var responseMessage = await client.GetAsync("api/Doctor");

            if (responseMessage.IsSuccessStatusCode)
            {
                var content = await responseMessage.Content.ReadAsStringAsync();

                var theList = JsonConvert.DeserializeObject<IList<Doctor>>(content);
                
                foreach(var item in theList)
                {
                    list.Add(new Doctor()
                    {
                        DoctorID = item.DoctorID,
                        Name = item.Name,
                        Surname = item.Surname,
                        Age = item.Age,
                        DateBorn = item.DateBorn
                    });
                }

                
            }
            return list;
        }

        public List<Doctor> TestMethod()
        {
            return TestMethodAsync().Result;
        }
    }
}
