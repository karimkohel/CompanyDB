using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompanyLib
{
    /// <summary>
    /// The Connector class is responsible for connecting and handling of the database (in text files)
    /// </summary>
    public class GlobalConnector
    {

        public static string DepartmentFilePath { get; set; }
        public static string EmployeeFilePath { get; set; }
        public static List<Department> Departments{ get; set;}
        public static List<Employee> Employees { get; set; }

        private static List<string> ConnectDBFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllLines(filePath).ToList();
            }
            else
            {
                return new List<string>();
            }
        }
        public static List<Department> LoadDepartments(string filePath)
        {
            List<string> lines = ConnectDBFile(filePath);

            List<Department> departments = new List<Department>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                departments.Add(new Department(int.Parse(cols[0]), int.Parse(cols[1]), cols[2], cols[3]));
            }
            GlobalConnector.Departments = departments;
            return departments;
        }
        public static Employee SerializeEmployee(Employee emp)
        {
            throw new NotImplementedException();

            // assign employee ID to emp

            // return emp;
        }

        public static Department SerializeDepartment(Department dep, List<Department> departments, string filePath)
        {
            // get max ID and add next one to current department
            int currID = 1;
            if(departments.Count > 0)
            {
                currID = departments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            dep.Id = currID;

            departments.Add(dep);

            List<string> lines = new List<string>();

            // add each object the a list of string with comma seperated values
            foreach(Department d in departments)
            {
                lines.Add($"{ d.Id },{ d.Number },{ d.Name },{ d.Address }");
            }

            // write to disk
            File.WriteAllLines(filePath, lines);

            return dep;
        }
    }
}
