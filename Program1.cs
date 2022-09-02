using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToobjectDemo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}{Salary}{City}";
        }


        class Program1
        {
            static void Main(string[] args)
            {
                List<Employee> emp = new List<Employee>()
                {

                    new Employee { Id = 1, Name = "raj", Salary = 46785, City = "pune" },
                    new Employee { Id = 2, Name = "divay", Salary = 76558, City = "mumbai" },
                    new Employee { Id = 3, Name = "sony", Salary = 46985, City = "pune" },
                    new Employee { Id = 4, Name = "akita", Salary = 16785, City = "hyd" },
                    new Employee { Id = 5, Name = "rahul", Salary = 49785, City = "Aurangaba" },
                };
                //1.display all employees
                var result1 = from e in emp
                             select e;
               

                //2. display employee with asending order by name
                var result2 = from e in emp
                              orderby e.Name ascending
                              select e;
                //3.display employee whose salary is > 25000
                var result3 = from e in emp
                              where e.Salary > 25000
                              select e;
                //4.display employee whos from 'Pune' City
                var result4 = from e in emp
                              where e.City == "pune"
                              select e;
                //5.display employee with desending order by salary
                var result5 = from e in emp
                              orderby e.Salary descending
                              select e;
                //6.display employee whose name start with 'P'
                var result6 = from e in emp
                              where e.Name.StartsWith("p")
                              select e;
                //7.display employee whose salary is > 25000 & emp is from 'Mumbai' city
                var result7 = from e in emp
                              where e.Salary > 25000 && e.City.Contains("mumbai")
                              select e;
                foreach(Employee item in result7)
                {
                    Console.WriteLine(item);
                }

                //Lambda Expression

                var res = emp.OrderBy(e => e.Name).ToList();
                var res1 = emp.Where(e => e.Salary > 25000).ToList();
                var res2 = emp.Where(e => e.City == "Pune").ToList();
                var res3 = emp.OrderBy(e => e.Salary).ToList();
                var res4 = emp.Where(e => e.City.StartsWith("P")).ToList();

                var res5 = lst.Where(e => e.Salary > 25000 && e.City == ("Mumbai")).ToList();






            }
        }

    }
}

