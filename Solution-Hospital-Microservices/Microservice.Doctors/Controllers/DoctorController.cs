namespace Microservice.Doctors.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Repository.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        public DoctorController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _repoWrapper.Doctor.FindAllAsync();

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await _repoWrapper.Doctor.FindByConditionAsync(
                element => element.DoctorID.Equals(id));

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

    }
}