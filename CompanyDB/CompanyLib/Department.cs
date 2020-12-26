using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyLib
{
    public class Department
    {
        /// <summary>
        /// Represents a company department that has employees
        /// </summary>
        public string Name
        {
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Department name can't be empty.");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Department name can't contain numbers.");
                }
            }

        }
        public int Number
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Department number can't be less than 1.");
                }
            }
        }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
