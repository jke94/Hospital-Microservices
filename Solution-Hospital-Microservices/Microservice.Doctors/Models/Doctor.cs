namespace Microservice.Doctors.Controllers
{
    using System;

    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBorn { get; set; }
        public int Age { get; set; }
    }
}
