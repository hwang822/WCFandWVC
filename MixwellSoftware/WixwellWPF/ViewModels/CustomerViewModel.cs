using System;
using System.Diagnostics;
using MixwellWPF.Models;
using System.Windows.Input;
using System.ComponentModel;
using MixwellWPF.Commands;


namespace MixwellWPF.ViewModels
{


    interface IShow  // Dependency Injection 
    {
        void show(string str);
    }

    class Display : IShow
    {
        IShow _surface;
        public Display(IShow surface)
        {
            _surface = surface;
        }
        public void show(string str)
        {
            _surface.show(str);
        }
    }

    internal class CustomerViewModel
    {
        private Customer _customer;

        public bool CanUpdate {             
            get{
                if(Customer == null){
                    return false;}
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        public CustomerViewModel() {
            _customer = new Customer("David");
        }

        public Customer Customer {
            get
            {
                return _customer;
            }
        }

        public void Clear()
        {
            _customer.Clear();            
        }

        public void AddName()
        {
            _customer.AddName();
        }


        public ICommand UpdataCommand
        {
            get
            {
                return new DelegatingCommand(Clear);  //abstract pointer to function/methods to DelegatingCommand
            }
        }

        public ICommand ChangecolorCommand
        {
            get
            {
                return new DelegatingCommand(AddName);  //abstract pointer to function/methods to DelegatingCommand
            }
        }

        public void ColarChanges()
        {
            //   Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
            
        }


        public void SaveChanges() {
         //   Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
            
        }
    }
}
