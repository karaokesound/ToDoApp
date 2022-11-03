using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Commands;
using ToDoApp.Stores;

namespace ToDoApp.ViewModels
{
    public class StartingPanelViewModel : BaseViewModel, IDataErrorInfo
    {
        #region NAVIGATION
        public ICommand NavigateNavigationPanelCommand { get; }
        public StartingPanelViewModel(NavigationStore navigationStore)
        {
            NavigateNavigationPanelCommand = new NavigateCommand<NavigationPanelViewModel>(navigationStore, () => new NavigationPanelViewModel(navigationStore));
        }
        #endregion

        public string Error { get { return null; } }

        private string _userName;

        private string _userPassword;

        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();

        public string this[string name, string password]
        {
            get
            {
                string result = null;

                switch (name)
                {
                    case "UserName":
                        if (string.IsNullOrWhiteSpace(UserName))
                            result = "Username can't be empty";
                        else if (UserName.Length < 5)
                            result = "Username must be a minimum of 5 characters";
                        break;
                }
                switch (password)
                {
                    case "Password":
                        if (string.IsNullOrWhiteSpace(Password))
                            result = "Password can't be empty";
                        else if (Password.Length < 5)
                            result = "Password must be a minimum of 5 characters";
                        break;
                }

                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = result;
                else if (result != null)
                    ErrorCollection.Add(name, result);

                if (ErrorCollection.ContainsKey(password))
                    ErrorCollection[password] = result;
                else if (result != null)
                    ErrorCollection.Add(Password, result);

                OnPropertyChanged("ErrorCollection");

                return result;
            }
        }

        public string UserName
        {
            get
            { return _userName; }

            set
            {
                _userName = value;
                OnPropertyChanged(_userName);
            }
        }

        public string Password
        {
            get { return _userPassword; }
            set
            {
                _userPassword = value;
                OnPropertyChanged(_userPassword);
            }
        }

        public string this[string columnName] => throw new NotImplementedException();

        //public string this[string password]
        //{
        //    get
        //    {
        //        string result = null;

        //        switch (password)
        //        {
        //            case "Password":
        //                if (string.IsNullOrWhiteSpace(Password))
        //                    result = "Username can't be empty";
        //                else if (Password.Length < 5)
        //                    result = "Username must be a minimum of 5 characters";
        //                break;
        //        }

        //        if (ErrorCollection.ContainsKey(password))
        //            ErrorCollection[password] = result;
        //        else if (result != null)
        //            ErrorCollection.Add(password, result);

        //        OnPropertyChanged("ErrorCollection");

        //        return result;
        //    }


        //public string Password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        string passwordResult = null;
        //        _password = value;
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Password can't be empty");
        //        }

        //        OnPropertyChanged(_password);
        //    }
        //}
    }
}
