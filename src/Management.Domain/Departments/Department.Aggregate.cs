namespace Management.Domain.Departments

{
    public partial class Departments
    {
        partial Department(string departmentName) : base()
        {
            this.DepartmentName = departmentName;
        }

        public bool ValidOnAdd()
        {
            return !string.IsNullOrEmpty(DepartmentName);
        }
    }
    
}