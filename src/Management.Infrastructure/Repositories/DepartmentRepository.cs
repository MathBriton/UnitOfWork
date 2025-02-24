namespace Management.Infrastructure.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public Department AddDepartment(string departmentName)
        {
            var department = new Department(departmentName);
            if (department.ValidOnAdd())
            {
                this.Add(department);
                return department;
            }
            else
                throw new Exception("Department invalid");
        }
    }

    public class Department
    {
        private string departmentName;

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        internal bool ValidOnAdd()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IDepartmentRepository
    {
    }
}
