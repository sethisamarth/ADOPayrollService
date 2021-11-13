using System;

namespace ADO_Employee_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Services using ADO!");
            //Create oobject for Employee Repository
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeDataManager employeeDataManager = new EmployeeDataManager();
            employeeDataManager.EmployeeID = 2;
            employeeDataManager.EmployeeName = "shivam";
            employeeDataManager.BasicPay = 3000000;
            employeeRepository.GetSqlData();
            employeeRepository.UpdateSalaryQuery();
            employeeRepository.UpdateSalary(employeeDataManager);
          
            
        }
    }
}
