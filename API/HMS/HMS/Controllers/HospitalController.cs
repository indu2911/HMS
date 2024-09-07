using HMS.Models;
using HMS.Services;
using HMS.Utils;
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
        public List<HospitalModel> Getlist()
        {
            string encrypt = "vigneshkumar";
            string encryptedstring = EncryptDecrypt.Encrypt(encrypt);

            string decryptedstring = EncryptDecrypt.Decrypt(encryptedstring);
            return hospitalService.GetHospitals();

        }
    }
}
