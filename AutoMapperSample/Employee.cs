namespace AutoMapperSample
{
    public class Employee
    {
        public string Name { get; set; }
        public Company Company { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class EmployeeDto
    {
        public string Name { get; set; }
        
        //目标类属性必须是 源类型中 复杂属性名称+复杂属性类型的内部属性名称
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}