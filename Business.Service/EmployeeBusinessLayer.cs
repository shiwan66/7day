using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employees.Data;
using Employees.Entities;
using Employees.Data.DataAccessLayer;

namespace Business.Service
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            //List<Employee> employees = new List<Employee>();
            //Employee emp = new Employee();
            //emp.FirstName = "johnson";
            //emp.LastName = " fernandes";
            //emp.Salary = 14000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "michael";
            //emp.LastName = "jackson";
            //emp.Salary = 16000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "robert";
            //emp.LastName = " pattinson";
            //emp.Salary = 20000;
            //employees.Add(emp);
            //return employees;

            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

        public void UploadEmployees(List<Employee> employees)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.AddRange(employees);
            salesDal.SaveChanges();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        } 
        //public bool IsValidUser(UserDetails u)
        //{
        //    if(u.UserName == "Admin" && u.Password == "Admin"){
        //        return true;
        //    }
        //    return false;
        //}
        public UserStatus GetUserValidity(UserDetails u)
        {
            if(u.UserName == "Admin" && u.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            } else if(u.UserName == "Sukesh" && u.Password == "Sukesh")
            {
                return UserStatus.AuthenticatedUser;
            } else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }
    }
}