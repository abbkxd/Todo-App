using System.Collections.ObjectModel;
using Todo_UserControls.MVVM.Helper;
using Todo_UserControls.MVVM.Model;

namespace Todo_UserControls.MVVM.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
		public ObservableCollection<TodoTask> Tasks { get; set; }
        public ObservableCollection<TodoTask> FilteredTasks { get; set; }

        private TodoTask _selectedTask;

		public TodoTask SelectedTask
        {
			get { return _selectedTask; }
			set { _selectedTask = value;
			OnPropertyChanged(); 
			}
		}

		private string _filterStatus ="All";

		public string FilteredStatus
        {
			get { return _filterStatus; }
			set {
                _filterStatus = value;
			OnPropertyChanged();
			}
		}

        public RelayCommand addTaskCommand { get; set; }
        public RelayCommand updateTaskCommand { get; set; }
        public RelayCommand deleteTaskCommand { get; set; }
        public RelayCommand markCompleteCommand { get; set; }
        public RelayCommand sortTasksCommand { get; set; }


        public MainWindowViewModel()
        {
            Tasks = new ObservableCollection<TodoTask>();
            FilteredTasks = new ObservableCollection<TodoTask>(Tasks);//Addiing Tasks observable collection to FilteredTasks

           

        }

        private void DeleteTask()
        {
            Tasks.Remove(SelectedTask);
            FilterTasks();
        }

        private void AddTask()
        {
            var newTask = new TodoTask { eventHead = "New Task", eventDescp = "Details", eventDate = DateTime.Now };
            Tasks.Add(newTask);
            FilterTasks();
        }
        private void UpdateTask()
        {
            // UI will automatically update due to data binding
        }
        private void MarkTaskAsCompleted()
        {
            if (SelectedTask != null)
                SelectedTask.eventStatus = true;
        }

        private void FilterTasks()
        {
            switch (FilteredStatus)
            {
                case "Completed":
                    FilteredTasks = new ObservableCollection<TodoTask>(Tasks.Where(t=>t.eventStatus));
                    break;
                case "Pending":
                    FilteredTasks = new ObservableCollection<TodoTask>(Tasks.Where(t => !t.eventStatus));
                    break;
                default:
                    FilteredTasks = new ObservableCollection<TodoTask>(Tasks);
                    break;

            }

            OnPropertyChanged(nameof(FilteredTasks));
        }

        private void SortTasks(string parameter)
        {
            switch (parameter)
            {
                case "Date":
                    FilteredTasks = new ObservableCollection<TodoTask>(FilteredTasks.OrderBy(t => t.eventDate));
                    break;
                case "Name":
                    FilteredTasks = new ObservableCollection<TodoTask>(FilteredTasks.OrderBy(t => t.eventHead));
                    break;
                case "Status":
                    FilteredTasks = new ObservableCollection<TodoTask>(FilteredTasks.OrderBy(t => t.eventStatus));
                    break;
            }
            OnPropertyChanged(nameof(FilteredTasks));
        }
    }
}
