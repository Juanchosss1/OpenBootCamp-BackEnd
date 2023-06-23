using universityApiBackEnd.DataAccess;
using universityApiBackEnd.Models;
using universityApiBackEnd.Models.DataModels;

namespace universityApiBackEnd.Services
{
    public class Service
    {
        private readonly UniversityDBContext _context;

        public Service(UniversityDBContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string userEmail)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == userEmail);

            return user;
        }
    }
}
