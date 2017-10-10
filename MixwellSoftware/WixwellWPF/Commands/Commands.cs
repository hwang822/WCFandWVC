using System.Windows.Input;
using MixwellWPF.ViewModels;


namespace MixwellWPF.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        private CustomerViewModel _viewModel;
        public CustomerUpdateCommand(CustomerViewModel viewmodel)
        {
            _viewModel = viewmodel;
        }

        public bool CanExecute(object parameter)
        {
            //throw new System.NotImplementedException();
            return _viewModel.CanUpdate;

        }

        public event System.EventHandler CanExecuteChanged{

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public void Execute(object parameter)
        {
            //throw new System.NotImplementedException();
            _viewModel.SaveChanges();
        }
    }
}
