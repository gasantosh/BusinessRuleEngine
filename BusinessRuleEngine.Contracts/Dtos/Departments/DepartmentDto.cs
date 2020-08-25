using System;
using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Contracts.Dtos.Departments
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DepartmentType DepartmentType { get; set; }
    }
}
