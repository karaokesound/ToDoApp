using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Commands;
using ToDoApp.Stores;

namespace ToDoApp.ViewModels
{
    public class FinishedTasksPanelViewModel : BaseViewModel
    {
        #region NAVIGATION
        public ICommand NavigateNavigationPanelCommand { get; }
        public ICommand NavigateProfilePanelCommand { get; }
        public ICommand NavigateTaskOperationsPanelCommand { get; }

        public FinishedTasksPanelViewModel(NavigationStore navigationStore)
        {
            NavigateNavigationPanelCommand = new NavigateCommand<NavigationPanelViewModel>(navigationStore, () => new NavigationPanelViewModel(navigationStore));
            NavigateProfilePanelCommand = new NavigateCommand<ProfilePanelViewModel>(navigationStore, () => new ProfilePanelViewModel(navigationStore));
            NavigateTaskOperationsPanelCommand = new NavigateCommand<TaskOperationsViewModel>(navigationStore, () => new TaskOperationsViewModel(navigationStore));
        }
        #endregion

        public ObservableCollection<WorkTaskViewModel> PassedTasksList { get; set; }

        //constructor overloading. This constructor is used by an object created in TasksTransferViewModel
        public FinishedTasksPanelViewModel()
        {
        }

        public void FinishedTasks (ObservableCollection<WorkTaskViewModel> finishedTask)
        {
            PassedTasksList = finishedTask;
        }
    }
}
