using System;

using BusinessRuleEngine.Enums;

namespace BusinessRuleEngine.Services.Bos.Departments
{
    public class DepartmentBo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DepartmentType DepartmentType { get; set; }
    }
}
