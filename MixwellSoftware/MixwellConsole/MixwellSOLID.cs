using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixwellConsole
{
    /*
*S - Single Responsibility Principle (known as SRP)  Class should be having one and only one responsibility   
•O - Open/Closed Principle                  Open for extension but close for modiftaion
•L - Liskov’s Substitution Principle        Child class should not break parent class type definition and havior
•I - Interface Segregation Principle        Interface shoud not be forced to unrealte user (should be seperated)
•D - Dependency Inversion Principle         Not write any tightly coupled code 

     */

    //S - Class should be having one and only one responsibility         
    public interface IEmpoyee
    {
        bool InsertIntoEmplyeeTable(Employee em);
    }

    public abstract class Employee : IEmpoyee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public bool InsertIntoEmplyeeTable(Employee em)
        {   // should only do one thing in this class
            // do something  
            return true;
        }
        public void GenerateReport(Employee em)
        {
            /* sould not have function to generatioe Report becuase later the function need change to other, the employee class have to change
             * need to create anotehr one class
            */
        }

        public virtual string GetProjectDetails(int employeedId)
        {
            return "Base Project";
        }

        public virtual string GetEmployeeDetails(int employeedId)
        {
            return "Base Employee";
        }
 
    }

    //O: Open for extension but close for modiftaion

    public class ReportGeneration
    {
        public string ReportType { get; set; }

        public void GenerateReport(Employee em)
        {
            //report reneration with Employee class

            if (ReportType == "CRS")
            {
            }

            if (ReportType == "PDF")
            {
            }
            // the class need add new if for new type. it need to extension to to diff type
        }
    }

    public abstract class IReprotGeneration 
    {
        public abstract void GenerateReport(Employee em);
    }

    public class CrystalReportGeneration : IReprotGeneration
    {
        public override void GenerateReport(Employee em)
        {
            //generate crystal report
        }
    }

    public class PDFReportGeneration : IReprotGeneration
    {
        public override void GenerateReport(Employee em)
        {
            //generate crystal report
        }

    }

    //L: Child class should not break parent class type definition and havior

    public class CasualEmployee : Employee
    {
        public override string GetProjectDetails(int employeedId)
        {
            return "Child Project";
        }
        public override string GetEmployeeDetails(int employeedId)
        {
            return "Child Employee";
        }

    }

    public class ContractorEmployee : Employee 
    {
        public override string GetProjectDetails(int employeedId)
        {
            return "Child Project";
        }
        public override string GetEmployeeDetails(int employeedId)
        {
            //for contractor employee no detail need
            throw new NotImplementedException();
        }        

    }
    // I: Interface shoud not be forced to unrealte user (should be seperated)

    public interface IPartTimeEmployee
    {  // this interface only useing for parttime employee
        void PayHourRate();
    }

    public class PartTimeEmployee : Employee, IPartTimeEmployee
    {
        public void PayHourRate()
        {

        }
    }

    //D: Not write any tightly coupled code 

    public interface IMessager
    {
        void SendMessage();
    }

    public class Email : IMessager
    {
        public void SendMessage()
        {
        }

    }

    public class SMS : IMessager
    {
        public void SendMessage()
        {
        }

    }

    public class Notification
    {
        private IMessager _Imessager;
        public Notification()
        {
            _Imessager = new Email();
        }

        public void NoNotiy()
        {
            _Imessager.SendMessage();
        }

    }   
     
    //************************************************
    class MixwellSOLID
    {
        //generate PDF report
    }
}


