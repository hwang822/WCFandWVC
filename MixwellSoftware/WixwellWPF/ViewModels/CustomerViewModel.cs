using System;
using System.Diagnostics;
using MixwellWPF.Models;
using System.Windows.Input;
using MixwellWPF.Commands;

namespace MixwellWPF.ViewModels
{
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
            UpdataCommand = new CustomerUpdateCommand(this);
        }

        public Customer Customer {
            get
            {
                return _customer;
            }
        }

        public ICommand UpdataCommand
        {
            get;
            private set;
        }

        public void SaveChanges() {
            Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
        }
    }
}
