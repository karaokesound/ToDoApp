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
    public class ProfilePanelViewModel : BaseViewModel
    {
        #region NAVIGATION
        public ICommand NavigateNavigationPanelCommand { get; }
        public ICommand NavigateTaskOperationsPanelCommand { get; }
        public ICommand NavigateFinishedTasksPanelCommand { get; }
        public ProfilePanelViewModel(NavigationStore navigationStore)
        {
            NavigateNavigationPanelCommand = new NavigateCommand<NavigationPanelViewModel>(navigationStore, () => new NavigationPanelViewModel(navigationStore));
            NavigateTaskOperationsPanelCommand = new NavigateCommand<TaskOperationsViewModel>(navigationStore, () => new TaskOperationsViewModel(navigationStore));
            NavigateFinishedTasksPanelCommand = new NavigateCommand<FinishedTasksPanelViewModel>(navigationStore, () => new FinishedTasksPanelViewModel(navigationStore));
        }
        #endregion
    }
}
