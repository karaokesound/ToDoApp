using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.ViewModels
{
    public class TasksTransferViewModel : BaseViewModel
    {
        //an object of FinishedTasksPanelViewModel, which pass the element of WorkTaskList (to that viewmodel), which was sent to this viewmodel
        //(TasksTransferViewModel) so therefore is able to be sent again (to FinishedTasksPanelViewModel), where is used by UI
        public FinishedTasksPanelViewModel finishedTask = new FinishedTasksPanelViewModel();

        public void TasksStore(ObservableCollection<WorkTaskViewModel> taskToStore)
        {
            //invoking a method from FinishedTasksPanelViewModel. It gives us possibility to transfer the element from TasksStore method
            //to FinishedTasksPanelViewModel
            finishedTask.FinishedTasks(taskToStore);
        }
    }
}
