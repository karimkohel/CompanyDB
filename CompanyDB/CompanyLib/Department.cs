using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLib
{
    class Department
    {
        /// <summary>
        /// Represents a company department that has employees
        /// </summary>
        public string Name { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
