using EmpNour.Models;

namespace EmpNour.Data
{
    public class DataAccess
    {
        private readonly MyDbContext _context;

        public DataAccess()
        {
            _context = new MyDbContext();
        }

        public User GetUserByNAT(int nat)
        {
            return _context.Users.FirstOrDefault(u => u.NationalNumber == nat);
        }

        public List<int> GetSalariesByUserId(int userId)
        {
            return _context.Salaries.Where(s => s.UserId == userId).Select(s => s.SalaryAmount).ToList();
        }
    }
}
