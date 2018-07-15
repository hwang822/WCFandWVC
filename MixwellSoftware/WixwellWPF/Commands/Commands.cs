using System;
using System.Windows.Input;
using MixwellWPF.ViewModels;


namespace MixwellWPF.Commands
{

    class DelegatingCommand : ICommand
    {

       //backing fields hold the delegates! To decouple the view model class from command we can use delegates 
        // i.e. "Action" and "Func". The command class only need two things "WhattoExecute" and "WhentoExute".
        // just passed these methods as generic delegates (abstract pointer to function/methods). 

        private readonly Action<object> _action;  
        private readonly Func<object, bool> _canExecute;

        //private CustomerViewModel _viewModel;

        public DelegatingCommand(Action action)
            : this((o) => action())
        { }

        public DelegatingCommand(Action<object> action)
            : this(action, (o) => true)
        { }

        public DelegatingCommand(Action<object> action, Func<object, bool> canExecute)
        { 
            _action = action;
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);

        }

        public event System.EventHandler CanExecuteChanged{

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public void Execute(object parameter)
        {
            this._action(parameter);
        }

    }


    internal class CustomerUpdateCommand : ICommand
    {

        private CustomerViewModel _viewModel;  // this will lead tight coupling between command classes and view moudel.

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
