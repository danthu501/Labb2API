namespace Labb2API.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
