namespace Microsoft.ILP2025.EmployeeCRUD.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Designation { get; set; }
        public int YOE { get; set; }
        public decimal Salary { get; set; }
    }
}
