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
    public class TaskOperationsViewModel : BaseViewModel
    {
        #region NAVIGATION AND COMMANDS
        public ICommand NavigateNavigationPanelCommand { get; }
        public ICommand NavigateProfilePanelCommand { get; }
        public ICommand NavigateFinishedTasksPanelCommand { get; }
        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteSelectedTaskCommand { get; set; }
        public ICommand FinishedTaskCommand { get; set; }
        public TaskOperationsViewModel(NavigationStore navigationStore)
        {
            NavigateNavigationPanelCommand = new NavigateCommand<NavigationPanelViewModel>(navigationStore, () => new NavigationPanelViewModel(navigationStore));
            NavigateProfilePanelCommand = new NavigateCommand<ProfilePanelViewModel>(navigationStore, () => new ProfilePanelViewModel(navigationStore));
            NavigateFinishedTasksPanelCommand = new NavigateCommand<FinishedTasksPanelViewModel>(navigationStore, () => new FinishedTasksPanelViewModel(navigationStore));
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedTaskCommand = new RelayCommand(DeleteSelectedTask);
            FinishedTaskCommand = new RelayCommand(FinishedTasks);
        }
        #endregion

        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public ObservableCollection<WorkTaskViewModel> FinishedTasksList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescription { get; set; }

        //object of a TasksTransferViewModel, which pass elements of WorkTaskList to this viewmodel
        public TasksTransferViewModel taskTransfer = new TasksTransferViewModel();

        private void AddNewTask()
        {
            if ((!string.IsNullOrEmpty(NewWorkTaskTitle) && !string.IsNullOrEmpty(NewWorkTaskDescription)) &&
                (!string.IsNullOrWhiteSpace(NewWorkTaskTitle) && !string.IsNullOrWhiteSpace(NewWorkTaskDescription)))
            {
                var newTask = new WorkTaskViewModel
                {
                    TaskTitle = NewWorkTaskTitle,
                    TaskDescription = NewWorkTaskDescription,
                    TaskStartTime = DateTime.Now,
                    TaskEndTime = DateTime.Now,
                };

                WorkTaskList.Add(newTask);

                //invoke a method from TasksTransferViewModel so as to pass the element of WorkTaskList to this viewmodel
                taskTransfer.TasksStore(WorkTaskList);

                NewWorkTaskTitle = string.Empty;
                NewWorkTaskDescription = string.Empty;

                OnPropertyChanged(nameof(NewWorkTaskTitle));
                OnPropertyChanged(nameof(NewWorkTaskDescription));
            }
            else return;
        }

        private void DeleteSelectedTask()
        {
            var selectedTask = WorkTaskList.Where(x => x.IsCheckboxSelected).ToList();

            foreach (var task in selectedTask)
            {
                WorkTaskList.Remove(task);
            }
        }

        private void FinishedTasks()
        {
            var finishedTasks = WorkTaskList.Where(y => y.IsCheckboxSelected).ToList();

            foreach (var finished in finishedTasks)
            {
                FinishedTasksList.Add(finished);
                WorkTaskList.Remove(finished);
            }
        }
    }
}
