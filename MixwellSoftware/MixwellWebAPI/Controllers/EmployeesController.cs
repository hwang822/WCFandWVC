using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixwellWebApi.Models;
//using MixwellWebAPI.Models;

// ASP NET Web API and SQL Server
//https://www.youtube.com/watch?v=nMGlaiNBbNU

// add API Empty Controller as new EmplpyeesController 

// Create Employees Data table in SQL server database.
/*
Create Database EmployeeDB
Go

Use EmployeeDB
Go

Create table Employees
(
	ID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender nvarchar(50),
	Salary int
)
Go

Insert into Employees values ('Mark', 'Hastings', 'Male', 60000)
Insert into Employees values ('Steve', 'Pound', 'Male',45000)
Insert into Employees values ('Philip', 'Hastings', 'Male',45000)
Insert into Employees values ('Mary', 'Lambeth', 'Female',30000)
Insert into Employees values ('Valarie', 'Vikings', 'Female',35000)
Insert into Employees values ('John', 'Stanmore', 'Male',80000)
*/

//Add New Data/Entity Data Module as ADO.NET Employee DataBase Enitty Moudle, Seelct EF Designer from Data base, select local server, database Employeesdb, Employees table to connection

//using MixwellWebAPI.Models; Add enitity data module Employee.cs and EmployDataAccess.cs

// Using Accept header the client can specify the format of the response they want.
// Accept:application/xml
// Accept:application/json
// MediaTypeFormatter is an abstract class from hich JsonMediaTypeFormatter and XmilMediaTypeFromatter classes inheritfrom
// using json only format change WebApiConfig.cs add config.Formatters.Remove(config.Formatters.XmlFormatter);

// build employees.html as client using jquery to conusme this service

namespace MixwellWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        //run http://localhost:13194/api/employees

        // this code is orignal HTML data format transfor
        public IEnumerable<Employee> Get()
        {   // get employees list from database
            /*
            <? xml version = "1.0" encoding = "ISO-8859-1" ?>
               < ArrayOfEmployee xmlns = "http://schemas.datacontract.org/2004/07/MixwellWebAPI.Models" xmlns: i = "http://www.w3.org/2001/XMLSchema-instance" >
                   < Employee >
                   < FirstName > Mark </ FirstName >
                   < Gender > Male </ Gender >
                   < ID > 1 </ ID >
                   < LastName > Hastings </ LastName >
                   < Salary > 60000 </ Salary >
                   </ Employee >
                   < Employee >
                   < FirstName > Steve </ FirstName >
                   < Gender > Male </ Gender >
                   < ID > 2 </ ID >
                   < LastName > Pound </ LastName >
                   < Salary > 45000 </ Salary >
                   </ Employee >
            */
            //            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            //            {
            //                return entities.Employees.ToList<Employee>();
            //            }
            return NotFound();

        }

        public Employee Get(int id)
        {   // get employee with id from database
            // run http://localhost:13194/api/employees/1
            /*
            <?xml version="1.0" encoding="ISO-8859-1"?>
            <Employee xmlns="http://schemas.datacontract.org/2004/07/MixwellWebAPI.Models" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
            <FirstName>Mark</FirstName>
            <Gender>Male</Gender>
            <ID>1</ID>
            <LastName>Hastings</LastName>
            <Salary>60000</Salary>
            </Employee>
            */

//            using (EmployeeDBEntities entities = new EmployeeDBEntities())
//            {
//                return entities.Employees.FirstOrDefault<Employee>(e => e.ID == id);
//            }

        }
        // https://www.youtube.com/watch?v=0eGUix3Nkjg

        //using Telerik Fiddler to test Post function.
        public void Post(Employee employee, int id)
        {
//            using (EmployeeDBEntities entities = new EmployeeDBEntities())
//            {
//                entities.Employees.Add(employee);
//                entities.SaveChanges();
//            }

        }

        //using Telerik Fiddler to test Delete function.
        public HttpResponseMessage Delete(int id)
        {
            try
            {
/*
                using (EmployeeDBEntities entities = new EmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(System.Net.HttpStatusCode.NotFound, "Employee with Id = " + id.ToString());
                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
*/
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        //using Telerik Fiddler to test Delete function.
        public HttpResponseMessage Put(int id, Employee employee)
        {
            try
            {
/*
                using (EmployeeDBEntities entities = new EmployeeDBEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(System.Net.HttpStatusCode.NotFound, "Employee with Id = " + id.ToString());
                    }
                    else
                    {
                        //entities.Employees.Remove(entity);
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Salary = employee.Salary;
                        entity.Gender = employee.Gender;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
*/
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

    }
}