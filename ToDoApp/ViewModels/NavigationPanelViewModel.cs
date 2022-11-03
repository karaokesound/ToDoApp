using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Commands;
using ToDoApp.Stores;

namespace ToDoApp.ViewModels
{
    public class NavigationPanelViewModel : BaseViewModel
    {
        #region NAVIGATION
        public ICommand NavigateTaskOperationsCommand { get; }
        public ICommand NavigateFinishedTasksPanelCommand { get; }
        public ICommand NavigateProfilePanelCommand { get; }
        public ICommand NavigateSignInPanelCommand { get; }
        public ICommand NavigateStartingPanelCommand { get; }
        public NavigationPanelViewModel(NavigationStore navigationStore)
        {
            NavigateTaskOperationsCommand = new NavigateCommand<TaskOperationsViewModel>(navigationStore, () => new TaskOperationsViewModel(navigationStore));
            NavigateFinishedTasksPanelCommand = new NavigateCommand<FinishedTasksPanelViewModel>(navigationStore, () => new FinishedTasksPanelViewModel(navigationStore));
            NavigateProfilePanelCommand = new NavigateCommand<ProfilePanelViewModel>(navigationStore, () => new ProfilePanelViewModel(navigationStore));
            NavigateStartingPanelCommand = new NavigateCommand<StartingPanelViewModel>(navigationStore, () => new StartingPanelViewModel(navigationStore));

        }
        #endregion
    }
}
