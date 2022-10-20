using Microsoft.EntityFrameworkCore;

namespace Labb2API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                FirstName = "Daniel",
                LastName = "Thulin",
                Gender = "m",
                Salary = 24500,
                StreetAdress = "Kiselgatan 69",
                Zipcode = "43256",
                City = "Varberg",
                Email = "danne@g-bk.com",
                PhoneNumber = "0730597135",
                EmployeeId = 1,
                DepartmentId=1

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                FirstName = "Testa",
                LastName = "kul",
                Gender = "m",
                Salary = 24500,
                StreetAdress = "storgatan 23",
                Zipcode = "43256",
                City = "Varberg",
                Email = "danne@g-bk.com",
                PhoneNumber = "0730597135",
                EmployeeId = 2,
                DepartmentId = 1

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                FirstName = "Daniel",
                LastName = "Thulin",
                Gender = "m",
                Salary = 24500,
                StreetAdress = "Kiselgatan 69",
                Zipcode = "43256",
                City = "Varberg",
                Email = "danne@g-bk.com",
                PhoneNumber = "0730597135",
                EmployeeId = 3,
                DepartmentId = 1

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                FirstName = "Anders",
                LastName = "Svensson",
                Gender = "m",
                Salary = 34500,
                StreetAdress = "Kastanjevägen 13",
                Zipcode = "43231",
                City = "Varberg",
                Email = "as@gmail.com",
                PhoneNumber = "0730987654",
                EmployeeId = 4,
                DepartmentId = 2

            });

            modelBuilder.Entity<Department>().HasData(new Department { DepartmentName = "It", DepartmentId=1 });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentName = "Economy", DepartmentId = 2 });
        }
    }
}
