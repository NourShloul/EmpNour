using EmpNour.Data;
using EmpNour.Models;

namespace EmpNour.Services
{
    public class ProcessStatus
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public EmpInfo GetEmpStatus(int nat)
        {
            var user = _dataAccess.GetUserByNAT(nat);
            if (user == null)
            {
                return null;
            }

            var salaries = _dataAccess.GetSalariesByUserId(user.Id);
            int highestSalary = salaries.Any() ? salaries.Max() : 0;
            double avgSalary = salaries.Any() ? salaries.Average() : 0;
            int totalSalary = salaries.Sum();

            string status = totalSalary > 2000 ? "GREEN" :
                            totalSalary < 2000 ? "RED" : "ORANGE";

            return new EmpInfo
            {
                Username = user.Username,
                NationalNumber = user.NationalNumber,
                Email = user.Email,
                Phone = user.Phone,
                IsActive = user.IsActive,
                HighestSalary = highestSalary,
                AverageSalary = avgSalary,
                Status = status
            };
        }
    }
}
