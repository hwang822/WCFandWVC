using System;
using System.ComponentModel;

namespace MixwellWPF.Models
{
    public class Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// initializes a new instance of the customer class;
        /// Gets or sets the customer's name
        /// </summary>
        public Customer(string customerName)
        {
            Name = customerName;
        }
        private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public void Clear()
        {
            if (_name != "")
                _name = "";
            else
                _name = "David";
            OnPropertyChanged("Name");
        }

        public void AddName()
        {
            _name = _name + " " + _name;
            OnPropertyChanged("Name");
        }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
