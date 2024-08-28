using HMS.Models;
using HMS.Respository;

namespace HMS.Services
{
    public class HospitalService
    {
        private readonly HospitalRepository _hospitalRepository;
        public HospitalService()
        {
            _hospitalRepository = new HospitalRepository();
        }

        public List<HospitalModel> GetHospitals()
        {
            return _hospitalRepository.GetHospitalList();
        }
    }
}
