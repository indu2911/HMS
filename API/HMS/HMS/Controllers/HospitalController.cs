using HMS.Models;
using HMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalService hospitalService;
        public HospitalController()
        {
            hospitalService = new HospitalService();
        }


        //TODO

        [HttpGet]
        public List<HospitalModel> Get()
        {
            return hospitalService.GetHospitals();
        }
    }
}
